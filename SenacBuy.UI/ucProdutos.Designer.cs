namespace SenacBuy.UI
{
    partial class ucProdutos
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
            txtBuscaProduto = new Guna.UI2.WinForms.Guna2TextBox();
            btnAdicionarProduto = new Guna.UI2.WinForms.Guna2Button();
            btnEditarProduto = new Guna.UI2.WinForms.Guna2Button();
            btnExcluirProduto = new Guna.UI2.WinForms.Guna2Button();
            panelConteudo = new Panel();
            dgvProdutos = new DataGridView();
            panelHeader.SuspendLayout();
            panelConteudo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.White;
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Controls.Add(lblSubtitulo);
            panelHeader.Controls.Add(txtBuscaProduto);
            panelHeader.Controls.Add(btnAdicionarProduto);
            panelHeader.Controls.Add(btnEditarProduto);
            panelHeader.Controls.Add(btnExcluirProduto);
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
            lblTitulo.Size = new Size(278, 34);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "📦  Catálogo de Produtos";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.Font = new Font("Segoe UI", 9F);
            lblSubtitulo.ForeColor = Color.Gray;
            lblSubtitulo.Location = new Point(25, 48);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(278, 20);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Gerenciamento de inventário e estoque";
            // 
            // txtBuscaProduto
            // 
            txtBuscaProduto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBuscaProduto.BorderColor = Color.FromArgb(200, 210, 225);
            txtBuscaProduto.BorderRadius = 8;
            txtBuscaProduto.CustomizableEdges = customizableEdges1;
            txtBuscaProduto.DefaultText = "";
            txtBuscaProduto.FillColor = Color.FromArgb(245, 247, 250);
            txtBuscaProduto.FocusedState.BorderColor = Color.FromArgb(0, 123, 204);
            txtBuscaProduto.Font = new Font("Segoe UI", 9.5F);
            txtBuscaProduto.Location = new Point(367, 19);
            txtBuscaProduto.Name = "txtBuscaProduto";
            txtBuscaProduto.PlaceholderText = "🔍  Pesquisar produto pelo nome...";
            txtBuscaProduto.SelectedText = "";
            txtBuscaProduto.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtBuscaProduto.Size = new Size(260, 40);
            txtBuscaProduto.TabIndex = 2;
            txtBuscaProduto.TextChanged += txtBuscaProduto_TextChanged;
            // 
            // btnAdicionarProduto
            // 
            btnAdicionarProduto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdicionarProduto.BorderRadius = 10;
            btnAdicionarProduto.Cursor = Cursors.Hand;
            btnAdicionarProduto.CustomizableEdges = customizableEdges3;
            btnAdicionarProduto.FillColor = Color.FromArgb(0, 123, 204);
            btnAdicionarProduto.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAdicionarProduto.ForeColor = Color.White;
            btnAdicionarProduto.Location = new Point(633, 19);
            btnAdicionarProduto.Name = "btnAdicionarProduto";
            btnAdicionarProduto.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnAdicionarProduto.Size = new Size(175, 40);
            btnAdicionarProduto.TabIndex = 3;
            btnAdicionarProduto.Text = "+ Adicionar Produto";
            btnAdicionarProduto.Click += btnAdicionarProduto_Click;
            // 
            // btnEditarProduto
            // 
            btnEditarProduto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditarProduto.BorderRadius = 10;
            btnEditarProduto.Cursor = Cursors.Hand;
            btnEditarProduto.CustomizableEdges = customizableEdges5;
            btnEditarProduto.FillColor = Color.FromArgb(255, 165, 0);
            btnEditarProduto.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnEditarProduto.ForeColor = Color.White;
            btnEditarProduto.Location = new Point(814, 19);
            btnEditarProduto.Name = "btnEditarProduto";
            btnEditarProduto.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnEditarProduto.Size = new Size(110, 40);
            btnEditarProduto.TabIndex = 4;
            btnEditarProduto.Text = "✏️ Editar";
            btnEditarProduto.Click += btnEditarProduto_Click;
            // 
            // btnExcluirProduto
            // 
            btnExcluirProduto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExcluirProduto.BorderRadius = 10;
            btnExcluirProduto.Cursor = Cursors.Hand;
            btnExcluirProduto.CustomizableEdges = customizableEdges7;
            btnExcluirProduto.FillColor = Color.FromArgb(220, 60, 60);
            btnExcluirProduto.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnExcluirProduto.ForeColor = Color.White;
            btnExcluirProduto.Location = new Point(930, 19);
            btnExcluirProduto.Name = "btnExcluirProduto";
            btnExcluirProduto.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnExcluirProduto.Size = new Size(110, 40);
            btnExcluirProduto.TabIndex = 5;
            btnExcluirProduto.Text = "🗑️ Excluir";
            btnExcluirProduto.Click += btnExcluirProduto_Click;
            // 
            // panelConteudo
            // 
            panelConteudo.BackColor = Color.White;
            panelConteudo.Controls.Add(dgvProdutos);
            panelConteudo.Dock = DockStyle.Fill;
            panelConteudo.Location = new Point(0, 80);
            panelConteudo.Name = "panelConteudo";
            panelConteudo.Padding = new Padding(20, 15, 20, 20);
            panelConteudo.Size = new Size(1060, 560);
            panelConteudo.TabIndex = 0;
            // 
            // dgvProdutos
            // 
            dgvProdutos.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(250, 251, 255);
            dgvProdutos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProdutos.BackgroundColor = Color.White;
            dgvProdutos.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(248, 250, 252);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(80, 90, 110);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvProdutos.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(220, 234, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(0, 60, 130);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvProdutos.DefaultCellStyle = dataGridViewCellStyle3;
            dgvProdutos.Dock = DockStyle.Fill;
            dgvProdutos.GridColor = Color.FromArgb(230, 230, 235);
            dgvProdutos.Location = new Point(20, 15);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.ReadOnly = true;
            dgvProdutos.RowHeadersVisible = false;
            dgvProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProdutos.Size = new Size(1020, 525);
            dgvProdutos.TabIndex = 0;
            // 
            // ucProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            Controls.Add(panelConteudo);
            Controls.Add(panelHeader);
            Name = "ucProdutos";
            Size = new Size(1060, 640);
            panelHeader.ResumeLayout(false);
            panelConteudo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelConteudo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscaProduto;
        private Guna.UI2.WinForms.Guna2Button btnAdicionarProduto;
        private Guna.UI2.WinForms.Guna2Button btnEditarProduto;
        private Guna.UI2.WinForms.Guna2Button btnExcluirProduto;
        private System.Windows.Forms.DataGridView dgvProdutos;
    }
}
