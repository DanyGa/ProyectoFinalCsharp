using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoFinalCsharp.EstructurasdeDatos.Grafos
{
    public partial class MatrizAdyacencia : Form
    {
        List<NodoGrafo> grafo = new List<NodoGrafo>();
        public MatrizAdyacencia()
        {
            InitializeComponent();
        }
        public MatrizAdyacencia(List<NodoGrafo> gr)
        {
            InitializeComponent();
            grafo = gr;
        }

        private void MatrizAdyacencia_Load(object sender, EventArgs e)
        {
            dgv.ColumnCount = 0;
            dgv.ColumnCount = grafo.Count;
            dgv.RowCount = 1;
            dgv.RowCount = grafo.Count;
            for (int i = 0; i < grafo.Count; i++)
            {
                dgv.Columns[i].Name = i.ToString();

            }

            for (int i = 0; i < grafo.Count; i++)
            {
                for (int j = 0; j < grafo.Count; j++)
                {
                    dgv.Rows[i].Cells[j].Value = 0;
                }
            }

            for (int i = 0; i < grafo.Count; i++)
            {
                for (int j = 0; j < grafo[i].aristas.Count(); j++)
                {
                    dgv.Rows[i].Cells[grafo[i].aristas[j].getDestino()].Value = 1;
                }
            }
        }
    }
}
