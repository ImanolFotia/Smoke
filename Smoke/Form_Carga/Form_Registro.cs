using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;

namespace Form_Carga
{
    public partial class Form_Registro : Form
    {
        Modelo.Usuarios Usuario;
        Vista.CVisual CVisual = new Vista.CVisual();
        Controladora.C_Usuarios C_Usuarios;
        enum Lenguaje { Español, Inglés, Francés };
        enum Pais { Argentina, France, USA };
        string Codigo_Verificacion;
        public Form_Registro()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
            CVisual.CambioVisual(this);
            C_Usuarios = Controladora.C_Usuarios.Obtener_Instancia();
            btn_Siguiente.Enabled = false;
            btn_Verificacion.Enabled = false;
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            var result = new string(
                Enumerable.Repeat(chars, 8)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());
            Codigo_Verificacion = result;
            cb_Pais.DataSource = Enum.GetValues(typeof(Pais));
            cb_Lenguaje.DataSource = Enum.GetValues(typeof(Lenguaje));
        }

        public static void SendMail(MailMessage Message)
        {
            string email_Smoke = "SmokeSurvTech@gmail.com";
            string contrasena_Smoke = "survtech";
            SmtpClient client = new SmtpClient();
            client.Host = "smtp.googlemail.com";
            client.Port = 587;
            client.UseDefaultCredentials = false;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.EnableSsl = true;
            client.Credentials = new System.Net.NetworkCredential(email_Smoke, contrasena_Smoke);
            client.Send(Message);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void Form_Registro_Load(object sender, EventArgs e)
        {

        }

        private void chk_Aceptar_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Aceptar.Checked == true) btn_Verificacion.Enabled = true;
            if (txt_Verificación.TextLength == 8 && chk_Aceptar.Checked == true) btn_Siguiente.Enabled = true;
        }

        private void btn_Siguiente_Click(object sender, EventArgs e)
        {
            if (txt_Verificación.Text != Codigo_Verificacion) MessageBox.Show("El Codigo ingresado es incorrecto.");
            if (txt_Verificación.Text == Codigo_Verificacion)
            {
                Usuario = new Modelo.Usuarios();
                Usuario.Id = txt_ID.Text;
                Usuario.eMail = txt_email.Text;
                Usuario.Lenguaje = cb_Lenguaje.SelectedItem.ToString();
                Usuario.Nombre = txt_Nombre.Text;
                Usuario.Pais = cb_Pais.SelectedItem.ToString();
                string pass = MD5.Encriptar(txt_Password.Text);
                Usuario.Password = pass;
                Usuario.Dev = 0;
                Usuario.usu_estado = true;
                Usuario.usu_Admin = false;
                C_Usuarios.Agregar(Usuario);
                MessageBox.Show("Usuario creado");
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btn_Verificacion_Click(object sender, EventArgs e)
        {
            string email_Smoke = "SmokeSurvTech@gmail.com";

            MailMessage Mensaje = new MailMessage(email_Smoke, txt_email.Text, "Registración en Smoke", "Hola "+ txt_Nombre.Text + Environment.NewLine + "El código de verificación es: " + Codigo_Verificacion + Environment.NewLine + "El nombre de usuario registrado es: " + txt_ID.Text + Environment.NewLine + "Contraseña: " + txt_Password.Text);
            SendMail(Mensaje);


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (txt_Verificación.TextLength == 8 && chk_Aceptar.Checked == true) btn_Siguiente.Enabled = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
