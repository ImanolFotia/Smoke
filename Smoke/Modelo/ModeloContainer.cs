using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public partial class ModeloContainer
    {
        //Singleton
        public static ModeloContainer instancia;
        public static ModeloContainer obtenerInstancia()
        {
            if (instancia == null)
                instancia = new ModeloContainer();

            return instancia;
        }
    }
}
