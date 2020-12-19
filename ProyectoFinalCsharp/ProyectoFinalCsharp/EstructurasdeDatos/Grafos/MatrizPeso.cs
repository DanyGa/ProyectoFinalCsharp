using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalCsharp.EstructurasdeDatos.Grafos
{
    public partial class MatrizPeso : Form
    {
        List<NodoGrafo> Grafo = new List<NodoGrafo>();
        public MatrizPeso()
        {
            InitializeComponent();
        }

        public MatrizPeso(List<NodoGrafo> gr)
        {
            InitializeComponent();
            Grafo = gr;
        }
        private void MatrizPeso_Load(object sender, EventArgs e)
        {
            dgv.ColumnCount = 0;
            dgv.ColumnCount = Grafo.Count;
            dgv.RowCount = 1;
            dgv.RowCount = Grafo.Count;
            for (int i = 0; i < Grafo.Count; i++)
            {
                dgv.Columns[i].Name = i.ToString();
            }

            for (int i = 0; i < Grafo.Count; i++)
            {
                for (int j = 0; j < Grafo.Count; j++)
                {
                    dgv.Rows[i].Cells[j].Value = 0;
                }
            }

            for (int i = 0; i < Grafo.Count; i++)
            {
                for (int j = 0; j < Grafo[i].aristas.Count(); j++)
                {
                    dgv.Rows[i].Cells[Grafo[i].aristas[j].getDestino()].Value = Grafo[i].aristas[j].getPeso();
                }
            }
        }
    }
}
