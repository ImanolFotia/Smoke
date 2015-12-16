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
    public partial class Form_Compras : Form
    {
        Modelo.Software Software;
        Modelo.UsuarioSoftware Compra;
        Modelo.Usuarios Usuario;
        Controladora.C_Software C_Software;
        Vista.CVisual CVisual = new Vista.CVisual();

        public Form_Compras(Modelo.Usuarios miusuario)
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
            CVisual.CambioVisual(this);
            C_Software = Controladora.C_Software.Obtener_Instancia();
            Usuario = miusuario;
            Armar_Lista();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void Armar_Lista()
        {
            dgv_Compras.DataSource = null;
            dgv_Compras.DataSource = C_Software.Obtener_Compras(Usuario);
            dgv_Compras.Columns[0].Visible = false;
            dgv_Compras.Columns[1].Visible = false;
            dgv_Compras.Columns[2].Visible = false;
            dgv_Compras.Columns[3].Visible = false;
            dgv_Compras.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //foreach (DataGridViewRow row in dgv_Compras.Rows) row.DefaultCellStyle.BackColor = Color.Black;
            //foreach (DataGridViewRow row in dgv_Compras.Rows) row.DefaultCellStyle.ForeColor = Color.White;
            foreach (DataGridViewColumn row in dgv_Compras.Columns) row.DefaultCellStyle.BackColor = Color.Black;
            foreach (DataGridViewColumn row in dgv_Compras.Columns) row.DefaultCellStyle.ForeColor = Color.White;
            dgv_Compras.BackgroundColor = Color.Black;
            dgv_Compras.ReadOnly = true;
        }

        private void Form_Compras_Load(object sender, EventArgs e)
        {

        }

        private void dgv_Compras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //nuevo form con id compra soft, pag web
            Compra = (Modelo.UsuarioSoftware)dgv_Compras.CurrentRow.DataBoundItem;
            Form_Descarga form = new Form_Descarga(Usuario, Compra);
            DialogResult dr = form.ShowDialog();
            this.Hide();
            if (dr == DialogResult.OK) this.Show();
        }
    }
}
