using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SenacBuy.UI.Services.Models;

namespace SenacBuy.UI
{
    /// <summary>
    /// Lista de clientes com CRUD completo e barra de pesquisa dinâmica.
    ///
    /// Integração com API:
    ///   Listar  → GET  api/cliente
    ///   Editar  → PUT  api/cliente/{id}  (via frmEditarRegistro)
    ///   Excluir → DELETE api/cliente/{id} (com confirmação)
    ///   Novo    → navega para ucNovoCliente
    /// </summary>
    public partial class ucClientes : UserControl
    {
        private readonly ClienteApiService _clienteService = new();
        private List<ClienteDto> _clientes = new();

        public ucClientes()
        {
            InitializeComponent();
            ConfigurarInterface();
            // 
            Load += async (s, e) => await CarregarClientesAsync();
        }

        private void ConfigurarInterface()
        {
            dgvClientes.Columns.Add("colId",   "ID");
            dgvClientes.Columns.Add("colNome", "Nome");
            dgvClientes.Columns.Add("colCPF",  "CPF");

            dgvClientes.Columns["colId"]!.FillWeight   = 30;
            dgvClientes.Columns["colNome"]!.FillWeight = 250;
            dgvClientes.Columns["colCPF"]!.FillWeight  = 150;
        }

        // ──────────────────────────────────────────────────────────────────────────────
        // CARREGAMENTO E PESQUISA
        // ──────────────────────────────────────────────────────────────────────────────

        private async Task CarregarClientesAsync(string filtro = "")
        {
            if (_clientes.Count == 0 || string.IsNullOrEmpty(filtro))
                _clientes = await _clienteService.GetClientesAsync();

            AtualizarGrid(_clientes, filtro);
        }

        private void AtualizarGrid(List<ClienteDto> lista, string filtro = "")
        {
            dgvClientes.Rows.Clear();

            var exibidos = string.IsNullOrWhiteSpace(filtro)
                ? lista
                : lista.Where(c =>
                    c.Nome.Contains(filtro, StringComparison.OrdinalIgnoreCase) ||
                    c.CPF.Contains(filtro,  StringComparison.OrdinalIgnoreCase)).ToList();

            foreach (var c in exibidos)
                dgvClientes.Rows.Add(c.Id, c.Nome, c.CPF);
        }

        // ──────────────────────────────────────────────────────────────────────────────
        // BARRA DE PESQUISA — filtra dinamicamente sem chamar a API novamente
        // ──────────────────────────────────────────────────────────────────────────────

        private void txtBuscaCliente_TextChanged(object sender, EventArgs e)
        {
            AtualizarGrid(_clientes, txtBuscaCliente.Text);
        }

        // ──────────────────────────────────────────────────────────────────────────────
        // BOTÕES
        // ──────────────────────────────────────────────────────────────────────────────

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            (this.FindForm() as frmPrincipal)?.Navegar(new ucNovoCliente());
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow == null)
            {
                MessageBox.Show("Selecione um registro para editar.",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dgvClientes.CurrentRow.Cells["colId"].Value);
            (this.FindForm() as frmPrincipal)?.Navegar(new ucNovoCliente(id));
        }

        private async void btnExcluirCliente_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow == null)
            {
                MessageBox.Show("Selecione um cliente para excluir.",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int    id   = Convert.ToInt32(dgvClientes.CurrentRow.Cells["colId"].Value);
            string nome = dgvClientes.CurrentRow.Cells["colNome"].Value?.ToString() ?? "";

            if (MessageBox.Show(
                    $"Excluir \"{nome}\"? Esta ação não pode ser desfeita.",
                    "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                != DialogResult.Yes) return;

            bool ok = await _clienteService.DeleteClienteAsync(id);
            if (ok)
            {
                MessageBox.Show("Cliente excluído com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                _clientes.Clear();
                await CarregarClientesAsync();
            }
        }
    }
}
