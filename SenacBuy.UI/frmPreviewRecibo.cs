using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using SenacBuy.UI.Services.Models;

namespace SenacBuy.UI
{
    /// <summary>
    /// Formulário de pré-visualização do recibo antes da impressão.
    ///
    /// Fluxo:
    ///   1. ucPedidos abre este form passando o PedidoDto selecionado.
    ///   2. O usuário visualiza o recibo via PrintPreviewDialog.
    ///   3. Ao clicar em "Imprimir", confirma e envia para a impressora.
    ///   4. "Fechar" cancela sem imprimir.
    /// </summary>
    public partial class frmPreviewRecibo : Form
    {
        private readonly PedidoDto _pedido;
        private readonly PrintDocument _printDocument;

        public frmPreviewRecibo(PedidoDto pedido)
        {
            InitializeComponent();
            _pedido = pedido;
            _printDocument = CriarDocumentoImpressao();

            // Exibe informações básicas no cabeçalho do form
            lblPedidoInfo.Text = $"Pedido #{_pedido.Id}  •  Cliente: {_pedido.NomeCliente}  •  {_pedido.DataPedido:dd/MM/yyyy}";
        }

        // ──────────────────────────────────────────────────────────────────────────────
        // CRIAÇÃO DO DOCUMENTO DE IMPRESSÃO
        // ──────────────────────────────────────────────────────────────────────────────

        private PrintDocument CriarDocumentoImpressao()
        {
            var pd = new PrintDocument();
            pd.DocumentName = $"Recibo Pedido #{_pedido.Id}";

            pd.PrintPage += (s, ev) =>
            {
                var g = ev.Graphics;
                if (g == null) return;

                var fontTitulo = new Font("Courier New", 18, FontStyle.Bold);
                var fontSecao  = new Font("Courier New", 12, FontStyle.Bold);
                var fontCorpo  = new Font("Courier New", 11);
                var fontTotal  = new Font("Courier New", 14, FontStyle.Bold);

                int x = 50;
                int y = 50;

                // ─── Cabeçalho ───────────────────────────────────────────────────────
                g.DrawString("SENACBUY — RECIBO DO PEDIDO", fontTitulo, Brushes.Black, x, y);
                y += 35;
                g.DrawString(new string('─', 55), fontCorpo, Brushes.Gray, x, y);
                y += 25;

                // ─── Dados do pedido ──────────────────────────────────────────────────
                g.DrawString($"Pedido #: {_pedido.Id}",                        fontCorpo, Brushes.Black, x, y); y += 22;
                g.DrawString($"Cliente : {_pedido.NomeCliente}",               fontCorpo, Brushes.Black, x, y); y += 22;
                g.DrawString($"Data    : {_pedido.DataPedido:dd/MM/yyyy HH:mm:ss}", fontCorpo, Brushes.Black, x, y); y += 22;
                g.DrawString($"Status  : {_pedido.Status}",                    fontCorpo, Brushes.Black, x, y); y += 30;

                // ─── Itens ─────────────────────────────────────────────────────────────
                g.DrawString("ITENS:", fontSecao, Brushes.Black, x, y);
                y += 25;
                g.DrawString(new string('─', 55), fontCorpo, Brushes.Gray, x, y);
                y += 20;

                foreach (var item in _pedido.Itens)
                {
                    string linha = $"{item.Quantidade,3}x  {item.NomeProduto,-30} {item.Subtotal,10:C2}";
                    g.DrawString(linha, fontCorpo, Brushes.Black, x, y);
                    y += 22;
                }

                // ─── Total ─────────────────────────────────────────────────────────────
                y += 10;
                g.DrawString(new string('─', 55), fontCorpo, Brushes.Gray, x, y);
                y += 20;
                g.DrawString($"TOTAL DO PEDIDO: {_pedido.Total:C2}", fontTotal, Brushes.Black, x, y);
            };

            return pd;
        }

        // ──────────────────────────────────────────────────────────────────────────────
        // BOTÕES
        // ──────────────────────────────────────────────────────────────────────────────

        private void btnPrevisualizar_Click(object sender, EventArgs e)
        {
            using var preview = new PrintPreviewDialog
            {
                Document  = _printDocument,
                Width     = 900,
                Height    = 650,
                StartPosition = FormStartPosition.CenterParent
            };
            preview.ShowDialog(this);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            using var printDialog = new PrintDialog { Document = _printDocument };
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                _printDocument.Print();
                MessageBox.Show("Recibo enviado para a impressora com sucesso!",
                    "Impressão Realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
