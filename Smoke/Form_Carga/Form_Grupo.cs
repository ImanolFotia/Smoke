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
    public partial class Form_Grupo : Form
    {
        string MODO;
        CONTROLADORA.cGrupos cGRUPOS;
        Modelo.grupo oGRUPO;
        Modelo.formulario oFormulario;
        bool checkear;
        bool checkearA = false;
        public Form_Grupo(string fMODO, Modelo.grupo miGRUPO)
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
            cGRUPOS = CONTROLADORA.cGrupos.obtenerInstancia();
            MODO = fMODO;
            oGRUPO = miGRUPO;
            checkedListBox2.Enabled = true;
            if (MODO != "A")
            {
                txtCodigo.Text = oGRUPO.gru_codigo;
                txtDesc.Text = oGRUPO.gru_descripcion;
                cbactivo.Checked = oGRUPO.gru_estado;
                txtCodigo.Enabled = false;
                if (MODO == "C")
                {
                    btnaceptar.Enabled = false;
                    btncancelar.Text = "Cerrar";
                    checkedListBox2.Enabled = false;
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void Form_Grupo_Load(object sender, EventArgs e)
        {
            cmbform.DataSource = cGRUPOS.obtenerFormulario();
            cmbform.DisplayMember = "frm_descripcion";

            oFormulario = (Modelo.formulario)cmbform.SelectedItem;

            chkuser.DataSource = null;
            chkuser.DataSource = cGRUPOS.obtenerUsuarios();
            chkuser.DisplayMember = "usu_nombre";

            checkearA = false;
            for (int i = 0; i < chkuser.Items.Count; i++)
            {
                Modelo.Usuarios oUsuario = (Modelo.Usuarios)chkuser.Items[i];
                foreach (Modelo.Usuarios miUsuario in oGRUPO.Usuarios.ToList())
                {
                    if (miUsuario.Id == oUsuario.Id)
                    {
                        chkuser.SetItemChecked(i, true);
                    }
                }
            }
            checkearA = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("Debe ingresar el código del grupo", "ATENCION!!");
                return;
            }

            if (string.IsNullOrEmpty(txtDesc.Text))
            {
                MessageBox.Show("Debe ingresar el nombre del grupo", "ATENCION!!");
                return;
            }

            try
            {

                oGRUPO.gru_descripcion = txtDesc.Text;
                oGRUPO.gru_estado = cbactivo.Checked;
                if (MODO == "A")
                {
                    oGRUPO.gru_codigo = txtCodigo.Text;
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

        private void cmbform_SelectedIndexChanged(object sender, EventArgs e)
        {
            oFormulario = (Modelo.formulario)cmbform.SelectedItem;
            checkedListBox2.DataSource = null;
            checkedListBox2.DataSource = oFormulario.permisoes.ToList();
            checkedListBox2.DisplayMember = "per_descripcion";

            checkear = false;

            for (int i = 0; i < checkedListBox2.Items.Count; i++)
            {
                Modelo.permiso oPermiso = (Modelo.permiso)checkedListBox2.Items[i];
                //var permisosQuery = from oPERFIL in oGRUPO.perfil.ToList()
                //                    where oPERFIL.formulario == oFormulario
                //                    select oPERFIL.permiso.ToList();
                Modelo.perfil oPerfil = oGRUPO.perfils.FirstOrDefault(P => P.formulario == oFormulario);

                if (oPerfil != null)
                {

                    foreach (Modelo.permiso miPermiso in oPerfil.permiso.ToList())
                    {
                        if (miPermiso == oPermiso)
                        {
                            checkedListBox2.SetItemChecked(i, true);
                        }
                    }
                }
            }
            checkear = true;
        }

        private void checkedListBox2_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (checkear == false) return;
            oFormulario = (Modelo.formulario)cmbform.SelectedItem;
            Modelo.permiso oPermiso = (Modelo.permiso)checkedListBox2.SelectedItem;
            Modelo.perfil oPerfil = oGRUPO.perfils.FirstOrDefault(P => P.formulario == oFormulario);
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

        private void chkuser_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (checkear == false) return;

            Modelo.Usuarios oUSUARIO = (Modelo.Usuarios)chkuser.SelectedItem;
            if (e.NewValue == CheckState.Checked)
            {
                oGRUPO.Usuarios.Add(oUSUARIO);
            }
            else
            {
                oGRUPO.Usuarios.Remove(oUSUARIO);
            }
        }

        private void cbactivo_CheckedChanged(object sender, EventArgs e)
        {

        }



    }
}
