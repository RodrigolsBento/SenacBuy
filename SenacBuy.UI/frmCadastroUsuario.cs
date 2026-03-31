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

        public async void btnCadastrar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtNome.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) || 
                string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                MessageBox.Show("Preencha todos os campos para continuar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (txtSenha.Text.Length <4)
            {
                MessageBox.Show("A senha deve ter pelo menos 4 caracteres.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            btnCadastrar.Enabled = false;
            btnCadastrar.Text = "Cadastrando...";

            try
            {
                var usuario = await _usuarioApiService.CadastrarUsuarioAsync(
                    nome: txtNome.Text.Trim(),
                    email: txtEmail.Text.Trim(),
                    senha: txtSenha.Text.Trim(),
                    fotoPerfil: null);

                if (usuario != null)
                { 
                    MessageBox.Show("Usuário cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            finally 
            {

                btnCadastrar.Enabled = true;
                btnCadastrar.Text = "Cadastrar";
            }


        }
    }
}
