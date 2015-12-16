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
    public partial class frmGRUPOS : Form
    {
        private static frmGRUPOS instancia;
        CONTROLADORA.cGrupos cGRUPOS;
        frmGRUPO formGrupo;
        public static frmGRUPOS obtener_instancia(Modelo.Usuarios oUSUARIO)
        {
            if (instancia == null)
                instancia = new frmGRUPOS(oUSUARIO);
            if (instancia.IsDisposed)
                instancia = new frmGRUPOS(oUSUARIO);

            return instancia;
        }

        private frmGRUPOS(Modelo.Usuarios oUSUARIO)
        {
            InitializeComponent();
            cGRUPOS = CONTROLADORA.cGrupos.obtenerInstancia();
            botonera1.ARMA_PERFIL("frmGRUPOS", oUSUARIO);
            
        }

        private void frmGRUPOS_Load(object sender, EventArgs e)
        {
            ARMA_LISTA();
        }

        private void ARMA_LISTA()
        {
            dgvDATA.DataSource = null;
            dgvDATA.DataSource = cGRUPOS.ObtenerGrupos();
            dgvDATA.Columns[0].HeaderText = "CODIGO";
            dgvDATA.Columns[1].HeaderText = "DESCRIPCION";
            dgvDATA.Columns[2].HeaderText = "ESTADO";
            dgvDATA.Columns[3].Visible = false;
            dgvDATA.Columns[4].Visible = false;
            

        }

        private void botonera1_Click_Alta(object sender, EventArgs e)
        {
            formGrupo = new frmGRUPO ("A", new Modelo.grupo());
            DialogResult dr = formGrupo.ShowDialog();
            if (dr == DialogResult.OK)
                ARMA_LISTA();
        }

        private void botonera1_Click_Baja(object sender, EventArgs e)
        {
            if (dgvDATA.CurrentRow == null)
                return;

            try
            {
                Modelo.grupo oGrupo = (Modelo.grupo)dgvDATA.CurrentRow.DataBoundItem;
                oGrupo.gru_estado = false;
                cGRUPOS.Modificacion(oGrupo);
                ARMA_LISTA();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.ToString());
            }
        }

        private void botonera1_Click_Cerrar(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botonera1_Click_Consulta(object sender, EventArgs e)
        {
            if (dgvDATA.CurrentRow == null)
                return;
            formGrupo = new frmGRUPO("C", (Modelo.grupo)dgvDATA.CurrentRow.DataBoundItem);
            DialogResult dr = formGrupo.ShowDialog();
        }

        private void botonera1_Click_Modificacion(object sender, EventArgs e)
        {
            if (dgvDATA.CurrentRow == null)
                return;
            formGrupo = new frmGRUPO("M", (Modelo.grupo)dgvDATA.CurrentRow.DataBoundItem);
            DialogResult dr = formGrupo.ShowDialog();
            if (dr == DialogResult.OK)
                ARMA_LISTA();
        }

        private void botonera1_Load(object sender, EventArgs e)
        {

        }
    }
}
