namespace SenacBuy.UI
{
    partial class frmEditarRegistro
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
            this.lblCampo1   = new System.Windows.Forms.Label();
            this.lblCampo2   = new System.Windows.Forms.Label();
            this.txtCampo1   = new System.Windows.Forms.TextBox();
            this.txtCampo2   = new System.Windows.Forms.TextBox();
            this.btnSalvar   = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblCampo1
            this.lblCampo1.AutoSize = true;
            this.lblCampo1.Location = new System.Drawing.Point(16, 20);
            this.lblCampo1.Name     = "lblCampo1";
            this.lblCampo1.Text     = "Campo 1:";

            // txtCampo1
            this.txtCampo1.Location = new System.Drawing.Point(160, 17);
            this.txtCampo1.Name     = "txtCampo1";
            this.txtCampo1.Size     = new System.Drawing.Size(240, 23);
            this.txtCampo1.TabIndex = 0;

            // lblCampo2
            this.lblCampo2.AutoSize = true;
            this.lblCampo2.Location = new System.Drawing.Point(16, 60);
            this.lblCampo2.Name     = "lblCampo2";
            this.lblCampo2.Text     = "Campo 2:";

            // txtCampo2
            this.txtCampo2.Location = new System.Drawing.Point(160, 57);
            this.txtCampo2.Name     = "txtCampo2";
            this.txtCampo2.Size     = new System.Drawing.Size(240, 23);
            this.txtCampo2.TabIndex = 1;

            // btnSalvar
            this.btnSalvar.Location = new System.Drawing.Point(245, 100);
            this.btnSalvar.Name     = "btnSalvar";
            this.btnSalvar.Size     = new System.Drawing.Size(75, 30);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text     = "Salvar";
            this.btnSalvar.Click   += new System.EventHandler(this.btnSalvar_Click);

            // btnCancelar
            this.btnCancelar.Location = new System.Drawing.Point(325, 100);
            this.btnCancelar.Name     = "btnCancelar";
            this.btnCancelar.Size     = new System.Drawing.Size(75, 30);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text     = "Cancelar";
            this.btnCancelar.Click   += new System.EventHandler(this.btnCancelar_Click);

            // frmEditarRegistro
            this.ClientSize        = new System.Drawing.Size(420, 148);
            this.Controls.Add(this.lblCampo1);
            this.Controls.Add(this.txtCampo1);
            this.Controls.Add(this.lblCampo2);
            this.Controls.Add(this.txtCampo2);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox     = false;
            this.MinimizeBox     = false;
            this.Name            = "frmEditarRegistro";
            this.StartPosition   = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text            = "Editar Registro";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label   lblCampo1;
        private System.Windows.Forms.Label   lblCampo2;
        private System.Windows.Forms.TextBox txtCampo1;
        private System.Windows.Forms.TextBox txtCampo2;
        private System.Windows.Forms.Button  btnSalvar;
        private System.Windows.Forms.Button  btnCancelar;
    }
}
