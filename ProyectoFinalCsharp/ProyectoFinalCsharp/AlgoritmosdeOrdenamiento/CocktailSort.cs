using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace ProyectoFinalCsharp.AlgoritmosdeOrdenamiento
{
    public partial class CocktailSort : Form
    {
        int[] vector;
        int n;
        int min;
        int max;
        int i;
        Stopwatch contador = new Stopwatch();

        public CocktailSort()
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

            int der = vector.Length - 1;
            int izq = 0;
            int ultimo = 0;
            int aux;
            int comparaciones = 0;
            int intercambios = 0;
            do
            {
                //recorrido a la derecha
                for (int i = izq; i < der; i++)
                {
                    comparaciones++;
                    if (vector[i] > vector[i + 1])
                    {
                        aux = vector[i];
                        vector[i] = vector[i + 1];
                        vector[i + 1] = aux;
                        ultimo = i;
                        intercambios++;
                    }
                }
                der = ultimo;

                //recorrido a la izq
                for (int j = der; j > izq; j--)
                {
                    comparaciones++;
                    if (vector[j - 1] > vector[j])
                    {
                        aux = vector[j];
                        vector[j] = vector[j - 1];
                        vector[j - 1] = aux;
                        ultimo = j;
                        intercambios++;
                    }

                }
                izq = ultimo;

            } while (izq < der);

            lblComparaciones.Text = comparaciones.ToString() + " Comparaciones";
            lblIntercambios.Text = intercambios.ToString() + " Intercambios";
            return;
        }

        public void Mostrar(ListBox l)
        {
            for (i = 0; i < vector.Length; i++)
            {
                l.Items.Add(vector[i]);
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                lbNum.Items.Clear();
                lbOrd.Items.Clear();
                n = int.Parse(txtNum.Text);
                min = int.Parse(txtMin.Text);
                max = int.Parse(txtMax.Text);
                GenerarDatos(n, min, max);
                Mostrar(lbNum);
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
            lblOrdenar.Text = contador.Elapsed.TotalMilliseconds.ToString() + " Milisegundos";
            Mostrar(lbOrd);
            btnGenerar.Enabled = true;
            btnOrdenar.Enabled = false;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MenuPrincipal annyeonghaseyo = new MenuPrincipal();
            annyeonghaseyo.Show();
            Hide();
        }

        private void CocktailSort_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }      
    }
}
