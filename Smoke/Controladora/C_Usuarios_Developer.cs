using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controladora
{
    class C_Usuarios_Developer
    {

        //Aplicación de Singleton
        public static C_Usuarios_Developer Instancia;
        public static C_Usuarios_Developer Obtener_Instancia()
        {
            if (Instancia == null) Instancia = new C_Usuarios_Developer();
            return Instancia;
        }
        Modelo.Modelo_Contenedor oModelo;
        private C_Usuarios_Developer()
        {
            oModelo = new Modelo.Modelo_Contenedor();
        }
        
        //ABMs
        public void Agregar(Modelo.Software Objeto)
        {
            oModelo.Softwares.AddObject(Objeto);
            oModelo.SaveChanges();
        }
        public void Modificar(Modelo.Software Objeto)
        {
            oModelo.Softwares.ApplyCurrentValues(Objeto);
            oModelo.SaveChanges();
        }
        public void Eliminar(Modelo.Software Objeto)
        {
            oModelo.Softwares.DeleteObject(Objeto);
            oModelo.SaveChanges();
        }

        //Listados
        public List<Modelo.Software> Listar_Software()
        {
            return oModelo.Softwares.ToList();
        }
        public List<Modelo.Usuarios> Listar_Usuarios()
        {
            return oModelo.Usuarios.ToList();
        }
        public List<Modelo.Usuarios_Developer> Listar_Usuarios_Developer()
        {
            return oModelo.Usuarios_Developer.ToList();
        }
        public List<Modelo.Pagos> Listar_Pagos()
        {
            return oModelo.Pagos.ToList();
        }
    }
}
