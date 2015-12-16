namespace Form_Carga
{
    partial class Form_TyC
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_TyC));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_Software = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.chk_Aceptar = new System.Windows.Forms.CheckBox();
            this.btn_Siguiente = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Software)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Controls.Add(this.dgv_Software);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 657);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Su software:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dgv_Software
            // 
            this.dgv_Software.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv_Software.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Software.Location = new System.Drawing.Point(6, 19);
            this.dgv_Software.Name = "dgv_Software";
            this.dgv_Software.Size = new System.Drawing.Size(488, 632);
            this.dgv_Software.TabIndex = 0;
            this.dgv_Software.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Software_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(518, 50);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(454, 590);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "ACUERDO DE SUSCRIPTOR A SMOKE®\r\n\r\n1.- Smoke siempre tiene la razón.\r\n2.- Si piens" +
                "a que ud. tiene la razón, remitase al punto número 1.";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // chk_Aceptar
            // 
            this.chk_Aceptar.AutoSize = true;
            this.chk_Aceptar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chk_Aceptar.Location = new System.Drawing.Point(518, 646);
            this.chk_Aceptar.Name = "chk_Aceptar";
            this.chk_Aceptar.Size = new System.Drawing.Size(186, 17);
            this.chk_Aceptar.TabIndex = 3;
            this.chk_Aceptar.Text = "Acepto los términos y condiciones";
            this.chk_Aceptar.UseVisualStyleBackColor = true;
            this.chk_Aceptar.CheckedChanged += new System.EventHandler(this.chk_Aceptar_CheckedChanged);
            // 
            // btn_Siguiente
            // 
            this.btn_Siguiente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Siguiente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Siguiente.Location = new System.Drawing.Point(710, 646);
            this.btn_Siguiente.Name = "btn_Siguiente";
            this.btn_Siguiente.Size = new System.Drawing.Size(262, 23);
            this.btn_Siguiente.TabIndex = 4;
            this.btn_Siguiente.Text = "Siguiente";
            this.btn_Siguiente.UseVisualStyleBackColor = true;
            this.btn_Siguiente.Click += new System.EventHandler(this.btn_Siguiente_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form_TyC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(994, 691);
            this.Controls.Add(this.btn_Siguiente);
            this.Controls.Add(this.chk_Aceptar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_TyC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Términos y condiciones";
            this.Load += new System.EventHandler(this.Form_TyC_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Software)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_Software;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox chk_Aceptar;
        private System.Windows.Forms.Button btn_Siguiente;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;

    }
}

