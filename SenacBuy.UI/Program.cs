namespace SenacBuy.UI;

/// <summary>
/// Ponto de entrada da aplicação Windows Forms.
/// A tela de login é exibida primeiro; o formulário principal só abre após autenticação.
/// </summary>
static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new frmLogin());
    }
}