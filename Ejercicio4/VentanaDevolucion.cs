using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4
{
    public partial class VentanaDevolucion : Form
    {

        VentanaPrincipal principal = Application.OpenForms.OfType<VentanaPrincipal>().FirstOrDefault();

        public VentanaDevolucion()
        {
            InitializeComponent();
            CargarLista();
            tbLector.Enabled = false;
            FechaPrestamo.Enabled = false;
        }
        public void CargarLista()
        {
            IReadOnlyList<Prestamo> prestamos = principal.ListaPrestamos;
            boxLibros.Items.Clear();
            boxLibros.Text = "Selecciones un Libro";
            foreach (Prestamo lib in prestamos)
            {
                boxLibros.Items.Add(lib);
            }
            boxLibros.DisplayMember = "Titulo";
        }
        private void btAtras_Click(object sender, EventArgs e)
        {
            Point posicionForm = this.Location;
            principal.Location = posicionForm;
            principal.Show();
            this.Close();
        }
        private void boxLibros_SelectedIndexChanged(object sender, EventArgs e)
        {
            IReadOnlyList<Prestamo> prestamos = principal.ListaPrestamos;
            tbLector.Text = prestamos[boxLibros.SelectedIndex].lector.NombreCompleto;
            FechaPrestamo.Value = prestamos[boxLibros.SelectedIndex].fechaPrestamo.Date;
        }
        private void btGuardar_Click(object sender, EventArgs e)
        {
            if (boxLibros.SelectedIndex < 0)
            {
                MessageBox.Show("ERROR, Selecciones un Libro");
            }
            else
            {
                TimeSpan time = FechaDevolucion.Value.Subtract(FechaPrestamo.Value);
                if (time < TimeSpan.Zero)
                {
                    MessageBox.Show("ERROR, Reingrese la fecha");
                }
                else if (time.Days > 15)
                {
                    MessageBox.Show("El libro fue entregado con mas de 15 dias\n Usuario marcado como moroso");
                    principal.CambiaraMoroso(boxLibros.SelectedIndex);
                    principal.RegistrarDevolucion(boxLibros.SelectedIndex);
                    principal.Show();
                    this.Close();
                }
                else
                {
                    principal.RegistrarDevolucion(boxLibros.SelectedIndex);
                    principal.Show();
                    this.Close();
                }


            }
        }
    }
}
