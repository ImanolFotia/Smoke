using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace CONTROLADORA
{
    public class cPERFIL
    {
        private static cPERFIL instancia;
        private Modelo.ModeloContainer oModelo;
        public static cPERFIL obtenerInstancia()
        {
            if (instancia == null)
                instancia = new cPERFIL();

            return instancia;
        }
        private cPERFIL()
        {
            oModelo = Modelo.ModeloContainer.obtenerInstancia();

            if (oModelo.moduloes.ToList().Count == 0)
            {

                Modelo.modulo oMODULO = new Modelo.modulo();
                oMODULO.mod_codigo = "SEG";
                oMODULO.mod_descripcion = "SEGURIDAD";
                //oModelo.AddTomoduloes(oMODULO);

                Modelo.permiso permisoA = new Modelo.permiso();
                permisoA.per_codigo = "A";
                permisoA.per_descripcion = "ALTA";
                oModelo.AddTopermisoes(permisoA);

                Modelo.permiso permisoB = new Modelo.permiso();
                permisoB.per_codigo = "B";
                permisoB.per_descripcion = "BAJA";
                oModelo.AddTopermisoes(permisoB);

                Modelo.permiso permisoM = new Modelo.permiso();
                permisoM.per_codigo = "M";
                permisoM.per_descripcion = "MODIFICACION";
                oModelo.AddTopermisoes(permisoM);

                Modelo.permiso permisoC = new Modelo.permiso();
                permisoC.per_codigo = "C";
                permisoC.per_descripcion = "CONSULTA";
                oModelo.AddTopermisoes(permisoC);

                Modelo.formulario oFORMULARIO_G = new Modelo.formulario();
                oFORMULARIO_G.frm_descripcion = "GESTION DE GRUPOS";
                oFORMULARIO_G.frm_estado = true;
                oFORMULARIO_G.frm_formulario = "Form_Grupos";
                oFORMULARIO_G.modulo = oMODULO;
                oFORMULARIO_G.permisoes.Add(permisoA);
                oFORMULARIO_G.permisoes.Add(permisoB);
                oFORMULARIO_G.permisoes.Add(permisoM);
                oFORMULARIO_G.permisoes.Add(permisoC);
                oModelo.AddToformularios(oFORMULARIO_G);

                Modelo.formulario oFORMULARIO_U = new Modelo.formulario();
                oFORMULARIO_U.frm_descripcion = "GESTION DE USUARIOS";
                oFORMULARIO_U.frm_estado = true;
                oFORMULARIO_U.frm_formulario = "Form_Usuarios";
                oFORMULARIO_U.modulo = oMODULO;
                oFORMULARIO_U.permisoes.Add(permisoA);
                oFORMULARIO_U.permisoes.Add(permisoB);
                oFORMULARIO_U.permisoes.Add(permisoM);
                oFORMULARIO_U.permisoes.Add(permisoC);
                oModelo.AddToformularios(oFORMULARIO_U);

                Modelo.formulario oFORMULARIO_C = new Modelo.formulario();
                oFORMULARIO_C.frm_descripcion = "CAMBIAR CONTRASEÑA";
                oFORMULARIO_C.frm_estado = true;
                oFORMULARIO_C.frm_formulario = "Form_Password";
                oFORMULARIO_C.modulo = oMODULO;
                oFORMULARIO_C.permisoes.Add(permisoM);
                oModelo.AddToformularios(oFORMULARIO_C);

                Modelo.grupo oGRUPO = new Modelo.grupo();
                oGRUPO.gru_codigo = "ADM";
                oGRUPO.gru_descripcion = "ADMINISTRADORES";
                oGRUPO.gru_estado = true;
                oModelo.AddTogrupoes(oGRUPO);

                Modelo.Usuarios oUSUARIO = new Modelo.Usuarios();
                oUSUARIO.Id = "a";
                oUSUARIO.Nombre = "ADMINISTRADOR";
                
                oUSUARIO.Password = Encriptar("a");
                oUSUARIO.eMail = "admin@empresa.com";
                oUSUARIO.Lenguaje = "Español";
                oUSUARIO.Pais = "Argentina";
                oUSUARIO.usu_Admin = true;
                oUSUARIO.Dev = 1;
                oUSUARIO.usu_estado = true;
                oUSUARIO.grupo.Add(oGRUPO);
                oModelo.AddToUsuarios(oUSUARIO);
                Modelo.Pagos oPago = null;
                oPago = new Modelo.Pagos();
                DateTime fecha = DateTime.Now;
                oPago.Fecha = fecha;
                oPago.Usuario = oUSUARIO;
                oModelo.AddToPagos(oPago);

                Modelo.Usuarios oUSUARIO1 = new Modelo.Usuarios();
                oUSUARIO1.Id = "eaviti";
                oUSUARIO1.Nombre = "Emiliano Agustín Viti";
                oUSUARIO1.Password = Encriptar("eaviti92");
                oUSUARIO1.eMail = "emi_1992_2@hotmail.com";
                oUSUARIO1.Lenguaje = "Español";
                oUSUARIO1.Pais = "Argentina";
                oUSUARIO1.usu_Admin = true;
                oUSUARIO1.Dev = 0;
                oUSUARIO1.usu_estado = true;
                oUSUARIO1.grupo.Add(oGRUPO);
                oModelo.AddToUsuarios(oUSUARIO1);

                Modelo.Usuarios oUSUARIO2 = new Modelo.Usuarios();
                oUSUARIO2.Id = "black_friday_18";
                oUSUARIO2.Nombre = "Imanol Fotia";
                oUSUARIO2.Password = Encriptar("th1rt3en");
                oUSUARIO2.eMail = "imanolfotia@gmail.com";
                oUSUARIO2.Lenguaje = "Español";
                oUSUARIO2.Pais = "Nigeria";
                oUSUARIO2.usu_Admin = true;
                oUSUARIO2.Dev = 0;
                oUSUARIO2.usu_estado = true;
                oUSUARIO2.grupo.Add(oGRUPO);
                oModelo.AddToUsuarios(oUSUARIO2);

                Modelo.Usuarios oUSUARIO23 = new Modelo.Usuarios();
                oUSUARIO23.Id = "SinPermisos";
                oUSUARIO23.Nombre = "No hace nada";
                oUSUARIO23.Password = Encriptar("qwe");
                oUSUARIO23.eMail = "hola.com";
                oUSUARIO23.Lenguaje = "Esperanto";
                oUSUARIO23.Pais = "Costa de Marfil";
                oUSUARIO23.usu_Admin = false;
                oUSUARIO23.Dev = 0;
                oUSUARIO23.usu_estado = true;
                oUSUARIO23.grupo.Add(oGRUPO);
                oModelo.AddToUsuarios(oUSUARIO23);

                Modelo.perfil oPERFIL;

                oPERFIL = new Modelo.perfil();
                oPERFIL.grupo = oGRUPO;
                oPERFIL.formulario = oFORMULARIO_G;
                oPERFIL.permiso.Add(permisoA);
                oPERFIL.permiso.Add(permisoB);
                oPERFIL.permiso.Add(permisoM);
                oPERFIL.permiso.Add(permisoC);
                oModelo.AddToperfils(oPERFIL);
                oPERFIL = null;

                oPERFIL = new Modelo.perfil();
                oPERFIL.grupo = oGRUPO;
                oPERFIL.formulario = oFORMULARIO_U;
                oPERFIL.permiso.Add(permisoA);
                oPERFIL.permiso.Add(permisoB);
                oPERFIL.permiso.Add(permisoM);
                oPERFIL.permiso.Add(permisoC);
                oModelo.AddToperfils(oPERFIL);
                oPERFIL = null;

                oPERFIL = new Modelo.perfil();
                oPERFIL.grupo = oGRUPO;
                oPERFIL.formulario = oFORMULARIO_C;
                oPERFIL.permiso.Add(permisoM);
                oModelo.AddToperfils(oPERFIL);
                oPERFIL = null;

                if (oModelo.PagoMensualMontoes.ToList().Count == 0)
                {
                    Modelo.PagoMensualMonto oPMM = new Modelo.PagoMensualMonto();
                    oPMM.Monto = 150;
                    oPMM.FechaModificacion = DateTime.Now;
                    oPMM.IdUsuario = oUSUARIO.Id;
                    oModelo.AddToPagoMensualMontoes(oPMM);
                }

                oModelo.SaveChanges();
            }
        }

        public static string Encriptar(string input)
        {
            string key = "smoke";


            //arreglo de bytes donde guardaremos la llave
            byte[] keyArray;
            //arreglo de bytes donde guardaremos el texto
            //que vamos a encriptar
            byte[] Arreglo_a_Cifrar =
            UTF8Encoding.UTF8.GetBytes(input);

            //se utilizan las clases de encriptación
            //provistas por el Framework
            //Algoritmo MD5
            MD5CryptoServiceProvider hashmd5 =
            new MD5CryptoServiceProvider();
            //se guarda la llave para que se le realice
            //hashing
            keyArray = hashmd5.ComputeHash(
            UTF8Encoding.UTF8.GetBytes(key));

            hashmd5.Clear();

            //Algoritmo 3DAS
            TripleDESCryptoServiceProvider tdes =
            new TripleDESCryptoServiceProvider();

            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;

            //se empieza con la transformación de la cadena
            ICryptoTransform cTransform =
            tdes.CreateEncryptor();

            //arreglo de bytes donde se guarda la
            //cadena cifrada
            byte[] ArrayResultado =
            cTransform.TransformFinalBlock(Arreglo_a_Cifrar,
            0, Arreglo_a_Cifrar.Length);

            tdes.Clear();

            //se regresa el resultado en forma de una cadena
            return Convert.ToBase64String(ArrayResultado,
            0, ArrayResultado.Length);



        }


        public List<Modelo.modulo> ObtenerModulos()
        {
            return oModelo.moduloes.ToList();
        }

        public List<Modelo.formulario> obtenerFormularios(Modelo.Usuarios Usuario, Modelo.modulo MODULO)
        {
            var contactQuery = from oFRM in oModelo.perfils.ToList()
                               where oFRM.formulario.modulo == MODULO && oFRM.formulario.frm_estado == true && Usuario.grupo.Contains(oFRM.grupo)
                               select oFRM.formulario;

            return (List<Modelo.formulario>)contactQuery.Distinct().ToList();
        }

        public List<Modelo.permiso> obtenerPermisos(Modelo.Usuarios Usuario, string FORMULARIO)
        {
            var contactQuery = from oFRM in oModelo.perfils.ToList()
                               where oFRM.formulario.frm_formulario == FORMULARIO && oFRM.formulario.frm_estado == true && Usuario.grupo.Contains(oFRM.grupo)
                               select oFRM;

            List<Modelo.permiso> Permisos = new List<Modelo.permiso>();
            foreach (Modelo.perfil oP in (List<Modelo.perfil>)contactQuery.ToList())
            {
                foreach (Modelo.permiso Per in oP.permiso.ToList())
                {
                    Permisos.Add(Per);
                }
            }

            return Permisos.Distinct().ToList();
        }

    }
}
