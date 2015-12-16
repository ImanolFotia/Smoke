namespace Form_Carga
{
    partial class frmGRUPOS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvDATA = new System.Windows.Forms.DataGridView();
            this.botonera1 = new Form_Carga.botonera();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDATA)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDATA
            // 
            this.dgvDATA.AllowUserToAddRows = false;
            this.dgvDATA.AllowUserToDeleteRows = false;
            this.dgvDATA.AllowUserToOrderColumns = true;
            this.dgvDATA.AllowUserToResizeRows = false;
            this.dgvDATA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDATA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDATA.Location = new System.Drawing.Point(12, 12);
            this.dgvDATA.Name = "dgvDATA";
            this.dgvDATA.ReadOnly = true;
            this.dgvDATA.Size = new System.Drawing.Size(512, 364);
            this.dgvDATA.TabIndex = 1;
            // 
            // botonera1
            // 
            this.botonera1.Location = new System.Drawing.Point(12, 387);
            this.botonera1.Name = "botonera1";
            this.botonera1.Size = new System.Drawing.Size(512, 65);
            this.botonera1.TabIndex = 0;
            this.botonera1.Click_Alta += new Form_Carga.Eventos_Botonera(this.botonera1_Click_Alta);
            this.botonera1.Click_Baja += new Form_Carga.Eventos_Botonera(this.botonera1_Click_Baja);
            this.botonera1.Click_Modificacion += new Form_Carga.Eventos_Botonera(this.botonera1_Click_Modificacion);
            this.botonera1.Click_Consulta += new Form_Carga.Eventos_Botonera(this.botonera1_Click_Consulta);
            this.botonera1.Click_Cerrar += new Form_Carga.Eventos_Botonera(this.botonera1_Click_Cerrar);
            this.botonera1.Load += new System.EventHandler(this.botonera1_Load);
            // 
            // frmGRUPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 459);
            this.Controls.Add(this.dgvDATA);
            this.Controls.Add(this.botonera1);
            this.Name = "frmGRUPOS";
            this.Text = "::. GRUPOS DE USUARIOS";
            this.Load += new System.EventHandler(this.frmGRUPOS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDATA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private botonera botonera1;
        private System.Windows.Forms.DataGridView dgvDATA;
    }
}