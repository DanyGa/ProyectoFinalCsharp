using System;
using System.Windows.Forms;
using System.IO;

namespace ProyectoFinalCsharp.EstructurasdeDatos.Listas.ListaSimpleCircular
{
    public partial class ListaSimpleCircular : Form
    {
        NodoListas n;
        LSC MiLista = new LSC();
        public ListaSimpleCircular()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!MiLista.BuscarDato(int.Parse(txtNodo.Text)))
                {
                    n = new NodoListas();
                    n.Dato = int.Parse(txtNodo.Text);
                    MiLista.Agregar(n);
                    lblLista.Text = MiLista.ToString();
                    txtNodo.Clear();
                    btnBorrarL.Enabled = true;
                    btnContar.Enabled = true;
                    btnGuardar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("El dato ya existe en la lista.");
                    txtNodo.Clear();
                }
            }
            catch
            {
                MessageBox.Show("Introduzca un número válido.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int dato = int.Parse(txtNodo.Text);

                if (!MiLista.BuscarDato(dato))
                {
                    MessageBox.Show("No se encontró el dato");
                    lblLista.Text = MiLista.ToString();
                    txtNodo.Clear();
                }
                MiLista.Eliminar(dato);
                lblLista.Text = MiLista.ToString();
                txtNodo.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Introduzca un número válido.");
            }
        }

        private void btnBorrarL_Click(object sender, EventArgs e)
        {
            MiLista.Head = null;
            lblLista.Text = MiLista.ToString();
            btnBorrarL.Enabled = false;
            btnContar.Enabled = false;
            btnGuardar.Enabled = false;
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Número de nodos en la lista: " + MiLista.ContarNodos());
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog Dialogo = new FolderBrowserDialog();
            if (Dialogo.ShowDialog() == DialogResult.OK)
            {
                string dato = lblLista.Text;
                string ruta = Dialogo.SelectedPath + "\\Lista.txt";
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
                MiLista.Head = null;
                int contador = 0;
                string ruta = Seleccionar.FileName;
                string linea = File.ReadAllText(ruta);
                string[] Lista = linea.Split(',');
                foreach (string i in Lista)
                {
                    n = new NodoListas();
                    n.Dato = int.Parse(Lista[contador]);
                    MiLista.Agregar(n);
                    lblLista.Text = MiLista.ToString();
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

        private void ListaSimpleCircular_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
