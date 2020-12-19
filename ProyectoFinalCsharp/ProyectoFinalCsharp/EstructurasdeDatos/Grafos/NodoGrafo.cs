﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalCsharp.EstructurasdeDatos.Grafos
{
    class NodoGrafo
    {
        public List<Arista> aristas = new List<Arista>();
        int posx;
        int posy;
        int nombre;

        public void llenaNodo(int x, int y)
        {
            posx = x;
            posy = y;
        }
        public void llenanombre(int nomb)
        {
            nombre = nomb;
        }
        public int getnombre()
        {
            return nombre;
        }
        public int getX()
        {
            return posx;
        }

        public int getY()
        {
            return posy;
        }

        public void llenararista(Arista ar)
        {
            aristas.Add(ar);
        }
    }
}
