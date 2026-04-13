using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using SenacBuy.UI.Services.Models;

namespace SenacBuy.UI
{
    /// <summary>
    /// Formulário de cadastro de novo produto integrado com a API.
    /// Chama ProdutoApiService.CreateProdutoAsync() ao salvar.
    /// </summary>
    public partial class ucNovoProduto : UserControl
    {
        private readonly ProdutoApiService   _produtoService   = new();
        private readonly CategoriaApiService _categoriaService = new();
        private List<CategoriaDto> _categorias = new();
        private string? _caminhoFotoLocal;
        private readonly int? _idEdicao;

        public ucNovoProduto(int? id = null)
        {
            InitializeComponent();
            _idEdicao = id;
            this.Load += async (s, e) => await CarregarDadosAsync();
        }

        private async Task CarregarDadosAsync()
        {
            // Carrega categorias antes de preencher campos (para modo edição)
            _categorias = await _categoriaService.GetCategoriasAsync();
            cmbCategoria.Items.Clear();
            cmbCategoria.Items.Add("(sem categoria)");
            foreach (var cat in _categorias)
                cmbCategoria.Items.Add(cat.Nome);
            cmbCategoria.SelectedIndex = 0;

            await CarregarEdicaoAsync();
        }

        private async Task CarregarEdicaoAsync()
        {
            if (!_idEdicao.HasValue)
            {
                lblTitulo.Text = "📝 Novo Produto";
                return;
            }

            lblTitulo.Text = "✏️ Editar Produto";
            btnSalvar.Text = "Atualizar";

            var produto = await _produtoService.GetProdutoByIdAsync(_idEdicao.Value);
            if (produto != null)
            {
                txtNome.Text = produto.Nome;
                txtPreco.Text = produto.Preco.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture);

                // Pré-seleciona a categoria
                if (produto.CategoriaId.HasValue)
                {
                    int idx = _categorias.FindIndex(c => c.Id == produto.CategoriaId.Value);
                    cmbCategoria.SelectedIndex = idx >= 0 ? idx + 1 : 0; // +1 por causa do item "(sem categoria)"
                }

                if (!string.IsNullOrEmpty(produto.FotoProduto))
                {
                    try
                    {
                        var url = $"{ApiClientService.ApiBaseUrl.TrimEnd('/')}/api/imagens/{produto.FotoProduto}";
                        picFoto.LoadAsync(url);
                    }
                    catch { }
                }
            }
        }

        private void btnSelecionarImagem_Click(object sender, EventArgs e)
        {
            using var ofd = new OpenFileDialog();
            ofd.Filter = "Imagens (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                _caminhoFotoLocal = ofd.FileName;
                picFoto.ImageLocation = _caminhoFotoLocal;
            }
        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text) ||
                string.IsNullOrWhiteSpace(txtPreco.Text))
            {
                MessageBox.Show("Preencha pelo menos o Nome e o Preço do produto.",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Parse do preço — aceita vírgula ou ponto como separador decimal
            if (!decimal.TryParse(txtPreco.Text.Trim().Replace(',', '.'),
                    System.Globalization.NumberStyles.Any,
                    System.Globalization.CultureInfo.InvariantCulture,
                    out decimal preco))
            {
                MessageBox.Show("Preço inválido. Use ponto ou vírgula como separador decimal. Ex: 9.99 ou 9,99",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            btnSalvar.Enabled = false;

            try
            {
                string? caminhoFotoApi = null;
                if (!string.IsNullOrEmpty(_caminhoFotoLocal))
                {
                    btnSalvar.Text = "Enviando foto...";
                    caminhoFotoApi = await _produtoService.UploadFotoAsync(_caminhoFotoLocal);
                    if (caminhoFotoApi == null)
                    {
                        return; // falha no upload já exibiu mensagem
                    }
                }

                btnSalvar.Text = "Salvando...";

                // Resolve CategoriaId: índice 0 = "(sem categoria)" = null
                int? categoriaId = null;
                if (cmbCategoria.SelectedIndex > 0)
                    categoriaId = _categorias[cmbCategoria.SelectedIndex - 1].Id;

                if (_idEdicao.HasValue)
                {
                    // MODO EDIÇÃO
                    var atualizado = await _produtoService.UpdateProdutoAsync(
                        id: _idEdicao.Value,
                        nome: txtNome.Text.Trim(),
                        preco: preco,
                        fotoProduto: caminhoFotoApi,
                        categoriaId: categoriaId);

                    if (atualizado)
                    {
                        MessageBox.Show("Produto atualizado com sucesso!",
                            "Edição Realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        var principal = this.FindForm() as frmPrincipal;
                        principal?.Navegar(new ucProdutos());
                    }
                }
                else
                {
                    // MODO CRIAÇÃO
                    var criado = await _produtoService.CreateProdutoAsync(
                        nome:  txtNome.Text.Trim(),
                        preco: preco,
                        fotoProduto: caminhoFotoApi,
                        categoriaId: categoriaId);

                    if (criado != null)
                    {
                        MessageBox.Show($"Produto \"{criado.Nome}\" cadastrado com sucesso!",
                            "Cadastro Realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        var principal = this.FindForm() as frmPrincipal;
                        principal?.Navegar(new ucProdutos());
                    }
                }
            }
            finally
            {
                btnSalvar.Enabled = true;
                btnSalvar.Text    = "Salvar";
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var principal = this.FindForm() as frmPrincipal;
            principal?.Navegar(new ucProdutos());
        }
    }
}
