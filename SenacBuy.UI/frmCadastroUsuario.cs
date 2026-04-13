using System;
using System.Windows.Forms;
using SenacBuy.UI.Services.Models;

namespace SenacBuy.UI
{
    /// <summary>
    /// Formulário de cadastro de novo usuário.
    ///
    /// Campos: Nome, E-mail, Senha.
    /// Ao clicar em "Cadastrar", chama UsuarioApiService.CadastrarUsuarioAsync().
    /// Em caso de sucesso, fecha e retorna ao frmLogin.
    /// </summary>
    public partial class frmCadastroUsuario : Form
    {
        private readonly UsuarioApiService _usuarioService = new();

        public frmCadastroUsuario()
        {
            InitializeComponent();
        }

        private async void btnCadastrar_Click(object sender, EventArgs e)
        {
            // Validação básica dos campos obrigatórios
            if (string.IsNullOrWhiteSpace(txtNome.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                MessageBox.Show("Preencha Nome, E-mail e Senha para continuar.",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtSenha.Text.Length < 4)
            {
                MessageBox.Show("A senha deve ter pelo menos 4 caracteres.",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            btnCadastrar.Enabled = false;
            btnCadastrar.Text    = "Cadastrando...";

            try
            {
                var usuario = await _usuarioService.CadastrarUsuarioAsync(
                    nome:  txtNome.Text.Trim(),
                    email: txtEmail.Text.Trim(),
                    senha: txtSenha.Text);

                if (usuario != null)
                {
                    MessageBox.Show(
                        $"Usuário \"{usuario.Nome}\" cadastrado com sucesso!\nFaça login para continuar.",
                        "Cadastro Realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Fecha o formulário de cadastro e volta para o login
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            finally
            {
                btnCadastrar.Enabled = true;
                btnCadastrar.Text    = "Cadastrar";
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
