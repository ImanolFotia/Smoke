namespace Form_Carga
{
    partial class Pantalla_Inicio
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslUSUARIO = new System.Windows.Forms.ToolStripStatusLabel();
            this.msMENU = new System.Windows.Forms.MenuStrip();
            this.Administracion_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.tableroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.auditoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.softwareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagoMensualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarPagoMensualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.misComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarCréditoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuantoCréditoTengoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.softwareCompradoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desarrolladoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dev0menu = new System.Windows.Forms.ToolStripMenuItem();
            this.informaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verificarÚltimoPagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.statusStrip1.SuspendLayout();
            this.msMENU.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tslUSUARIO});
            this.statusStrip1.Location = new System.Drawing.Point(0, 751);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1263, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "Usuario:";
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
            this.msMENU.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Administracion_Menu,
            this.misComprasToolStripMenuItem,
            this.tiendaToolStripMenuItem,
            this.desarrolladoresToolStripMenuItem,
            this.dev0menu});
            this.msMENU.Location = new System.Drawing.Point(0, 0);
            this.msMENU.Name = "msMENU";
            this.msMENU.Size = new System.Drawing.Size(1263, 24);
            this.msMENU.TabIndex = 3;
            this.msMENU.Text = "menuStrip1";
            this.msMENU.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.msMENU_ItemClicked);
            // 
            // Administracion_Menu
            // 
            this.Administracion_Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tableroToolStripMenuItem,
            this.auditoriaToolStripMenuItem,
            this.cambiarPagoMensualToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.Administracion_Menu.Name = "Administracion_Menu";
            this.Administracion_Menu.Size = new System.Drawing.Size(100, 20);
            this.Administracion_Menu.Text = "Administración";
            this.Administracion_Menu.Click += new System.EventHandler(this.estadisticasToolStripMenuItem_Click);
            // 
            // tableroToolStripMenuItem
            // 
            this.tableroToolStripMenuItem.Name = "tableroToolStripMenuItem";
            this.tableroToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.tableroToolStripMenuItem.Text = "Tablero";
            this.tableroToolStripMenuItem.Click += new System.EventHandler(this.tableroToolStripMenuItem_Click);
            // 
            // auditoriaToolStripMenuItem
            // 
            this.auditoriaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.softwareToolStripMenuItem,
            this.loginToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.pagoMensualToolStripMenuItem});
            this.auditoriaToolStripMenuItem.Name = "auditoriaToolStripMenuItem";
            this.auditoriaToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.auditoriaToolStripMenuItem.Text = "Auditoria";
            // 
            // softwareToolStripMenuItem
            // 
            this.softwareToolStripMenuItem.Name = "softwareToolStripMenuItem";
            this.softwareToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.softwareToolStripMenuItem.Text = "Software";
            this.softwareToolStripMenuItem.Click += new System.EventHandler(this.softwareToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // pagoMensualToolStripMenuItem
            // 
            this.pagoMensualToolStripMenuItem.Name = "pagoMensualToolStripMenuItem";
            this.pagoMensualToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pagoMensualToolStripMenuItem.Text = "Pago Mensual";
            this.pagoMensualToolStripMenuItem.Click += new System.EventHandler(this.pagoMensualToolStripMenuItem_Click);
            // 
            // cambiarPagoMensualToolStripMenuItem
            // 
            this.cambiarPagoMensualToolStripMenuItem.Name = "cambiarPagoMensualToolStripMenuItem";
            this.cambiarPagoMensualToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.cambiarPagoMensualToolStripMenuItem.Text = "Cambiar pago mensual";
            this.cambiarPagoMensualToolStripMenuItem.Click += new System.EventHandler(this.cambiarPagoMensualToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // misComprasToolStripMenuItem
            // 
            this.misComprasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarCréditoToolStripMenuItem,
            this.cuantoCréditoTengoToolStripMenuItem,
            this.softwareCompradoToolStripMenuItem});
            this.misComprasToolStripMenuItem.Name = "misComprasToolStripMenuItem";
            this.misComprasToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.misComprasToolStripMenuItem.Text = "Mis Compras";
            this.misComprasToolStripMenuItem.Click += new System.EventHandler(this.misComprasToolStripMenuItem_Click);
            // 
            // cargarCréditoToolStripMenuItem
            // 
            this.cargarCréditoToolStripMenuItem.Name = "cargarCréditoToolStripMenuItem";
            this.cargarCréditoToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.cargarCréditoToolStripMenuItem.Text = "Cargar crédito";
            this.cargarCréditoToolStripMenuItem.Click += new System.EventHandler(this.cargarCréditoToolStripMenuItem_Click);
            // 
            // cuantoCréditoTengoToolStripMenuItem
            // 
            this.cuantoCréditoTengoToolStripMenuItem.Name = "cuantoCréditoTengoToolStripMenuItem";
            this.cuantoCréditoTengoToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.cuantoCréditoTengoToolStripMenuItem.Text = "¿Cuanto crédito tengo?";
            this.cuantoCréditoTengoToolStripMenuItem.Click += new System.EventHandler(this.cuantoCréditoTengoToolStripMenuItem_Click);
            // 
            // softwareCompradoToolStripMenuItem
            // 
            this.softwareCompradoToolStripMenuItem.Name = "softwareCompradoToolStripMenuItem";
            this.softwareCompradoToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.softwareCompradoToolStripMenuItem.Text = "Software comprado";
            this.softwareCompradoToolStripMenuItem.Click += new System.EventHandler(this.softwareCompradoToolStripMenuItem_Click);
            // 
            // tiendaToolStripMenuItem
            // 
            this.tiendaToolStripMenuItem.Name = "tiendaToolStripMenuItem";
            this.tiendaToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.tiendaToolStripMenuItem.Text = "Tienda";
            this.tiendaToolStripMenuItem.Click += new System.EventHandler(this.tiendaToolStripMenuItem_Click);
            // 
            // desarrolladoresToolStripMenuItem
            // 
            this.desarrolladoresToolStripMenuItem.Name = "desarrolladoresToolStripMenuItem";
            this.desarrolladoresToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.desarrolladoresToolStripMenuItem.Text = "Desarrolladores";
            this.desarrolladoresToolStripMenuItem.Click += new System.EventHandler(this.desarrolladoresToolStripMenuItem_Click);
            // 
            // dev0menu
            // 
            this.dev0menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informaciónToolStripMenuItem,
            this.pagoToolStripMenuItem,
            this.verificarÚltimoPagoToolStripMenuItem});
            this.dev0menu.Name = "dev0menu";
            this.dev0menu.Size = new System.Drawing.Size(156, 20);
            this.dev0menu.Text = "¿Querés ser desarrollador?";
            this.dev0menu.Click += new System.EventHandler(this.dev0menu_Click);
            // 
            // informaciónToolStripMenuItem
            // 
            this.informaciónToolStripMenuItem.Name = "informaciónToolStripMenuItem";
            this.informaciónToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.informaciónToolStripMenuItem.Text = "Información";
            this.informaciónToolStripMenuItem.Click += new System.EventHandler(this.informaciónToolStripMenuItem_Click);
            // 
            // pagoToolStripMenuItem
            // 
            this.pagoToolStripMenuItem.Name = "pagoToolStripMenuItem";
            this.pagoToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.pagoToolStripMenuItem.Text = "Pago";
            this.pagoToolStripMenuItem.Click += new System.EventHandler(this.pagoToolStripMenuItem_Click);
            // 
            // verificarÚltimoPagoToolStripMenuItem
            // 
            this.verificarÚltimoPagoToolStripMenuItem.Name = "verificarÚltimoPagoToolStripMenuItem";
            this.verificarÚltimoPagoToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.verificarÚltimoPagoToolStripMenuItem.Text = "Verificar último pago";
            this.verificarÚltimoPagoToolStripMenuItem.Click += new System.EventHandler(this.verificarÚltimoPagoToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 24);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1263, 727);
            this.webBrowser1.TabIndex = 4;
            this.webBrowser1.Url = new System.Uri("http://192.168.0.14/Smoke/smoke.php", System.UriKind.Absolute);
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // Pantalla_Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 773);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.msMENU);
            this.MainMenuStrip = this.msMENU;
            this.Name = "Pantalla_Inicio";
            this.Text = "Pantalla_Inicio";
            this.Load += new System.EventHandler(this.Pantalla_Inicio_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.msMENU.ResumeLayout(false);
            this.msMENU.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.MenuStrip msMENU;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripStatusLabel tslUSUARIO;
        private System.Windows.Forms.ToolStripMenuItem Administracion_Menu;
        private System.Windows.Forms.ToolStripMenuItem tableroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desarrolladoresToolStripMenuItem;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ToolStripMenuItem dev0menu;
        private System.Windows.Forms.ToolStripMenuItem auditoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem softwareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem misComprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarCréditoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuantoCréditoTengoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem softwareCompradoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verificarÚltimoPagoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarPagoMensualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagoMensualToolStripMenuItem;
    }
}