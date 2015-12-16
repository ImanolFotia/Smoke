namespace Form_Carga
{
    partial class Form_Carga_Software
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Carga_Software));
            this.btn_Siguiente = new System.Windows.Forms.Button();
            this.chk_Aceptar = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_Software = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.cmb_leng = new System.Windows.Forms.ComboBox();
            this.nup_edad = new System.Windows.Forms.NumericUpDown();
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.cmb_cat = new System.Windows.Forms.ComboBox();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Software)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nup_edad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Siguiente
            // 
            this.btn_Siguiente.BackColor = System.Drawing.SystemColors.InfoText;
            this.btn_Siguiente.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn_Siguiente.Location = new System.Drawing.Point(688, 265);
            this.btn_Siguiente.Name = "btn_Siguiente";
            this.btn_Siguiente.Size = new System.Drawing.Size(262, 23);
            this.btn_Siguiente.TabIndex = 9;
            this.btn_Siguiente.Text = "Finalizar";
            this.btn_Siguiente.UseVisualStyleBackColor = true;
            this.btn_Siguiente.Click += new System.EventHandler(this.btn_Siguiente_Click);
            // 
            // chk_Aceptar
            // 
            this.chk_Aceptar.AutoSize = true;
            this.chk_Aceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chk_Aceptar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chk_Aceptar.Location = new System.Drawing.Point(562, 265);
            this.chk_Aceptar.Name = "chk_Aceptar";
            this.chk_Aceptar.Size = new System.Drawing.Size(50, 17);
            this.chk_Aceptar.TabIndex = 8;
            this.chk_Aceptar.Text = "Subir";
            this.chk_Aceptar.UseVisualStyleBackColor = false;
            this.chk_Aceptar.CheckedChanged += new System.EventHandler(this.chk_Aceptar_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_Software);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 657);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Su software:";
            // 
            // dgv_Software
            // 
            this.dgv_Software.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Software.Location = new System.Drawing.Point(6, 19);
            this.dgv_Software.Name = "dgv_Software";
            this.dgv_Software.Size = new System.Drawing.Size(488, 632);
            this.dgv_Software.TabIndex = 0;
            this.dgv_Software.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Software_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_precio);
            this.groupBox2.Controls.Add(this.txt_nombre);
            this.groupBox2.Controls.Add(this.cmb_leng);
            this.groupBox2.Controls.Add(this.nup_edad);
            this.groupBox2.Controls.Add(this.txt_desc);
            this.groupBox2.Controls.Add(this.cmb_cat);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(518, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(454, 209);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del software:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Precio:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Lenguaje:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Edad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Descripción:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Categoría:";
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(95, 167);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(353, 20);
            this.txt_precio.TabIndex = 6;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(95, 35);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(353, 20);
            this.txt_nombre.TabIndex = 5;
            // 
            // cmb_leng
            // 
            this.cmb_leng.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_leng.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_leng.FormattingEnabled = true;
            this.cmb_leng.Location = new System.Drawing.Point(94, 140);
            this.cmb_leng.Name = "cmb_leng";
            this.cmb_leng.Size = new System.Drawing.Size(354, 21);
            this.cmb_leng.TabIndex = 4;
            this.cmb_leng.SelectedIndexChanged += new System.EventHandler(this.cmb_leng_SelectedIndexChanged);
            // 
            // nup_edad
            // 
            this.nup_edad.Location = new System.Drawing.Point(95, 114);
            this.nup_edad.Name = "nup_edad";
            this.nup_edad.Size = new System.Drawing.Size(353, 20);
            this.nup_edad.TabIndex = 2;
            // 
            // txt_desc
            // 
            this.txt_desc.Location = new System.Drawing.Point(95, 61);
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(353, 20);
            this.txt_desc.TabIndex = 1;
            // 
            // cmb_cat
            // 
            this.cmb_cat.BackColor = System.Drawing.SystemColors.Window;
            this.cmb_cat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_cat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_cat.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_cat.FormattingEnabled = true;
            this.cmb_cat.Location = new System.Drawing.Point(95, 87);
            this.cmb_cat.Name = "cmb_cat";
            this.cmb_cat.Size = new System.Drawing.Size(353, 21);
            this.cmb_cat.TabIndex = 0;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataSource = typeof(Modelo.Usuarios);
            // 
            // Form_Carga_Software
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(984, 681);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_Siguiente);
            this.Controls.Add(this.chk_Aceptar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Carga_Software";
            this.Text = "Subir software";
            this.TransparencyKey = System.Drawing.Color.Lime;
            this.Load += new System.EventHandler(this.Form_Carga_Software_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Software)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nup_edad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Siguiente;
        private System.Windows.Forms.CheckBox chk_Aceptar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_Software;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.ComboBox cmb_leng;
        private System.Windows.Forms.NumericUpDown nup_edad;
        private System.Windows.Forms.TextBox txt_desc;
        private System.Windows.Forms.ComboBox cmb_cat;
        private System.Windows.Forms.BindingSource usuariosBindingSource;

    }
}