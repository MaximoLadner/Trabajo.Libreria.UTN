using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajoParaElViernes.clases
{
    class Rubros : Interface1<Libro>
    {
        public string Nombre { get; set; }
        public List<Libro> libros { get; set; }
        public Rubros(string Nombre)
        {
            this.Nombre = Nombre;
            libros = new List<Libro>();
        }
        public void AgregarLibro(Libro libro)
        {
            libros.Add(libro);
        }

        
    }
}
