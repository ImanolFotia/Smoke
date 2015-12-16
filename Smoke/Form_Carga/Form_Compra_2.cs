using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Form_Carga
{
    public partial class Form_Compra_2 : Form
    {   
        Modelo.UsuarioSoftware Compra;
        Controladora.C_Software C_Software = Controladora.C_Software.Obtener_Instancia();
        Modelo.Software oSoftware;
        Vista.CVisual CVisual = new Vista.CVisual();
        Modelo.Usuarios oUsuario;
        String url, nombre, desc, precio, id;
        public Form_Compra_2(Modelo.Software fSoftware, Modelo.Usuarios oUSUARIO)
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
            CVisual.CambioVisual(this);
            oUsuario = oUSUARIO;
            Modelo.ModeloContainer oModelo = new Modelo.ModeloContainer();
            oSoftware = fSoftware;
            Armar_Lista();
            String IPWEB = CVisual.LeerIPWEB();
            nombre = oSoftware.Nombre;
            precio = oSoftware.Precio;
            desc = oSoftware.Descripcion;
            id = oSoftware.Id.ToString();
            url = IPWEB + "/Smoke/product.php?Name=" + nombre + "&&" + "Price=" + precio + "&&" + "&&" + "&AppID=" + id;
            label2.Text = url;
            webBrowser1.Navigate(url);
            btn_Comprar.Enabled = true;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void Armar_Lista()
        {
        }

        private void Form_TyC_Load(object sender, EventArgs e)
        {
            Armar_Lista();
        }

        private void btn_Atras_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btn_Siguiente_Click(object sender, EventArgs e)
        {
        }


        private void cb_usuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            Armar_Lista();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_Comprar_Click(object sender, EventArgs e)
        {
            List<Modelo.UsuarioSoftware> listadoXObjeto = new List<Modelo.UsuarioSoftware>();
            if (listadoXObjeto.Any(x => x.Software.Id == oSoftware.Id) && listadoXObjeto.Any(x => x.Usuario.Id == oUsuario.Id))
            {
                MessageBox.Show("Usted ya posee este software.");
                return;
            }
            Compra = new Modelo.UsuarioSoftware();
            Compra.IdSoftware = oSoftware.Id;
            Compra.IdUsuario = oUsuario.Id;
            Compra.Software = oSoftware;
            Compra.Usuario = oUsuario;
            C_Software.Compra(Compra);
            btn_Comprar.Enabled = false;
            webBrowser1.Navigate("25.146.125.242/Smoke/product.php?Name=" + nombre + "&&" + "Price=" + precio  + "&&" + "&AppID=" + id + "&&" + "Comprado=1");
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
