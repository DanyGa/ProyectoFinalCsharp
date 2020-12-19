using System;
using System.Windows.Forms;
using System.IO;

namespace ProyectoFinalCsharp.EstructurasdeDatos.Pilas
{
    public partial class Pilas : Form
    {
        Pila MiPila = new Pila();
        NodoPila n = new NodoPila();
        public Pilas()
        {
            InitializeComponent();
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            NodoPila n = new NodoPila(int.Parse(txtNodo.Text));
            MiPila.Push(n);
            lblPila.Text = MiPila.ToString();
            txtNodo.Clear();
            btnBorrarP.Enabled = true;
            btnContar.Enabled = true;
            btnGuardar.Enabled = true;
        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            MiPila.Pop();
            lblPila.Text = MiPila.ToString();
        }

        private void btnBorrarP_Click(object sender, EventArgs e)
        {
            MiPila.Top = null;
            lblPila.Text = MiPila.ToString();
            btnBorrarP.Enabled = false;
            btnContar.Enabled = false;
            btnGuardar.Enabled = false;
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Número de nodos en la Pila: " + MiPila.ContarNodos());
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog Dialogo = new FolderBrowserDialog();
                if (Dialogo.ShowDialog() == DialogResult.OK)
                {
                    string dato = lblPila.Text;
                    string ruta = Dialogo.SelectedPath + "\\Pila.txt";
                    using (var writer = new StreamWriter(ruta))
                    {
                        writer.Close();
                    }
                    File.WriteAllText(ruta, dato);
                    MessageBox.Show("Datos guardados en el archivo : " + "Pila.txt");
                }
            }
            catch
            {
                MessageBox.Show("Error al guardar");
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog Seleccionar = new OpenFileDialog();
                if (Seleccionar.ShowDialog() == DialogResult.OK)
                {
                    MiPila.Top = null;
                    string ruta = Seleccionar.FileName;
                    string linea = File.ReadAllText(ruta);
                    string[] Pila = linea.Split(',');
                    int contador = Pila.Length - 1;
                    foreach (string i in Pila)
                    {
                        n = new NodoPila();
                        n.Dato = int.Parse(Pila[contador]);
                        MiPila.Push(n);
                        contador--;
                    }
                    lblPila.Text = MiPila.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Error al cargar");
                MiPila.Top = null;
                lblPila.Text = MiPila.ToString();
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MenuPrincipal annyeonghaseyo = new MenuPrincipal();
            annyeonghaseyo.Show();
            Hide();
        }

        private void Pilas_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }       
    }
}
