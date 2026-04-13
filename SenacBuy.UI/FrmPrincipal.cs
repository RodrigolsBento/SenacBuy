using SenacBuy.UI.Services.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SenacBuy.UI
{
    /// <summary>
    /// Formulário principal do SenacBuy.
    /// Contém a sidebar de navegação fixa e o painel central onde os UserControls são carregados.
    /// Navegação baseada em UserControls — sem MDI.
    /// </summary>
    public partial class frmPrincipal : Form
    {
        private readonly string _nomeUsuario;

        public frmPrincipal(string nomeUsuario = "Usuário", string? caminhoFoto = null)
        {
            InitializeComponent();
            _nomeUsuario = nomeUsuario;
            lblUsuario.Text = $"👤  {nomeUsuario}";

            if (!string.IsNullOrEmpty(caminhoFoto))
            {
                CarregarFotoPerfilAsync(caminhoFoto);
            }

            // Carrega o Dashboard como tela inicial
            LoadUserControl(new ucDashboard());
        }

        private async void CarregarFotoPerfilAsync(string caminhoRelativo)
        {
            try
            {
                var url = $"{ApiClientService.ApiBaseUrl.TrimEnd('/')}/api/imagens/{caminhoRelativo}";
                using var stream = await ApiClientService.Cliente.GetStreamAsync(url);
                picUsuario.Image = Image.FromStream(stream);
            }
            catch { /* ignora erro de imagem no sidebar */ }
        }

        // ──────────────────────────── NAVEGAÇÃO ───────────────────────────────────

        /// <summary>
        /// Carrega um UserControl no panelContainer, substituindo o conteúdo atual.
        /// Padrão de navegação utilizado em toda a aplicação.
        /// </summary>
        private void LoadUserControl(UserControl control)
        {
            panelContainer.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(control);
        }

        // ──────────────────────────── EVENTOS DA SIDEBAR ──────────────────────────

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnDashboard);
            LoadUserControl(new ucDashboard());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnClientes);
            LoadUserControl(new ucClientes());
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnProdutos);
            LoadUserControl(new ucProdutos());
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnPedidos);
            LoadUserControl(new ucPedidos());
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnUsuarios);
            LoadUserControl(new ucUsuarios());
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair do sistema?", "Confirmar Saída",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        /// <summary>
        /// Destaca o botão ativo na sidebar (azul primário) e desmarca os demais.
        /// </summary>
        private void SetActiveButton(Guna.UI2.WinForms.Guna2Button activeBtn)
        {
            var botoes = new[] { btnDashboard, btnClientes, btnProdutos, btnPedidos, btnUsuarios };
            foreach (var btn in botoes)
            {
                btn.FillColor = Color.Transparent;
                btn.ForeColor = Color.FromArgb(160, 170, 195);
            }
            activeBtn.FillColor = Color.FromArgb(0, 123, 204);
            activeBtn.ForeColor = Color.White;
        }

        // Permite que UserControls filhos naveguem de volta
        public void Navegar(UserControl control) => LoadUserControl(control);
    }
}
