using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace ProyectoFinalCsharp.AlgoritmosdeOrdenamiento
{
    public partial class RadixSort : Form
    {
        int[] vector;
        int n;
        int min;
        int max;
        int i;
        Stopwatch contador = new Stopwatch();

        public RadixSort()
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
            int[] count = new int[1 << min];
            int[] pref = new int[1 << min];
            int groups = (int)Math.Ceiling((double)max / (double)min);
            int mask = (1 << min) - 1;


            for (int c = 0, shift = 0; c < groups; c++, shift += min)
            {
                for (int j = 0; j < count.Length; j++)
                {
                    
                    count[j] = 0;

                }
                for (int i = 0; i < vector.Length; i++)
                {
                    count[(vector[i] >> shift) & mask]++;
                    
                }
                pref[0] = 0;
                for (int i = 1; i < count.Length; i++)
                {

                    pref[i] = pref[i - 1] + count[i - 1];
                   
                }
                for (int i = 0; i < vector.Length; i++)
                {

                    aux[pref[(vector[i] >> shift) & mask]++] = vector[i];
                    
                }
                aux.CopyTo(vector, 0);
            }

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

        private void RadixSort_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
