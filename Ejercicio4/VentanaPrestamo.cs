using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4
{
    public partial class VentanaPrestamo : Form
    {
        private VentanaPrincipal? principal = Application.OpenForms.OfType<VentanaPrincipal>().FirstOrDefault();


        public VentanaPrestamo()
        {
            InitializeComponent();
            CargarLectores();
            CargarLibros();

            cbMoroso.Enabled = false;
            cbPrestado.Enabled = false;
        }

        public void CargarLibros()
        {
            IReadOnlyList<Libro> libros = principal.ListaLibros;
            boxLibros.Items.Clear();
            boxLibros.Text = "Selecciones un Libro";
            foreach (Libro libro in libros)
            {
                boxLibros.Items.Add(libro);
            }
            boxLibros.DisplayMember = "titulo";
        }
        public void CargarLectores()
        {
            IReadOnlyList<Lector> lectors = principal.ListaLectores;
            boxLectores.Items.Clear();
            boxLectores.Text = "Selecciones al Lector";
            foreach (Lector lector in lectors)
            {
                boxLectores.Items.Add(lector);
            }
            boxLectores.DisplayMember = "NombreCompleto";
        }

        private void btAtras_Click(object sender, EventArgs e)
        {
            Point posicionForm = this.Location;
            principal.Location = posicionForm;
            principal?.Show();
            this.Close();
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            if (boxLectores.SelectedIndex < 0 || boxLibros.SelectedIndex < 0)
            {
                MessageBox.Show("ERROR , Seleccione al Lector y un Libro");
            }
            else
            {
                if (cbPrestado.Checked == true)
                {
                    MessageBox.Show("ERROR, Libro prestado");
                }
                else
                {
                    Point posicionForm = this.Location;
                    principal.Location = posicionForm;
                    principal.RegistrarPrestamo(boxLectores.SelectedIndex, boxLibros.SelectedIndex, FechaPrestamo.Value.Date);
                    principal.Show();
                    this.Close();
                }
            }
        }

        private void boxLectores_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbMoroso.Checked = principal.EsMoroso(boxLectores.SelectedIndex);
        }

        private void boxLibros_SelectedIndexChanged(object sender, EventArgs e)
        {
            IReadOnlyList<Libro> libros = principal.ListaLibros;
            cbPrestado.Checked = libros[boxLibros.SelectedIndex].prestado;
        }
    }
}
