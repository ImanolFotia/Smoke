using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CONTROLADORA
{
    public class cGrupos
    {
        private static cGrupos instancia;
        private Modelo.ModeloContainer oModelo;
        public static cGrupos obtenerInstancia()
        {
            if (instancia == null)
                instancia = new cGrupos();

            return instancia;
        }
        private cGrupos()
        {
            oModelo = Modelo.ModeloContainer.obtenerInstancia();
        }
        public List<Modelo.grupo> ObtenerGrupos()
        {
            return oModelo.grupoes.ToList();
        }
        public void Alta(Modelo.grupo oGrupo)
        {
            oModelo.AddTogrupoes(oGrupo);
            oModelo.SaveChanges();
        }
        public void Baja(Modelo.grupo oGrupo)
        {
            oModelo.DeleteObject(oGrupo);
            oModelo.SaveChanges();
        }
        public void Modificacion(Modelo.grupo oGrupo)
        {
            oModelo.ApplyCurrentValues("grupos", oGrupo);
            oModelo.SaveChanges();
        }

        public List<Modelo.permiso> obtenerPermisos()
        {
            return oModelo.permisoes.ToList();
        }

        public List<Modelo.formulario> obtenerFormulario()
        {
            return oModelo.formularios.ToList();
        }

        public List<Modelo.Usuarios> obtenerUsuarios()
        {
            return oModelo.Usuarios.ToList();
        }


    }
}
