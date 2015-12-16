namespace Form_Carga
{
    partial class Form_Pago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Pago));
            this.txt_A_Pagar = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_metpag = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_A_Pagar
            // 
            this.txt_A_Pagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_A_Pagar.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_A_Pagar.Location = new System.Drawing.Point(12, 12);
            this.txt_A_Pagar.Multiline = true;
            this.txt_A_Pagar.Name = "txt_A_Pagar";
            this.txt_A_Pagar.Size = new System.Drawing.Size(368, 202);
            this.txt_A_Pagar.TabIndex = 0;
            this.txt_A_Pagar.Text = "Total a pagar:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_metpag);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 220);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 57);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // cmb_metpag
            // 
            this.cmb_metpag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmb_metpag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_metpag.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_metpag.ForeColor = System.Drawing.SystemColors.Window;
            this.cmb_metpag.FormattingEnabled = true;
            this.cmb_metpag.Location = new System.Drawing.Point(101, 19);
            this.cmb_metpag.Name = "cmb_metpag";
            this.cmb_metpag.Size = new System.Drawing.Size(261, 21);
            this.cmb_metpag.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Método de Pago:";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(21, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(353, 26);
            this.button1.TabIndex = 8;
            this.button1.Text = "Pagar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_Pago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(394, 319);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_A_Pagar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Pago";
            this.Text = "Form_Pago";
            this.Load += new System.EventHandler(this.Form_Pago_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_A_Pagar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_metpag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}