using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controladora
{
    public class C_Usuarios
    {

        //Aplicación de Singleton
        public static C_Usuarios Instancia;
        Modelo.ModeloContainer oModelo;
        public static C_Usuarios Obtener_Instancia()
        {
            if (Instancia == null) Instancia = new C_Usuarios();
            return Instancia;
        }

        private C_Usuarios()
        {
            oModelo = new Modelo.ModeloContainer();
        }

        //

        //ABMs
        public void Agregar(Modelo.Usuarios Objeto)
        {
            oModelo.AddToUsuarios(Objeto);
            oModelo.SaveChanges();
        }

        public void AgregarPago(Modelo.Pagos ObjetoPagos)
        {
            oModelo.Pagos.AddObject(ObjetoPagos);
            oModelo.SaveChanges();
        }

        public void Modificar(Modelo.Usuarios ObjetoModificarUsuario)
        {
            oModelo.Usuarios.ApplyCurrentValues(ObjetoModificarUsuario);
            oModelo.SaveChanges();
        }
        public void Eliminar(Modelo.Usuarios Objeto)
        {
            oModelo.Usuarios.DeleteObject(Objeto);
            oModelo.SaveChanges();
        }

        public decimal Obtener_PagoMensualMonto()
        {

            var UP = oModelo.PagoMensualMontoes
           .OrderByDescending(p => p.Id)
           .FirstOrDefault();
            return UP.Monto;
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
        public List<Modelo.grupo> ObtenerGrupos()
        {
            return oModelo.grupoes.ToList();
        }
        
    }
}
