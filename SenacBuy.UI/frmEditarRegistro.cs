using System;
using System.Windows.Forms;

namespace SenacBuy.UI
{
    /// <summary>
    /// Diálogo genérico e reutilizável para edição de dois campos de texto.
    ///
    /// Usado por ucClientes (editar Nome/CPF) e ucProdutos (editar Nome/Preço).
    /// Retorna DialogResult.OK quando o usuário clica em "Salvar",
    /// e os valores digitados ficam disponíveis em Campo1 e Campo2.
    /// </summary>
    public partial class frmEditarRegistro : Form
    {
        /// <summary>Valor do primeiro campo após confirmação</summary>
        public string Campo1 { get; private set; } = string.Empty;

        /// <summary>Valor do segundo campo após confirmação</summary>
        public string Campo2 { get; private set; } = string.Empty;

        /// <summary>
        /// Abre o diálogo com título e valores iniciais para dois campos.
        /// </summary>
        /// <param name="titulo">Título da janela</param>
        /// <param name="valor1">Valor inicial do campo 1</param>
        /// <param name="valor2">Valor inicial do campo 2</param>
        /// <param name="label1">Rótulo do campo 1 (padrão: "Nome")</param>
        /// <param name="label2">Rótulo do campo 2 (padrão: "CPF / Identificador")</param>
        public frmEditarRegistro(string titulo,
            string valor1  = "",
            string valor2  = "",
            string label1  = "Nome",
            string label2  = "CPF / Identificador")
        {
            InitializeComponent();

            this.Text      = titulo;
            lblCampo1.Text = label1 + ":";
            lblCampo2.Text = label2 + ":";
            txtCampo1.Text = valor1;
            txtCampo2.Text = valor2;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCampo1.Text))
            {
                MessageBox.Show($"O campo \"{lblCampo1.Text.TrimEnd(':')}\" é obrigatório.",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCampo1.Focus();
                return;
            }

            Campo1       = txtCampo1.Text.Trim();
            Campo2       = txtCampo2.Text.Trim();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
