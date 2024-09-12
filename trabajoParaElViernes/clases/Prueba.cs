//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using trabajoParaElViernes.clases;

//namespace trabajoParaElViernes.clases
//{
//    internal class Prueba
//    {
//        string usuario = "maximo";
//        string constrasenia = "maximoladner123";
//        string genero;
//        string eleccion = "";
//        int cantidad = 0;
//        int total = 0;


//            while (true)
//            {
//                Console.Write("Ingrese su usuario: ");
//                usuario = Console.ReadLine();
//                Console.Write("\nIngrese su contraseña: ");
//                constrasenia = Console.ReadLine();
//                if (usuario == "maximoladner" && constrasenia == "maximoladner123")
//                {
//                    Libro milibro = new Libro();
//        milibro.TiposLibros();
//                    Console.WriteLine("Eliga el genero que quiera: ");
//                    genero = Console.ReadLine();
//                    genero.ToUpper();
//                    if (genero == "fantasia" || genero == "1")
//                    {
                    
//                            LibroFantasia libroFantasia = new LibroFantasia();
//        libroFantasia.MostrarLibros();
//                            Console.Write("Seleccione el/los que quiera comprar o escriba salir para seguir viendo mas libros: ");
//                            eleccion = Console.ReadLine();
//                            Console.Write("Que cantidad desea comprar?");
//                            cantidad = int.Parse(Console.ReadLine());

//    }
//                    else if (genero == "autoayuda" || genero == "2")
//                    {
//                        LibroAutoayuda libroAutoayuda = new LibroAutoayuda();
//    libroAutoayuda.MostrarLibros();
//                        Console.Write("Seleccione el/los que quiera comprar: ");
//                        eleccion = Console.ReadLine();
//                        Console.Write("Que cantidad desea comprar?");
//                        cantidad = int.Parse(Console.ReadLine());
//}
//                    else if (genero == "academico" || genero == "3")
//{
//    LibroAcademico libroAcademico = new LibroAcademico();
//    libroAcademico.MostrarLibros();
//    Console.Write("Seleccione el/los que quiera comprar: ");
//    eleccion = Console.ReadLine();
//    Console.Write("Que cantidad desea comprar?");
//    cantidad = int.Parse(Console.ReadLine());
//}
//                }
//                else
//{
//    Console.WriteLine("USUARIO O CONTRASEÑA INCORRECTA, INTETELO NUEVAMENTE");
//}
//total += cantidad;
//Console.WriteLine(total);
//Console.ReadKey();
//    }
//}
