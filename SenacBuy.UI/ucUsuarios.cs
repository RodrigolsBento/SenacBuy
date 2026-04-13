using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SenacBuy.UI.Services.Models;

namespace SenacBuy.UI
{
    public partial class ucUsuarios : UserControl
    {
        private readonly UsuarioApiService _usuarioService = new();
        private List<UsuarioDto> _usuarios = new();

        public ucUsuarios()
        {
            InitializeComponent();
            ConfigurarInterface();
            Load += async (s, e) => await CarregarUsuariosAsync();
        }

        private void ConfigurarInterface()
        {
            dgvUsuarios.RowTemplate.Height = 50; // Aumentar altura da linha para caber a foto

            dgvUsuarios.Columns.Add(new DataGridViewImageColumn
            {
                Name = "colFoto",
                HeaderText = "Foto",
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                FillWeight = 40
            });
            dgvUsuarios.Columns.Add("colId",    "ID");
            dgvUsuarios.Columns.Add("colNome",  "Nome");
            dgvUsuarios.Columns.Add("colEmail", "E-mail");

            dgvUsuarios.Columns["colId"]!.FillWeight    = 30;
            dgvUsuarios.Columns["colNome"]!.FillWeight  = 200;
            dgvUsuarios.Columns["colEmail"]!.FillWeight = 200;
        }

        public async Task CarregarUsuariosAsync(string filtro = "")
        {
            if (_usuarios.Count == 0 || string.IsNullOrEmpty(filtro))
                _usuarios = await _usuarioService.ListarUsuariosAsync();

            AtualizarGrid(_usuarios, filtro);
        }

        private void AtualizarGrid(List<UsuarioDto> lista, string filtro = "")
        {
            dgvUsuarios.Rows.Clear();

            var exibidos = string.IsNullOrWhiteSpace(filtro)
                ? lista
                : lista.Where(u =>
                    u.Nome.Contains(filtro, StringComparison.OrdinalIgnoreCase) ||
                    u.Email.Contains(filtro, StringComparison.OrdinalIgnoreCase)).ToList();

            foreach (var u in exibidos)
            {
                int rowIndex = dgvUsuarios.Rows.Add(null, u.Id, u.Nome, u.Email);
                _ = CarregarImagemAsync(rowIndex, u.FotoPerfil);
            }
        }

        private async Task CarregarImagemAsync(int rowIndex, string? caminhoRelativo)
        {
            if (string.IsNullOrEmpty(caminhoRelativo)) return;
            try
            {
                // Constrói URL: http://localhost:5086/api/imagens/usuarios/nome.jpg
                var url = $"{ApiClientService.ApiBaseUrl.TrimEnd('/')}/api/imagens/{caminhoRelativo}";
                using var stream = await ApiClientService.Cliente.GetStreamAsync(url);
                var img = System.Drawing.Image.FromStream(stream);

                if (dgvUsuarios.Rows.Count > rowIndex)
                    dgvUsuarios.Rows[rowIndex].Cells["colFoto"].Value = img;
            }
            catch { /* Ignora erro de carregamento (ex: 404, sem rede) */ }
        }

        private void txtBuscaUsuario_TextChanged(object sender, EventArgs e)
        {
            AtualizarGrid(_usuarios, txtBuscaUsuario.Text);
        }

        private void btnNovoUsuario_Click(object sender, EventArgs e)
        {
            (this.FindForm() as frmPrincipal)?.Navegar(new ucNovoUsuario());
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow == null)
            {
                MessageBox.Show("Selecione um usuário para editar.",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["colId"].Value);
            (this.FindForm() as frmPrincipal)?.Navegar(new ucNovoUsuario(id));
        }

        private async void btnExcluirUsuario_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow == null)
            {
                MessageBox.Show("Selecione um usuário para excluir.",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["colId"].Value);
            string nome = dgvUsuarios.CurrentRow.Cells["colNome"].Value?.ToString() ?? "";

            if (MessageBox.Show(
                    $"Excluir o usuário \"{nome}\"?\nEsta ação não pode ser desfeita.",
                    "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                != DialogResult.Yes) return;

            bool ok = await _usuarioService.ExcluirUsuarioAsync(id);
            if (ok)
            {
                MessageBox.Show("Usuário excluído com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                _usuarios.Clear();
                await CarregarUsuariosAsync();
            }
        }
    }
}
