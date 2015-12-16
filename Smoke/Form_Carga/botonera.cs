using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Form_Carga
{
    public delegate void Eventos_Botonera(object sender, EventArgs e);

    public partial class botonera : UserControl
    {
        public event Eventos_Botonera Click_Alta;
        public event Eventos_Botonera Click_Baja;
        public event Eventos_Botonera Click_Modificacion;
        public event Eventos_Botonera Click_Consulta;
        public event Eventos_Botonera Click_Cerrar;
        CONTROLADORA.cPERFIL cPERFIL;

        public botonera()
        {
            InitializeComponent();           
        }

        public void ARMA_PERFIL(string FORMULARIO, Modelo.Usuarios USUARIO)
        {
            try
            {
                if (cPERFIL == null)
                    cPERFIL = CONTROLADORA.cPERFIL.obtenerInstancia();
                btnALTAS.Enabled = false;
                btnBAJAS.Enabled = false;
                btnMODIFICACIONES.Enabled = false;
                btnCONSULTAS.Enabled = false;

                foreach (Modelo.permiso oPERMISO in cPERFIL.obtenerPermisos(USUARIO, FORMULARIO))
                {
                    switch (oPERMISO.per_codigo)
                    {
                        case "A":
                            btnALTAS.Enabled = true;
                            break;
                        case "B":
                            btnBAJAS.Enabled = true;
                            break;
                        case "M":
                            btnMODIFICACIONES.Enabled = true;
                            break;
                        case "C":
                            btnCONSULTAS.Enabled = true;
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
         }

        private void btnALTAS_Click(object sender, EventArgs e)
        {
            Click_Alta(sender,e);
        }

        private void btnBAJAS_Click(object sender, EventArgs e)
        {
            Click_Baja(sender, e);
        }

        private void btnMODIFICACIONES_Click(object sender, EventArgs e)
        {
            Click_Modificacion(sender, e);
        }

        private void btnCONSULTAS_Click(object sender, EventArgs e)
        {
            Click_Consulta(sender, e);
        }

        private void btnCERRAR_Click(object sender, EventArgs e)
        {
            Click_Cerrar(sender, e);
        }

        private void botonera_Load(object sender, EventArgs e)
        {

        }
    }
}
