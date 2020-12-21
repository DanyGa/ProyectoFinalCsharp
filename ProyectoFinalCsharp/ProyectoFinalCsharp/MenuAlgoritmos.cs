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

        private void btnCounting_Click(object sender, EventArgs e)
        {
            AlgoritmosdeOrdenamiento.CountingSort sam = new AlgoritmosdeOrdenamiento.CountingSort();
            sam.Show();
            Hide();
        }

        private void btnRadix_Click(object sender, EventArgs e)
        {
            AlgoritmosdeOrdenamiento.RadixSort sa = new AlgoritmosdeOrdenamiento.RadixSort();
            sa.Show();
            Hide();
        }

        private void btnShell_Click(object sender, EventArgs e)
        {
            AlgoritmosdeOrdenamiento.ShellSort o = new AlgoritmosdeOrdenamiento.ShellSort();
            o.Show();
            Hide();
        }

        private void MenuAlgoritmos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
