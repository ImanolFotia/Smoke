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
    public partial class Form_Modificar_Software : Form
    {
        Form_TyC formtyc;
        Modelo.Software Software;
        Modelo.Usuarios Usuario;
        Controladora.C_Software C_Software;
        Vista.CVisual CVisual = new Vista.CVisual();
        enum Categoria { Modelado, Musica, Video };
        enum Lenguaje { Español, Inglés, Francés };
        public Form_Modificar_Software(Modelo.Usuarios miusuario, Modelo.Software misoftware)
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
            CVisual.CambioVisual(this);
            btn_Siguiente.Enabled = false;
            cmb_cat.DataSource = null;
            cmb_leng.DataSource = null;
            cmb_cat.DataSource = Enum.GetValues(typeof(Categoria));
            cmb_leng.DataSource = Enum.GetValues(typeof(Lenguaje));
            C_Software = Controladora.C_Software.Obtener_Instancia();
            Usuario = miusuario;
            Armar_Lista();
            Software = misoftware;
        }

        private void Form_Modificar_Software_Load(object sender, EventArgs e)
        {
            txt_nombre.Text = Software.Nombre;
            txt_desc.Text = Software.Descripcion;
            txtLink.Text = Software.Link;
            txt_precio.Text = Software.Precio.ToString();
            nup_edad.Value = Software.Edad;
            cmb_cat.SelectedItem = Software.Categoria;
            cmb_leng.SelectedItem = Software.Lenguaje;
            actualizarBoton();
        }

        private void actualizarBoton()
        {
            if (Software.Estado == true)
            {
                button1.Text = "Activar Software";
            }
            else
            {
                button1.Text = "Desactivar Software";
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void Armar_Lista()
        {
            dgv_Software.DataSource = null;
            dgv_Software.DataSource = C_Software.Obtener_Software(Usuario);
            dgv_Software.Columns[0].Visible = false;
            dgv_Software.Columns[1].Visible = false;
            dgv_Software.Columns[2].Visible = false;
            dgv_Software.Columns[3].Visible = false;
            dgv_Software.Columns[7].Visible = false;
            dgv_Software.Columns[4].Visible = false;
            dgv_Software.Columns[8].Visible = false;
            dgv_Software.Columns[9].Visible = false;
            dgv_Software.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_Software.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            foreach (DataGridViewColumn row in dgv_Software.Columns) row.DefaultCellStyle.BackColor = Color.Black;
            foreach (DataGridViewColumn row in dgv_Software.Columns) row.DefaultCellStyle.ForeColor = Color.White;
            dgv_Software.ReadOnly = true;
            dgv_Software.BackgroundColor = Color.Black;
        }

        private void btn_Atras_Click(object sender, EventArgs e)
        {
            formtyc = new Form_TyC(Usuario);
            formtyc.Show();
            this.Close();
        }

        private void chk_Aceptar_CheckedChanged(object sender, EventArgs e)
        {

        }

        //private void btn_Siguiente_Click(object sender, EventArgs e)
        //{
        //    Software = new Modelo.Software();
        //    Software.Nombre = txt_nombre.Text;
        //    Software.Descripcion = txt_desc.Text;
        //    Software.Categoria = cmb_cat.SelectedItem.ToString();
        //    Software.Edad = Convert.ToInt32(nup_edad.Value);
        //    Software.Lenguaje = cmb_leng.SelectedItem.ToString();
        //    Software.Precio = Convert.ToDecimal(txt_precio.Text);
        //    Software.Link = txtLink.Text;
        //    Software.Usuario = Usuario;
        //    C_Software.Agregar2(Software);
        //    Modelo.AuditoriaSoftware oAuSoft = new Modelo.AuditoriaSoftware();
        //    oAuSoft.IdUsuario = Usuario.Id;
        //    oAuSoft.Fecha_Accion = DateTime.Now;
        //    oAuSoft.Accion = "Subir";
        //    //aplicación del patrón de diseño prototype
        //    //se clona el objeto Software, ya instanciado, en el objeto Auditoria (oAuSoft)
        //    oAuSoft.Software = Software;
        //    C_Software.AgregarAuditoriaSoftware(oAuSoft);
        //    Armar_Lista();
        //    MessageBox.Show("Carga de software exitosa.");
        //    formtyc = new Form_TyC(Usuario);
        //    formtyc.Show();
        //    this.Close();
        //}

        private void chk_Aceptar_CheckedChanged_1(object sender, EventArgs e)
        {
            decimal parsedValue;
            if (decimal.TryParse(txt_precio.Text, out parsedValue) && !string.IsNullOrWhiteSpace(txt_desc.Text) && !string.IsNullOrWhiteSpace(txt_nombre.Text) && !string.IsNullOrWhiteSpace(txtLink.Text) && !string.IsNullOrWhiteSpace(txt_precio.Text))
            {
                if (chk_Aceptar.Checked == true) btn_Siguiente.Enabled = true;
                if (chk_Aceptar.Checked == false) btn_Siguiente.Enabled = false;
            }
            else
            {
                if (chk_Aceptar.Checked == true)
                {
                    MessageBox.Show("Campos ingresados incorrectos");
                    chk_Aceptar.Checked = false;
                    return;
                }
            }
        }

        private void btn_Siguiente_Click_1(object sender, EventArgs e)
        {
            
            Software.Nombre = txt_nombre.Text;
            Software.Descripcion = txt_desc.Text;
            Software.Categoria = cmb_cat.SelectedItem.ToString();
            Software.Edad = Convert.ToInt32(nup_edad.Value);
            Software.Lenguaje = cmb_leng.SelectedItem.ToString();
            Software.Precio = Convert.ToDecimal(txt_precio.Text);
            Software.Link = txtLink.Text;
            Software.Usuario = Usuario;
            C_Software.Modificar(Software);
            Modelo.AuditoriaSoftware oAuSoft = new Modelo.AuditoriaSoftware();
            oAuSoft.IdUsuario = Usuario.Id;
            oAuSoft.Fecha_Accion = DateTime.Now;
            oAuSoft.Accion = "Modificar: " + Environment.NewLine +
                                " ID: " + Software.Id + Environment.NewLine +
                                " Nombre: " + txt_nombre.Text + Environment.NewLine +
                                " Descripcion: " + txt_desc.Text + Environment.NewLine +
                                " Categoria: " + cmb_cat.SelectedItem.ToString() + Environment.NewLine +
                                " Edad: " + Convert.ToInt32(nup_edad.Value) + Environment.NewLine +
                                " Lenguaje: " + cmb_leng.SelectedItem.ToString() + Environment.NewLine +
                                " Precio: " + Convert.ToDecimal(txt_precio.Text) + Environment.NewLine +
                                " Link: " + txtLink.Text;
            //aplicación del patrón de diseño prototype
            //se clona el objeto Software, ya instanciado, en el objeto Auditoria (oAuSoft)
            oAuSoft.Software = Software;
            C_Software.AgregarAuditoriaSoftware(oAuSoft);
            MessageBox.Show("Modificación de software exitosa.");
            formtyc = new Form_TyC(Usuario);
            formtyc.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Software.Estado = !Software.Estado;
            MessageBox.Show((Software.Estado) ? "Tu Software Esta desactivado" : "Tu Software Esta activado");
            C_Software.Modificar(Software);
            Modelo.AuditoriaSoftware oAuSoft = new Modelo.AuditoriaSoftware();
            oAuSoft.IdUsuario = Usuario.Id;
            oAuSoft.Fecha_Accion = DateTime.Now;
            oAuSoft.Accion = (Software.Estado ? "Cambio de estado: Baja"+ Environment.NewLine + "ID: " + Software.Id : "Cambio de estado: Alta"+ Environment.NewLine + "ID: " + Software.Id);
            oAuSoft.Software = Software;
            C_Software.AgregarAuditoriaSoftware(oAuSoft);
            actualizarBoton();
        }


    }
}
