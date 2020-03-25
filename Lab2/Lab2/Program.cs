using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Espotifai sp = new Espotifai();

            //interfaz
            string stopper ="";
            Console.WriteLine("Bienvenido a Espotifai");
            while (stopper!="3")
            {
                Console.WriteLine("\nque funcion desea utilizar?\n");
                Console.WriteLine("(1)Agregar Cancion \n(2)VerCanciones \n(3)Ver canciones por criterio \n(4)Salir del programa");
                stopper= Console.ReadLine();
                switch (stopper)
                {
                    case "1":
                        Console.WriteLine("Ingrese el nombre de la cancion: ");
                        string nameofsong = Console.ReadLine();

                        Console.WriteLine("Ingrese el nombre del album: ");
                        string nameofalbum = Console.ReadLine();

                        Console.WriteLine("Ingrese el nombre del artista: ");
                        string nameofartist = Console.ReadLine();

                        Console.WriteLine("Ingrese el nombre del genero: ");
                        string nameofgenre = Console.ReadLine();

                        Cancion cancion = new Cancion(nameofsong, nameofalbum, nameofartist, nameofgenre);
                        sp.AgregarCancion(cancion);

                        if (sp.AgregarCancion(cancion))
                        {
                            Console.WriteLine("La Cancion se anadio correctamente");
                        }
                        else
                        {
                            Console.WriteLine("/mLa cancion ya se encuentra en el repertorio");
                        }
                        break;

                    case "2":
                        sp.VerCancion();
                        break;

                    case "3":
                        Console.WriteLine("Ingrese el criterio a utilizar: ");
                        string criterio = Console.ReadLine();
                        Console.WriteLine("Ingrese el valor del criterio: ");
                        string valor = Console.ReadLine();
                        sp.CancionesPorCriterio(criterio, valor);
                        break;
                    case "4":
                        break;
                    default:
                        Console.WriteLine("Ingrese una opcion valida");
                        break;
                }
            }
            
            
        }
    }
}
