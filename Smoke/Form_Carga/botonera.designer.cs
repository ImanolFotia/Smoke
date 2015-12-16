namespace Form_Carga
{
    partial class botonera
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(botonera));
            this.btnCERRAR = new System.Windows.Forms.Button();
            this.btnALTAS = new System.Windows.Forms.Button();
            this.btnBAJAS = new System.Windows.Forms.Button();
            this.btnCONSULTAS = new System.Windows.Forms.Button();
            this.btnMODIFICACIONES = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCERRAR
            // 
            this.btnCERRAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCERRAR.Image = ((System.Drawing.Image)(resources.GetObject("btnCERRAR.Image")));
            this.btnCERRAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCERRAR.Location = new System.Drawing.Point(545, 3);
            this.btnCERRAR.Name = "btnCERRAR";
            this.btnCERRAR.Size = new System.Drawing.Size(94, 60);
            this.btnCERRAR.TabIndex = 10;
            this.btnCERRAR.Text = "&Cerrar";
            this.btnCERRAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCERRAR.UseVisualStyleBackColor = true;
            this.btnCERRAR.Click += new System.EventHandler(this.btnCERRAR_Click);
            // 
            // btnALTAS
            // 
            this.btnALTAS.Image = ((System.Drawing.Image)(resources.GetObject("btnALTAS.Image")));
            this.btnALTAS.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnALTAS.Location = new System.Drawing.Point(3, 3);
            this.btnALTAS.Name = "btnALTAS";
            this.btnALTAS.Size = new System.Drawing.Size(93, 60);
            this.btnALTAS.TabIndex = 0;
            this.btnALTAS.Text = "&Agregar";
            this.btnALTAS.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnALTAS.UseVisualStyleBackColor = true;
            this.btnALTAS.Click += new System.EventHandler(this.btnALTAS_Click);
            // 
            // btnBAJAS
            // 
            this.btnBAJAS.Image = ((System.Drawing.Image)(resources.GetObject("btnBAJAS.Image")));
            this.btnBAJAS.Location = new System.Drawing.Point(102, 3);
            this.btnBAJAS.Name = "btnBAJAS";
            this.btnBAJAS.Size = new System.Drawing.Size(91, 60);
            this.btnBAJAS.TabIndex = 1;
            this.btnBAJAS.Text = "&Eliminar";
            this.btnBAJAS.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBAJAS.UseVisualStyleBackColor = true;
            this.btnBAJAS.Click += new System.EventHandler(this.btnBAJAS_Click);
            // 
            // btnCONSULTAS
            // 
            this.btnCONSULTAS.Image = ((System.Drawing.Image)(resources.GetObject("btnCONSULTAS.Image")));
            this.btnCONSULTAS.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCONSULTAS.Location = new System.Drawing.Point(296, 3);
            this.btnCONSULTAS.Name = "btnCONSULTAS";
            this.btnCONSULTAS.Size = new System.Drawing.Size(91, 60);
            this.btnCONSULTAS.TabIndex = 4;
            this.btnCONSULTAS.Text = "&Ver Detalle";
            this.btnCONSULTAS.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCONSULTAS.UseVisualStyleBackColor = true;
            this.btnCONSULTAS.Click += new System.EventHandler(this.btnCONSULTAS_Click);
            // 
            // btnMODIFICACIONES
            // 
            this.btnMODIFICACIONES.Image = ((System.Drawing.Image)(resources.GetObject("btnMODIFICACIONES.Image")));
            this.btnMODIFICACIONES.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMODIFICACIONES.Location = new System.Drawing.Point(199, 3);
            this.btnMODIFICACIONES.Name = "btnMODIFICACIONES";
            this.btnMODIFICACIONES.Size = new System.Drawing.Size(91, 60);
            this.btnMODIFICACIONES.TabIndex = 2;
            this.btnMODIFICACIONES.Text = "&Modificar";
            this.btnMODIFICACIONES.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMODIFICACIONES.UseVisualStyleBackColor = true;
            this.btnMODIFICACIONES.Click += new System.EventHandler(this.btnMODIFICACIONES_Click);
            // 
            // botonera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCONSULTAS);
            this.Controls.Add(this.btnBAJAS);
            this.Controls.Add(this.btnMODIFICACIONES);
            this.Controls.Add(this.btnALTAS);
            this.Controls.Add(this.btnCERRAR);
            this.Name = "botonera";
            this.Size = new System.Drawing.Size(642, 66);
            this.Load += new System.EventHandler(this.botonera_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCERRAR;
        private System.Windows.Forms.Button btnALTAS;
        private System.Windows.Forms.Button btnBAJAS;
        private System.Windows.Forms.Button btnCONSULTAS;
        private System.Windows.Forms.Button btnMODIFICACIONES;
    }
}
