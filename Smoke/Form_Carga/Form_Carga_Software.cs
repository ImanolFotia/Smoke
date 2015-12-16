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
    public partial class Form_Carga_Software : Form
    {
        Form_TyC formtyc;
        Modelo.Software Software;
        Modelo.Usuarios Usuario;
        Controladora.C_Software C_Software;
        Vista.CVisual CVisual = new Vista.CVisual();
        enum Categoria  { Modelado, Musica, Video };
        enum Lenguaje { Español, Inglés, Francés };
       
        public Form_Carga_Software(Modelo.Usuarios miusuario)
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
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void Form_Carga_Software_Load(object sender, EventArgs e)
        {

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
            if (chk_Aceptar.Checked == true) btn_Siguiente.Enabled = true;
            if (chk_Aceptar.Checked == false) btn_Siguiente.Enabled = false;
        }
     
        private void btn_Siguiente_Click(object sender, EventArgs e)
        {
            Software = new Modelo.Software();
            Software.Nombre = txt_nombre.Text;
            Software.Descripcion = txt_desc.Text;
            Software.Categoria = cmb_cat.SelectedItem.ToString();
            Software.Edad = Convert.ToInt32(nup_edad.Value);
            Software.Lenguaje = cmb_leng.SelectedItem.ToString();
            Software.Precio = txt_precio.Text;
            Software.Usuario = Usuario;
            C_Software.Agregar2(Software);
            Modelo.AuditoriaSoftware oAuSoft = new Modelo.AuditoriaSoftware();
            oAuSoft.IdUsuario = Usuario.Id;
            oAuSoft.Fecha_Accion = DateTime.Now;
            //aplicación del patrón de diseño prototype
            //se clona el objeto Software, ya instanciado, en el objeto Auditoria (oAuSoft)
            oAuSoft.Software = Software;
            C_Software.AgregarAuditoriaSoftware(oAuSoft);
            Armar_Lista();
        }
        private void cmb_Usuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void dgv_Software_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmb_leng_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
