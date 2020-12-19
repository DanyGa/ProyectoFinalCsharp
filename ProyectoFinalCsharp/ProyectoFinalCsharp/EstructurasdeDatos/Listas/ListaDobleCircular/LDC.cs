using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalCsharp.EstructurasdeDatos.Listas.ListaDobleCircular
{
    class LDC
    {
        private NodoListas head;
        public NodoListas Head
        {
            get { return head; }
            set { head = value; }
        }
        public LDC()
        {
            head = null;
        }
        public LDC(NodoListas n)
        {
            head = n;
            n.Anterior = head;
            n.Siguiente = head;
        }
        public bool Agregar(NodoListas n)
        {
            NodoListas h = head;
            if (head == null)
            {

                n.Anterior = n;
                n.Siguiente = n;
                head = n;
                return true;
            }
            if (BuscarDato(n.Dato))
            {
                return false;
            }

            if (n.Dato < head.Dato)
            {
                head.Anterior.Siguiente = n;
                n.Anterior = head.Anterior;
                n.Siguiente = head;
                head.Anterior = n;
                head = n;
                return true;

            }
            do
            {
                if (n.Dato < h.Siguiente.Dato)
                {
                    break;
                }
                h = h.Siguiente;
            } while (h != head);
            if (n.Dato < h.Siguiente.Dato)
            {
                h.Siguiente.Anterior = n;
                n.Anterior = h;
                n.Siguiente = h.Siguiente;
                h.Siguiente = n;
            }
            else
            {
                n.Siguiente = h;
                n.Anterior = h.Anterior;
                h.Anterior.Siguiente = n;
                h.Anterior = n;
            }
            return true;
        }

        public bool Eliminar(int dato)
        {
            if (BuscarDato(dato))
            {
                NodoListas h = head;

                while (h.Siguiente != head)
                {
                    if (h.Dato == dato)
                    {
                        break;
                    }

                    h = h.Siguiente;
                }
                h.Anterior.Siguiente = h.Siguiente;
                h.Siguiente.Anterior = h.Anterior;
                if (h == head)
                {

                    head = head.Siguiente;


                }

                return true;

            }
            return false;
        }

        public override string ToString()
        {
            string lista = "";
            NodoListas h = head;
            if (h != null)
            {
                do
                {
                    lista += h.Dato + ", ";
                    h = h.Siguiente;
                } while (h != head);
                lista += ".";
                lista = lista.Replace(", .", "");
                return lista;
            }
            else
            {
                return "La lista está vacía";
            }
        }

        public bool BuscarDato(int a)
        {
            NodoListas h = head;
            if (h != null)
            {
                do
                {
                    if (h.Dato == a)
                    {
                        return true;
                    }
                    h = h.Siguiente;
                } while (h != head);
            }
            return false;
        }
        public int ContarNodos()
        {
            int contador = 0;
            NodoListas h = head;
            do
            {
                contador++;
                h = h.Siguiente;
            } while (h != head);
            return contador;
        }
             
        
    }
}
