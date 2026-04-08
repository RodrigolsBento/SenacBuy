
using SenacBuy.Domain.Entities;
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
    public partial class ucUsuario : UserControl
    {

        //serviços que faz chamada http para os andpoints de usuário
        private readonly UsuarioApiService _usuarioService = new();

        //cache local para armazenar os usuários já carregados, evitando chamadas desnecessárias à API
        private List<UsuarioDto> _usuarios = new();


        //contrutor do usercontroll
        public ucUsuario()
        {
            InitializeComponent();
            ConfigurarInterface();//config as colunas 
            Load += async (s, e) => await CarregarUsuariosAsync(); //carrega os usuários ao iniciar o controle
        }

        private void ConfigurarInterface()
        {
            // Aumenta altura da linha para acomodar imagens de perfil
            dgvUsuarios.RowTemplate.Height = 50;

            // Adiciona coluna de imagem para foto do usuário
            dgvUsuarios.Columns.Add(new DataGridViewImageColumn
            {
                Name = "colFoto",
                HeaderText = "Foto",
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                FillWeight = 40
            });

            // Colunas adicionais: ID, Nome, E-mail
            dgvUsuarios.Columns.Add("colId", "ID");
            dgvUsuarios.Columns.Add("colNome", "Nome");
            dgvUsuarios.Columns.Add("colEmail", "E-mail");

            // Ajusta preenchimento proporcional de colunas para melhor visualização
            dgvUsuarios.Columns["colId"]!.FillWeight = 30;
            dgvUsuarios.Columns["colNome"]!.FillWeight = 200;
            dgvUsuarios.Columns["colEmail"]!.FillWeight = 200;
        }


        public async Task CarregarUsuariosAsync(string filtro = "")
        {
            if (_usuarios.Count == 0 || string.IsNullOrEmpty(filtro))
                _usuarios = await _usuarioService.ListarUsuarioAsync();

            AtualizarGrid(_usuarios, filtro);
        }


        //chamada recorrente sempre atualizado 
        private void AtualizarGrid(List<UsuarioDto> lista, string filtro = "")
        {

            dgvUsuarios.Rows.Clear();//limpa o grid para evitar duplicação

            var exibidos = string.IsNullOrWhiteSpace(filtro) ? lista : lista.Where(usuario =>
            usuario.Nome.Contains(filtro, StringComparison.OrdinalIgnoreCase) ||
            usuario.Email.Contains(filtro, StringComparison.OrdinalIgnoreCase)).ToList();//StringComparison ignora case sensitve

            foreach (var usuario in exibidos)
            {
                int rowIndex = dgvUsuarios.Rows.Add(null, usuario.Id, usuario.Nome, usuario.Email);
                _ = CarregarImagemAsync(rowIndex, usuario.FotoPerfil); //carrega //ignora um carregamento esperado
            }

        }


        private async Task CarregarImagemAsync(int rowIndex, string? caminhoRelativo)
        {
            if (string.IsNullOrEmpty(caminhoRelativo)) return; // Sem imagem, sai
            try
            {
                // Constrói URL para a imagem a partir do baseUrl configurado
                var url = $"{ApiClientService.ApiBaseUrl.TrimEnd('/')}/api/imagens/{caminhoRelativo}";
                using var stream = await ApiClientService.Cliente.GetStreamAsync(url);
                var img = System.Drawing.Image.FromStream(stream);

                // Se a linha ainda existir, coloca a imagem na célula específica
                if (dgvUsuarios.Rows.Count > rowIndex)
                    dgvUsuarios.Rows[rowIndex].Cells["colFoto"].Value = img;
            }
            catch { /* Ignora erro de carregamento (ex: 404, sem rede) */ }
        }



        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            AtualizarGrid(_usuarios, txtBuscarUsuario.Text);
        }

        private void btnNovoUsuario_Click(object sender, EventArgs e)
        {
            (this.FindForm() as FrmPrincipal)?.Navegar(new ucNovoUsuario());//linka um painel ao outro, para navegar entre os controles
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow == null)
            {
                MessageBox.Show("Selecione um usuário para editar.","Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var id = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["colId"].Value);
            (this.FindForm() as FrmPrincipal)?.Navegar(new ucNovoUsuario(id)); //pesquisa por uma determinada informação 


        }
    }
}
