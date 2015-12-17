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
    public partial class Form_TyC : Form
    {
        Controladora.C_Software C_Software = Controladora.C_Software.Obtener_Instancia();
        Modelo.Usuarios oUsuario;
        Modelo.Software oSoftware;
        Vista.CVisual CVisual = new Vista.CVisual();
        public Form_TyC(Modelo.Usuarios FormUsuario)
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
            Modelo.ModeloContainer oModelo = new Modelo.ModeloContainer();
            btn_Siguiente.Enabled = false;
            oUsuario = FormUsuario;
            CVisual.CambioVisual(this);
            if (oModelo.Software.Count() == 0)
            {
                oSoftware = new Modelo.Software();
                oSoftware.Categoria = "Shooter";
                oSoftware.Descripcion = "Best game ever";
                oSoftware.Edad = 12;
                oSoftware.Link = "www.mediasmoke.com";
                oSoftware.Lenguaje = "English";
                oSoftware.Nombre = "Epsilon";
                oSoftware.Precio = 1245;
                oSoftware.Usuario = oUsuario;
                C_Software.Agregar2(oSoftware);

            }
            Armar_Lista();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void Armar_Lista()
        {
            dgv_Software.DataSource = null;
            dgv_Software.DataSource = C_Software.Obtener_Software(oUsuario);
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

        private void Form_TyC_Load(object sender, EventArgs e)
        {
            Armar_Lista();
        }

        private void chk_Aceptar_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Aceptar.Checked == true) btn_Siguiente.Enabled = true;
            if (chk_Aceptar.Checked == false) btn_Siguiente.Enabled = false;
        }

        private void btn_Atras_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btn_Siguiente_Click(object sender, EventArgs e)
        {
            if(oUsuario.Dev == 2)
            {
                Form_Pago FPS = new Form_Pago(oUsuario, 150, 1);
                FPS.Show();
                this.Hide();
            }
            else if(oUsuario.Dev == 1)
            {
            Form_Carga_Software FCS = new Form_Carga_Software(oUsuario);
            FCS.Show(); 
                this.Hide();
            }
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cb_usuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            Armar_Lista();
        }

        private void dgv_Software_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
