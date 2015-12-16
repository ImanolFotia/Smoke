using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace Form_Carga
{
    public partial class frmPRINCIPAL : Form
    {
        Modelo.Usuarios oUSUARIO;
        CONTROLADORA.cPERFIL cPERFIL;
        private Form miFORM;
        public frmPRINCIPAL()
        {
            InitializeComponent();
            cPERFIL = CONTROLADORA.cPERFIL.obtenerInstancia();
        }

        private void frmPRINCIPAL_Load(object sender, EventArgs e)
        {
            frmLOGIN formLOGIN = new frmLOGIN();
            DialogResult drLOGIN = formLOGIN.ShowDialog();

            if (drLOGIN != DialogResult.OK)
            {
                Application.Exit();
                return;
            }
            oUSUARIO = formLOGIN.USUARIO;
            tslUSUARIO.Text = oUSUARIO.usu_nombre;
            //creo un objeto DropDwnButton para cargar los módulos
            //en la barra de menúes del formulario
            ToolStripDropDownButton MENU_MODULO;

            foreach (Modelo.modulo oMODULO in cPERFIL.ObtenerModulos())
            {
                // por cáda módulo creo un objeto ToolStripDropDownButton
                MENU_MODULO = new ToolStripDropDownButton();
                // le asigno los parámetros name y text al objeto
                MENU_MODULO.Name = oMODULO.mod_codigo;
                MENU_MODULO.Text = oMODULO.mod_descripcion;

                //inserto el objeto creado a la barra de menúes del formulario
                msMENU.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { MENU_MODULO });

                //busco las funciones asociadas al formulario
                ARMA_FUNCIONES(oMODULO, MENU_MODULO);
            }
        }
        private void ARMA_FUNCIONES(Modelo.modulo  MODULO, ToolStripDropDownButton MEN_FUNCION)
        {
            //le solicito a la controladora la lista de funciones de
            //un módulo determinado
              // defino un objeto ToolStripMenuItem para asignar las funciones recuperadas
            ToolStripMenuItem MENU_FUNCIONES;

            //recorro el listado de funciones
            foreach (Modelo.formulario oFORM in cPERFIL.obtenerFormularios(oUSUARIO, MODULO))
            {
                // creo el objeto ToolStripMenuItem para cargar la funcion recibida
                MENU_FUNCIONES = new ToolStripMenuItem();
                MENU_FUNCIONES.Name = oFORM.frm_codigo.ToString();
                MENU_FUNCIONES.Text = oFORM.frm_descripcion;
                MENU_FUNCIONES.Tag = oFORM.frm_formulario;

                //agrego la función al módulo asociado
                MEN_FUNCION.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { MENU_FUNCIONES });

                //le asigno el método que tiene que ejecutar cuando se 
                //dispare el evento click de la función
                MENU_FUNCIONES.Click += new EventHandler(this.ITEM_CLICK);
            }
        }

        private void ITEM_CLICK(object sender, EventArgs e)
        {
            // al hacer click en algún objeto ToolStripMenuItem
            // se dispara este evento
            // el atributo sender me permite identificar que opción
            // del menú generó el evento
            ToolStripMenuItem seleccion = (ToolStripMenuItem)sender;
            // si el atributo tag es distinto de 0 es porque tiene definido 
            // el nombre del formulario
            if ((string)seleccion.Tag != "0")
            {
                // le pido al compilador que me recupere todos los elementos del
                // assembly (proyecto VISTA)
                // comienzo a recorrer cada elemento devuelto
                foreach (System.Type type in Assembly.GetExecutingAssembly().GetTypes())
                {
                    //pregunto si es de tipo Formulario
                    if (type.IsSubclassOf(typeof(Form)))
                    {
                        // verifico si el nombre del formulario es igual al
                        // atributo tag que tiene el nombre del formulario
                        // a abrir
                        if (type.Name.ToString() == (string)seleccion.Tag)
                        {
                            try
                            {
                                //si corresponde creo una instancia de ese objeto
                                Type t = type as Type;
                                // aplicando reflection invoco el metodo getINSTANCIA del formulario
                                miFORM = (Form)t.InvokeMember("obtener_instancia", BindingFlags.Default | BindingFlags.Static | BindingFlags.Public | BindingFlags.InvokeMethod | BindingFlags.InvokeMethod, null, null, new object[] { this.oUSUARIO }) as System.Windows.Forms.Form;
                                //ejecuto el método show del formulario para que lo muestre
                                miFORM.Show();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                }
            }
        }        
    }
}
