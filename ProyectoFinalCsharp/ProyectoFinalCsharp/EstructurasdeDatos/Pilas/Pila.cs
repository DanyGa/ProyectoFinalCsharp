using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalCsharp.EstructurasdeDatos.Pilas
{
    class Pila
    {
        private NodoPila top;

        public NodoPila Top
        {
            get
            {
                return top;
            }
            set
            {
                top = value;
            }
        }

        public int ContarNodos()
        {
            int contador = 0;
            NodoPila h = top;
            while (h != null)
            {
                contador++;

                h = h.Siguiente;
            }
            return contador;
        }

        public Pila()
        {
            top = null;
        }

        public void Push(NodoPila n)
        {
            n.Siguiente = top;
            top = n;
        }

        public NodoPila Pop()
        {
            NodoPila regreso = null;
            if (top != null)
            {
                top = top.Siguiente;
            }
            return regreso;
        }

        public override string ToString()
        {
            string lista = "";
            NodoPila t = top;
            if (t != null)
            {
                lista += t.ToString();
                t = t.Siguiente;
                while (t != null)
                {
                    lista += "," + t.ToString();
                    t = t.Siguiente;
                }
                lista += ".";
                lista = lista.Replace(".", "");
                return lista;

            }
            else
            {
                return "La lista esta vacia";
            }
        }
    }
}
