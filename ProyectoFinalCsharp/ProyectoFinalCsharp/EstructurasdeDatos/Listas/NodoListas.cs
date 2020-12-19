using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalCsharp.EstructurasdeDatos.Listas
{
    class NodoListas
    {
        private int dato;
        private NodoListas siguiente;
        private NodoListas anterior;

        public int Dato
        {
            get { return dato; }
            set { dato = value; }
        }

        public NodoListas Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }

        public NodoListas Anterior
        {
            get { return anterior; }
            set { anterior = value; }
        }

        public NodoListas(int dato, NodoListas siguiente, NodoListas anterior)
        {
            this.dato = dato;
            this.siguiente = siguiente;
            this.anterior = anterior;
        }

        public NodoListas()
        {
            dato = 0;
            siguiente = null;
            anterior = null;
        }

        public override string ToString()
        {
            return dato + "";
        }
    }
}
