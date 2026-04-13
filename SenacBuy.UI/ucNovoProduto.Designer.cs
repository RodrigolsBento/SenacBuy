namespace SenacBuy.UI
{
    partial class ucNovoProduto
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelHeader = new Panel();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            panelForm = new Panel();
            txtNome = new Guna.UI2.WinForms.Guna2TextBox();
            txtDescricao = new Guna.UI2.WinForms.Guna2TextBox();
            txtPreco = new Guna.UI2.WinForms.Guna2TextBox();
            txtEstoque = new Guna.UI2.WinForms.Guna2TextBox();
            lblCategoria = new System.Windows.Forms.Label();
            cmbCategoria = new System.Windows.Forms.ComboBox();
            btnSalvar = new Guna.UI2.WinForms.Guna2Button();
            btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            picFoto = new Guna.UI2.WinForms.Guna2PictureBox();
            btnSelecionarImagem = new Guna.UI2.WinForms.Guna2Button();
            panelHeader.SuspendLayout();
            panelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFoto).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.White;
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Controls.Add(lblSubtitulo);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1060, 75);
            panelHeader.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Century Gothic", 14F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(30, 40, 60);
            lblTitulo.Location = new Point(30, 10);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(550, 34);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "📦  Cadastro de Novo Produto";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.Font = new Font("Segoe UI", 9F);
            lblSubtitulo.ForeColor = Color.Gray;
            lblSubtitulo.Location = new Point(30, 46);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(400, 20);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Preencha as informações do produto";
            // 
            // panelForm
            // 
            panelForm.AutoScroll = true;
            panelForm.BackColor = Color.White;
            panelForm.Controls.Add(txtNome);
            panelForm.Controls.Add(txtDescricao);
            panelForm.Controls.Add(txtPreco);
            panelForm.Controls.Add(txtEstoque);
            panelForm.Controls.Add(lblCategoria);
            panelForm.Controls.Add(cmbCategoria);
            panelForm.Controls.Add(btnSalvar);
            panelForm.Controls.Add(btnCancelar);
            panelForm.Controls.Add(picFoto);
            panelForm.Controls.Add(btnSelecionarImagem);
            panelForm.Dock = DockStyle.Fill;
            panelForm.Location = new Point(0, 75);
            panelForm.Name = "panelForm";
            panelForm.Padding = new Padding(10);
            panelForm.Size = new Size(1060, 565);
            panelForm.TabIndex = 0;
            // 
            // txtNome
            // 
            txtNome.BorderRadius = 10;
            txtNome.CustomizableEdges = customizableEdges1;
            txtNome.DefaultText = "";
            txtNome.FocusedState.BorderColor = Color.FromArgb(0, 123, 204);
            txtNome.Font = new Font("Segoe UI", 10F);
            txtNome.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtNome.Location = new Point(186, 63);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome do Produto *";
            txtNome.SelectedText = "";
            txtNome.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtNome.Size = new Size(330, 38);
            txtNome.TabIndex = 0;
            // 
            // txtDescricao
            // 
            txtDescricao.BorderRadius = 10;
            txtDescricao.CustomizableEdges = customizableEdges3;
            txtDescricao.DefaultText = "";
            txtDescricao.FocusedState.BorderColor = Color.FromArgb(0, 123, 204);
            txtDescricao.Font = new Font("Segoe UI", 10F);
            txtDescricao.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtDescricao.Location = new Point(186, 115);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.PlaceholderText = "Descrição";
            txtDescricao.SelectedText = "";
            txtDescricao.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtDescricao.Size = new Size(200, 38);
            txtDescricao.TabIndex = 1;
            // 
            // txtPreco
            // 
            txtPreco.BorderRadius = 10;
            txtPreco.CustomizableEdges = customizableEdges5;
            txtPreco.DefaultText = "";
            txtPreco.FocusedState.BorderColor = Color.FromArgb(0, 123, 204);
            txtPreco.Font = new Font("Segoe UI", 10F);
            txtPreco.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPreco.Location = new Point(186, 167);
            txtPreco.Name = "txtPreco";
            txtPreco.PlaceholderText = "Preço (ex: 4500,00) *";
            txtPreco.SelectedText = "";
            txtPreco.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtPreco.Size = new Size(200, 38);
            txtPreco.TabIndex = 2;
            // 
            // txtEstoque
            // 
            txtEstoque.BorderRadius = 10;
            txtEstoque.CustomizableEdges = customizableEdges7;
            txtEstoque.DefaultText = "";
            txtEstoque.FocusedState.BorderColor = Color.FromArgb(0, 123, 204);
            txtEstoque.Font = new Font("Segoe UI", 10F);
            txtEstoque.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEstoque.Location = new Point(406, 167);
            txtEstoque.Name = "txtEstoque";
            txtEstoque.PlaceholderText = "Estoque";
            txtEstoque.SelectedText = "";
            txtEstoque.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtEstoque.Size = new Size(110, 38);
            txtEstoque.TabIndex = 3;
            // 
            // lblCategoria
            // 
            lblCategoria = new System.Windows.Forms.Label();
            lblCategoria.Text      = "Categoria";
            lblCategoria.Font      = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCategoria.ForeColor = Color.FromArgb(60, 70, 90);
            lblCategoria.AutoSize  = true;
            lblCategoria.Location  = new Point(406, 115);
            lblCategoria.Name      = "lblCategoria";
            // 
            // cmbCategoria
            // 
            cmbCategoria.Font         = new Font("Segoe UI", 10F);
            cmbCategoria.FlatStyle    = FlatStyle.Flat;
            cmbCategoria.Location     = new Point(406, 135);
            cmbCategoria.Size         = new Size(200, 28);
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.Name         = "cmbCategoria";
            // 
            // btnSalvar
            // 
            btnSalvar.BorderRadius = 10;
            btnSalvar.Cursor = Cursors.Hand;
            btnSalvar.CustomizableEdges = customizableEdges11;
            btnSalvar.FillColor = Color.FromArgb(0, 123, 204);
            btnSalvar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(30, 230);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnSalvar.Size = new Size(140, 42);
            btnSalvar.TabIndex = 5;
            btnSalvar.Text = "✓  Salvar";
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BorderRadius = 10;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.CustomizableEdges = customizableEdges13;
            btnCancelar.FillColor = Color.FromArgb(220, 220, 225);
            btnCancelar.Font = new Font("Segoe UI", 10F);
            btnCancelar.ForeColor = Color.FromArgb(80, 80, 90);
            btnCancelar.Location = new Point(185, 230);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnCancelar.Size = new Size(120, 42);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Click += btnCancelar_Click;
            // 
            // picFoto
            // 
            picFoto.BorderRadius = 10;
            picFoto.CustomizableEdges = customizableEdges15;
            picFoto.FillColor = Color.FromArgb(240, 240, 240);
            picFoto.ImageRotate = 0F;
            picFoto.Location = new Point(30, 63);
            picFoto.Name = "picFoto";
            picFoto.ShadowDecoration.CustomizableEdges = customizableEdges16;
            picFoto.Size = new Size(150, 142);
            picFoto.SizeMode = PictureBoxSizeMode.Zoom;
            picFoto.TabIndex = 7;
            picFoto.TabStop = false;
            // 
            // btnSelecionarImagem
            // 
            btnSelecionarImagem.BorderRadius = 8;
            btnSelecionarImagem.Cursor = Cursors.Hand;
            btnSelecionarImagem.CustomizableEdges = customizableEdges17;
            btnSelecionarImagem.FillColor = Color.FromArgb(230, 235, 240);
            btnSelecionarImagem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSelecionarImagem.ForeColor = Color.FromArgb(80, 90, 100);
            btnSelecionarImagem.Location = new Point(30, 13);
            btnSelecionarImagem.Name = "btnSelecionarImagem";
            btnSelecionarImagem.ShadowDecoration.CustomizableEdges = customizableEdges18;
            btnSelecionarImagem.Size = new Size(150, 40);
            btnSelecionarImagem.TabIndex = 8;
            btnSelecionarImagem.Text = "Selecionar Foto";
            btnSelecionarImagem.Click += btnSelecionarImagem_Click;
            // 
            // ucNovoProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            Controls.Add(panelForm);
            Controls.Add(panelHeader);
            Name = "ucNovoProduto";
            Size = new Size(1060, 640);
            panelHeader.ResumeLayout(false);
            panelForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picFoto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private Guna.UI2.WinForms.Guna2TextBox txtNome;
        private Guna.UI2.WinForms.Guna2TextBox txtDescricao;
        private Guna.UI2.WinForms.Guna2TextBox txtPreco;
        private Guna.UI2.WinForms.Guna2TextBox txtEstoque;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private Guna.UI2.WinForms.Guna2Button btnSalvar;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
        private Guna.UI2.WinForms.Guna2PictureBox picFoto;
        private Guna.UI2.WinForms.Guna2Button btnSelecionarImagem;
    }
}
