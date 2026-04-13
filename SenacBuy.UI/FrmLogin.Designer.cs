namespace SenacBuy.UI
{
    partial class frmLogin
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelCabecalho = new Panel();
            btnFechar = new Guna.UI2.WinForms.Guna2CircleButton();
            lblNome = new Label();
            lblSlogan = new Label();
            lblInstrucao = new Label();
            txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            txtSenha = new Guna.UI2.WinForms.Guna2TextBox();
            btnEntrar = new Guna.UI2.WinForms.Guna2Button();
            btnCadastrarSe = new Guna.UI2.WinForms.Guna2Button();
            lblDica = new Label();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            panelCabecalho.SuspendLayout();
            SuspendLayout();
            // 
            // panelCabecalho
            // 
            panelCabecalho.BackColor = Color.FromArgb(0, 123, 204);
            panelCabecalho.Controls.Add(btnFechar);
            panelCabecalho.Controls.Add(lblNome);
            panelCabecalho.Controls.Add(lblSlogan);
            panelCabecalho.Location = new Point(0, 0);
            panelCabecalho.Name = "panelCabecalho";
            panelCabecalho.Size = new Size(340, 130);
            panelCabecalho.TabIndex = 0;
            // 
            // btnFechar
            // 
            btnFechar.DisabledState.BorderColor = Color.DarkGray;
            btnFechar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnFechar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnFechar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnFechar.FillColor = Color.FromArgb(192, 0, 0);
            btnFechar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFechar.ForeColor = Color.White;
            btnFechar.Location = new Point(303, 6);
            btnFechar.Name = "btnFechar";
            btnFechar.ShadowDecoration.CustomizableEdges = customizableEdges1;
            btnFechar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnFechar.Size = new Size(30, 30);
            btnFechar.TabIndex = 2;
            btnFechar.Text = "X";
            btnFechar.Click += btnFechar_Click;
            // 
            // lblNome
            // 
            lblNome.Font = new Font("Century Gothic", 22F, FontStyle.Bold);
            lblNome.ForeColor = Color.White;
            lblNome.Location = new Point(0, 30);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(340, 50);
            lblNome.TabIndex = 0;
            lblNome.Text = "\U0001f6d2 SenacBuy";
            lblNome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSlogan
            // 
            lblSlogan.Font = new Font("Segoe UI", 9.5F);
            lblSlogan.ForeColor = Color.FromArgb(200, 230, 255);
            lblSlogan.Location = new Point(0, 84);
            lblSlogan.Name = "lblSlogan";
            lblSlogan.Size = new Size(340, 24);
            lblSlogan.TabIndex = 1;
            lblSlogan.Text = "Sistema de Controle de Vendas";
            lblSlogan.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblInstrucao
            // 
            lblInstrucao.Font = new Font("Segoe UI", 9F);
            lblInstrucao.ForeColor = Color.Gray;
            lblInstrucao.Location = new Point(0, 148);
            lblInstrucao.Name = "lblInstrucao";
            lblInstrucao.Size = new Size(340, 22);
            lblInstrucao.TabIndex = 1;
            lblInstrucao.Text = "Faça seu login para continuar";
            lblInstrucao.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtEmail
            // 
            txtEmail.BorderRadius = 10;
            txtEmail.CustomizableEdges = customizableEdges2;
            txtEmail.DefaultText = "admin@senac.br";
            txtEmail.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtEmail.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtEmail.FocusedState.BorderColor = Color.FromArgb(0, 123, 204);
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEmail.Location = new Point(50, 185);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "✉  Email";
            txtEmail.SelectedText = "";
            txtEmail.ShadowDecoration.CustomizableEdges = customizableEdges3;
            txtEmail.Size = new Size(240, 38);
            txtEmail.TabIndex = 0;
            // 
            // txtSenha
            // 
            txtSenha.BorderRadius = 10;
            txtSenha.CustomizableEdges = customizableEdges4;
            txtSenha.DefaultText = "1234";
            txtSenha.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSenha.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSenha.FocusedState.BorderColor = Color.FromArgb(0, 123, 204);
            txtSenha.Font = new Font("Segoe UI", 10F);
            txtSenha.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSenha.Location = new Point(50, 236);
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderText = "🔒  Senha";
            txtSenha.SelectedText = "";
            txtSenha.ShadowDecoration.CustomizableEdges = customizableEdges5;
            txtSenha.Size = new Size(240, 38);
            txtSenha.TabIndex = 1;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // btnEntrar
            // 
            btnEntrar.BorderRadius = 10;
            btnEntrar.Cursor = Cursors.Hand;
            btnEntrar.CustomizableEdges = customizableEdges6;
            btnEntrar.FillColor = Color.FromArgb(0, 123, 204);
            btnEntrar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnEntrar.ForeColor = Color.White;
            btnEntrar.Location = new Point(50, 295);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.ShadowDecoration.CustomizableEdges = customizableEdges7;
            btnEntrar.Size = new Size(240, 45);
            btnEntrar.TabIndex = 2;
            btnEntrar.Text = "Entrar";
            btnEntrar.Click += btnEntrar_Click;
            // 
            // btnCadastrarSe
            // 
            btnCadastrarSe.BorderColor = Color.FromArgb(0, 123, 204);
            btnCadastrarSe.BorderRadius = 10;
            btnCadastrarSe.Cursor = Cursors.Hand;
            btnCadastrarSe.CustomizableEdges = customizableEdges8;
            btnCadastrarSe.FillColor = Color.Transparent;
            btnCadastrarSe.Font = new Font("Segoe UI", 9.5F);
            btnCadastrarSe.ForeColor = Color.FromArgb(0, 123, 204);
            btnCadastrarSe.Location = new Point(50, 350);
            btnCadastrarSe.Name = "btnCadastrarSe";
            btnCadastrarSe.ShadowDecoration.CustomizableEdges = customizableEdges9;
            btnCadastrarSe.Size = new Size(240, 36);
            btnCadastrarSe.TabIndex = 3;
            btnCadastrarSe.Text = "Não tem conta? Cadastrar-se";
            btnCadastrarSe.Click += btnCadastrarSe_Click;
            // 
            // lblDica
            // 
            lblDica.Font = new Font("Segoe UI", 8F);
            lblDica.ForeColor = Color.LightGray;
            lblDica.Location = new Point(0, 400);
            lblDica.Name = "lblDica";
            lblDica.Size = new Size(340, 20);
            lblDica.TabIndex = 4;
            lblDica.Text = "© 2024 SenacBuy Corporation";
            lblDica.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.BorderRadius = 20;
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(340, 430);
            Controls.Add(panelCabecalho);
            Controls.Add(lblInstrucao);
            Controls.Add(txtEmail);
            Controls.Add(txtSenha);
            Controls.Add(btnEntrar);
            Controls.Add(btnCadastrarSe);
            Controls.Add(lblDica);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SenacBuy - Login";
            panelCabecalho.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelCabecalho;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSlogan;
        private System.Windows.Forms.Label lblInstrucao;
        private System.Windows.Forms.Label lblDica;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtSenha;
        private Guna.UI2.WinForms.Guna2Button btnEntrar;
        private Guna.UI2.WinForms.Guna2Button btnCadastrarSe;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2CircleButton btnFechar;
    }
}