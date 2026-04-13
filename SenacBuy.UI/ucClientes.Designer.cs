namespace SenacBuy.UI
{
    partial class ucClientes
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panelHeader = new Panel();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            txtBuscaCliente = new Guna.UI2.WinForms.Guna2TextBox();
            btnNovoCliente = new Guna.UI2.WinForms.Guna2Button();
            btnEditarCliente = new Guna.UI2.WinForms.Guna2Button();
            btnExcluirCliente = new Guna.UI2.WinForms.Guna2Button();
            panelConteudo = new Panel();
            dgvClientes = new DataGridView();
            panelHeader.SuspendLayout();
            panelConteudo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.White;
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Controls.Add(lblSubtitulo);
            panelHeader.Controls.Add(txtBuscaCliente);
            panelHeader.Controls.Add(btnNovoCliente);
            panelHeader.Controls.Add(btnEditarCliente);
            panelHeader.Controls.Add(btnExcluirCliente);
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
            lblTitulo.Size = new Size(400, 34);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "👥  Gestão de Clientes";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.Font = new Font("Segoe UI", 9F);
            lblSubtitulo.ForeColor = Color.Gray;
            lblSubtitulo.Location = new Point(25, 48);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(400, 20);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Gerencie os clientes cadastrados no sistema";
            // 
            // txtBuscaCliente
            // 
            txtBuscaCliente.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBuscaCliente.BorderColor = Color.FromArgb(200, 210, 225);
            txtBuscaCliente.BorderRadius = 8;
            txtBuscaCliente.CustomizableEdges = customizableEdges1;
            txtBuscaCliente.DefaultText = "";
            txtBuscaCliente.FillColor = Color.FromArgb(245, 247, 250);
            txtBuscaCliente.FocusedState.BorderColor = Color.FromArgb(0, 123, 204);
            txtBuscaCliente.Font = new Font("Segoe UI", 9.5F);
            txtBuscaCliente.Location = new Point(431, 18);
            txtBuscaCliente.Name = "txtBuscaCliente";
            txtBuscaCliente.PlaceholderText = "🔍  Pesquisar por nome ou CPF...";
            txtBuscaCliente.SelectedText = "";
            txtBuscaCliente.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtBuscaCliente.Size = new Size(217, 40);
            txtBuscaCliente.TabIndex = 2;
            txtBuscaCliente.TextChanged += txtBuscaCliente_TextChanged;
            // 
            // btnNovoCliente
            // 
            btnNovoCliente.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNovoCliente.BorderRadius = 10;
            btnNovoCliente.Cursor = Cursors.Hand;
            btnNovoCliente.CustomizableEdges = customizableEdges3;
            btnNovoCliente.FillColor = Color.FromArgb(0, 123, 204);
            btnNovoCliente.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNovoCliente.ForeColor = Color.White;
            btnNovoCliente.Location = new Point(654, 18);
            btnNovoCliente.Name = "btnNovoCliente";
            btnNovoCliente.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnNovoCliente.Size = new Size(155, 40);
            btnNovoCliente.TabIndex = 3;
            btnNovoCliente.Text = "+ Novo Cliente";
            btnNovoCliente.Click += btnNovoCliente_Click;
            // 
            // btnEditarCliente
            // 
            btnEditarCliente.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditarCliente.BorderRadius = 10;
            btnEditarCliente.Cursor = Cursors.Hand;
            btnEditarCliente.CustomizableEdges = customizableEdges5;
            btnEditarCliente.FillColor = Color.FromArgb(255, 165, 0);
            btnEditarCliente.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnEditarCliente.ForeColor = Color.White;
            btnEditarCliente.Location = new Point(815, 18);
            btnEditarCliente.Name = "btnEditarCliente";
            btnEditarCliente.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnEditarCliente.Size = new Size(110, 40);
            btnEditarCliente.TabIndex = 4;
            btnEditarCliente.Text = "✏️ Editar";
            btnEditarCliente.Click += btnEditarCliente_Click;
            // 
            // btnExcluirCliente
            // 
            btnExcluirCliente.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExcluirCliente.BorderRadius = 10;
            btnExcluirCliente.Cursor = Cursors.Hand;
            btnExcluirCliente.CustomizableEdges = customizableEdges7;
            btnExcluirCliente.FillColor = Color.FromArgb(220, 60, 60);
            btnExcluirCliente.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnExcluirCliente.ForeColor = Color.White;
            btnExcluirCliente.Location = new Point(931, 18);
            btnExcluirCliente.Name = "btnExcluirCliente";
            btnExcluirCliente.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnExcluirCliente.Size = new Size(110, 40);
            btnExcluirCliente.TabIndex = 5;
            btnExcluirCliente.Text = "🗑️ Excluir";
            btnExcluirCliente.Click += btnExcluirCliente_Click;
            // 
            // panelConteudo
            // 
            panelConteudo.BackColor = Color.White;
            panelConteudo.Controls.Add(dgvClientes);
            panelConteudo.Dock = DockStyle.Fill;
            panelConteudo.Location = new Point(0, 80);
            panelConteudo.Name = "panelConteudo";
            panelConteudo.Padding = new Padding(20, 15, 20, 20);
            panelConteudo.Size = new Size(1060, 560);
            panelConteudo.TabIndex = 0;
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(250, 251, 255);
            dgvClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.BackgroundColor = Color.White;
            dgvClientes.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(248, 250, 252);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(80, 90, 110);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvClientes.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(50, 60, 80);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(220, 234, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(0, 60, 130);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvClientes.DefaultCellStyle = dataGridViewCellStyle3;
            dgvClientes.Dock = DockStyle.Fill;
            dgvClientes.GridColor = Color.FromArgb(230, 230, 235);
            dgvClientes.Location = new Point(20, 15);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersVisible = false;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(1020, 525);
            dgvClientes.TabIndex = 0;
            // 
            // ucClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            Controls.Add(panelConteudo);
            Controls.Add(panelHeader);
            Name = "ucClientes";
            Size = new Size(1060, 640);
            panelHeader.ResumeLayout(false);
            panelConteudo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelConteudo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscaCliente;
        private Guna.UI2.WinForms.Guna2Button btnNovoCliente;
        private Guna.UI2.WinForms.Guna2Button btnEditarCliente;
        private Guna.UI2.WinForms.Guna2Button btnExcluirCliente;
        private System.Windows.Forms.DataGridView dgvClientes;
    }
}
