using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CONTROLADORA
{
    public class cPASSWORD
    {
        private static cPASSWORD instancia;
        private Modelo.ModeloContainer oModelo;
        public static cPASSWORD obtenerInstancia()
        {
            if (instancia == null)
                instancia = new cPASSWORD();

            return instancia;
        }
        private cPASSWORD()
        {
            oModelo = Modelo.ModeloContainer.obtenerInstancia();
        }

        public void MODIFICACION(Modelo.Usuarios oUSUARIO)
        {
            oModelo.ApplyCurrentValues("Usuarios", oUSUARIO);
            oModelo.SaveChanges();
        }

    }
}
