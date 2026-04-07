using SenacBuy.UI.Services;
using SenacBuy.UI.Services.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SenacBuy.UI
{
    public partial class ucNovoUsuario : UserControl
    {

        private readonly UsuarioApiService _usuarioApiService = new();
        private string? _caminhoFotoLocal;
        private readonly int? _idEdicao;

        public ucNovoUsuario(int? id = null)//caso vier com nulo
        {
            InitializeComponent();
            _idEdicao = id;

            this.Load += async (s, e) => await CarregarEdicaoAsync();
        }

        private async Task CarregarEdicaoAsync()
        {
            if (!_idEdicao.HasValue)//verifica se NÃO tem valor
            {
                lblTitulo.Text = "Novo Usuário";
                return;
            }

            lblTitulo.Text = "Editar Usuário";
            btnSalvar.Text = "Atualizar Usuário";

            txtSenha.PlaceholderText = "Deixe em branco para manter a senha atual";//caso o usuário queira apenas atualizar o nome ou foto, sem alterar a senha

            var usuario = await _usuarioApiService.GetUsuarioByIdAsync(_idEdicao.Value);//esperasse parâmetro de id 
            if (usuario != null)//verificar se o usuario foi preenchido ou não 
            {
                txtNome.Text = usuario.Nome; // unir os dados do banco com os campos e carregando na tela 
                txtEmail.Text = usuario.Email;

                if (!string.IsNullOrEmpty(usuario.FotoPerfil))//caminho da foto do usuario
                {
                    try
                    {

                        var url = $"{ApiClientService.ApiBaseUrl.TrimEnd('/')}/api/imagens/{usuario.FotoPerfil}";//pega o cominho completo da foto e está armazenando na URL
                        picFoto.LoadAsync(url);//carrega a foto do usuário na picture box, usando o método LoadAsync para carregar a imagem de forma assíncrona, evitando travamentos na interface
                    }
                    catch { }


                }
            }

        }

        private void btnSelecionarImagem_Click(object sender, EventArgs e)
        {
            using var ofd = new OpenFileDialog();//caixa de dialogo para selecionar a imagem
            ofd.Filter = "Imagens (*.jpg;*.jpeg;*.png)| *.jpg;*.jpeg;*.png";//filtro para mostrar apenas arquivos de imagem
            if (ofd.ShowDialog() == DialogResult.OK)//verificar se o usuário selecionou um arquivo e clicou em OK
            {
                _caminhoFotoLocal = ofd.FileName;//armazenar o caminho da foto selecionada
                picFoto.ImageLocation = _caminhoFotoLocal;//carregar a foto selecionada na picture box, usando o método LoadAsync para evitar travamentos na interface
            }
        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                btnSalvar.Enabled = false;//desabilitar o botão para evitar cliques múltiplos enquanto a operação de salvamento está em andamento
                string nome = txtNome.Text.Trim();
                string email = txtEmail.Text.Trim();
                string senha = txtSenha.Text;

                if (!_idEdicao.HasValue && string.IsNullOrEmpty(senha))
                {
                    MessageBox.Show("Preencha todos os campos obrigatório(*).", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!_idEdicao.HasValue && senha.Length < 6)//reforçar a regra de senha para novos usuários, mas permitir que na edição, o usuário deixe em branco para manter a senha atual
                {
                    MessageBox.Show("A senha deve conter pelo menos 6 caracteres.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string? caminhoFotoApi = null;
                if (!string.IsNullOrEmpty(_caminhoFotoLocal))
                {
                    btnSalvar.Text = "Enviando foto...";//feedback visual para o usuário, indicando que a foto está sendo enviada para a API
                    caminhoFotoApi = await _usuarioApiService.UploadFotoAsync(_caminhoFotoLocal);//fazer o upload da foto para a API e obter o caminho da foto armazenada na API, que será usado no payload de criação ou atualização do usuário
                    if (caminhoFotoApi == null)
                    {
                        return;
                    }
                }

                if (_idEdicao.HasValue)
                {
                    btnSalvar.Text = "Atualizando usuário...";
                    var dto = new UsuarioDto
                    {
                        Id = _idEdicao.Value,
                        Nome = nome,
                        Email = email,
                        FotoPerfil = caminhoFotoApi
                    };

                    var ok = await _usuarioApiService.AtualizarUsuarioAsync(dto);//se a senha for nula ou vazia, passar null para manter a senha atual, caso contrário, passar a nova senha para atualização
                    if (ok)
                    {
                        MessageBox.Show("Usuário atualizado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        VoltarParaLista();
                    }

                }
                else
                {
                    btnSalvar.Text = "Salvando usuário...";
                    var novoDto = await _usuarioApiService.CadastrarUsuarioAsync(nome, email, senha, caminhoFotoApi);//criar um novo usuário usando os dados fornecidos e o caminho da foto (se houver) 
                    if (novoDto != null)
                    {
                        MessageBox.Show("Usuário cadastrado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        VoltarParaLista();

                    }
                }

            }
            finally
            {

                btnSalvar.Enabled = true;//reabilitar o botão após a conclusão da operação de salvamento, independentemente do resultado (sucesso ou falha)
                btnSalvar.Text = "Salvar Usuário";
            }
        }

        private void VoltarParaLista()
        {
            var principal = this.FindForm() as FrmPrincipal;
            principal?.Navegar(new ucUsuario());
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            VoltarParaLista();
        }
    }
}
