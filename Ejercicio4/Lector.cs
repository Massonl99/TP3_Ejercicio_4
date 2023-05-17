using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    public class Lector
    {
        private int numero;
        private string? nombre;
        private string? apellido;
        private bool moroso = false;

        private List<Libro> librosTomados = new List<Libro>();

        //__________________________Metodos_________________________
        public string? NombreCompleto
        {
            get { return $"{apellido} {nombre}"; }
        }
        public int ID { get { return numero; } set { numero = value; } }
        public string? Nombre { get {  return nombre; } set {  nombre = value; } }
        public string? Apellido { get { return apellido; } set { apellido = value; } } 
        public bool Moroso { get { return moroso; } set {  moroso = value; } }
    }
}
