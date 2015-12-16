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
    public partial class Form_Password : Form
    {
        private static Form_Password instancia;
        private Modelo.Usuarios oUSUARIO = new Modelo.Usuarios();
        private CONTROLADORA.cPASSWORD cPASSWORD;
        Vista.CVisual CVisual = new Vista.CVisual();
        public static Form_Password obtener_instancia(Modelo.Usuarios miUSUARIO)
        {
            if (instancia == null)
                instancia = new Form_Password(miUSUARIO);
            if (instancia.IsDisposed)
                instancia = new Form_Password(miUSUARIO);
            return instancia;


        }

        public Form_Password(Modelo.Usuarios miUSUARIO)
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
            CVisual.CambioVisual(this);
            this.Size = new Size(339, 242);
            oUSUARIO = miUSUARIO;
            cPASSWORD = CONTROLADORA.cPASSWORD.obtenerInstancia();
            textBox1.Text = oUSUARIO.Password;
            textBox1.Enabled = false;
            
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void Form_Password_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == null && textBox3.Text == null) return;
            if (textBox1.Text != oUSUARIO.Password)
            {
                MessageBox.Show("La contraseñas actual no coincide con la ingresada", "ATENCION!!");
                return;
            }

            if (!string.IsNullOrEmpty(textBox2.Text))
            {
                if (!string.Equals(textBox2.Text, textBox3.Text))
                {
                    MessageBox.Show("Las contraseñas no coinciden", "ATENCION!!");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar una nueva contraseña", "ATENCION!!");
                return;
            }

           
                oUSUARIO.Password = MD5.Encriptar(textBox2.Text);
                cPASSWORD.MODIFICACION(oUSUARIO);
                MessageBox.Show("Se ha actualizado la contraseña, se reiniciará el programa y luego podrá loguearse con su nueva contraseña", "Cambiar contraseña");
                oUSUARIO = null;
                Application.Restart();


            
           /* catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message, "ATENCION !!");
            }*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            oUSUARIO = null;
            Application.Restart();
            
        }
    }
}
