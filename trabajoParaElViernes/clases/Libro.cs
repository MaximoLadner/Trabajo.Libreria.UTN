using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using trabajoParaElViernes.clases;

namespace trabajoParaElViernes
{
    class Libro
    {
        public string Titulo { get; set; }
        public string Autor {  get; set; }
        public decimal Precio { get; set; }
        public string Rubro { get; set; }
        public int Stock { get; set; }

        public Libro(string Titulo, string Autor, decimal Precio,string Rubro, int Stock)
        {
            this.Titulo = Titulo;
            this.Autor = Autor;
            this.Precio = Precio;
            this.Rubro = Rubro;
            this.Stock = Stock;
        }
        public virtual void MostrarDetalles()
        {
            Console.WriteLine($"Titulo: {Titulo}\nAutor: {Autor}\nPrecio: {Precio}\nRubro: {Rubro}\nStock: {Stock}");
        }
        
    }
}
