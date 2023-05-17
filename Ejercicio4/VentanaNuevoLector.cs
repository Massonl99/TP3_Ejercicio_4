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
    public partial class VentanaNuevoLector : Form
    {
        private VentanaPrincipal principal = Application.OpenForms.OfType<VentanaPrincipal>().FirstOrDefault();

        public VentanaNuevoLector()
        {
            InitializeComponent();
            tbID.Enabled = false;
            tbID.Text = principal.IdLector.ToString("00000");
            cbMoroso.Enabled = false;
        }

        private void btAtras_Click(object sender, EventArgs e)
        {
            principal.Show();
            this.Close();
        }
        private void btGuardar_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text == "" || textbox.Text == "")
            {
                MessageBox.Show("ERROR, Por Favor Ingrese Nombre y Apellido");
            }
            else
            {
                principal.RegistrarLector(tbNombre.Text, tbApellido.Text);
                principal.Show();
                this.Close();
            }

        }
    }
}
