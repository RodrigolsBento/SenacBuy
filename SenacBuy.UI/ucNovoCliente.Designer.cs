namespace SenacBuy.UI
{
    partial class ucNovoCliente
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            panelHeader   = new System.Windows.Forms.Panel();
            lblTitulo     = new System.Windows.Forms.Label();
            lblSubtitulo  = new System.Windows.Forms.Label();
            panelForm     = new System.Windows.Forms.Panel();
            lblSecPessoal = new System.Windows.Forms.Label();
            txtNome       = new Guna.UI2.WinForms.Guna2TextBox();
            txtCpf        = new Guna.UI2.WinForms.Guna2TextBox();
            txtEmail      = new Guna.UI2.WinForms.Guna2TextBox();
            txtTelefone   = new Guna.UI2.WinForms.Guna2TextBox();
            lblSecEndereco = new System.Windows.Forms.Label();
            txtCep        = new Guna.UI2.WinForms.Guna2TextBox();
            txtLogradouro = new Guna.UI2.WinForms.Guna2TextBox();
            txtNumero     = new Guna.UI2.WinForms.Guna2TextBox();
            txtCidade     = new Guna.UI2.WinForms.Guna2TextBox();
            txtEstado     = new Guna.UI2.WinForms.Guna2TextBox();
            btnSalvar     = new Guna.UI2.WinForms.Guna2Button();
            btnCancelar   = new Guna.UI2.WinForms.Guna2Button();

            panelHeader.SuspendLayout();
            panelForm.SuspendLayout();
            this.SuspendLayout();

            // ─── panelHeader ──────────────────────────────────────────────────────
            panelHeader.BackColor = System.Drawing.Color.White;
            panelHeader.Dock      = System.Windows.Forms.DockStyle.Top;
            panelHeader.Height    = 75;
            panelHeader.Name      = "panelHeader";
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Controls.Add(lblSubtitulo);

            // ─── lblTitulo ────────────────────────────────────────────────────────
            lblTitulo.Text      = "👤  Novo Cliente";
            lblTitulo.Font      = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            lblTitulo.ForeColor = System.Drawing.Color.FromArgb(30, 40, 60);
            lblTitulo.AutoSize  = false;
            lblTitulo.Size      = new System.Drawing.Size(500, 34);
            lblTitulo.Location  = new System.Drawing.Point(30, 10);
            lblTitulo.Name      = "lblTitulo";

            // ─── lblSubtitulo ─────────────────────────────────────────────────────
            lblSubtitulo.Text      = "Preencha as informações do novo cliente";
            lblSubtitulo.Font      = new System.Drawing.Font("Segoe UI", 9F);
            lblSubtitulo.ForeColor = System.Drawing.Color.Gray;
            lblSubtitulo.AutoSize  = false;
            lblSubtitulo.Size      = new System.Drawing.Size(400, 20);
            lblSubtitulo.Location  = new System.Drawing.Point(30, 46);
            lblSubtitulo.Name      = "lblSubtitulo";

            // ─── Seção Informações Pessoais ────────────────────────────────────────
            lblSecPessoal.Text      = "Informações Pessoais";
            lblSecPessoal.Font      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblSecPessoal.ForeColor = System.Drawing.Color.FromArgb(0, 123, 204);
            lblSecPessoal.AutoSize  = true;
            lblSecPessoal.Location  = new System.Drawing.Point(30, 20);
            lblSecPessoal.Name      = "lblSecPessoal";

            // ─── txtNome ──────────────────────────────────────────────────────────
            txtNome.BorderRadius    = 10;
            txtNome.DefaultText     = "";
            txtNome.SelectedText    = "";
            txtNome.PlaceholderText = "Nome Completo *";
            txtNome.Font            = new System.Drawing.Font("Segoe UI", 10F);
            txtNome.FocusedState.BorderColor = System.Drawing.Color.FromArgb(0, 123, 204);
            txtNome.HoverState.BorderColor   = System.Drawing.Color.FromArgb(94, 148, 255);
            txtNome.Location        = new System.Drawing.Point(30, 52);
            txtNome.Size            = new System.Drawing.Size(450, 38);
            txtNome.Name            = "txtNome";

            // ─── txtCpf ───────────────────────────────────────────────────────────
            txtCpf.BorderRadius    = 10;
            txtCpf.DefaultText     = "";
            txtCpf.SelectedText    = "";
            txtCpf.PlaceholderText = "CPF / CNPJ *";
            txtCpf.Font            = new System.Drawing.Font("Segoe UI", 10F);
            txtCpf.FocusedState.BorderColor = System.Drawing.Color.FromArgb(0, 123, 204);
            txtCpf.HoverState.BorderColor   = System.Drawing.Color.FromArgb(94, 148, 255);
            txtCpf.Location        = new System.Drawing.Point(30, 104);
            txtCpf.Size            = new System.Drawing.Size(200, 38);
            txtCpf.Name            = "txtCpf";

            // ─── txtEmail ─────────────────────────────────────────────────────────
            txtEmail.BorderRadius    = 10;
            txtEmail.DefaultText     = "";
            txtEmail.SelectedText    = "";
            txtEmail.PlaceholderText = "E-mail *";
            txtEmail.Font            = new System.Drawing.Font("Segoe UI", 10F);
            txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(0, 123, 204);
            txtEmail.HoverState.BorderColor   = System.Drawing.Color.FromArgb(94, 148, 255);
            txtEmail.Location        = new System.Drawing.Point(250, 104);
            txtEmail.Size            = new System.Drawing.Size(230, 38);
            txtEmail.Name            = "txtEmail";

            // ─── txtTelefone ──────────────────────────────────────────────────────
            txtTelefone.BorderRadius    = 10;
            txtTelefone.DefaultText     = "";
            txtTelefone.SelectedText    = "";
            txtTelefone.PlaceholderText = "Telefone";
            txtTelefone.Font            = new System.Drawing.Font("Segoe UI", 10F);
            txtTelefone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(0, 123, 204);
            txtTelefone.HoverState.BorderColor   = System.Drawing.Color.FromArgb(94, 148, 255);
            txtTelefone.Location        = new System.Drawing.Point(30, 156);
            txtTelefone.Size            = new System.Drawing.Size(200, 38);
            txtTelefone.Name            = "txtTelefone";

            // ─── Seção Endereço ────────────────────────────────────────────────────
            lblSecEndereco.Text      = "Endereço";
            lblSecEndereco.Font      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblSecEndereco.ForeColor = System.Drawing.Color.FromArgb(0, 123, 204);
            lblSecEndereco.AutoSize  = true;
            lblSecEndereco.Location  = new System.Drawing.Point(30, 215);
            lblSecEndereco.Name      = "lblSecEndereco";

            // ─── txtCep ───────────────────────────────────────────────────────────
            txtCep.BorderRadius    = 10;
            txtCep.DefaultText     = "";
            txtCep.SelectedText    = "";
            txtCep.PlaceholderText = "CEP";
            txtCep.Font            = new System.Drawing.Font("Segoe UI", 10F);
            txtCep.FocusedState.BorderColor = System.Drawing.Color.FromArgb(0, 123, 204);
            txtCep.HoverState.BorderColor   = System.Drawing.Color.FromArgb(94, 148, 255);
            txtCep.Location        = new System.Drawing.Point(30, 245);
            txtCep.Size            = new System.Drawing.Size(150, 38);
            txtCep.Name            = "txtCep";

            // ─── txtLogradouro ────────────────────────────────────────────────────
            txtLogradouro.BorderRadius    = 10;
            txtLogradouro.DefaultText     = "";
            txtLogradouro.SelectedText    = "";
            txtLogradouro.PlaceholderText = "Logradouro";
            txtLogradouro.Font            = new System.Drawing.Font("Segoe UI", 10F);
            txtLogradouro.FocusedState.BorderColor = System.Drawing.Color.FromArgb(0, 123, 204);
            txtLogradouro.HoverState.BorderColor   = System.Drawing.Color.FromArgb(94, 148, 255);
            txtLogradouro.Location        = new System.Drawing.Point(200, 245);
            txtLogradouro.Size            = new System.Drawing.Size(280, 38);
            txtLogradouro.Name            = "txtLogradouro";

            // ─── txtNumero ────────────────────────────────────────────────────────
            txtNumero.BorderRadius    = 10;
            txtNumero.DefaultText     = "";
            txtNumero.SelectedText    = "";
            txtNumero.PlaceholderText = "Número";
            txtNumero.Font            = new System.Drawing.Font("Segoe UI", 10F);
            txtNumero.FocusedState.BorderColor = System.Drawing.Color.FromArgb(0, 123, 204);
            txtNumero.HoverState.BorderColor   = System.Drawing.Color.FromArgb(94, 148, 255);
            txtNumero.Location        = new System.Drawing.Point(30, 297);
            txtNumero.Size            = new System.Drawing.Size(100, 38);
            txtNumero.Name            = "txtNumero";

            // ─── txtCidade ────────────────────────────────────────────────────────
            txtCidade.BorderRadius    = 10;
            txtCidade.DefaultText     = "";
            txtCidade.SelectedText    = "";
            txtCidade.PlaceholderText = "Cidade";
            txtCidade.Font            = new System.Drawing.Font("Segoe UI", 10F);
            txtCidade.FocusedState.BorderColor = System.Drawing.Color.FromArgb(0, 123, 204);
            txtCidade.HoverState.BorderColor   = System.Drawing.Color.FromArgb(94, 148, 255);
            txtCidade.Location        = new System.Drawing.Point(150, 297);
            txtCidade.Size            = new System.Drawing.Size(220, 38);
            txtCidade.Name            = "txtCidade";

            // ─── txtEstado ────────────────────────────────────────────────────────
            txtEstado.BorderRadius    = 10;
            txtEstado.DefaultText     = "";
            txtEstado.SelectedText    = "";
            txtEstado.PlaceholderText = "Estado";
            txtEstado.Font            = new System.Drawing.Font("Segoe UI", 10F);
            txtEstado.FocusedState.BorderColor = System.Drawing.Color.FromArgb(0, 123, 204);
            txtEstado.HoverState.BorderColor   = System.Drawing.Color.FromArgb(94, 148, 255);
            txtEstado.Location        = new System.Drawing.Point(390, 297);
            txtEstado.Size            = new System.Drawing.Size(90, 38);
            txtEstado.Name            = "txtEstado";

            // ─── btnSalvar ────────────────────────────────────────────────────────
            btnSalvar.Text         = "✓  Salvar";
            btnSalvar.FillColor    = System.Drawing.Color.FromArgb(0, 123, 204);
            btnSalvar.ForeColor    = System.Drawing.Color.White;
            btnSalvar.Font         = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnSalvar.BorderRadius = 10;
            btnSalvar.Size         = new System.Drawing.Size(140, 42);
            btnSalvar.Location     = new System.Drawing.Point(30, 370);
            btnSalvar.Cursor       = System.Windows.Forms.Cursors.Hand;
            btnSalvar.Name         = "btnSalvar";
            btnSalvar.Click       += btnSalvar_Click;

            // ─── btnCancelar ───────────────────────────────────────────────────────
            btnCancelar.Text         = "Cancelar";
            btnCancelar.FillColor    = System.Drawing.Color.FromArgb(220, 220, 225);
            btnCancelar.ForeColor    = System.Drawing.Color.FromArgb(80, 80, 90);
            btnCancelar.Font         = new System.Drawing.Font("Segoe UI", 10F);
            btnCancelar.BorderRadius = 10;
            btnCancelar.Size         = new System.Drawing.Size(120, 42);
            btnCancelar.Location     = new System.Drawing.Point(185, 370);
            btnCancelar.Cursor       = System.Windows.Forms.Cursors.Hand;
            btnCancelar.Name         = "btnCancelar";
            btnCancelar.Click       += btnCancelar_Click;

            // ─── panelForm ────────────────────────────────────────────────────────
            panelForm.BackColor  = System.Drawing.Color.White;
            panelForm.Dock       = System.Windows.Forms.DockStyle.Fill;
            panelForm.Padding    = new System.Windows.Forms.Padding(10);
            panelForm.AutoScroll = true;
            panelForm.Name       = "panelForm";
            panelForm.Controls.Add(lblSecPessoal);
            panelForm.Controls.Add(txtNome);
            panelForm.Controls.Add(txtCpf);
            panelForm.Controls.Add(txtEmail);
            panelForm.Controls.Add(txtTelefone);
            panelForm.Controls.Add(lblSecEndereco);
            panelForm.Controls.Add(txtCep);
            panelForm.Controls.Add(txtLogradouro);
            panelForm.Controls.Add(txtNumero);
            panelForm.Controls.Add(txtCidade);
            panelForm.Controls.Add(txtEstado);
            panelForm.Controls.Add(btnSalvar);
            panelForm.Controls.Add(btnCancelar);

            // ─── ucNovoCliente ────────────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor           = System.Drawing.Color.FromArgb(245, 247, 250);
            this.Controls.Add(panelForm);
            this.Controls.Add(panelHeader);
            this.Name = "ucNovoCliente";
            this.Size = new System.Drawing.Size(1060, 640);

            panelHeader.ResumeLayout(false);
            panelForm.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblSecPessoal;
        private System.Windows.Forms.Label lblSecEndereco;
        private Guna.UI2.WinForms.Guna2TextBox txtNome;
        private Guna.UI2.WinForms.Guna2TextBox txtCpf;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtTelefone;
        private Guna.UI2.WinForms.Guna2TextBox txtCep;
        private Guna.UI2.WinForms.Guna2TextBox txtLogradouro;
        private Guna.UI2.WinForms.Guna2TextBox txtNumero;
        private Guna.UI2.WinForms.Guna2TextBox txtCidade;
        private Guna.UI2.WinForms.Guna2TextBox txtEstado;
        private Guna.UI2.WinForms.Guna2Button btnSalvar;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
    }
}
