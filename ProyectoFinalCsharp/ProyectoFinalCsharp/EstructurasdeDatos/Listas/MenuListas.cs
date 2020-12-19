using System;
using System.Windows.Forms;

namespace ProyectoFinalCsharp.EstructurasdeDatos.Listas
{
    public partial class MenuListas : Form
    {
        public MenuListas()
        {
            InitializeComponent();
        }

        private void btnSimple_Click(object sender, EventArgs e)
        {
            ListaSimple.ListaSimple wolyoil = new ListaSimple.ListaSimple();
            wolyoil.Show();
            Hide();
        }

        private void btnSCircular_Click(object sender, EventArgs e)
        {
            ListaSimpleCircular.ListaSimpleCircular hwayoil = new ListaSimpleCircular.ListaSimpleCircular();
            hwayoil.Show();
            Hide();
        }

        private void btnDoble_Click(object sender, EventArgs e)
        {
            ListaDoble.ListaDoble suyoil = new ListaDoble.ListaDoble();
            suyoil.Show();
            Hide();
        }

        private void btnDCircular_Click(object sender, EventArgs e)
        {
            ListaDobleCircular.ListaDobleCircular mokyoil = new ListaDobleCircular.ListaDobleCircular();
            mokyoil.Show();
            Hide();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MenuPrincipal annyeonghaseyo = new MenuPrincipal();
            annyeonghaseyo.Show();
            Hide();
        }

        private void MenuListas_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
