using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4
{
    public partial class VentanaNuevoLibro : Form
    {
        private VentanaPrincipal? principal = Application.OpenForms.OfType<VentanaPrincipal>().FirstOrDefault();
        

        public VentanaNuevoLibro()
        {
            InitializeComponent();
            tbID.Enabled = false;
            tbID.Text = principal?.IdLibro.ToString("000000");
        }
        private void btAtras_Click(object sender, EventArgs e)
        {
            principal?.Show();
            this.Close();
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            if (tbAutor.Text == "" || tbTitulo.Text == "" || tbEditorial.Text == "")
            {
                MessageBox.Show("ERROR, Por Favor Rellene todos los campos");
            }
            else
            {
                principal?.RegistrarLibro(tbTitulo.Text,tbAutor.Text,tbEditorial.Text);
                principal?.Show();
                this.Close();
            }
        }
    }
}
