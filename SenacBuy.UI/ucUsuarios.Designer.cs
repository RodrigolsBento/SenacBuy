namespace SenacBuy.UI
{
    partial class ucUsuarios
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panelHeader = new Panel();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            txtBuscaUsuario = new Guna.UI2.WinForms.Guna2TextBox();
            btnNovoUsuario = new Guna.UI2.WinForms.Guna2Button();
            btnEditarUsuario = new Guna.UI2.WinForms.Guna2Button();
            btnExcluirUsuario = new Guna.UI2.WinForms.Guna2Button();
            panelConteudo = new Panel();
            dgvUsuarios = new DataGridView();
            panelHeader.SuspendLayout();
            panelConteudo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.White;
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Controls.Add(lblSubtitulo);
            panelHeader.Controls.Add(txtBuscaUsuario);
            panelHeader.Controls.Add(btnNovoUsuario);
            panelHeader.Controls.Add(btnEditarUsuario);
            panelHeader.Controls.Add(btnExcluirUsuario);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Padding = new Padding(25, 0, 25, 0);
            panelHeader.Size = new Size(1060, 80);
            panelHeader.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Century Gothic", 14F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(30, 40, 60);
            lblTitulo.Location = new Point(25, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(250, 34);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "👤  Gestão de Usuários";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.Font = new Font("Segoe UI", 9F);
            lblSubtitulo.ForeColor = Color.Gray;
            lblSubtitulo.Location = new Point(25, 48);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(250, 20);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Gerencie os usuários e acessos do sistema";
            // 
            // txtBuscaUsuario
            // 
            txtBuscaUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBuscaUsuario.BorderColor = Color.FromArgb(200, 210, 225);
            txtBuscaUsuario.BorderRadius = 8;
            txtBuscaUsuario.CustomizableEdges = customizableEdges1;
            txtBuscaUsuario.DefaultText = "";
            txtBuscaUsuario.FillColor = Color.FromArgb(245, 247, 250);
            txtBuscaUsuario.FocusedState.BorderColor = Color.FromArgb(0, 123, 204);
            txtBuscaUsuario.Font = new Font("Segoe UI", 9.5F);
            txtBuscaUsuario.Location = new Point(281, 21);
            txtBuscaUsuario.Name = "txtBuscaUsuario";
            txtBuscaUsuario.PlaceholderText = "🔍  Pesquisar por nome ou e-mail...";
            txtBuscaUsuario.SelectedText = "";
            txtBuscaUsuario.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtBuscaUsuario.Size = new Size(388, 40);
            txtBuscaUsuario.TabIndex = 2;
            txtBuscaUsuario.TextChanged += txtBuscaUsuario_TextChanged;
            // 
            // btnNovoUsuario
            // 
            btnNovoUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNovoUsuario.BorderRadius = 10;
            btnNovoUsuario.Cursor = Cursors.Hand;
            btnNovoUsuario.CustomizableEdges = customizableEdges3;
            btnNovoUsuario.FillColor = Color.FromArgb(0, 123, 204);
            btnNovoUsuario.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNovoUsuario.ForeColor = Color.White;
            btnNovoUsuario.Location = new Point(675, 21);
            btnNovoUsuario.Name = "btnNovoUsuario";
            btnNovoUsuario.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnNovoUsuario.Size = new Size(145, 40);
            btnNovoUsuario.TabIndex = 3;
            btnNovoUsuario.Text = "+ Novo Usuário";
            btnNovoUsuario.Click += btnNovoUsuario_Click;
            // 
            // btnEditarUsuario
            // 
            btnEditarUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditarUsuario.BorderRadius = 10;
            btnEditarUsuario.Cursor = Cursors.Hand;
            btnEditarUsuario.CustomizableEdges = customizableEdges5;
            btnEditarUsuario.FillColor = Color.FromArgb(255, 165, 0);
            btnEditarUsuario.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnEditarUsuario.ForeColor = Color.White;
            btnEditarUsuario.Location = new Point(826, 21);
            btnEditarUsuario.Name = "btnEditarUsuario";
            btnEditarUsuario.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnEditarUsuario.Size = new Size(100, 40);
            btnEditarUsuario.TabIndex = 4;
            btnEditarUsuario.Text = "✏️ Editar";
            btnEditarUsuario.Click += btnEditarUsuario_Click;
            // 
            // btnExcluirUsuario
            // 
            btnExcluirUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExcluirUsuario.BorderRadius = 10;
            btnExcluirUsuario.Cursor = Cursors.Hand;
            btnExcluirUsuario.CustomizableEdges = customizableEdges7;
            btnExcluirUsuario.FillColor = Color.FromArgb(220, 60, 60);
            btnExcluirUsuario.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnExcluirUsuario.ForeColor = Color.White;
            btnExcluirUsuario.Location = new Point(932, 21);
            btnExcluirUsuario.Name = "btnExcluirUsuario";
            btnExcluirUsuario.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnExcluirUsuario.Size = new Size(100, 40);
            btnExcluirUsuario.TabIndex = 5;
            btnExcluirUsuario.Text = "🗑️ Excluir";
            btnExcluirUsuario.Click += btnExcluirUsuario_Click;
            // 
            // panelConteudo
            // 
            panelConteudo.BackColor = Color.White;
            panelConteudo.Controls.Add(dgvUsuarios);
            panelConteudo.Dock = DockStyle.Fill;
            panelConteudo.Location = new Point(0, 80);
            panelConteudo.Name = "panelConteudo";
            panelConteudo.Padding = new Padding(20, 15, 20, 20);
            panelConteudo.Size = new Size(1060, 560);
            panelConteudo.TabIndex = 0;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(250, 251, 255);
            dgvUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuarios.BackgroundColor = Color.White;
            dgvUsuarios.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(248, 250, 252);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(80, 90, 110);
            dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvUsuarios.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(50, 60, 80);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(220, 234, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(0, 60, 130);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvUsuarios.DefaultCellStyle = dataGridViewCellStyle3;
            dgvUsuarios.Dock = DockStyle.Fill;
            dgvUsuarios.GridColor = Color.FromArgb(230, 230, 235);
            dgvUsuarios.Location = new Point(20, 15);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersVisible = false;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new Size(1020, 525);
            dgvUsuarios.TabIndex = 0;
            // 
            // ucUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            Controls.Add(panelConteudo);
            Controls.Add(panelHeader);
            Name = "ucUsuarios";
            Size = new Size(1060, 640);
            panelHeader.ResumeLayout(false);
            panelConteudo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelConteudo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscaUsuario;
        private Guna.UI2.WinForms.Guna2Button btnNovoUsuario;
        private Guna.UI2.WinForms.Guna2Button btnEditarUsuario;
        private Guna.UI2.WinForms.Guna2Button btnExcluirUsuario;
        private System.Windows.Forms.DataGridView dgvUsuarios;
    }
}
