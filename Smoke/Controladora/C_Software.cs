using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controladora
{
    public class C_Software
    {   
        
        //Aplicación de Singleton
        public static C_Software Instancia;
        Modelo.ModeloContainer oModelo;
        public static C_Software Obtener_Instancia()
        {
            if (Instancia == null) Instancia = new C_Software();
            return Instancia;
        }
        private C_Software()
        {
            oModelo = Modelo.ModeloContainer.obtenerInstancia();
        }

        //ABMs

        public void AgregarUsuario(Modelo.Usuarios Objeto)
        {
            oModelo.AddToUsuarios(Objeto);
            oModelo.SaveChanges();
        }
        public void Agregar2(Modelo.Software oSoftware)
        {
            oModelo.AddToSoftware(oSoftware);
            oModelo.SaveChanges();
        }
        public void Agregar(Modelo.Software oSoftware, Modelo.Usuarios Usuario)//Software
        {
            oModelo.Usuarios.AddObject(Usuario);
            oModelo.Software.AddObject(oSoftware);
            oModelo.SaveChanges();
            
        }
        public void Compra(Modelo.UsuarioSoftware oCompra)
        {
            oModelo.UsuarioSoftware.AddObject(oCompra);
            oModelo.SaveChanges();
        }
        public void Modificar(Modelo.Software Objeto)
        {
            oModelo.Software.ApplyCurrentValues(Objeto);
            oModelo.SaveChanges();
        }
        public void Eliminar(Modelo.Software Objeto)
        {
            oModelo.Software.DeleteObject(Objeto);
            oModelo.SaveChanges();
        }

        //Listados
        public List<Modelo.Software> Listar_Software()
        {
            return oModelo.Software.ToList();
        }
        public List<Modelo.UsuarioSoftware> Listar_Compras()
        {
            return oModelo.UsuarioSoftware.ToList();
        }
        public List<Modelo.Usuarios> Listar_Usuarios()
        {
            return oModelo.Usuarios.ToList();
        }
        public List<Modelo.Pagos> Listar_Pagos()
        {
            return oModelo.Pagos.ToList();
        }
        //Query
        public List<Modelo.Software> Obtener_Software(Modelo.Usuarios U_D)
        {
            var eQuery = from o_software in oModelo.Software.ToList()
                         select o_software;
            if (U_D != null) eQuery = eQuery.Where(x => x.Usuario == U_D);
            return (List<Modelo.Software>)eQuery.ToList();
        }
        //Query Compras
        public List<Modelo.UsuarioSoftware> Obtener_Compras(Modelo.Usuarios U_C)
        {
            var eQuery = from o_software in oModelo.UsuarioSoftware.ToList()
                         select o_software;
            if (U_C != null) eQuery = eQuery.Where(x => x.Usuario == U_C);
            return (List<Modelo.UsuarioSoftware>)eQuery.ToList();
        }
        //Query Búsqueda de Software por Nombre
        public List<Modelo.Software> Buscar_Software(string NombreS)
        {
            var eQuery = from OS in oModelo.Software.ToList()
                         select OS;
            if (!string.IsNullOrEmpty(NombreS))
                eQuery = eQuery.Where(x => Convert.ToString(x.Nombre).ToUpper().Contains(NombreS.ToUpper()));
            return (List<Modelo.Software>)eQuery.ToList();
        }
        //Query Búsqueda por Descripción
        public List<Modelo.Software> Buscar_Software_Descripción(string DescS)
        {
            var eQuery = from OS in oModelo.Software.ToList()
                         select OS;
            if (!string.IsNullOrEmpty(DescS))
                eQuery = eQuery.Where(x => Convert.ToString(x.Descripcion).ToUpper().Contains(DescS.ToUpper()));
            return (List<Modelo.Software>)eQuery.ToList();
        }

        /* Auditoria Software
         * Se registra quien subio el software junto con la fecha en el momento de hacerlo
         * */
        public List<Modelo.AuditoriaSoftware> ObtenerAuditoriaSoftware()
        {
            return oModelo.AuditoriaSoftwares.ToList();
        }

        public void AgregarAuditoriaSoftware(Modelo.AuditoriaSoftware AuditoriaSoftwareObjeto)
        {
            oModelo.AddToAuditoriaSoftwares(AuditoriaSoftwareObjeto);
            oModelo.SaveChanges();
        }


    }
}
