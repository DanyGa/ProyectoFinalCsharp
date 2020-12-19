using System;
using System.Windows.Forms;

namespace ProyectoFinalCsharp
{
    public partial class MenuEstructuras : Form
    {
        public MenuEstructuras()
        {
            InitializeComponent();
        }

        private void btnListas_Click(object sender, EventArgs e)
        {
            EstructurasdeDatos.Listas.MenuListas hana = new EstructurasdeDatos.Listas.MenuListas();
            hana.Show();
            Hide();
        }

        private void btnPila_Click(object sender, EventArgs e)
        {
            EstructurasdeDatos.Pilas.Pilas dul = new EstructurasdeDatos.Pilas.Pilas();
            dul.Show();
            Hide();
        }

        private void btnCola_Click(object sender, EventArgs e)
        {
            EstructurasdeDatos.Colas.Colas set = new EstructurasdeDatos.Colas.Colas();
            set.Show();
            Hide();
        }

        private void btnGrafo_Click(object sender, EventArgs e)
        {

        }

        private void btnArbol_Click(object sender, EventArgs e)
        {
            EstructurasdeDatos.Arboles.Arbol daseot = new EstructurasdeDatos.Arboles.Arbol();
            daseot.Show();
            Hide();
        }

        private void MenuEstructuras_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
