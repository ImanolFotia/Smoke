using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controladora
{
    public class C_Pagos
    {

        //Aplicación de Singleton
        public static C_Pagos Instancia;
        public static C_Pagos Obtener_Instancia()
        {
            if (Instancia == null) Instancia = new C_Pagos();
            return Instancia;
        }
        Modelo.ModeloContainer oModelo;
        private C_Pagos()
        {
            oModelo = new Modelo.ModeloContainer();
        }
        
        //ABMs
        public void AgregarPago(Modelo.Pagos ObjetoPagos)
        {
            oModelo.Pagos.AddObject(ObjetoPagos);
            oModelo.SaveChanges();
        }
        public void Modificar(Modelo.Pagos Objeto)
        {
            oModelo.Pagos.ApplyCurrentValues(Objeto);
            oModelo.SaveChanges();
        }
        public void Eliminar(Modelo.Pagos Objeto)
        {
            oModelo.Pagos.DeleteObject(Objeto);
            oModelo.SaveChanges();
        }

        public void ModificarMonto(Modelo.PagoMensualMonto PagoMensualObjeto)
        {
            oModelo.PagoMensualMontoes.ApplyCurrentValues(PagoMensualObjeto);
            oModelo.SaveChanges();
        }

        //Listados
        public List<Modelo.Software> Listar_Software()
        {
            return oModelo.Software.ToList();
        }
        public List<Modelo.Usuarios> Listar_Usuarios()
        {
            return oModelo.Usuarios.ToList();
        }
        public List<Modelo.Pagos> Listar_Pagos()
        {
            return oModelo.Pagos.ToList();
        }

        //Obtener el monto de pago
        public decimal Obtener_PagoMensualMonto()
        {
            int ID = 1;
            var q = oModelo.PagoMensualMontoes.Where(x => x.Id == ID).Select(x => x.Monto);
            return q.First();
        }
        //Obtiene el objeto del pago mensual para después poder modificarloz
        public Modelo.PagoMensualMonto Obtener_PagoMensual()
        {
            int ID = 1;
            Modelo.PagoMensualMonto OPMM = oModelo.PagoMensualMontoes.FirstOrDefault(u => u.Id == ID);
            return OPMM;
        }

        //Obtener último pago
        public Modelo.Pagos Obtener_Ult_Pago(Modelo.Usuarios Usuario)
        {

            var UP = oModelo.Pagos
                       .OrderByDescending(p => p.Fecha)
                       .FirstOrDefault();
            return UP;

            //string UID = Usuario.Id;
            //Modelo.Pagos OP = oModelo.Pagos.Where(u => u.Usuario.Id == UID);
            //return OP;
        }
    }
}
