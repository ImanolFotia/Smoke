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
    public partial class Form_Grupos : Form
    {
        private static Form_Grupos instancia;
        CONTROLADORA.cGrupos cGRUPOS;
        Form_Grupo formGrupo;
        public static Form_Grupos obtener_instancia(Modelo.Usuarios oUSUARIO)
        {
            if (instancia == null)
                instancia = new Form_Grupos(oUSUARIO);
            if (instancia.IsDisposed)
                instancia = new Form_Grupos(oUSUARIO);

            return instancia;
        }

        public Form_Grupos(Modelo.Usuarios oUSUARIO)
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
            cGRUPOS = CONTROLADORA.cGrupos.obtenerInstancia();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void Form_Grupos_Load(object sender, EventArgs e)
        {
            ARMA_LISTA();
        }

        private void ARMA_LISTA()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = cGRUPOS.ObtenerGrupos();
            dataGridView1.Columns[0].HeaderText = "CODIGO";
            dataGridView1.Columns[1].HeaderText = "DESCRIPCION";
            dataGridView1.Columns[2].HeaderText = "ESTADO";
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;


        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            formGrupo = new Form_Grupo("A", new Modelo.grupo());
            DialogResult dr = formGrupo.ShowDialog();
            if (dr == DialogResult.OK)
                ARMA_LISTA();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                return;

            try
            {
                Modelo.grupo oGrupo = (Modelo.grupo)dataGridView1.CurrentRow.DataBoundItem;
                oGrupo.gru_estado = false;
                cGRUPOS.Modificacion(oGrupo);
                ARMA_LISTA();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.ToString());
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnconsul_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                return;
            formGrupo = new Form_Grupo("C", (Modelo.grupo)dataGridView1.CurrentRow.DataBoundItem);
            DialogResult dr = formGrupo.ShowDialog();
        }

        private void btnmod_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                return;
            formGrupo = new Form_Grupo("M", (Modelo.grupo)dataGridView1.CurrentRow.DataBoundItem);
            DialogResult dr = formGrupo.ShowDialog();
            if (dr == DialogResult.OK)
                ARMA_LISTA();
        }


    }
}
