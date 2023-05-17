using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    public class Libro
    {
        private int codigo;
        public string? titulo;
        public string? autor;
        public string? editorial;

        public bool prestado = false;

        //--------------------Metodos---------------
        public int Codigo { get { return codigo; }set { codigo = value; } }
        public string? Titulo { get {  return titulo; }}
    }
}
