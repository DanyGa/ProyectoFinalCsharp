using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public void Ordenar(int[] vector)
        {
            int[] aux = new int[vector.Length];
            int r = 2;
            int b = 32;
            int[] count = new int[1 << r];
            int[] pref = new int[1 << r];
            int comparaciones = 0;
            int intercambios = 0;
            int groups = (int)Math.Ceiling((double)b / (double)r);
            int mask = (1 << r) - 1;


            for (int c = 0, shift = 0; c < groups; c++, shift += r)
            {
                for (int j = 0; j < count.Length; j++)
                {
                    comparaciones++;
                    count[j] = 0;
                    intercambios++;
                }
                for (int i = 0; i < vector.Length; i++)
                {
                    comparaciones++;
                    count[(vector[i] >> shift) & mask]++;
                    intercambios++;
                }
                pref[0] = 0;
                for (int i = 1; i < count.Length; i++)
                {
                    comparaciones++;
                    pref[i] = pref[i - 1] + count[i - 1];
                    intercambios++;
                }
                for (int i = 0; i < vector.Length; i++)
                {
                    comparaciones++;
                    aux[pref[(vector[i] >> shift) & mask]++] = vector[i];
                    intercambios++;
                }
                aux.CopyTo(vector, 0);

                lblComparaciones.Text = comparaciones.ToString() + " Comparaciones";
                lblIntercambios.Text = intercambios.ToString() + " Intercambios";
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
                MessageBox.Show("Introduzca un numero valido");
            }
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            contador.Restart();
            Ordenar(vector);
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
