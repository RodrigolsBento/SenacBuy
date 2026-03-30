using Microsoft.VisualBasic;
using SenacBuy.UI.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SenacBuy.UI
{
    public partial class frmCadastroUsuario : Form
    {
        private readonly UsuarioApiService _usuarioApiService = new();

        public frmCadastroUsuario()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtNome.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) || 
                string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                MessageBox.Show("Preencha todos os campos para continuar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
