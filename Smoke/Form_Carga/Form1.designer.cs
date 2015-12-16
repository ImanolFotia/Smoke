namespace Form_Carga
{
    partial class frmPRINCIPAL
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
            this.ssMENU = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslUSUARIO = new System.Windows.Forms.ToolStripStatusLabel();
            this.msMENU = new System.Windows.Forms.MenuStrip();
            this.ssMENU.SuspendLayout();
            this.SuspendLayout();
            // 
            // ssMENU
            // 
            this.ssMENU.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tslUSUARIO});
            this.ssMENU.Location = new System.Drawing.Point(0, 479);
            this.ssMENU.Name = "ssMENU";
            this.ssMENU.Size = new System.Drawing.Size(892, 22);
            this.ssMENU.TabIndex = 2;
            this.ssMENU.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(50, 17);
            this.toolStripStatusLabel1.Text = "Usuario:";
            // 
            // tslUSUARIO
            // 
            this.tslUSUARIO.Name = "tslUSUARIO";
            this.tslUSUARIO.Size = new System.Drawing.Size(0, 17);
            // 
            // msMENU
            // 
            this.msMENU.Location = new System.Drawing.Point(0, 0);
            this.msMENU.Name = "msMENU";
            this.msMENU.Size = new System.Drawing.Size(892, 24);
            this.msMENU.TabIndex = 5;
            this.msMENU.Text = "msMENU";
            // 
            // frmPRINCIPAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(892, 501);
            this.Controls.Add(this.msMENU);
            this.Controls.Add(this.ssMENU);
            this.Name = "frmPRINCIPAL";
            this.Text = ":.. Módulo de seguridad";
            this.Load += new System.EventHandler(this.frmPRINCIPAL_Load);
            this.ssMENU.ResumeLayout(false);
            this.ssMENU.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip ssMENU;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tslUSUARIO;
        private System.Windows.Forms.MenuStrip msMENU;
    }
}

