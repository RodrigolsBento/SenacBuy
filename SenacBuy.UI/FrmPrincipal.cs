using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SenacBuy.UI
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnUsuarios);
            LoadUserControl(new ucUsuario());
        }

        private void SetActiveButton(Guna2Button activeBtn)
        {
            var botoes = new[]
            {
                btnDashboard,
                btnClientes,
                btnProdutos,
                btnPedidos,
                btnUsuarios
            };
            foreach (var btn in botoes)
            {
                btn.FillColor = Color.Transparent;
                ForeColor = Color.FromArgb(160, 170, 204);
            }
            activeBtn.FillColor = Color.FromArgb(0, 123, 204);
            activeBtn.ForeColor = Color.White;
        }



        private void LoadUserControl(UserControl uc)
        {
            panelContainer.Controls.Clear();//limpa tela 
            uc.Dock = DockStyle.Fill; //encaixar 
            panelContainer.Controls.Add(uc);//vai ser o uc que foi clicado 

        }


        public void Navegar(UserControl control) => LoadUserControl(control);

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();//o close() matem a aplicação rodando em segundo plano, o exit fecha tudo
        }
    }

}

