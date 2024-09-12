using System;
using System.Collections.Generic;
using trabajoParaElViernes.clases;

namespace trabajoParaElViernes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Usuario> UsuarioRegistrados = new List<Usuario>
            {
                new Usuario("maximo","maximoladner123"),
                new Usuario("santino","santigarrone4"),
                new Usuario("ignacio","ignacioOrffei")
            };

            Rubros fantasia = new Rubros("Fantasia");
            fantasia.AgregarLibro(new Libro("Las aventuras de Maximo", "Maximo Ladner", 100, "Fantasia", 10));
            fantasia.AgregarLibro(new Libro("Las aventuras de Santiago(garrone)", "Maximo Ladner", 5, "Fantasia", 100));

            Rubros autoayuda = new Rubros("Autoayuda");
            autoayuda.AgregarLibro(new Libro("El poder del AHORA", "Eckhart Tolle", 150, "Autoayuda", 7));
            autoayuda.AgregarLibro(new Libro("EL SUTIL ARTE DE QUE (casi todo) TE IMPORTE UNA MIERDA", "Mark Mansion", 120, "Autoayuda", 4));

            List<Rubros> rubrosInventario = new List<Rubros> { fantasia, autoayuda };

            while (true)
            {
                Console.WriteLine("Ingrese su nombre: ");
                string usuario = Console.ReadLine();
                Console.WriteLine("Ingrese su contraseña: ");
                string contraseña = Console.ReadLine();
                Usuario unUsuario = new Usuario(usuario, contraseña);

                if (unUsuario.EsClienteRegistrado(UsuarioRegistrados))
                {
                    Console.WriteLine($"Bienvenido señor {unUsuario.Nombre}");

                    Console.WriteLine("Rubros disponibles: ");
                    for (int i = 0; i < rubrosInventario.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {rubrosInventario[i].Nombre}");
                    }

                    Console.WriteLine("Ingrese el número del rubro que desea: ");
                    int rubroSeleccionado = int.Parse(Console.ReadLine()) - 1;

                    if (rubroSeleccionado >= 0 && rubroSeleccionado < rubrosInventario.Count)
                    {
                        var rubro = rubrosInventario[rubroSeleccionado];

                        Console.WriteLine($"Libros en el rubro {rubro.Nombre}:");
                        for (int i = 0; i < rubro.libros.Count; i++)
                        {
                            var libro = rubro.libros[i];
                            Console.WriteLine($"{i + 1}_ {libro.Titulo}, Autor: {libro.Autor}, Precio: {libro.Precio}, Stock: {libro.Stock}");
                        }

                        List<Libro> carritoCompra = new List<Libro>();
                        string continuarComprando;

                        do
                        {
                            Console.WriteLine("Ingrese el número del libro que desea comprar: ");
                            int libroSeleccionado = int.Parse(Console.ReadLine()) - 1;

                            Console.WriteLine("Ingrese la cantidad que desea comprar: ");
                            int cantidad = int.Parse(Console.ReadLine());

                            if (libroSeleccionado >= 0 && libroSeleccionado < rubro.libros.Count)
                            {
                                var libroSeleccionadoObjeto = rubro.libros[libroSeleccionado];

                                if (libroSeleccionadoObjeto.Stock >= cantidad)
                                {
                                    Console.WriteLine($"Agregando {cantidad} unidades de {libroSeleccionadoObjeto.Titulo} al carrito.");
                                    libroSeleccionadoObjeto.Stock -= cantidad;
                                    carritoCompra.Add(libroSeleccionadoObjeto);
                                }
                                else
                                {
                                    Console.WriteLine("No hay suficiente stock disponible.");
                                }
                            }

                            Console.WriteLine("¿Desea seguir comprando? (s/n)");
                            continuarComprando = Console.ReadLine().ToLower();
                        }
                        while (continuarComprando == "s");

                        if (carritoCompra.Count > 0)
                        {
                            Console.WriteLine("Resumen de su compra:");
                            decimal total = 0;
                            foreach (var libro in carritoCompra)
                            {
                                Console.WriteLine($"{libro.Titulo} - {libro.Precio:C}");
                                total += libro.Precio;
                            }

                            Console.WriteLine($"Total: {total:C}");

                            Console.WriteLine("¿Desea confirmar su compra? (s/n)");
                            string confirmacion = Console.ReadLine().ToLower();

                            if (confirmacion == "s")
                            {
                                Console.WriteLine("Ingrese los datos de su tarjeta de crédito.");
                                Console.Write("Número de tarjeta: ");
                                int numeroTarjeta = int.Parse(Console.ReadLine());
                                Console.Write("Fecha de vencimiento: ");
                                string vencimiento = (Console.ReadLine());
                                Console.Write("Código de seguridad: ");
                                int codigoSeguridad = int.Parse(Console.ReadLine());

                                Console.WriteLine("Pago procesado correctamente.");
                                Console.WriteLine("Compra finalizada.");
                                Console.WriteLine("muchas gracias por su compra, VUELvA PRONTO o me enojo");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Compra cancelada.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No se han agregado libros al carrito.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Rubro no válido.");
                    }
                }
                else
                {
                    Console.WriteLine("Usuario incorrecto, ingreselo nuevamente.");
                }
            }
        }
    }
}
