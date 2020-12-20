using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace ProyectoFinalCsharp.AlgoritmosdeOrdenamiento
{
    public partial class ShellSort : Form
    {
        int[] vector;
        int n;
        int min;
        int max;
        int i;

        Stopwatch contador = new Stopwatch();

        public ShellSort()
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

        public int Ordenar(int n)
        {
            int aux;
            int comparaciones = 0;
            int intercambios = 0;
            int j = vector.Length / 2;
            int x;

            while (j > 0)
            {
                x = 1;
                while (x != 0)
                {
                    x = 0;
                    i = 1;
                    while (i <= (vector.Length - j))
                    {
                        comparaciones++;
                        if (vector[i - 1] > vector[(i - 1) + j])
                        {
                            aux = vector[(i - 1) + j];
                            vector[(i - 1) + j] = vector[i - 1];
                            vector[i - 1] = aux;
                            x = 1;
                            intercambios++;
                        }
                        i++;                     
                    }
                }
                j = j / 2; //salto /2... 5/2 = 2

                lblComparaciones.Text = comparaciones.ToString() + " Comparaciones";
                lblIntercambios.Text = intercambios.ToString() + " Intercambios";
            }
            return intercambios;
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

        private void ShellSort_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
