using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Form_Carga
{
    public partial class Form_Descarga : Form
    {
        Modelo.UsuarioSoftware Compra;
        Modelo.Usuarios Usuario;
        Controladora.C_Software C_Software;
        Vista.CVisual CVisual = new Vista.CVisual();
        String nombre, desc, id;
        decimal precio;
        string url = "25.146.125.242";
        public Form_Descarga(Modelo.Usuarios miusuario, Modelo.UsuarioSoftware micompra)
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
            CVisual.CambioVisual(this);
            C_Software = Controladora.C_Software.Obtener_Instancia();
            Usuario = miusuario;
            Compra = micompra;
            String IPWEB = CVisual.LeerIPWEB();
            nombre = Compra.Software.Nombre;
            precio = Compra.Software.Precio;
            desc = Compra.Software.Descripcion;
            id = Compra.Software.Id.ToString();
            webBrowser1.Navigate(IPWEB + "/Smoke/product.php?Name=" + nombre + "&&" + "Price=" + precio + "&&" + "Desc=" + desc + "&&" + "&AppID=" + id + "&&" + "Comprado=1");
            Process.Start("IExplore.exe", Compra.Software.Link);
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void Form_Descarga_Load(object sender, EventArgs e)
        {

        }

        private void Form_Descarga_Load_1(object sender, EventArgs e)
        {

        }
    }
}
