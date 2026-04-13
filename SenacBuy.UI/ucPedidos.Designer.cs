namespace SenacBuy.UI
{
    partial class ucPedidos
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panelHeader = new Panel();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            cmbFiltroStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            btnImprimirRecibo = new Guna.UI2.WinForms.Guna2Button();
            btnEditarPedido = new Guna.UI2.WinForms.Guna2Button();
            btnExcluirPedido = new Guna.UI2.WinForms.Guna2Button();
            btnNovoPedido = new Guna.UI2.WinForms.Guna2Button();
            panelConteudo = new Panel();
            dgvPedidos = new DataGridView();
            panelHeader.SuspendLayout();
            panelConteudo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.White;
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Controls.Add(lblSubtitulo);
            panelHeader.Controls.Add(cmbFiltroStatus);
            panelHeader.Controls.Add(btnImprimirRecibo);
            panelHeader.Controls.Add(btnEditarPedido);
            panelHeader.Controls.Add(btnExcluirPedido);
            panelHeader.Controls.Add(btnNovoPedido);
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
            lblTitulo.Size = new Size(287, 34);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "\U0001f6d2  Gestão de Pedidos";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.Font = new Font("Segoe UI", 9F);
            lblSubtitulo.ForeColor = Color.Gray;
            lblSubtitulo.Location = new Point(25, 48);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(287, 20);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Gerencie e acompanhe todos os pedidos de venda";
            // 
            // cmbFiltroStatus
            // 
            cmbFiltroStatus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbFiltroStatus.BackColor = Color.Transparent;
            cmbFiltroStatus.BorderColor = Color.FromArgb(200, 210, 225);
            cmbFiltroStatus.BorderRadius = 8;
            cmbFiltroStatus.CustomizableEdges = customizableEdges1;
            cmbFiltroStatus.DrawMode = DrawMode.OwnerDrawFixed;
            cmbFiltroStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFiltroStatus.FillColor = Color.FromArgb(245, 247, 250);
            cmbFiltroStatus.FocusedColor = Color.Empty;
            cmbFiltroStatus.Font = new Font("Segoe UI", 9.5F);
            cmbFiltroStatus.ForeColor = Color.FromArgb(68, 88, 112);
            cmbFiltroStatus.ItemHeight = 30;
            cmbFiltroStatus.Items.AddRange(new object[] { "Todos", "Pendente", "Finalizado", "Cancelado" });
            cmbFiltroStatus.Location = new Point(549, 24);
            cmbFiltroStatus.Name = "cmbFiltroStatus";
            cmbFiltroStatus.ShadowDecoration.CustomizableEdges = customizableEdges2;
            cmbFiltroStatus.Size = new Size(130, 36);
            cmbFiltroStatus.StartIndex = 0;
            cmbFiltroStatus.TabIndex = 2;
            // 
            // btnImprimirRecibo
            // 
            btnImprimirRecibo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnImprimirRecibo.BorderRadius = 10;
            btnImprimirRecibo.Cursor = Cursors.Hand;
            btnImprimirRecibo.CustomizableEdges = customizableEdges3;
            btnImprimirRecibo.FillColor = Color.FromArgb(108, 117, 125);
            btnImprimirRecibo.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnImprimirRecibo.ForeColor = Color.White;
            btnImprimirRecibo.Location = new Point(361, 20);
            btnImprimirRecibo.Name = "btnImprimirRecibo";
            btnImprimirRecibo.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnImprimirRecibo.Size = new Size(150, 40);
            btnImprimirRecibo.TabIndex = 3;
            btnImprimirRecibo.Text = "🖨️ Imprimir Recibo";
            btnImprimirRecibo.Click += btnImprimirRecibo_Click;
            // 
            // btnEditarPedido
            // 
            btnEditarPedido.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditarPedido.BorderRadius = 10;
            btnEditarPedido.Cursor = Cursors.Hand;
            btnEditarPedido.CustomizableEdges = customizableEdges5;
            btnEditarPedido.FillColor = Color.FromArgb(255, 165, 0);
            btnEditarPedido.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnEditarPedido.ForeColor = Color.White;
            btnEditarPedido.Location = new Point(841, 20);
            btnEditarPedido.Name = "btnEditarPedido";
            btnEditarPedido.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnEditarPedido.Size = new Size(95, 40);
            btnEditarPedido.TabIndex = 4;
            btnEditarPedido.Text = "✏️ Editar";
            btnEditarPedido.Click += btnEditarPedido_Click;
            // 
            // btnExcluirPedido
            // 
            btnExcluirPedido.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExcluirPedido.BorderRadius = 10;
            btnExcluirPedido.Cursor = Cursors.Hand;
            btnExcluirPedido.CustomizableEdges = customizableEdges7;
            btnExcluirPedido.FillColor = Color.FromArgb(220, 60, 60);
            btnExcluirPedido.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnExcluirPedido.ForeColor = Color.White;
            btnExcluirPedido.Location = new Point(942, 20);
            btnExcluirPedido.Name = "btnExcluirPedido";
            btnExcluirPedido.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnExcluirPedido.Size = new Size(100, 40);
            btnExcluirPedido.TabIndex = 5;
            btnExcluirPedido.Text = "🗑️ Excluir";
            btnExcluirPedido.Click += btnExcluirPedido_Click;
            // 
            // btnNovoPedido
            // 
            btnNovoPedido.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNovoPedido.BorderRadius = 10;
            btnNovoPedido.Cursor = Cursors.Hand;
            btnNovoPedido.CustomizableEdges = customizableEdges9;
            btnNovoPedido.FillColor = Color.FromArgb(0, 123, 204);
            btnNovoPedido.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNovoPedido.ForeColor = Color.White;
            btnNovoPedido.Location = new Point(685, 20);
            btnNovoPedido.Name = "btnNovoPedido";
            btnNovoPedido.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnNovoPedido.Size = new Size(150, 40);
            btnNovoPedido.TabIndex = 6;
            btnNovoPedido.Text = "Novo Pedido";
            btnNovoPedido.Click += btnNovoPedido_Click;
            // 
            // panelConteudo
            // 
            panelConteudo.BackColor = Color.White;
            panelConteudo.Controls.Add(dgvPedidos);
            panelConteudo.Dock = DockStyle.Fill;
            panelConteudo.Location = new Point(0, 80);
            panelConteudo.Name = "panelConteudo";
            panelConteudo.Padding = new Padding(20, 15, 20, 20);
            panelConteudo.Size = new Size(1060, 560);
            panelConteudo.TabIndex = 0;
            // 
            // dgvPedidos
            // 
            dgvPedidos.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(250, 251, 255);
            dgvPedidos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPedidos.BackgroundColor = Color.White;
            dgvPedidos.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(248, 250, 252);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(80, 90, 110);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvPedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvPedidos.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(220, 234, 255);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvPedidos.DefaultCellStyle = dataGridViewCellStyle3;
            dgvPedidos.Dock = DockStyle.Fill;
            dgvPedidos.GridColor = Color.FromArgb(230, 230, 235);
            dgvPedidos.Location = new Point(20, 15);
            dgvPedidos.Name = "dgvPedidos";
            dgvPedidos.ReadOnly = true;
            dgvPedidos.RowHeadersVisible = false;
            dgvPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPedidos.Size = new Size(1020, 525);
            dgvPedidos.TabIndex = 0;
            // 
            // ucPedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            Controls.Add(panelConteudo);
            Controls.Add(panelHeader);
            Name = "ucPedidos";
            Size = new Size(1060, 640);
            panelHeader.ResumeLayout(false);
            panelConteudo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelConteudo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private Guna.UI2.WinForms.Guna2ComboBox cmbFiltroStatus;
        private Guna.UI2.WinForms.Guna2Button btnImprimirRecibo;
        private Guna.UI2.WinForms.Guna2Button btnNovoPedido;
        private Guna.UI2.WinForms.Guna2Button btnEditarPedido;
        private Guna.UI2.WinForms.Guna2Button btnExcluirPedido;
        private System.Windows.Forms.DataGridView dgvPedidos;
    }
}
