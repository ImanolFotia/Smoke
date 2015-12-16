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
    public partial class frmGRUPO : Form
    {
        string MODO;
        CONTROLADORA.cGrupos cGRUPOS;
        Modelo.grupo  oGRUPO;
        Modelo.formulario oFormulario;
        bool checkear;
        bool checkearA = false;
        public frmGRUPO(string fMODO, Modelo.grupo miGRUPO)
        {
            InitializeComponent();
            cGRUPOS = CONTROLADORA.cGrupos.obtenerInstancia();
            MODO = fMODO;
            oGRUPO = miGRUPO;
            chkPermisos.Enabled = true;

            if (MODO != "A")
            {
                txtCODIGO.Text = oGRUPO.gru_codigo ;
                txtDESCRIPCION.Text = oGRUPO.gru_descripcion;
                chkEstado.Checked = oGRUPO.gru_estado;
               txtCODIGO.Enabled = false;
               if (MODO == "C")
               {
                   btnGUARDAR.Enabled = false;
                   btnCANCELAR.Text = "Cerrar";
                   chkPermisos.Enabled = false;
               }
            }

        }

        private void frmGRUPO_Load(object sender, EventArgs e)
        {
            cmbFORMULARIO.DataSource = cGRUPOS.obtenerFormulario();
            cmbFORMULARIO.DisplayMember = "frm_descripcion";

            oFormulario = (Modelo.formulario)cmbFORMULARIO.SelectedItem;

            chkUSUARIOS.DataSource = null;
            chkUSUARIOS.DataSource = cGRUPOS.obtenerUsuarios();
            chkUSUARIOS.DisplayMember = "usu_nombre";

            checkearA = false;
            for (int i = 0; i < chkUSUARIOS.Items.Count; i++)
            {
                Modelo.Usuarios oUsuario = (Modelo.Usuarios)chkUSUARIOS.Items[i];
                foreach (Modelo.Usuarios miUsuario in oGRUPO.Usuarios.ToList())
                {
                    if (miUsuario.usu_codigo == oUsuario.usu_codigo)
                    {
                        chkUSUARIOS.SetItemChecked(i, true);
                    }
                }
            }
            checkearA = true;
        }
        
        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnGUARDAR_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCODIGO.Text))
            {
                MessageBox.Show("Debe ingresar el código del grupo", "ATENCION!!");
                return;
            }

            if (string.IsNullOrEmpty(txtDESCRIPCION.Text))
            {
                MessageBox.Show("Debe ingresar el nombre del grupo","ATENCION!!");
                return;
            }

            try
            {
                
                oGRUPO.gru_descripcion  = txtDESCRIPCION.Text;
                oGRUPO.gru_estado = chkEstado.Checked;
                if (MODO == "A")
                {
                    oGRUPO.gru_codigo = txtCODIGO.Text;
                    cGRUPOS.Alta(oGRUPO);
                }
                else
                {
                    cGRUPOS.Modificacion(oGRUPO);
                }
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message.ToString());
            }
        }

        private void cmbFORMULARIO_SelectedIndexChanged(object sender, EventArgs e)
        {
            oFormulario = (Modelo.formulario)cmbFORMULARIO.SelectedItem;
            chkPermisos.DataSource = null;
            chkPermisos.DataSource = oFormulario.permiso.ToList();
            chkPermisos.DisplayMember = "per_descripcion";

            checkear = false;

            for (int i = 0; i < chkPermisos.Items.Count; i++)
            {
                Modelo.permiso oPermiso = (Modelo.permiso)chkPermisos.Items[i];
                //var permisosQuery = from oPERFIL in oGRUPO.perfil.ToList()
                //                    where oPERFIL.formulario == oFormulario
                //                    select oPERFIL.permiso.ToList();
                Modelo.perfil oPerfil = oGRUPO.perfil.FirstOrDefault(P => P.formulario == oFormulario);

                if (oPerfil != null)
                {

                    foreach (Modelo.permiso miPermiso in oPerfil.permiso.ToList())
                    {
                        if (miPermiso == oPermiso)
                        {
                            chkPermisos.SetItemChecked(i, true);
                        }
                    }
                }
            }
            checkear = true;
        }

        private void chkPermisos_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (checkear == false) return;
            oFormulario = (Modelo.formulario)cmbFORMULARIO.SelectedItem;
            Modelo.permiso oPermiso = (Modelo.permiso)chkPermisos.SelectedItem;
           Modelo.perfil oPerfil = oGRUPO.perfil.FirstOrDefault(P => P.formulario == oFormulario);
           if (oPerfil == null)
           {
               oPerfil = new Modelo.perfil();
               oPerfil.grupo = oGRUPO;
               oPerfil.formulario = oFormulario;
           }

           if (e.NewValue == CheckState.Checked)
           {
               oPerfil.permiso.Add(oPermiso); 
               checkear = true;
           }
           else
           {
               oPerfil.permiso.Remove(oPermiso);
               checkear = true;
           }
        }

        private void chkUSUARIOS_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (checkear == false) return;

            Modelo.Usuarios oUSUARIO = (Modelo.Usuarios)chkUSUARIOS.SelectedItem;
            if (e.NewValue == CheckState.Checked)
            {
                oGRUPO.Usuarios.Add(oUSUARIO);
            }
            else
            {
                oGRUPO.Usuarios.Remove(oUSUARIO);
            }
        }

        private void chkPermisos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
