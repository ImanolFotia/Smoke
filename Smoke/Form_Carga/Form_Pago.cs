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
    enum MetodoPago {Rapipago, Pagofacil, Visa, Mastercard};
    
    public partial class Form_Pago : Form
    {
        Controladora.C_Usuarios cUsuarios = Controladora.C_Usuarios.Obtener_Instancia();
        Modelo.ModeloContainer oModelo = Modelo.ModeloContainer.obtenerInstancia();
        public static Form_Pago Instancia;
        Modelo.Usuarios oUsuario;
        Vista.CVisual CVisual = new Vista.CVisual();
        Decimal Monto;
        int TipoPago;
        public Form_Pago(Modelo.Usuarios miUsuario, Decimal miMonto, int miTipoPago)
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
            CVisual.CambioVisual(this);
            this.Size = new Size(400, 348);
            cmb_metpag.DataSource = Enum.GetValues(typeof(MetodoPago));
            oUsuario = miUsuario;
            Monto = miMonto;
            TipoPago = miTipoPago;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void Form_Pago_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TipoPago == 0)//carga crédito
            {
                try
                {
                    oUsuario.Credito += Monto;
                    oModelo.Usuarios.ApplyCurrentValues(oUsuario);
                    oModelo.SaveChanges();
                    Modelo.Pagos oPago = new Modelo.Pagos();
                    oPago.Usuario = (Modelo.Usuarios)oUsuario;
                    oPago.Fecha = DateTime.Now;
                    oPago.Tipo = true;
                    oPago.Monto = Monto;
                    oModelo.AddToPagos(oPago);
                    Decimal MontoActual;
                    MontoActual = oUsuario.Credito;//.GetValueOrDefault() porque es nullable, si no no deja convertirlo
                    MontoActual.ToString();
                    MessageBox.Show("Tu crédito ahora es de $" + MontoActual + "." + Environment.NewLine + "Muchas gracias por tu carga.");
                    this.DialogResult = DialogResult.OK;
                }
                catch
                {
                    //MessageBox.Show("Tu crédito ahora es de $" + MontoActual + "." + Environment.NewLine + "Muchas gracias por tu carga.");
                    this.DialogResult = DialogResult.OK;
                }
            }
            if (TipoPago == 1)//pago mensual
            {
                try
                {
                    oUsuario.Dev = 1;
                    oModelo.Usuarios.ApplyCurrentValues(oUsuario);
                    oModelo.SaveChanges();
                    Modelo.Pagos oPago = new Modelo.Pagos();
                    oPago.Usuario = (Modelo.Usuarios)oUsuario;
                    oPago.Fecha = DateTime.Now;
                    oPago.Monto = cUsuarios.Obtener_PagoMensualMonto();
                    cUsuarios.AgregarPago(oPago);
                    MessageBox.Show("Gracias por tu pago mensual." + Environment.NewLine + "Ya podés usar todos nuestros servicios");
                }
                catch {

                    MessageBox.Show("Gracias por tu pago mensual." + Environment.NewLine + "Ya podés usar todos nuestros servicios");
                    this.DialogResult = DialogResult.OK;
                }
            }
            if (TipoPago == 3)//re-pago mensual
            {
                oUsuario.Dev = 1;
                oModelo.Usuarios.ApplyCurrentValues(oUsuario);
                oModelo.SaveChanges();
                Modelo.Pagos oPago = new Modelo.Pagos();
                oPago.Usuario = (Modelo.Usuarios)oUsuario;
                oPago.Fecha = DateTime.Now;
                cUsuarios.AgregarPago(oPago);
                MessageBox.Show("Gracias por tu pago mensual." + Environment.NewLine + "Ya podés usar todos nuestros servicios");
            }
        }    
    }
}
