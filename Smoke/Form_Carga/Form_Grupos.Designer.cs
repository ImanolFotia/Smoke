namespace Form_Carga
{
    partial class Form_Grupos
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnmod = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnconsul = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(529, 388);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(24, 423);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(96, 50);
            this.btnagregar.TabIndex = 1;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnmod
            // 
            this.btnmod.Location = new System.Drawing.Point(126, 423);
            this.btnmod.Name = "btnmod";
            this.btnmod.Size = new System.Drawing.Size(96, 50);
            this.btnmod.TabIndex = 2;
            this.btnmod.Text = "Modificar";
            this.btnmod.UseVisualStyleBackColor = true;
            this.btnmod.Click += new System.EventHandler(this.btnmod_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(228, 423);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(96, 50);
            this.btneliminar.TabIndex = 3;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnconsul
            // 
            this.btnconsul.Location = new System.Drawing.Point(330, 423);
            this.btnconsul.Name = "btnconsul";
            this.btnconsul.Size = new System.Drawing.Size(96, 50);
            this.btnconsul.TabIndex = 4;
            this.btnconsul.Text = "Consultar";
            this.btnconsul.UseVisualStyleBackColor = true;
            this.btnconsul.Click += new System.EventHandler(this.btnconsul_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(456, 423);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 50);
            this.btnexit.TabIndex = 5;
            this.btnexit.Text = "Salir";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Form_Grupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 497);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnconsul);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnmod);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form_Grupos";
            this.Text = "Form_Grupos";
            this.Load += new System.EventHandler(this.Form_Grupos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnmod;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnconsul;
        private System.Windows.Forms.Button btnexit;
    }
}