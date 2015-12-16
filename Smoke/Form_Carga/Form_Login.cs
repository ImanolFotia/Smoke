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
    public partial class Form_Login : Form
    {
        CONTROLADORA.cLOGIN oLOGIN;
        Modelo.Usuarios oUSUARIO;
        Vista.CVisual CVisual = new Vista.CVisual();
        public Modelo.Usuarios USUARIO
        {
            get { return oUSUARIO; }
        }
        public Form_Login()
        {
            InitializeComponent();
            CVisual.CambioVisual(this);
            this.Size = new Size(318, 373);
            oLOGIN = CONTROLADORA.cLOGIN.obtenerInstancia();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (txt_usuario.Text == "")
            {
                lblUserNameError.Text = "* Debe ingresar el nombre de usuario";
                return;
            }
            else
            {
                lblUserNameError.Text = "";
            }
            if (txt_pass.Text == "")
            {
                lblPasswordError.Text = "* Debe ingresar la contraseña";
                return;
            }
            else
            {
                lblPasswordError.Text = "";
            }
            try
            {
                string pass = MD5.Encriptar(txt_pass.Text);
                oUSUARIO = oLOGIN.LOGIN(txt_usuario.Text, pass);
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Ingreso al sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btn_aceptar;
        }

        private void btn_Registrarse_Click(object sender, EventArgs e)
        {
            Form_Registro form = new Form_Registro();
            DialogResult dr = form.ShowDialog();
            this.Hide();
            if (dr == DialogResult.OK) this.Show();
        }

        private void btn_Contrasena_Click(object sender, EventArgs e)
        {
            if (txt_usuario.Text == "")
            {
                lblUserNameError.Text = "* Debe ingresar el nombre de usuario";
                return;
            }
            else
            {
                lblUserNameError.Text = "";
            }
            if (txt_pass.Text == "")
            {
                lblPasswordError.Text = "* Debe ingresar la contraseña";
                return;
            }
            else
            {
                lblPasswordError.Text = "";
            }
            try
            {
                
                oUSUARIO = oLOGIN.LOGIN(txt_usuario.Text, MD5.Encriptar(txt_pass.Text));
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Ingreso al sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            if (oUSUARIO == null) return;
            Form_Password form = new Form_Password(oUSUARIO);
            form.Show();
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_usuario.Text == "")
            {
                lblUserNameError.Text = "* Debe ingresar el nombre de usuario";
                return;
            }

            string passrec = oLOGIN.RecuperarPassword(txt_usuario.Text);
            
            string email_Smoke = "SmokeSurvTech@gmail.com";

            string usereMail = oLOGIN.RecuperarMail(txt_usuario.Text);

            MailMessage Mensaje = new MailMessage(email_Smoke, usereMail, "Recuperar Password", "Hola " + txt_usuario.Text + Environment.NewLine + "Tu contraseña es: " + passrec + Environment.NewLine);
            SendMail(Mensaje);

            MessageBox.Show("El mail con tu contraseña ha sido enviado.", "Smoke");
        }


    }
}
