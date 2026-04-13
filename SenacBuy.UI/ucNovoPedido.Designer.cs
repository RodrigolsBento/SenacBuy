namespace SenacBuy.UI
{
    partial class ucNovoPedido
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
            panelHeader       = new System.Windows.Forms.Panel();
            lblTitulo         = new System.Windows.Forms.Label();
            lblSubtitulo      = new System.Windows.Forms.Label();
            panelForm         = new System.Windows.Forms.Panel();
            lblCliente        = new System.Windows.Forms.Label();
            cmbCliente        = new System.Windows.Forms.ComboBox();
            lblStatus         = new System.Windows.Forms.Label();
            cmbStatus         = new System.Windows.Forms.ComboBox();
            lblAdicionarItens = new System.Windows.Forms.Label();
            cmbProduto        = new System.Windows.Forms.ComboBox();
            numQtd            = new System.Windows.Forms.NumericUpDown();
            btnAdicionarItem  = new Guna.UI2.WinForms.Guna2Button();
            lblCarrinho       = new System.Windows.Forms.Label();
            dgvItens          = new System.Windows.Forms.DataGridView();
            btnFinalizar      = new Guna.UI2.WinForms.Guna2Button();
            btnCancelar       = new Guna.UI2.WinForms.Guna2Button();

            panelHeader.SuspendLayout();
            panelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(dgvItens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(numQtd)).BeginInit();
            this.SuspendLayout();

            // ─── panelHeader ──────────────────────────────────────────────────────
            panelHeader.BackColor = System.Drawing.Color.White;
            panelHeader.Dock      = System.Windows.Forms.DockStyle.Top;
            panelHeader.Height    = 75;
            panelHeader.Name      = "panelHeader";
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Controls.Add(lblSubtitulo);

            // ─── lblTitulo ────────────────────────────────────────────────────────
            lblTitulo.Text      = "🛒  Novo Pedido";
            lblTitulo.Font      = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            lblTitulo.ForeColor = System.Drawing.Color.FromArgb(30, 40, 60);
            lblTitulo.AutoSize  = false;
            lblTitulo.Size      = new System.Drawing.Size(500, 34);
            lblTitulo.Location  = new System.Drawing.Point(30, 10);
            lblTitulo.Name      = "lblTitulo";

            // ─── lblSubtitulo ────────────────────────────────────────────────────────────────────────────────────
            lblSubtitulo.Text      = "Selecione o cliente, defina o status e adicione os itens";
            lblSubtitulo.Font      = new System.Drawing.Font("Segoe UI", 9F);
            lblSubtitulo.ForeColor = System.Drawing.Color.Gray;
            lblSubtitulo.AutoSize  = false;
            lblSubtitulo.Size      = new System.Drawing.Size(450, 20);
            lblSubtitulo.Location  = new System.Drawing.Point(30, 46);
            lblSubtitulo.Name      = "lblSubtitulo";

            // ─── lblCliente ───────────────────────────────────────────────────────
            lblCliente.Text      = "Cliente";
            lblCliente.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblCliente.ForeColor = System.Drawing.Color.FromArgb(60, 70, 90);
            lblCliente.AutoSize  = true;
            lblCliente.Location  = new System.Drawing.Point(30, 20);
            lblCliente.Name      = "lblCliente";

            // ─── cmbCliente ───────────────────────────────────────────────────────
            cmbCliente.Font         = new System.Drawing.Font("Segoe UI", 10F);
            cmbCliente.FlatStyle    = System.Windows.Forms.FlatStyle.Flat;
            cmbCliente.Location     = new System.Drawing.Point(30, 40);
            cmbCliente.Size         = new System.Drawing.Size(240, 30);
            cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbCliente.Name         = "cmbCliente";

            // ─── lblStatus ────────────────────────────────────────────────────────
            lblStatus.Text      = "Status";
            lblStatus.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblStatus.ForeColor = System.Drawing.Color.FromArgb(60, 70, 90);
            lblStatus.AutoSize  = true;
            lblStatus.Location  = new System.Drawing.Point(290, 20);
            lblStatus.Name      = "lblStatus";

            // ─── cmbStatus ────────────────────────────────────────────────────────
            cmbStatus.Font         = new System.Drawing.Font("Segoe UI", 10F);
            cmbStatus.FlatStyle    = System.Windows.Forms.FlatStyle.Flat;
            cmbStatus.Location     = new System.Drawing.Point(290, 40);
            cmbStatus.Size         = new System.Drawing.Size(220, 30);
            cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbStatus.Name         = "cmbStatus";
            cmbStatus.Items.AddRange(new object[] { "Pendente", "Finalizado", "Cancelado" });
            cmbStatus.SelectedIndex = 0;

            // ─── lblAdicionarItens ────────────────────────────────────────────────
            lblAdicionarItens.Text      = "🛍   Adicionar Itens";
            lblAdicionarItens.Font      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblAdicionarItens.ForeColor = System.Drawing.Color.FromArgb(0, 123, 204);
            lblAdicionarItens.AutoSize  = true;
            lblAdicionarItens.Location  = new System.Drawing.Point(30, 100);
            lblAdicionarItens.Name      = "lblAdicionarItens";

            // ─── cmbProduto ───────────────────────────────────────────────────────
            cmbProduto.Font         = new System.Drawing.Font("Segoe UI", 10F);
            cmbProduto.FlatStyle    = System.Windows.Forms.FlatStyle.Flat;
            cmbProduto.Location     = new System.Drawing.Point(30, 125);
            cmbProduto.Size         = new System.Drawing.Size(370, 30);
            cmbProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbProduto.Name         = "cmbProduto";

            // ─── numQtd ───────────────────────────────────────────────────────────
            numQtd.Location  = new System.Drawing.Point(415, 125);
            numQtd.Size      = new System.Drawing.Size(60, 30);
            numQtd.Minimum   = 1;
            numQtd.Maximum   = 999;
            numQtd.Value     = 1;
            numQtd.Font      = new System.Drawing.Font("Segoe UI", 10F);
            numQtd.Name      = "numQtd";

            // ─── btnAdicionarItem ─────────────────────────────────────────────────
            btnAdicionarItem.Text         = "+ Adicionar";
            btnAdicionarItem.FillColor    = System.Drawing.Color.FromArgb(0, 123, 204);
            btnAdicionarItem.ForeColor    = System.Drawing.Color.White;
            btnAdicionarItem.Font         = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            btnAdicionarItem.BorderRadius = 8;
            btnAdicionarItem.Size         = new System.Drawing.Size(110, 32);
            btnAdicionarItem.Location     = new System.Drawing.Point(485, 123);
            btnAdicionarItem.Cursor       = System.Windows.Forms.Cursors.Hand;
            btnAdicionarItem.Name         = "btnAdicionarItem";
            btnAdicionarItem.Click       += btnAdicionarItem_Click;

            // ─── lblCarrinho ──────────────────────────────────────────────────────
            lblCarrinho.Text      = "Itens no Carrinho";
            lblCarrinho.Font      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblCarrinho.ForeColor = System.Drawing.Color.FromArgb(30, 40, 60);
            lblCarrinho.AutoSize  = true;
            lblCarrinho.Location  = new System.Drawing.Point(30, 175);
            lblCarrinho.Name      = "lblCarrinho";

            // ─── dgvItens (colunas configuradas em ConfigurarInterface()) ─────────
            dgvItens.Location               = new System.Drawing.Point(30, 198);
            dgvItens.Size                   = new System.Drawing.Size(565, 200);
            dgvItens.BackgroundColor         = System.Drawing.Color.White;
            dgvItens.BorderStyle             = System.Windows.Forms.BorderStyle.FixedSingle;
            dgvItens.ColumnHeadersHeight     = 36;
            dgvItens.RowHeadersVisible       = false;
            dgvItens.AllowUserToAddRows      = false;
            dgvItens.ReadOnly                = true;
            dgvItens.SelectionMode           = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvItens.AutoSizeColumnsMode     = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvItens.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dgvItens.DefaultCellStyle.Font  = new System.Drawing.Font("Segoe UI", 9F);
            dgvItens.Name = "dgvItens";

            // ─── btnFinalizar ─────────────────────────────────────────────────────
            btnFinalizar.Text         = "✓  Finalizar Pedido";
            btnFinalizar.FillColor    = System.Drawing.Color.FromArgb(34, 197, 94);
            btnFinalizar.ForeColor    = System.Drawing.Color.White;
            btnFinalizar.Font         = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnFinalizar.BorderRadius = 10;
            btnFinalizar.Size         = new System.Drawing.Size(175, 42);
            btnFinalizar.Location     = new System.Drawing.Point(30, 415);
            btnFinalizar.Cursor       = System.Windows.Forms.Cursors.Hand;
            btnFinalizar.Name         = "btnFinalizar";
            btnFinalizar.Click       += btnFinalizar_Click;

            // ─── btnCancelar ───────────────────────────────────────────────────────
            btnCancelar.Text         = "Cancelar";
            btnCancelar.FillColor    = System.Drawing.Color.FromArgb(220, 220, 225);
            btnCancelar.ForeColor    = System.Drawing.Color.FromArgb(80, 80, 90);
            btnCancelar.Font         = new System.Drawing.Font("Segoe UI", 10F);
            btnCancelar.BorderRadius = 10;
            btnCancelar.Size         = new System.Drawing.Size(120, 42);
            btnCancelar.Location     = new System.Drawing.Point(220, 415);
            btnCancelar.Cursor       = System.Windows.Forms.Cursors.Hand;
            btnCancelar.Name         = "btnCancelar";
            btnCancelar.Click       += btnCancelar_Click;

            // ─── panelForm ────────────────────────────────────────────────────────
            panelForm.BackColor  = System.Drawing.Color.White;
            panelForm.Dock       = System.Windows.Forms.DockStyle.Fill;
            panelForm.Padding    = new System.Windows.Forms.Padding(10);
            panelForm.AutoScroll = true;
            panelForm.Name       = "panelForm";
            panelForm.Controls.Add(lblCliente);
            panelForm.Controls.Add(cmbCliente);
            panelForm.Controls.Add(lblStatus);
            panelForm.Controls.Add(cmbStatus);
            panelForm.Controls.Add(lblAdicionarItens);
            panelForm.Controls.Add(cmbProduto);
            panelForm.Controls.Add(numQtd);
            panelForm.Controls.Add(btnAdicionarItem);
            panelForm.Controls.Add(lblCarrinho);
            panelForm.Controls.Add(dgvItens);
            panelForm.Controls.Add(btnFinalizar);
            panelForm.Controls.Add(btnCancelar);

            // ─── ucNovoPedido ─────────────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor           = System.Drawing.Color.FromArgb(245, 247, 250);
            this.Controls.Add(panelForm);
            this.Controls.Add(panelHeader);
            this.Name = "ucNovoPedido";
            this.Size = new System.Drawing.Size(1060, 640);

            panelHeader.ResumeLayout(false);
            panelForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(dgvItens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(numQtd)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblAdicionarItens;
        private System.Windows.Forms.ComboBox cmbProduto;
        private System.Windows.Forms.NumericUpDown numQtd;
        private Guna.UI2.WinForms.Guna2Button btnAdicionarItem;
        private System.Windows.Forms.Label lblCarrinho;
        private System.Windows.Forms.DataGridView dgvItens;
        private Guna.UI2.WinForms.Guna2Button btnFinalizar;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
    }
}
