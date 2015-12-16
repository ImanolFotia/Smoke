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
    public partial class Form_Compra_1 : Form
    {
        Controladora.C_Software C_Software = Controladora.C_Software.Obtener_Instancia();
        Modelo.Software oSoftware;
        Modelo.Usuarios oUsuario;
        Vista.CVisual CVisual = new Vista.CVisual();
        public Form_Compra_1(Modelo.Usuarios oUSUARIO)
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
            CVisual.CambioVisual(this);
            dgv_Software.ReadOnly = false;
            Modelo.ModeloContainer oModelo = new Modelo.ModeloContainer();
            Armar_Lista();
            oUsuario = oUSUARIO;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void Armar_Lista_Filtrada_Nombre()
        {
            dgv_Software.DataSource = null;
            dgv_Software.DataSource = C_Software.Buscar_Software(txt_Busqueda.Text);
            dgv_Software.Columns[0].Visible = false;
            dgv_Software.Columns[1].Visible = false;
            dgv_Software.Columns[2].Visible = false;
            dgv_Software.Columns[3].Visible = false;
            dgv_Software.Columns[7].Visible = false;
            dgv_Software.Columns[4].Visible = false;
            dgv_Software.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_Software.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgv_Software.Columns[8].Visible = false;
            dgv_Software.Columns[9].Visible = false;
            foreach (DataGridViewColumn row in dgv_Software.Columns) row.DefaultCellStyle.BackColor = Color.Black;
            foreach (DataGridViewColumn row in dgv_Software.Columns) row.DefaultCellStyle.ForeColor = Color.White;
            dgv_Software.ReadOnly = true;
            dgv_Software.BackgroundColor = Color.Black;
        }

        private void Armar_Lista_Filtrada_Descripcion()
        {
            dgv_Software.DataSource = null;
            dgv_Software.DataSource = C_Software.Buscar_Software_Descripción(txt_Busqueda_Descripicion.Text);
            dgv_Software.Columns[0].Visible = false;
            dgv_Software.Columns[1].Visible = false;
            dgv_Software.Columns[2].Visible = false;
            dgv_Software.Columns[3].Visible = false;
            dgv_Software.Columns[7].Visible = false;
            dgv_Software.Columns[4].Visible = false;
            dgv_Software.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_Software.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgv_Software.Columns[8].Visible = false;
            dgv_Software.Columns[9].Visible = false;
            foreach (DataGridViewColumn row in dgv_Software.Columns) row.DefaultCellStyle.BackColor = Color.Black;
            foreach (DataGridViewColumn row in dgv_Software.Columns) row.DefaultCellStyle.ForeColor = Color.White;
            dgv_Software.ReadOnly = true;
            dgv_Software.BackgroundColor = Color.Black;
        }

        private void Armar_Lista()
        {
            //oUsuario = (Modelo.Usuarios)cb_usuario.SelectedItem;
            dgv_Software.DataSource = null;
            dgv_Software.DataSource = C_Software.Listar_Software();
            //dgv_Software.DataSource = C_Software.Obtener_Software(oUsuario);
            dgv_Software.Columns[0].Visible = false;
            dgv_Software.Columns[1].Visible = false;
            dgv_Software.Columns[2].Visible = false;
            dgv_Software.Columns[3].Visible = false;
            dgv_Software.Columns[7].Visible = false;
            dgv_Software.Columns[4].Visible = false;
            dgv_Software.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_Software.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgv_Software.Columns[8].Visible = false;
            dgv_Software.Columns[9].Visible = false;
            //dgv_Software.AutoResizeColumns();
            //dgv_Software.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //dgv_Software.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //foreach (DataGridViewRow row in dgv_Compras.Rows) row.DefaultCellStyle.BackColor = Color.Black;
            //foreach (DataGridViewRow row in dgv_Compras.Rows) row.DefaultCellStyle.ForeColor = Color.White;
            foreach (DataGridViewColumn row in dgv_Software.Columns) row.DefaultCellStyle.BackColor = Color.Black;
            foreach (DataGridViewColumn row in dgv_Software.Columns) row.DefaultCellStyle.ForeColor = Color.White;
            dgv_Software.ReadOnly = true;
            dgv_Software.BackgroundColor = Color.Black;
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

        private void dgv_Software_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv_Software.ReadOnly = false;
            oSoftware = (Modelo.Software)dgv_Software.CurrentRow.DataBoundItem;
            Form_Compra_2 form = new Form_Compra_2(oSoftware, oUsuario);
            DialogResult dr = form.ShowDialog();
            this.Hide();
            if (dr == DialogResult.OK) this.Show();
        }

        private void btn_Siguiente_Click_1(object sender, EventArgs e)
        {

        }

        private void txt_Busqueda_TextChanged(object sender, EventArgs e)
        {
            if (txt_Busqueda.Text == null) Armar_Lista();
            if (txt_Busqueda.Text != null) Armar_Lista_Filtrada_Nombre();
        }

        private void txt_Busqueda_Descripicion_TextChanged(object sender, EventArgs e)
        {
            if (txt_Busqueda_Descripicion == null) Armar_Lista();
            if (txt_Busqueda_Descripicion.Text != null) Armar_Lista_Filtrada_Descripcion();

        }


    }
}
