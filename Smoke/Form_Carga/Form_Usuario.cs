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
    public partial class Form_Usuario : Form
    {
        string MODO;
        Controladora.C_Usuarios cUSUARIOS;
        Modelo.Usuarios oUSUARIO;
        bool checkearA;
        Modelo.grupo oGrupo;
        public Form_Usuario(string fMODO, Modelo.Usuarios miUSUARIO)
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
            cUSUARIOS = Controladora.C_Usuarios.Obtener_Instancia();
            MODO = fMODO;
            oUSUARIO = miUSUARIO;
            cbestado.Enabled = true;

            if (MODO != "A")
            {
                txtCodigo.Text = oUSUARIO.Id;
                txtNombre.Text = oUSUARIO.Nombre;
                txtEmail.Text = oUSUARIO.eMail;
                cbestado.Checked = oUSUARIO.usu_estado;
                txtCodigo.Enabled = false;
                if (MODO == "C")
                {
                    btnaceptar.Enabled = false;
                    btancancelar.Text = "Cerrar";
                    cbestado.Enabled = false;
                    chkgrupo.Enabled = false;
                }
            }
            else
            {
                cbestado.Checked = true;
            }

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void Form_Usuario_Load(object sender, EventArgs e)
        {
            chkgrupo.DataSource = null;
            chkgrupo.DataSource = cUSUARIOS.ObtenerGrupos();
            chkgrupo.DisplayMember = "gru_descripcion";

            checkearA = false;
            for (int i = 0; i < chkgrupo.Items.Count; i++)
            {
                oGrupo = (Modelo.grupo)chkgrupo.Items[i];
                foreach (Modelo.grupo miGrupo in oUSUARIO.grupo)
                {
                    if (miGrupo.gru_codigo == oGrupo.gru_codigo)
                    {
                        chkgrupo.SetItemChecked(i, true);
                    }
                }
            }
            checkearA = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btancancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("Debe ingresar el código del usuario", "ATENCION!!");
                return;
            }

            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Debe ingresar el nombre del usuario", "ATENCION!!");
                return;
            }

            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Debe ingresar el email del usuario", "ATENCION!!");
                return;
            }

            if (!string.IsNullOrEmpty(txtpass.Text))
            {
                if (!string.Equals(txtpass.Text, txtpassrep.Text))
                {
                    MessageBox.Show("Las contraseñas no coinciden", "ATENCION!!");
                    return;
                }
            }

            try
            {
                oUSUARIO.Id = txtCodigo.Text;
                oUSUARIO.Nombre = txtNombre.Text;
                oUSUARIO.eMail = txtEmail.Text;
                oUSUARIO.Lenguaje = txtleng.Text;
                oUSUARIO.Pais = txt_pais.Text;
                oUSUARIO.usu_estado = cbestado.Checked;
                oUSUARIO.Dev = 0;
                oUSUARIO.usu_Admin = true;
                oUSUARIO.grupo.Add(oGrupo);
                if (MODO == "A")
                {
                    if (!string.IsNullOrEmpty(txtpass.Text))
                    {
                        oUSUARIO.Password = txtpass.Text;
                    }
                    else
                    {
                        oUSUARIO.Password = txtCodigo.Text;
                    }

                    cUSUARIOS.Agregar(oUSUARIO);
                }
                else
                {
                    if (!string.IsNullOrEmpty(txtpass.Text))
                    {
                        oUSUARIO.Password = txtpass.Text;
                    }
                    cUSUARIOS.Modificar(oUSUARIO);
                }
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message.ToString());
            }
        }
    }
}
