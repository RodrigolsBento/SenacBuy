using System;
using System.Windows.Forms;
using SenacBuy.UI.Services.Models;

namespace SenacBuy.UI
{
    /// <summary>
    /// Tela de autenticação do SenacBuy.
    /// O login é validado via API (POST api/usuario/login).
    /// Inclui botão "Cadastrar-se" que abre frmCadastroUsuario.
    /// </summary>
    public partial class frmLogin : Form
    {
        private readonly UsuarioApiService _usuarioService = new();

        public frmLogin()
        {
            InitializeComponent();
        }

        // ──────────────────────────────────────────────────────────────────────────────
        // ENTRAR
        // ──────────────────────────────────────────────────────────────────────────────

        private async void btnEntrar_Click(object sender, EventArgs e)
        {
            // Validação: campos obrigatórios
            if (string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                MessageBox.Show("Preencha email e senha.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            btnEntrar.Enabled = false;
            btnEntrar.Text = "Entrando...";

            try
            {
                // Chama a API para autenticar — POST api/usuario/login
                var resultado = await _usuarioService.LoginAsync(
                    email: txtEmail.Text.Trim(),
                    senha: txtSenha.Text);

                if (resultado == null)
                {
                    // Mensagem de erro já exibida pelo UsuarioApiService
                    return;
                }

                if (resultado.Sucesso)
                {
                    // Login bem-sucedido — abre o formulário principal
                    var principal = new frmPrincipal(resultado.Nome, resultado.FotoPerfil);
                    principal.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(
                        $"Acesso negado.\n{resultado.Mensagem}",
                        "Autenticação Falhou",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            finally
            {
                btnEntrar.Enabled = true;
                btnEntrar.Text = "Entrar";
            }
        }

        // ──────────────────────────────────────────────────────────────────────────────
        // CADASTRAR-SE
        // ──────────────────────────────────────────────────────────────────────────────

        private void btnCadastrarSe_Click(object sender, EventArgs e)
        {
            // Abre o formulário de cadastro como diálogo modal
            using var frm = new frmCadastroUsuario();
            frm.ShowDialog(this);
            // Após fechar o cadastro, o usuário retorna para esta tela de login
        }

        // ──────────────────────────────────────────────────────────────────────────────
        // FECHAR APLICAÇÃO
        // ──────────────────────────────────────────────────────────────────────────────

        // Encerra toda a aplicação ao fechar o login
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Application.Exit();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
