using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Ejercicio4
{
    public class Prestamo
    {
        public Lector lector;
        public Libro libro;
        public DateTime fechaPrestamo;
        public DateTime fechaDevolucion;

        public string Titulo
        {
            get {return libro.Titulo.ToString(); }
        }
    }
}
