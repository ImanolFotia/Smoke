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
        String url, nombre, desc, id;
        decimal precio;
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
            string url = "localhost/TD/Smoke/product.php?Name=" + nombre + "&&" + "Price=" + precio + "&&" + "&AppID=" + id + "&&" + "Comprado=0" + "&&" + "&Desc=" + oSoftware.Descripcion;
            webBrowser1.Navigate(url);
            List<Modelo.UsuarioSoftware> us = C_Software.Listar_Compras();

            btn_Comprar.Enabled = true;
            for (int i = 0; i < us.Count; i++)
            {
                if (us.ElementAt(i).IdUsuario == oUsuario.Id && us.ElementAt(i).IdSoftware == oSoftware.Id)
                {
                    webBrowser1.Navigate("localhost/TD/Smoke/product.php?Name=" + nombre + "&&" + "Price=" + precio + "&&" + "&AppID=" + id + "&&" + "Comprado=1" + "&&" + "&Desc=" + oSoftware.Descripcion + "&&" + "&Link=" + oSoftware.Link);
                    btn_Comprar.Enabled = false;
                }

            }
            label2.Text = url;
            
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
            List<Modelo.UsuarioSoftware> us = C_Software.Listar_Compras();
            for (int i = 0; i < us.Count ; i++ )
            {
                if (us.ElementAt(i).IdUsuario == oUsuario.Id && us.ElementAt(i).IdSoftware == oSoftware.Id)
                {
                    MessageBox.Show("Ya tenés este software.");
                    webBrowser1.Navigate("localhost/TD/Smoke/product.php?Name=" + nombre + "&&" + "Price=" + precio + "&&" + "&AppID=" + id + "&&" + "Comprado=1" + "&&" + "&Desc=" + oSoftware.Descripcion + "&&" + "&Link=" + oSoftware.Link);
                    return;
                }
            }

            if (oUsuario.Credito - precio < 0)
            {
                MessageBox.Show("Tu crédito es insuficiente");
                return;
            }
            //Patron de diseño State:
            //modifica el comportamiento de la clase dependiendo del estado del objeto
            if (oSoftware.Estado == true)
            {
                MessageBox.Show("El software que estás intentando comprar no está disponible en este momento.");
            }
            Compra = new Modelo.UsuarioSoftware();
            Compra.IdSoftware = oSoftware.Id;
            Compra.IdUsuario = oUsuario.Id;
            Compra.Software = oSoftware;
            Compra.Usuario = oUsuario;
            oUsuario.Credito = oUsuario.Credito - Compra.Software.Precio;
            C_Software.Compra(Compra);
            btn_Comprar.Enabled = false;
            webBrowser1.Navigate("localhost/TD/Smoke/product.php?Name=" + nombre + "&&" + "Price=" + precio + "&&" + "&AppID=" + id + "&&" + "Comprado=1" + "&&" + "&Desc=" + oSoftware.Descripcion + "&&" + "&Link=" + oSoftware.Link);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
