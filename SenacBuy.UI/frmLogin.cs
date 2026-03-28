using SenacBuy.UI.Services;

namespace SenacBuy.UI;

public partial class frmLogin : Form
{


    private readonly UsuarioApiService _usuarioApiService = new();


    public frmLogin()
    {
        InitializeComponent();
    }

 

    private async void btnEntrar_Click_1(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtSenha.Text))
        {
            MessageBox.Show("Preencha todos os campos para continuar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        btnEntrar.Enabled = false;
        btnEntrar.Text = "Entrando...";

        try
        {
            var resultado = await _usuarioApiService.LoginAsync(email: txtEmail.Text.Trim(), senha: txtSenha.Text);

            if (resultado == null)
            {
                //mensagem de erro já exibida no serviço 
                return;
            }

            if (resultado.Sucesso)
            {
                var principal = new FrmPrincipal();
                principal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show($"Acesso negado. \n{resultado.Mensagem}", "Autenticação falhou", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        finally
        {

            btnEntrar.Enabled = true;
            btnEntrar.Text = "Entrar";
        }

    }
}
