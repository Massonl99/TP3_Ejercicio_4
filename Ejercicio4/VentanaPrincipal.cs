using Microsoft.VisualBasic;
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
    public partial class VentanaPrincipal : Form
    {
        private List<Lector> lectores = new List<Lector>();
        private List<Libro> libros = new List<Libro>();
        private List<Prestamo> prestamos = new List<Prestamo>();

        private int idLector = 0;
        private int idLibro = 0;
        private int idPrestamo = 0;

        public VentanaPrincipal()
        {
            InitializeComponent();
        }
        //------------------------Metodos---------------------------------------- 
        public int IdLector { get { return idLector + 1; } }
        public int IdLibro { get { return idLibro + 1; } }
        public void RegistrarLector(string nombre, string apellido)
        {
            idLector++;
            lectores.Add(new Lector());
            lectores[idLector - 1].ID = idLector;
            lectores[idLector - 1].Nombre = nombre;
            lectores[idLector - 1].Apellido = apellido;
            //hola mundo
        }
        public void RegistrarLibro(string titulo, string autor, string editorial)
        {
            libros.Add(new Libro());
            libros[idLibro].titulo = titulo;
            libros[idLibro].editorial = editorial;
            libros[idLibro].autor = autor;
            idLibro++;
            libros[idLibro - 1].Codigo = idLibro;
        }
        public void RegistrarPrestamo(int idLector, int idLibro, DateTime fecha)
        {
            idPrestamo++;
            prestamos.Add(new Prestamo());
            libros[idLibro].prestado = true;
            prestamos[idPrestamo-1].lector = lectores[idLector];
            prestamos[idPrestamo-1].libro = libros[idLibro];
            prestamos[idPrestamo-1].fechaPrestamo = fecha;
        }
        public void RegistrarDevolucion(int nPrestamo)
        {
            int idBuscado = prestamos[nPrestamo].libro.Codigo;
            foreach (Libro libro in libros)
            {
                if (idBuscado == libro.Codigo)
                {
                    libro.prestado = false;
                    idPrestamo--;
                    break;
                }
            }
            prestamos.RemoveAt(nPrestamo);
        }
        public IReadOnlyList<Libro> ListaLibros
        {
            get { return libros.AsReadOnly(); }
        }
        public IReadOnlyList<Lector> ListaLectores
        {
            get { return lectores.AsReadOnly(); }
        }
        public IReadOnlyList<Prestamo> ListaPrestamos
        {
            get { return prestamos.AsReadOnly(); }
        }
        public bool EsMoroso(int nLector)
        {
            return lectores[nLector].Moroso;
        }
        public void CambiaraMoroso(int nLector)
        {
            lectores[nLector].Moroso = true;
        }

        //------------------------Interacciones con el Form----------------------
        private void btSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btNuevoLibro_Click(object sender, EventArgs e)
        {
            VentanaNuevoLibro ventanaNuevoLibro = new VentanaNuevoLibro();
            ventanaNuevoLibro.Show();
            this.Hide();
        }
        private void btNuevoLector_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaNuevoLector ventanaNuevoLector = new VentanaNuevoLector();
            ventanaNuevoLector.Show();
        }
        private void btPrestamo_Click(object sender, EventArgs e)
        {
            VentanaPrestamo ventanaPrestamo = new VentanaPrestamo();
            ventanaPrestamo.Show();
            this.Hide();
        }
        private void btDevolucion_Click(object sender, EventArgs e)
        {
            VentanaDevolucion ventanaDevolucion = new VentanaDevolucion();  
            ventanaDevolucion.Show();
            this.Hide();
        }
    }
}