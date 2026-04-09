namespace SenacBuy.UI
{
    partial class ucUsuario
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            txtBuscarUsuario = new Guna.UI2.WinForms.Guna2TextBox();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnExcluirUsuario = new Guna.UI2.WinForms.Guna2Button();
            btnEditarUsuario = new Guna.UI2.WinForms.Guna2Button();
            btnNovoUsuario = new Guna.UI2.WinForms.Guna2Button();
            dgvUsuarios = new Guna.UI2.WinForms.Guna2DataGridView();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = SystemColors.ControlLight;
            guna2Panel1.Controls.Add(txtBuscarUsuario);
            guna2Panel1.Controls.Add(guna2HtmlLabel2);
            guna2Panel1.Controls.Add(guna2HtmlLabel1);
            guna2Panel1.Controls.Add(btnExcluirUsuario);
            guna2Panel1.Controls.Add(btnEditarUsuario);
            guna2Panel1.Controls.Add(btnNovoUsuario);
            guna2Panel1.CustomizableEdges = customizableEdges9;
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges10;
            guna2Panel1.Size = new Size(882, 82);
            guna2Panel1.TabIndex = 0;
            // 
            // txtBuscarUsuario
            // 
            txtBuscarUsuario.BorderRadius = 20;
            txtBuscarUsuario.CustomizableEdges = customizableEdges1;
            txtBuscarUsuario.DefaultText = "";
            txtBuscarUsuario.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtBuscarUsuario.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtBuscarUsuario.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtBuscarUsuario.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtBuscarUsuario.FillColor = Color.WhiteSmoke;
            txtBuscarUsuario.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtBuscarUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBuscarUsuario.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtBuscarUsuario.Location = new Point(262, 24);
            txtBuscarUsuario.Margin = new Padding(4);
            txtBuscarUsuario.Name = "txtBuscarUsuario";
            txtBuscarUsuario.PlaceholderText = "🔍Pesquise aqui";
            txtBuscarUsuario.SelectedText = "";
            txtBuscarUsuario.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtBuscarUsuario.Size = new Size(270, 35);
            txtBuscarUsuario.TabIndex = 3;
            txtBuscarUsuario.TextChanged += txtPesquisa_TextChanged;
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel2.ForeColor = SystemColors.AppWorkspace;
            guna2HtmlLabel2.Location = new Point(12, 42);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(233, 17);
            guna2HtmlLabel2.TabIndex = 2;
            guna2HtmlLabel2.Text = "Gerencie os usuários e acessos do sistema";
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.Location = new Point(35, 14);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(148, 23);
            guna2HtmlLabel1.TabIndex = 2;
            guna2HtmlLabel1.Text = "Gestão de Usuários";
            // 
            // btnExcluirUsuario
            // 
            btnExcluirUsuario.BorderRadius = 12;
            btnExcluirUsuario.CustomizableEdges = customizableEdges3;
            btnExcluirUsuario.DisabledState.BorderColor = Color.DarkGray;
            btnExcluirUsuario.DisabledState.CustomBorderColor = Color.DarkGray;
            btnExcluirUsuario.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnExcluirUsuario.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnExcluirUsuario.FillColor = Color.Red;
            btnExcluirUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnExcluirUsuario.ForeColor = Color.White;
            btnExcluirUsuario.Location = new Point(765, 24);
            btnExcluirUsuario.Name = "btnExcluirUsuario";
            btnExcluirUsuario.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnExcluirUsuario.Size = new Size(107, 35);
            btnExcluirUsuario.TabIndex = 0;
            btnExcluirUsuario.Text = "Excluir";
            btnExcluirUsuario.Click += btnExcluirUsuario_Click;
            // 
            // btnEditarUsuario
            // 
            btnEditarUsuario.BorderRadius = 12;
            btnEditarUsuario.CustomizableEdges = customizableEdges5;
            btnEditarUsuario.DisabledState.BorderColor = Color.DarkGray;
            btnEditarUsuario.DisabledState.CustomBorderColor = Color.DarkGray;
            btnEditarUsuario.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnEditarUsuario.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnEditarUsuario.FillColor = Color.Goldenrod;
            btnEditarUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEditarUsuario.ForeColor = Color.White;
            btnEditarUsuario.Location = new Point(652, 24);
            btnEditarUsuario.Name = "btnEditarUsuario";
            btnEditarUsuario.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnEditarUsuario.Size = new Size(107, 35);
            btnEditarUsuario.TabIndex = 0;
            btnEditarUsuario.Text = "Editar";
            btnEditarUsuario.Click += btnEditarUsuario_Click;
            // 
            // btnNovoUsuario
            // 
            btnNovoUsuario.BackColor = Color.Transparent;
            btnNovoUsuario.BorderRadius = 12;
            btnNovoUsuario.CustomizableEdges = customizableEdges7;
            btnNovoUsuario.DisabledState.BorderColor = Color.DarkGray;
            btnNovoUsuario.DisabledState.CustomBorderColor = Color.DarkGray;
            btnNovoUsuario.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnNovoUsuario.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnNovoUsuario.FillColor = Color.Blue;
            btnNovoUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnNovoUsuario.ForeColor = Color.White;
            btnNovoUsuario.Location = new Point(539, 24);
            btnNovoUsuario.Name = "btnNovoUsuario";
            btnNovoUsuario.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnNovoUsuario.Size = new Size(107, 35);
            btnNovoUsuario.TabIndex = 0;
            btnNovoUsuario.Text = "Novo Usuário";
            btnNovoUsuario.Click += btnNovoUsuario_Click;
            // 
            // dgvUsuarios
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvUsuarios.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvUsuarios.BorderStyle = BorderStyle.Fixed3D;
            dgvUsuarios.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dgvUsuarios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(10);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvUsuarios.DefaultCellStyle = dataGridViewCellStyle3;
            dgvUsuarios.GridColor = Color.FromArgb(231, 229, 255);
            dgvUsuarios.Location = new Point(5, 88);
            dgvUsuarios.Margin = new Padding(10, 10, 5, 5);
            dgvUsuarios.Name = "dgvUsuarios";
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvUsuarios.RowHeadersVisible = false;
            dgvUsuarios.Size = new Size(867, 438);
            dgvUsuarios.TabIndex = 1;
            dgvUsuarios.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvUsuarios.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvUsuarios.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvUsuarios.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvUsuarios.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvUsuarios.ThemeStyle.BackColor = Color.White;
            dgvUsuarios.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvUsuarios.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvUsuarios.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvUsuarios.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvUsuarios.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvUsuarios.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.ThemeStyle.HeaderStyle.Height = 4;
            dgvUsuarios.ThemeStyle.ReadOnly = false;
            dgvUsuarios.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvUsuarios.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvUsuarios.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvUsuarios.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvUsuarios.ThemeStyle.RowsStyle.Height = 25;
            dgvUsuarios.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvUsuarios.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // ucUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            Controls.Add(dgvUsuarios);
            Controls.Add(guna2Panel1);
            Name = "ucUsuario";
            Size = new Size(882, 529);
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnExcluirUsuario;
        private Guna.UI2.WinForms.Guna2Button btnEditarUsuario;
        private Guna.UI2.WinForms.Guna2Button btnNovoUsuario;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscarUsuario;
        private Guna.UI2.WinForms.Guna2DataGridView dgvUsuarios;
    }
}
