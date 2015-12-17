using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Windows;
using System.Net.NetworkInformation;

namespace Form_Carga
{
    public partial class Pantalla_Inicio : Form
    {
        Modelo.AuditoriaLogin oAuditoriaLogin;
        Modelo.Usuarios oUSUARIO;
        Modelo.PagoMensualMonto OPMM;
        Modelo.Pagos oUPago;
        Modelo.ModeloContainer oModelo = Modelo.ModeloContainer.obtenerInstancia();
        CONTROLADORA.cPERFIL cPERFIL;
        CONTROLADORA.cLOGIN cLogin;
        Controladora.C_Usuarios cUsuarios;
        Vista.CVisual CVisual = new Vista.CVisual();
        private Form miFORM;
        public Pantalla_Inicio()
        {
            InitializeComponent();
            //por si se cierra el form desde la cruz
            this.FormClosing += Form1_FormClosing;

            // You should replace the bold icon in the sample below
            // with an icon of your own choosing.
            // Note the escape character used (@) when specifying the path.
            //notifyIcon1.Icon =
            //   new System.Drawing.Icon(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal) + @"\Resources\epsilon.ico");
            //notifyIcon1.Visible = true;
            //notifyIcon1.Text = "Smoke";
            cPERFIL = CONTROLADORA.cPERFIL.obtenerInstancia();
            cLogin = CONTROLADORA.cLOGIN.obtenerInstancia();
            cUsuarios = Controladora.C_Usuarios.Obtener_Instancia();
            CVisual.CambioVisual(this);
            desarrolladoresToolStripMenuItem.Visible = false;
        }



        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (oUSUARIO != null)
            {
            oAuditoriaLogin.Logout = DateTime.Now;
            oAuditoriaLogin.Usuario = oUSUARIO;
            oAuditoriaLogin.Id_Usuario = oUSUARIO.Id;
            cLogin.AgregarAuditoriaLogin(oAuditoriaLogin);
            }
        }

        private void btn_Comprar_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Subir_Click(object sender, EventArgs e)
        {
            
        }

        private void Pantalla_Inicio_Load(object sender, EventArgs e)
        {
            //Checkea conexión a internet para iniciar o no el programa
            //Haciendo ping a google.com
            Ping myPing = new Ping();
            String host = "google.com";
            byte[] buffer = new byte[32];
            int timeout = 1000;
            PingOptions pingOptions = new PingOptions();
            try
            {
                PingReply reply = myPing.Send(host, timeout, buffer, pingOptions);
            }
            catch
            {
                MessageBox.Show("No estás conectado a internet, o tu conexión no cumple los requisitos necesarios para que Smoke funcione. Checkea tu conexión e intentalo de nuevo");
                Application.Exit();
                Application.ExitThread();
                this.Close();
            }

            String IPWEB = CVisual.LeerIPWEB();
            string url = IPWEB + "/Smoke/smoke.php";
            webBrowser1.Navigate("localhost/TD/Smoke/smoke.php");
            Form_Login formLOGIN = new Form_Login();
            DialogResult drLOGIN = formLOGIN.ShowDialog();

            if (drLOGIN != DialogResult.OK)
            {
                Application.Exit();
                return;
            }
            oUSUARIO = null;
            oUSUARIO = formLOGIN.USUARIO;
            tslUSUARIO.Text = oUSUARIO.Nombre;
            oAuditoriaLogin = new Modelo.AuditoriaLogin();
            oAuditoriaLogin.Login = DateTime.Now;
            DateTime thisDate = DateTime.Now;
            if (oUSUARIO.Pagos.ToList().Count() > 0)
            {
                oUPago = cLogin.Obtener_Ult_Pago(oUSUARIO);
            }
            else
            {
                oUPago = new Modelo.Pagos();
                oUPago.Fecha = thisDate;
                oUPago.Fecha = thisDate.AddMonths(-1);
            }
            if (1 == 1)
            {
                DateTime DevExpira = thisDate.AddMonths(1);
                DateTime FechaUltPago = oUPago.Fecha.Value;
                int ComparacionFechas = DateTime.Compare(FechaUltPago, DateTime.Now);//<0 = t1 es anterior a t2 >0 t1 es posterior a t2
                if (FechaUltPago < DateTime.Now)
                {
                    oUSUARIO.Dev = 1;
                    oModelo.Usuarios.ApplyCurrentValues(oUSUARIO);
                    oModelo.SaveChanges();
                }
                else if (FechaUltPago > DateTime.Now)
                {
                    oUSUARIO.Dev = 2;
                    MessageBox.Show("Recordá que tu suscripción ya venció");
                    oModelo.Usuarios.ApplyCurrentValues(oUSUARIO);
                    oModelo.SaveChanges();
                }
            }

            //Strategy
            if (oUSUARIO.usu_Admin != true)
            {
                desarrolladoresToolStripMenuItem.Visible = false;
                dev0menu.Visible = true;
                if (oUSUARIO.Dev == 1) desarrolladoresToolStripMenuItem.Visible = true;
                if (oUSUARIO.Dev == 2) desarrolladoresToolStripMenuItem.Visible = true;
                if (oUSUARIO.Dev == 0) desarrolladoresToolStripMenuItem.Visible = false;
                Administracion_Menu.Visible = false;
            }

            //creo un objeto DropDwnButton para cargar los módulos
            //en la barra de menúes del formulario
            if (oUSUARIO.usu_Admin == true)
            {
                desarrolladoresToolStripMenuItem.Visible = true;
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
        }

        private void ARMA_FUNCIONES(Modelo.modulo MODULO, ToolStripDropDownButton MEN_FUNCION)
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
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void tableroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Tablero frm_tab = new Form_Tablero();
            frm_tab.Show();
        }

        private void estadisticasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void msMENU_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tiendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Compra_1 form = new Form_Compra_1(oUSUARIO);
            DialogResult dr = form.ShowDialog();
            this.Hide();
            if (dr == DialogResult.OK) this.Show();
        }

        private void desarrolladoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime FechaUltPago = oUPago.Fecha.Value;
            FechaUltPago = FechaUltPago.AddMonths(1);

            if (FechaUltPago < DateTime.Now)
            {
                oUSUARIO.Dev = 2;
                oModelo.Usuarios.ApplyCurrentValues(oUSUARIO);
                oModelo.SaveChanges();
                MessageBox.Show("Tu suscripción ya venció, para seguir subiendo software deberás realizar tu pago mensual");
                return;
            }

            if (oUSUARIO.Dev == 0)
            {
                oUSUARIO.Dev = 2;
                oModelo.Usuarios.ApplyCurrentValues(oUSUARIO);
                oModelo.SaveChanges();
                MessageBox.Show("Usted no es Desarrollador, por favor pague el impuesto mensual. Gracias.");
                return;
            }


            Form_TyC form = new Form_TyC(oUSUARIO);
            DialogResult dr = form.ShowDialog();
            this.Hide();
            if (dr == DialogResult.OK) this.Show();
        }

        private void dev0menu_Click(object sender, EventArgs e)
        {

        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            oAuditoriaLogin.Logout = DateTime.Now;
            cLogin.AgregarAuditoriaLogin(oAuditoriaLogin);
            this.Close();
        }



        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        private void softwareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Auditoria_Software form = new Form_Auditoria_Software();
            DialogResult dr = form.ShowDialog();
            this.Hide();
            if (dr == DialogResult.OK) this.Show();
        }

        private void pagoMensualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Auditoria_Pagos form = new Form_Auditoria_Pagos();
            DialogResult dr = form.ShowDialog();
            this.Hide();
            if (dr == DialogResult.OK) this.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Auditoria_Usuarios form = new Form_Auditoria_Usuarios();
            DialogResult dr = form.ShowDialog();
            this.Hide();
            if (dr == DialogResult.OK) this.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Auditoria_Login form = new Form_Auditoria_Login();
            DialogResult dr = form.ShowDialog();
            this.Hide();
            if (dr == DialogResult.OK) this.Show();
        }

        private void misComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cargarCréditoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            decimal Credito_Deseado;
            int TipoPago = 0; //0 = cargar crédito, 1 = pago mensual
            string entrada = Microsoft.VisualBasic.Interaction.InputBox("¿Cuanto crédito querés cargar?");
            if (Decimal.TryParse(entrada, out Credito_Deseado))
            {
                decimal Pago = Convert.ToDecimal(Credito_Deseado);
                Form_Pago form = new Form_Pago(oUSUARIO, Pago, TipoPago);
                DialogResult dr = form.ShowDialog();
                this.Hide();
                if (dr == DialogResult.OK) this.Show();
            }
            else
            {
                if (entrada != "")
                {
                    MessageBox.Show("Tenés que ingresar un valor decimal");
                    return;
                }
            }
        }

        private void softwareCompradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Compras form = new Form_Compras(oUSUARIO);
            DialogResult dr = form.ShowDialog();
            this.Hide();
            if (dr == DialogResult.OK) this.Show();
        }

        private void informaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Monto = Convert.ToString(cLogin.Obtener_PagoMensualMonto());
            MessageBox.Show("Te informamos que para ser desarrollador deberás pagar un monto mensual de $" + Monto + "." + Environment.NewLine + "Este monto incluye revisión antivirus del software, subidas ilimitadas por mes, y la publicación de tu software en nuestra plataforma." + Environment.NewLine + "Muchas gracias por elegirnos, el equipo de Smoke.");
        }

        private void pagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (oUSUARIO.Dev == 1)
            {
                DateTime vencimiento;
                vencimiento = oUPago.Fecha.Value;
                vencimiento = vencimiento.AddMonths(1);                
                string fechavencimiento = vencimiento.ToString();
                MessageBox.Show("Tu suscripción mensual está activa. Recordá que vence el:" + Environment.NewLine + fechavencimiento + Environment.NewLine + "Deberas reiniciar la aplicacion para que los cambios surtan efecto");
                return;
            }
            int TipoPago = 1; //0 = cargar crédito, 1 = pago mensual
            decimal Monto = cLogin.Obtener_PagoMensualMonto();
            Form_Pago form = new Form_Pago(oUSUARIO, Monto, TipoPago);
            DialogResult dr = form.ShowDialog();
            this.Hide();
            if (dr == DialogResult.OK) this.Show();
        }

        private void verificarÚltimoPagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime vencimiento;
            vencimiento = oUPago.Fecha.Value;
            vencimiento = vencimiento.AddMonths(1);                
            string fechavencimiento = vencimiento.ToString();
            MessageBox.Show("Tu suscripción mensual vence el:" + Environment.NewLine + fechavencimiento);
        }

        private void cuantoCréditoTengoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (oUSUARIO.Credito != null)
            {
                string CreditoActual = oUSUARIO.Credito.ToString();
                MessageBox.Show("Actualmente tu crédito es de $" + CreditoActual + ".");
            }
            else MessageBox.Show("Actualmente no tenés crédito en Smoke");
        }

        private void cambiarPagoMensualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            decimal Pago_Deseado;
            string entrada = Microsoft.VisualBasic.Interaction.InputBox("Nuevo monto de pago mensual:");
            if (Decimal.TryParse(entrada, out Pago_Deseado))
            {
                OPMM = new Modelo.PagoMensualMonto();
                OPMM.FechaModificacion = DateTime.Now;
                OPMM.IdUsuario = oUSUARIO.Id;
                OPMM.Monto = Pago_Deseado;
                cLogin.AgregarMonto(OPMM);
                string PMM = OPMM.Monto.ToString();
                OPMM = null;
                MessageBox.Show("Pago mensual modificado." + Environment.NewLine + "Monto actual: $" + PMM + ".");
            }
            else
            {
                if (entrada != "")
                {
                    MessageBox.Show("Tenés que ingresar un valor decimal");
                    return;
                }
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.ProcessStartInfo proc = new System.Diagnostics.ProcessStartInfo();
            //proc.FileName = @"C:\windows\system32\cmd.exe";
            //proc.Arguments = "/c cd .. & cd .. & cd .. & cd .. && C:/Program Files/Git/cmd/git.exe add . && C:/Program Files/Git/cmd/git.exe commit -m 'backup' && C:/Program Files/Git/cmd/git.exe push Smoke master & pause";
            //System.Diagnostics.Process.Start(proc);
        }





    }
}
