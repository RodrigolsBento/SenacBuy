namespace SenacBuy.UI
{
    partial class frmCadastroUsuario
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitulo    = new System.Windows.Forms.Label();
            this.lblNome      = new System.Windows.Forms.Label();
            this.lblEmail     = new System.Windows.Forms.Label();
            this.lblSenha     = new System.Windows.Forms.Label();
            this.txtNome      = new System.Windows.Forms.TextBox();
            this.txtEmail     = new System.Windows.Forms.TextBox();
            this.txtSenha     = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnCancelar  = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblTitulo
            this.lblTitulo.Font      = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location  = new System.Drawing.Point(20, 20);
            this.lblTitulo.Name      = "lblTitulo";
            this.lblTitulo.Size      = new System.Drawing.Size(340, 30);
            this.lblTitulo.TabIndex  = 0;
            this.lblTitulo.Text      = "📝 Cadastro de Usuário";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblNome
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(20, 70);
            this.lblNome.Name     = "lblNome";
            this.lblNome.Text     = "Nome completo:";

            // txtNome
            this.txtNome.Location    = new System.Drawing.Point(20, 90);
            this.txtNome.Name        = "txtNome";
            this.txtNome.PlaceholderText = "Ex: João da Silva";
            this.txtNome.Size        = new System.Drawing.Size(340, 23);
            this.txtNome.TabIndex    = 1;

            // lblEmail
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(20, 128);
            this.lblEmail.Name     = "lblEmail";
            this.lblEmail.Text     = "E-mail:";

            // txtEmail
            this.txtEmail.Location    = new System.Drawing.Point(20, 148);
            this.txtEmail.Name        = "txtEmail";
            this.txtEmail.PlaceholderText = "Ex: joao@email.com";
            this.txtEmail.Size        = new System.Drawing.Size(340, 23);
            this.txtEmail.TabIndex    = 2;

            // lblSenha
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(20, 186);
            this.lblSenha.Name     = "lblSenha";
            this.lblSenha.Text     = "Senha (mín. 4 caracteres):";

            // txtSenha
            this.txtSenha.Location      = new System.Drawing.Point(20, 206);
            this.txtSenha.Name          = "txtSenha";
            this.txtSenha.PasswordChar  = '●';
            this.txtSenha.PlaceholderText = "Sua senha";
            this.txtSenha.Size          = new System.Drawing.Size(340, 23);
            this.txtSenha.TabIndex      = 3;

            // btnCadastrar
            this.btnCadastrar.Location  = new System.Drawing.Point(175, 252);
            this.btnCadastrar.Name      = "btnCadastrar";
            this.btnCadastrar.Size      = new System.Drawing.Size(90, 32);
            this.btnCadastrar.TabIndex  = 4;
            this.btnCadastrar.Text      = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click    += new System.EventHandler(this.btnCadastrar_Click);

            // btnCancelar
            this.btnCancelar.Location  = new System.Drawing.Point(270, 252);
            this.btnCancelar.Name      = "btnCancelar";
            this.btnCancelar.Size      = new System.Drawing.Size(90, 32);
            this.btnCancelar.TabIndex  = 5;
            this.btnCancelar.Text      = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click    += new System.EventHandler(this.btnCancelar_Click);

            // frmCadastroUsuario
            this.ClientSize        = new System.Drawing.Size(380, 300);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox     = false;
            this.MinimizeBox     = false;
            this.Name            = "frmCadastroUsuario";
            this.StartPosition   = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text            = "SenacBuy — Cadastro de Usuário";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label   lblTitulo;
        private System.Windows.Forms.Label   lblNome;
        private System.Windows.Forms.Label   lblEmail;
        private System.Windows.Forms.Label   lblSenha;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button  btnCadastrar;
        private System.Windows.Forms.Button  btnCancelar;
    }
}
