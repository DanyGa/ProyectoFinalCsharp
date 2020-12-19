using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalCsharp.EstructurasdeDatos.Pilas
{
    class NodoPila
    {
        private int dato;

        public int Dato
        {
            get
            {
                return dato;
            }
            set
            {
                dato = value;
            }
        }

        private NodoPila siguiente;

        public NodoPila Siguiente
        {
            get
            {
                return siguiente;
            }
            set
            {
                siguiente = value;
            }
        }

        public NodoPila()
        {
            dato = 0;
            siguiente = null;
        }

        public NodoPila(int d)
        {
            dato = d;
            siguiente = null;
        }

        public NodoPila(int d, NodoPila s)
        {
            dato = d;
            siguiente = s;
        }

        public NodoPila(NodoPila n)
        {
            dato = n.dato;
            siguiente = n.siguiente;
        }

        public override string ToString()
        {
            return dato + "";
        }
    }
}
