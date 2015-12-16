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
    public partial class frmLOGIN : Form
    {
        CONTROLADORA.cLOGIN oLOGIN;
        Modelo.Usuarios oUSUARIO;
        public Modelo.Usuarios USUARIO
        {
            get { return oUSUARIO; }
        }

        public frmLOGIN()
        {
            InitializeComponent();
            oLOGIN = CONTROLADORA.cLOGIN.obtenerInstancia();
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnINGRESAR_Click(object sender, EventArgs e)
        {
            if (txtUSUARIO.Text == "")
            {
                lblUserNameError.Text = "* Debe ingresar el nombre de usuario";
                return;
            }
            else
            {
                lblUserNameError.Text = "";
            }
            if (txtPASSWORD.Text == "")
            {
                lblPasswordError.Text = "* Debe ingresar la contraseña";
                return;
            }
            else
            {
                lblPasswordError.Text = "";
            }
            try
            {
                oUSUARIO = oLOGIN.LOGIN(txtUSUARIO.Text, txtPASSWORD.Text);
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message,"Ingreso al sistema",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
        }

        private void frmLOGIN_Load(object sender, EventArgs e)
        {

        }
    }
}
