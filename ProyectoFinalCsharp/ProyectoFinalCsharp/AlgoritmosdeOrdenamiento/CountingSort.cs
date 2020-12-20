using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace ProyectoFinalCsharp.AlgoritmosdeOrdenamiento
{
    public partial class CountingSort : Form
    {
        int[] vector;
        int[] Ordenado;
        int n;
        int min;
        int max;
        int i;
        Stopwatch contador = new Stopwatch();

        public CountingSort()
        {
            InitializeComponent();
        }

        public void GenerarDatos(int n, int min, int max)
        {
            vector = new int[n];
            Random aleatorio = new Random();
            for (i = 0; i < vector.Length; i++)
            {
                vector[i] = aleatorio.Next(min, max);

            }
        }

        public void Ordenar(int n)
        {
            int[] aux = new int[vector.Length];            
            int valorMayor = 0;
            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] > valorMayor)
                {
                    valorMayor = vector[i];
                }
            }

            aux = new int[valorMayor + 1];

            for (int i = 0; i < vector.Length; i++)
            {
                int posicion = vector[i];
                aux[posicion]++;
            }

            for (int i = 1; i < aux.Length; i++)
            {
                aux[i] = aux[i - 1] + aux[i];
            }

            for (int i = aux.Length - 1; i != 0; i--)
            {
                aux[i] = aux[i - 1];
            }
            aux[0] = 0;

            Ordenado = new int[vector.Length];
            for (int i = 0; i < vector.Length; i++)
            {
                int valor = vector[i];
                int posicion = aux[valor];
                Ordenado[posicion] = valor;
                aux[valor]++;
            }
            
        }

        public string Mostrar(int[] arreglo)
        {
            string colaString = "";
            colaString += arreglo[0];
            for (int i = 0; i < arreglo.Length - 1; i++)
            {
                colaString += "," + arreglo[i + 1];
            }
            return colaString;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                lblGenerado.Text = "0";
                lblOrdenado.Text = "0";
                lblTiempo.Text = "0:0";
                n = int.Parse(txtNum.Text);
                min = int.Parse(txtMin.Text);
                max = int.Parse(txtMax.Text);
                GenerarDatos(n, min, max);
                lblGenerado.Text = Mostrar(vector);
                btnGenerar.Enabled = false;
                btnOrdenar.Enabled = true;
                txtNum.Clear();
                txtMin.Clear();
                txtMax.Clear();
            }
            catch
            {
                MessageBox.Show("Introduzca un número válido.");
            }
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            contador.Restart();
            Ordenar(n);
            contador.Stop();
            lblTiempo.Text = contador.Elapsed.TotalMilliseconds.ToString() + " Milisegundos";
            lblOrdenado.Text = Mostrar(Ordenado);
            btnGenerar.Enabled = true;
            btnOrdenar.Enabled = false;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MenuPrincipal annyeonghaseyo = new MenuPrincipal();
            annyeonghaseyo.Show();
            Hide();
        }

        private void CountingSort_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        
    }
}
