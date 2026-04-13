namespace SenacBuy.UI
{
    partial class ucDashboard
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
            panelBemVindo = new Panel();
            lblBoasVindas = new Label();
            lblData = new Label();
            panelCards = new Panel();
            cardClientes = new Panel();
            lblIconClientes = new Label();
            lblCardClientes = new Label();
            lblValClientes = new Label();
            cardProdutos = new Panel();
            lblIconProdutos = new Label();
            lblCardProdutos = new Label();
            lblValProdutos = new Label();
            cardPedidos = new Panel();
            lblIconPedidos = new Label();
            lblCardPedidos = new Label();
            lblValPedidos = new Label();
            cardFaturamento = new Panel();
            lblIconFatur = new Label();
            lblCardFatur = new Label();
            lblValFatur = new Label();
            lblAtividade = new Label();
            panelFill = new Panel();
            panelBemVindo.SuspendLayout();
            panelCards.SuspendLayout();
            cardClientes.SuspendLayout();
            cardProdutos.SuspendLayout();
            cardPedidos.SuspendLayout();
            cardFaturamento.SuspendLayout();
            SuspendLayout();
            // 
            // panelBemVindo
            // 
            panelBemVindo.BackColor = Color.White;
            panelBemVindo.Controls.Add(lblBoasVindas);
            panelBemVindo.Controls.Add(lblData);
            panelBemVindo.Dock = DockStyle.Top;
            panelBemVindo.Location = new Point(0, 0);
            panelBemVindo.Name = "panelBemVindo";
            panelBemVindo.Padding = new Padding(30, 10, 0, 10);
            panelBemVindo.Size = new Size(1060, 80);
            panelBemVindo.TabIndex = 3;
            // 
            // lblBoasVindas
            // 
            lblBoasVindas.Font = new Font("Century Gothic", 16F, FontStyle.Bold);
            lblBoasVindas.ForeColor = Color.FromArgb(30, 40, 60);
            lblBoasVindas.Location = new Point(30, 10);
            lblBoasVindas.Name = "lblBoasVindas";
            lblBoasVindas.Size = new Size(600, 36);
            lblBoasVindas.TabIndex = 0;
            lblBoasVindas.Text = "Bem-vindo(a) de volta! 👋";
            // 
            // lblData
            // 
            lblData.Font = new Font("Segoe UI", 9F);
            lblData.ForeColor = Color.Gray;
            lblData.Location = new Point(30, 48);
            lblData.Name = "lblData";
            lblData.Size = new Size(400, 20);
            lblData.TabIndex = 1;
            // 
            // panelCards
            // 
            panelCards.BackColor = Color.FromArgb(245, 247, 250);
            panelCards.Controls.Add(cardClientes);
            panelCards.Controls.Add(cardProdutos);
            panelCards.Controls.Add(cardPedidos);
            panelCards.Controls.Add(cardFaturamento);
            panelCards.Dock = DockStyle.Top;
            panelCards.Location = new Point(0, 80);
            panelCards.Name = "panelCards";
            panelCards.Size = new Size(1060, 140);
            panelCards.TabIndex = 2;
            // 
            // cardClientes
            // 
            cardClientes.BackColor = Color.White;
            cardClientes.Controls.Add(lblIconClientes);
            cardClientes.Controls.Add(lblCardClientes);
            cardClientes.Controls.Add(lblValClientes);
            cardClientes.Location = new Point(20, 15);
            cardClientes.Name = "cardClientes";
            cardClientes.Size = new Size(210, 110);
            cardClientes.TabIndex = 0;
            // 
            // lblIconClientes
            // 
            lblIconClientes.Font = new Font("Segoe UI", 24F);
            lblIconClientes.ForeColor = Color.FromArgb(0, 123, 204);
            lblIconClientes.Location = new Point(15, 25);
            lblIconClientes.Name = "lblIconClientes";
            lblIconClientes.Size = new Size(60, 60);
            lblIconClientes.TabIndex = 0;
            lblIconClientes.Text = "👥";
            lblIconClientes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCardClientes
            // 
            lblCardClientes.Font = new Font("Segoe UI", 9F);
            lblCardClientes.ForeColor = Color.Gray;
            lblCardClientes.Location = new Point(82, 28);
            lblCardClientes.Name = "lblCardClientes";
            lblCardClientes.Size = new Size(106, 20);
            lblCardClientes.TabIndex = 1;
            lblCardClientes.Text = "Total de Clientes";
            // 
            // lblValClientes
            // 
            lblValClientes.Font = new Font("Century Gothic", 20F, FontStyle.Bold);
            lblValClientes.ForeColor = Color.FromArgb(30, 40, 60);
            lblValClientes.Location = new Point(82, 52);
            lblValClientes.Name = "lblValClientes";
            lblValClientes.Size = new Size(106, 36);
            lblValClientes.TabIndex = 2;
            lblValClientes.Text = "128";
            // 
            // cardProdutos
            // 
            cardProdutos.BackColor = Color.White;
            cardProdutos.Controls.Add(lblIconProdutos);
            cardProdutos.Controls.Add(lblCardProdutos);
            cardProdutos.Controls.Add(lblValProdutos);
            cardProdutos.Location = new Point(252, 15);
            cardProdutos.Name = "cardProdutos";
            cardProdutos.Size = new Size(210, 110);
            cardProdutos.TabIndex = 1;
            // 
            // lblIconProdutos
            // 
            lblIconProdutos.Font = new Font("Segoe UI", 24F);
            lblIconProdutos.ForeColor = Color.FromArgb(34, 197, 94);
            lblIconProdutos.Location = new Point(15, 25);
            lblIconProdutos.Name = "lblIconProdutos";
            lblIconProdutos.Size = new Size(60, 60);
            lblIconProdutos.TabIndex = 0;
            lblIconProdutos.Text = "📦";
            lblIconProdutos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCardProdutos
            // 
            lblCardProdutos.Font = new Font("Segoe UI", 9F);
            lblCardProdutos.ForeColor = Color.Gray;
            lblCardProdutos.Location = new Point(82, 28);
            lblCardProdutos.Name = "lblCardProdutos";
            lblCardProdutos.Size = new Size(108, 20);
            lblCardProdutos.TabIndex = 1;
            lblCardProdutos.Text = "Produtos Ativos";
            // 
            // lblValProdutos
            // 
            lblValProdutos.Font = new Font("Century Gothic", 20F, FontStyle.Bold);
            lblValProdutos.ForeColor = Color.FromArgb(30, 40, 60);
            lblValProdutos.Location = new Point(82, 52);
            lblValProdutos.Name = "lblValProdutos";
            lblValProdutos.Size = new Size(108, 36);
            lblValProdutos.TabIndex = 2;
            lblValProdutos.Text = "47";
            // 
            // cardPedidos
            // 
            cardPedidos.BackColor = Color.White;
            cardPedidos.Controls.Add(lblIconPedidos);
            cardPedidos.Controls.Add(lblCardPedidos);
            cardPedidos.Controls.Add(lblValPedidos);
            cardPedidos.Location = new Point(484, 15);
            cardPedidos.Name = "cardPedidos";
            cardPedidos.Size = new Size(210, 110);
            cardPedidos.TabIndex = 2;
            // 
            // lblIconPedidos
            // 
            lblIconPedidos.Font = new Font("Segoe UI", 24F);
            lblIconPedidos.ForeColor = Color.FromArgb(249, 115, 22);
            lblIconPedidos.Location = new Point(15, 25);
            lblIconPedidos.Name = "lblIconPedidos";
            lblIconPedidos.Size = new Size(60, 60);
            lblIconPedidos.TabIndex = 0;
            lblIconPedidos.Text = "\U0001f6d2";
            lblIconPedidos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCardPedidos
            // 
            lblCardPedidos.Font = new Font("Segoe UI", 9F);
            lblCardPedidos.ForeColor = Color.Gray;
            lblCardPedidos.Location = new Point(82, 28);
            lblCardPedidos.Name = "lblCardPedidos";
            lblCardPedidos.Size = new Size(109, 20);
            lblCardPedidos.TabIndex = 1;
            lblCardPedidos.Text = "Pedidos Hoje";
            // 
            // lblValPedidos
            // 
            lblValPedidos.Font = new Font("Century Gothic", 20F, FontStyle.Bold);
            lblValPedidos.ForeColor = Color.FromArgb(30, 40, 60);
            lblValPedidos.Location = new Point(82, 52);
            lblValPedidos.Name = "lblValPedidos";
            lblValPedidos.Size = new Size(109, 36);
            lblValPedidos.TabIndex = 2;
            lblValPedidos.Text = "12";
            // 
            // cardFaturamento
            // 
            cardFaturamento.BackColor = Color.White;
            cardFaturamento.Controls.Add(lblIconFatur);
            cardFaturamento.Controls.Add(lblCardFatur);
            cardFaturamento.Controls.Add(lblValFatur);
            cardFaturamento.Location = new Point(716, 15);
            cardFaturamento.Name = "cardFaturamento";
            cardFaturamento.Size = new Size(223, 110);
            cardFaturamento.TabIndex = 3;
            // 
            // lblIconFatur
            // 
            lblIconFatur.Font = new Font("Segoe UI", 24F);
            lblIconFatur.ForeColor = Color.FromArgb(139, 92, 246);
            lblIconFatur.Location = new Point(15, 25);
            lblIconFatur.Name = "lblIconFatur";
            lblIconFatur.Size = new Size(60, 60);
            lblIconFatur.TabIndex = 0;
            lblIconFatur.Text = "💰";
            lblIconFatur.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCardFatur
            // 
            lblCardFatur.Font = new Font("Segoe UI", 9F);
            lblCardFatur.ForeColor = Color.Gray;
            lblCardFatur.Location = new Point(82, 28);
            lblCardFatur.Name = "lblCardFatur";
            lblCardFatur.Size = new Size(130, 20);
            lblCardFatur.TabIndex = 1;
            lblCardFatur.Text = "Faturamento";
            // 
            // lblValFatur
            // 
            lblValFatur.Font = new Font("Century Gothic", 20F, FontStyle.Bold);
            lblValFatur.ForeColor = Color.FromArgb(30, 40, 60);
            lblValFatur.Location = new Point(82, 52);
            lblValFatur.Name = "lblValFatur";
            lblValFatur.Size = new Size(130, 36);
            lblValFatur.TabIndex = 2;
            lblValFatur.Text = "R$ 8.450";
            // 
            // lblAtividade
            // 
            lblAtividade.BackColor = Color.White;
            lblAtividade.Dock = DockStyle.Top;
            lblAtividade.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblAtividade.ForeColor = Color.FromArgb(30, 40, 60);
            lblAtividade.Location = new Point(0, 220);
            lblAtividade.Name = "lblAtividade";
            lblAtividade.Size = new Size(1060, 45);
            lblAtividade.TabIndex = 1;
            lblAtividade.Text = "  📋  Resumo do Sistema";
            lblAtividade.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelFill
            // 
            panelFill.BackColor = Color.FromArgb(245, 247, 250);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 265);
            panelFill.Name = "panelFill";
            panelFill.Size = new Size(1060, 375);
            panelFill.TabIndex = 0;
            // 
            // ucDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            Controls.Add(panelFill);
            Controls.Add(lblAtividade);
            Controls.Add(panelCards);
            Controls.Add(panelBemVindo);
            Name = "ucDashboard";
            Size = new Size(1060, 640);
            panelBemVindo.ResumeLayout(false);
            panelCards.ResumeLayout(false);
            cardClientes.ResumeLayout(false);
            cardProdutos.ResumeLayout(false);
            cardPedidos.ResumeLayout(false);
            cardFaturamento.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelBemVindo;
        private System.Windows.Forms.Panel panelCards;
        private System.Windows.Forms.Panel cardClientes;
        private System.Windows.Forms.Panel cardProdutos;
        private System.Windows.Forms.Panel cardPedidos;
        private System.Windows.Forms.Panel cardFaturamento;
        private System.Windows.Forms.Panel panelFill;
        private System.Windows.Forms.Label lblBoasVindas;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblCardClientes;
        private System.Windows.Forms.Label lblValClientes;
        private System.Windows.Forms.Label lblIconClientes;
        private System.Windows.Forms.Label lblCardProdutos;
        private System.Windows.Forms.Label lblValProdutos;
        private System.Windows.Forms.Label lblIconProdutos;
        private System.Windows.Forms.Label lblCardPedidos;
        private System.Windows.Forms.Label lblValPedidos;
        private System.Windows.Forms.Label lblIconPedidos;
        private System.Windows.Forms.Label lblCardFatur;
        private System.Windows.Forms.Label lblValFatur;
        private System.Windows.Forms.Label lblIconFatur;
        private System.Windows.Forms.Label lblAtividade;
    }
}
