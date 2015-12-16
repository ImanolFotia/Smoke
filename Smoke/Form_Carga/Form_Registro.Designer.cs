namespace Form_Carga
{
    partial class Form_Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Registro));
            this.btn_Siguiente = new System.Windows.Forms.Button();
            this.chk_Aceptar = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Verificacion = new System.Windows.Forms.Button();
            this.txt_Verificación = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.cb_Lenguaje = new System.Windows.Forms.ComboBox();
            this.cb_Pais = new System.Windows.Forms.ComboBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Siguiente
            // 
            this.btn_Siguiente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Siguiente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Siguiente.Location = new System.Drawing.Point(256, 271);
            this.btn_Siguiente.Name = "btn_Siguiente";
            this.btn_Siguiente.Size = new System.Drawing.Size(262, 23);
            this.btn_Siguiente.TabIndex = 7;
            this.btn_Siguiente.Text = "Siguiente";
            this.btn_Siguiente.UseVisualStyleBackColor = true;
            this.btn_Siguiente.Click += new System.EventHandler(this.btn_Siguiente_Click);
            // 
            // chk_Aceptar
            // 
            this.chk_Aceptar.AutoSize = true;
            this.chk_Aceptar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chk_Aceptar.Location = new System.Drawing.Point(12, 698);
            this.chk_Aceptar.Name = "chk_Aceptar";
            this.chk_Aceptar.Size = new System.Drawing.Size(186, 17);
            this.chk_Aceptar.TabIndex = 6;
            this.chk_Aceptar.Text = "Acepto los términos y condiciones";
            this.chk_Aceptar.UseVisualStyleBackColor = true;
            this.chk_Aceptar.CheckedChanged += new System.EventHandler(this.chk_Aceptar_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(454, 676);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID de usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "e-Mail:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Lenguaje:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "País:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Código de seguridad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Password";
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(101, 24);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(250, 20);
            this.txt_ID.TabIndex = 14;
            this.txt_ID.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Verificacion);
            this.groupBox1.Controls.Add(this.txt_Verificación);
            this.groupBox1.Controls.Add(this.txt_Password);
            this.groupBox1.Controls.Add(this.btn_Siguiente);
            this.groupBox1.Controls.Add(this.cb_Lenguaje);
            this.groupBox1.Controls.Add(this.cb_Pais);
            this.groupBox1.Controls.Add(this.txt_email);
            this.groupBox1.Controls.Add(this.txt_Nombre);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_ID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(472, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 300);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de registro:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_Verificacion
            // 
            this.btn_Verificacion.Location = new System.Drawing.Point(25, 193);
            this.btn_Verificacion.Name = "btn_Verificacion";
            this.btn_Verificacion.Size = new System.Drawing.Size(326, 23);
            this.btn_Verificacion.TabIndex = 23;
            this.btn_Verificacion.Text = "Enviar verificación de seguridad";
            this.btn_Verificacion.UseVisualStyleBackColor = true;
            this.btn_Verificacion.Click += new System.EventHandler(this.btn_Verificacion_Click);
            // 
            // txt_Verificación
            // 
            this.txt_Verificación.Location = new System.Drawing.Point(135, 227);
            this.txt_Verificación.Name = "txt_Verificación";
            this.txt_Verificación.Size = new System.Drawing.Size(216, 20);
            this.txt_Verificación.TabIndex = 21;
            this.txt_Verificación.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(101, 156);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(250, 20);
            this.txt_Password.TabIndex = 20;
            // 
            // cb_Lenguaje
            // 
            this.cb_Lenguaje.FormattingEnabled = true;
            this.cb_Lenguaje.Location = new System.Drawing.Point(101, 129);
            this.cb_Lenguaje.Name = "cb_Lenguaje";
            this.cb_Lenguaje.Size = new System.Drawing.Size(250, 21);
            this.cb_Lenguaje.TabIndex = 19;
            // 
            // cb_Pais
            // 
            this.cb_Pais.FormattingEnabled = true;
            this.cb_Pais.Location = new System.Drawing.Point(101, 102);
            this.cb_Pais.Name = "cb_Pais";
            this.cb_Pais.Size = new System.Drawing.Size(250, 21);
            this.cb_Pais.TabIndex = 18;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(101, 76);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(417, 20);
            this.txt_email.TabIndex = 17;
            this.txt_email.TabStop = false;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(101, 50);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(417, 20);
            this.txt_Nombre.TabIndex = 16;
            this.txt_Nombre.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Nombre:";
            // 
            // Form_Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chk_Aceptar);
            this.Controls.Add(this.textBox1);
            this.Name = "Form_Registro";
            this.Text = "Form_Registro";
            this.Load += new System.EventHandler(this.Form_Registro_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Siguiente;
        private System.Windows.Forms.CheckBox chk_Aceptar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Verificación;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.ComboBox cb_Lenguaje;
        private System.Windows.Forms.ComboBox cb_Pais;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Verificacion;
    }
}