namespace SenacBuy.UI
{
    partial class frmPreviewRecibo
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
            panelHeader     = new System.Windows.Forms.Panel();
            lblTitulo       = new System.Windows.Forms.Label();
            lblPedidoInfo   = new System.Windows.Forms.Label();
            panelCorpo      = new System.Windows.Forms.Panel();
            lblInstrucao    = new System.Windows.Forms.Label();
            panelBotoes     = new System.Windows.Forms.Panel();
            btnPrevisualizar = new Guna.UI2.WinForms.Guna2Button();
            btnImprimir     = new Guna.UI2.WinForms.Guna2Button();
            btnFechar       = new Guna.UI2.WinForms.Guna2Button();

            panelHeader.SuspendLayout();
            panelCorpo.SuspendLayout();
            panelBotoes.SuspendLayout();
            this.SuspendLayout();

            // ─── panelHeader ─────────────────────────────────────────────────────
            panelHeader.BackColor = System.Drawing.Color.FromArgb(20, 33, 61);
            panelHeader.Dock      = System.Windows.Forms.DockStyle.Top;
            panelHeader.Height    = 70;
            panelHeader.Name      = "panelHeader";
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Controls.Add(lblPedidoInfo);

            // ─── lblTitulo ────────────────────────────────────────────────────────
            lblTitulo.Text      = "🖨️   Visualizar Recibo";
            lblTitulo.Font      = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            lblTitulo.ForeColor = System.Drawing.Color.White;
            lblTitulo.AutoSize  = false;
            lblTitulo.Size      = new System.Drawing.Size(560, 34);
            lblTitulo.Location  = new System.Drawing.Point(25, 8);
            lblTitulo.Name      = "lblTitulo";

            // ─── lblPedidoInfo ────────────────────────────────────────────────────
            lblPedidoInfo.Text      = "";
            lblPedidoInfo.Font      = new System.Drawing.Font("Segoe UI", 9F);
            lblPedidoInfo.ForeColor = System.Drawing.Color.FromArgb(160, 200, 230);
            lblPedidoInfo.AutoSize  = false;
            lblPedidoInfo.Size      = new System.Drawing.Size(560, 22);
            lblPedidoInfo.Location  = new System.Drawing.Point(25, 43);
            lblPedidoInfo.Name      = "lblPedidoInfo";

            // ─── panelCorpo ───────────────────────────────────────────────────────
            panelCorpo.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            panelCorpo.Dock      = System.Windows.Forms.DockStyle.Fill;
            panelCorpo.Name      = "panelCorpo";
            panelCorpo.Padding   = new System.Windows.Forms.Padding(30);
            panelCorpo.Controls.Add(lblInstrucao);

            // ─── lblInstrucao ─────────────────────────────────────────────────────
            lblInstrucao.Text      = "Clique em \"👁 Pré-visualizar\" para ver o recibo completo.\r\n" +
                                     "Após conferir, clique em \"🖨 Imprimir\" para enviar à impressora.";
            lblInstrucao.Font      = new System.Drawing.Font("Segoe UI", 11F);
            lblInstrucao.ForeColor = System.Drawing.Color.FromArgb(70, 90, 120);
            lblInstrucao.AutoSize  = false;
            lblInstrucao.Size      = new System.Drawing.Size(560, 80);
            lblInstrucao.Location  = new System.Drawing.Point(30, 30);
            lblInstrucao.Name      = "lblInstrucao";

            // ─── panelBotoes ──────────────────────────────────────────────────────
            panelBotoes.BackColor = System.Drawing.Color.White;
            panelBotoes.Dock      = System.Windows.Forms.DockStyle.Bottom;
            panelBotoes.Height    = 65;
            panelBotoes.Name      = "panelBotoes";
            panelBotoes.Controls.Add(btnPrevisualizar);
            panelBotoes.Controls.Add(btnImprimir);
            panelBotoes.Controls.Add(btnFechar);

            // ─── btnPrevisualizar ─────────────────────────────────────────────────
            btnPrevisualizar.Text         = "👁  Pré-visualizar";
            btnPrevisualizar.FillColor    = System.Drawing.Color.FromArgb(0, 123, 204);
            btnPrevisualizar.ForeColor    = System.Drawing.Color.White;
            btnPrevisualizar.Font         = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnPrevisualizar.BorderRadius = 10;
            btnPrevisualizar.Size         = new System.Drawing.Size(175, 40);
            btnPrevisualizar.Location     = new System.Drawing.Point(20, 12);
            btnPrevisualizar.Cursor       = System.Windows.Forms.Cursors.Hand;
            btnPrevisualizar.Name         = "btnPrevisualizar";
            btnPrevisualizar.Click       += btnPrevisualizar_Click;

            // ─── btnImprimir ──────────────────────────────────────────────────────
            btnImprimir.Text         = "🖨  Imprimir";
            btnImprimir.FillColor    = System.Drawing.Color.FromArgb(34, 197, 94);
            btnImprimir.ForeColor    = System.Drawing.Color.White;
            btnImprimir.Font         = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnImprimir.BorderRadius = 10;
            btnImprimir.Size         = new System.Drawing.Size(145, 40);
            btnImprimir.Location     = new System.Drawing.Point(210, 12);
            btnImprimir.Cursor       = System.Windows.Forms.Cursors.Hand;
            btnImprimir.Name         = "btnImprimir";
            btnImprimir.Click       += btnImprimir_Click;

            // ─── btnFechar ────────────────────────────────────────────────────────
            btnFechar.Text         = "Fechar";
            btnFechar.FillColor    = System.Drawing.Color.FromArgb(220, 220, 225);
            btnFechar.ForeColor    = System.Drawing.Color.FromArgb(80, 80, 90);
            btnFechar.Font         = new System.Drawing.Font("Segoe UI", 10F);
            btnFechar.BorderRadius = 10;
            btnFechar.Size         = new System.Drawing.Size(110, 40);
            btnFechar.Location     = new System.Drawing.Point(370, 12);
            btnFechar.Cursor       = System.Windows.Forms.Cursors.Hand;
            btnFechar.Name         = "btnFechar";
            btnFechar.Click       += btnFechar_Click;

            // ─── frmPreviewRecibo ─────────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor           = System.Drawing.Color.White;
            this.ClientSize          = new System.Drawing.Size(620, 250);
            this.Controls.Add(panelCorpo);
            this.Controls.Add(panelBotoes);
            this.Controls.Add(panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox     = false;
            this.MinimizeBox     = false;
            this.Name            = "frmPreviewRecibo";
            this.StartPosition   = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text            = "Visualizar Recibo";

            panelHeader.ResumeLayout(false);
            panelCorpo.ResumeLayout(false);
            panelBotoes.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelCorpo;
        private System.Windows.Forms.Panel panelBotoes;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblPedidoInfo;
        private System.Windows.Forms.Label lblInstrucao;
        private Guna.UI2.WinForms.Guna2Button btnPrevisualizar;
        private Guna.UI2.WinForms.Guna2Button btnImprimir;
        private Guna.UI2.WinForms.Guna2Button btnFechar;
    }
}
