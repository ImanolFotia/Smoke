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
    public partial class Form_Usuarios : Form
    {
        private static Form_Usuarios instancia;
        Controladora.C_Usuarios cUSUARIOS;
        Form_Usuario formUsuario;

        public static Form_Usuarios obtener_instancia(Modelo.Usuarios oUSUARIO)
        {
            if (instancia == null)
                instancia = new Form_Usuarios(oUSUARIO);
            if (instancia.IsDisposed)
                instancia = new Form_Usuarios(oUSUARIO);

            return instancia;
        }
        public Form_Usuarios(Modelo.Usuarios oUSUARIO)
        {
            InitializeComponent();
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
            cUSUARIOS = Controladora.C_Usuarios.Obtener_Instancia();
            ARMA_LISTA();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void Form_Usuarios_Load(object sender, EventArgs e)
        {
            ARMA_LISTA();
        }

        private void ARMA_LISTA()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = cUSUARIOS.Listar_Usuarios();/*
            dataGridView1.Columns[0].HeaderText = "USUARIO";
            dataGridView1.Columns[1].HeaderText = "NOMBRE";
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].HeaderText = "ESTADO";
            dataGridView1.Columns[4].Visible = false;*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formUsuario = new Form_Usuario("A", new Modelo.Usuarios());
            DialogResult dr = formUsuario.ShowDialog();
            if (dr == DialogResult.OK)
                ARMA_LISTA();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                return;

            try
            {
                Modelo.Usuarios oUsu = (Modelo.Usuarios)dataGridView1.CurrentRow.DataBoundItem;
                oUsu.usu_estado = false;
                cUSUARIOS.Modificar(oUsu);
                ARMA_LISTA();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.ToString());
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (dataGridView1.CurrentRow == null)
                return;
            formUsuario = new Form_Usuario("C", (Modelo.Usuarios)dataGridView1.CurrentRow.DataBoundItem);
            DialogResult dr = formUsuario.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                return;
            formUsuario = new Form_Usuario("M", (Modelo.Usuarios)dataGridView1.CurrentRow.DataBoundItem);
            DialogResult dr = formUsuario.ShowDialog();
            if (dr == DialogResult.OK)
                ARMA_LISTA();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
