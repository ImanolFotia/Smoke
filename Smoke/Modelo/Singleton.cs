using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class Singleton
    {
        private static Singleton Obtener_Instancia;
        private Singleton() { }
        public static Singleton Instancia
        {
            get
            {
                if (Obtener_Instancia == null) Obtener_Instancia = new Singleton();
                return Instancia;
            }
        }
        
    }
}
