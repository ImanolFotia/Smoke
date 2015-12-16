using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace CONTROLADORA
{
    public class cLOGIN
    {
        private static cLOGIN instancia;
        private Modelo.ModeloContainer oModelo;
        public static cLOGIN obtenerInstancia()
        {
            if (instancia == null)
                instancia = new cLOGIN();

            return instancia;
        }
        private cLOGIN()
        {
            oModelo = Modelo.ModeloContainer.obtenerInstancia();
        }

        public Modelo.Usuarios LOGIN(string usuario, string password)
        {
            Modelo.Usuarios oUsuario = oModelo.Usuarios.FirstOrDefault(u => u.Id == usuario);

            if (oUsuario == null)
            {
                throw new Exception("El usuario ingresado no se encuentra registrado en el sistema");
            }

            if (oUsuario.Password != password)
            {
                throw new Exception("La contraseña ingresada es incorrecta");
            }

            if (oUsuario.usu_estado == false)
            {
                throw new Exception("El usuario ingresado se encuentra inactivo");
            }


            return oUsuario;
        }

        public string RecuperarMail(string usuario)
        {
            Modelo.Usuarios oUsuario = oModelo.Usuarios.FirstOrDefault(u => u.Id == usuario);

            if (oUsuario == null)
            {
                throw new Exception("El usuario ingresado no se encuentra registrado en el sistema");
            }
            return oUsuario.eMail;
        
        }

        public string RecuperarPassword(string usuario) {

            Modelo.Usuarios oUsuario = oModelo.Usuarios.FirstOrDefault(u => u.Id == usuario);

            if (oUsuario == null)
            {
                throw new Exception("El usuario ingresado no se encuentra registrado en el sistema");
            }

            string key = "smoke";
            byte[] keyArray;
            //convierte el texto en una secuencia de bytes
            byte[] Array_a_Descifrar =
            Convert.FromBase64String(oUsuario.Password);

            //se llama a las clases que tienen los algoritmos
            //de encriptación se le aplica hashing
            //algoritmo MD5
            MD5CryptoServiceProvider hashmd5 =
            new MD5CryptoServiceProvider();

            keyArray = hashmd5.ComputeHash(
            UTF8Encoding.UTF8.GetBytes(key));

            hashmd5.Clear();

            TripleDESCryptoServiceProvider tdes =
            new TripleDESCryptoServiceProvider();

            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform =
            tdes.CreateDecryptor();

            byte[] resultArray =
            cTransform.TransformFinalBlock(Array_a_Descifrar,
            0, Array_a_Descifrar.Length);

            tdes.Clear();
            //se regresa en forma de cadena
            return UTF8Encoding.UTF8.GetString(resultArray);

        
        }

            
        //Auditoria login
        public List<Modelo.AuditoriaLogin> ObtenerAuditoriaLogin()
        {
            return oModelo.AuditoriaLogins.ToList();
        }

        public void AgregarAuditoriaLogin(Modelo.AuditoriaLogin AuditoriaLoginObjeto)
        {
            oModelo.AddToAuditoriaLogins(AuditoriaLoginObjeto);
            oModelo.SaveChanges();
        }


        public void AgregarPago(Modelo.Pagos ObjetoPagos)
        {
            ObjetoPagos.Fecha = DateTime.Now;
            oModelo.AddToPagos(ObjetoPagos);
            oModelo.SaveChanges();
        }


        //Obtener último pago
        public Modelo.Pagos Obtener_Ult_Pago(Modelo.Usuarios Usuario)
        {

            var UP = oModelo.Pagos
                       .OrderByDescending(p => p.Id)
                       .FirstOrDefault();
            return UP;

            //string UID = Usuario.Id;
            //Modelo.Pagos OP = oModelo.Pagos.Where(u => u.Usuario.Id == UID);
            //return OP;
        }


        //Obtiene el objeto del pago mensual para después poder modificarloz
        public Modelo.PagoMensualMonto Obtener_PagoMensual()
        {
            int ID = 1;
            Modelo.PagoMensualMonto OPMM = oModelo.PagoMensualMontoes.FirstOrDefault(u => u.Id == ID);
            return OPMM;
        }


        public void ModificarMonto(Modelo.PagoMensualMonto PagoMensualObjeto)
        {
            oModelo.PagoMensualMontoes.ApplyCurrentValues(PagoMensualObjeto);
            oModelo.SaveChanges();
        }

        //Obtener el monto de pago
        public decimal Obtener_PagoMensualMonto()
        {
            int ID = 1;
            var q = oModelo.PagoMensualMontoes.Where(x => x.Id == ID).Select(x => x.Monto);
            return q.First();
        }

    }
}
