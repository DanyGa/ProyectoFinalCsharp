using System;
using System.Windows.Forms;
using System.IO;

namespace ProyectoFinalCsharp.EstructurasdeDatos.Colas
{
    public partial class Colas : Form
    {
        NodoCola n;
        Cola MiCola = new Cola();
        public Colas()
        {
            InitializeComponent();
        }

        private void btnEncolar_Click(object sender, EventArgs e)
        {
            try
            {
                n = new NodoCola();
                n.Dato = int.Parse(txtNodo.Text);
                MiCola.Encolar(n);
                lblCola.Text = MiCola.ToString();
                txtNodo.Clear();
                btnBorrarC.Enabled = true;
                btnConsultar.Enabled = true;
                btnGuardar.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Introduzca un número válido.");
            }
        }

        private void btnDesencolar_Click(object sender, EventArgs e)
        {
            MiCola.Desencolar();
            lblCola.Text = MiCola.ToString();
        }

        private void btnBorrarC_Click(object sender, EventArgs e)
        {
            MiCola.Head = null;
            lblCola.Text = MiCola.ToString();
            btnBorrarC.Enabled = false;
            btnConsultar.Enabled = false;
            btnGuardar.Enabled = false;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El dato frontal es : " + MiCola.Front());
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog Dialogo = new FolderBrowserDialog();
            if (Dialogo.ShowDialog() == DialogResult.OK)
            {
                string dato = lblCola.Text;
                string ruta = Dialogo.SelectedPath + "\\Cola.txt";
                using (var writer = new StreamWriter(ruta))
                {
                    writer.Close();
                }
                File.WriteAllText(ruta, dato);
                MessageBox.Show("Datos guardados.");
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog Seleccionar = new OpenFileDialog();
            if (Seleccionar.ShowDialog() == DialogResult.OK)
            {
                MiCola.Head = null;
                int contador = 0;
                string ruta = Seleccionar.FileName;
                string linea = File.ReadAllText(ruta);
                string[] Lista = linea.Split(',');
                foreach (string i in Lista)
                {
                    n = new NodoCola();
                    n.Dato = int.Parse(Lista[contador]);
                    MiCola.Encolar(n);
                    lblCola.Text = MiCola.ToString();
                    contador++;
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MenuPrincipal annyeonghaseyo = new MenuPrincipal();
            annyeonghaseyo.Show();
            Hide();
        }

        private void Colas_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
