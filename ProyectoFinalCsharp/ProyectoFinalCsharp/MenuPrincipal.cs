using System;
using System.Windows.Forms;

namespace ProyectoFinalCsharp
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnAlgoritmo_Click(object sender, EventArgs e)
        {
            MenuAlgoritmos abrir = new MenuAlgoritmos();
            abrir.Show();
            Hide();
        }

        private void btnEstructura_Click(object sender, EventArgs e)
        {
            MenuEstructuras aperto = new MenuEstructuras();
            aperto.Show();
            Hide();
        }

        private void MenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
