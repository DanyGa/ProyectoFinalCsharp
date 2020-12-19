using System;
using System.Windows.Forms;

namespace ProyectoFinalCsharp
{
    public partial class MenuAlgoritmos : Form
    {
        public MenuAlgoritmos()
        {
            InitializeComponent();
        }

        private void btnBubble_Click(object sender, EventArgs e)
        {
            AlgoritmosdeOrdenamiento.BubbleSort il = new AlgoritmosdeOrdenamiento.BubbleSort();
            il.Show();
            Hide();
        }

        private void btnCocktail_Click(object sender, EventArgs e)
        {
            AlgoritmosdeOrdenamiento.CocktailSort i = new AlgoritmosdeOrdenamiento.CocktailSort();
            i.Show();
            Hide();
        }

        private void btnInsertion_Click(object sender, EventArgs e)
        {
            AlgoritmosdeOrdenamiento.InsertionSort sam = new AlgoritmosdeOrdenamiento.InsertionSort();
            sam.Show();
            Hide();
        }

        private void btnCounting_Click(object sender, EventArgs e)
        {
            AlgoritmosdeOrdenamiento.CountingSort o = new AlgoritmosdeOrdenamiento.CountingSort();
            o.Show();
            Hide();
        }

        private void btnRadix_Click(object sender, EventArgs e)
        {
            AlgoritmosdeOrdenamiento.RadixSort pal = new AlgoritmosdeOrdenamiento.RadixSort();
            pal.Show();
            Hide();
        }

        private void btnShell_Click(object sender, EventArgs e)
        {
            AlgoritmosdeOrdenamiento.ShellSort gu = new AlgoritmosdeOrdenamiento.ShellSort();
            gu.Show();
            Hide();
        }

        private void MenuAlgoritmos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
