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
            string DEFAULT_STOPPER ="4";
            Espotifai sp = new Espotifai();

            //interfaz
            string stopper ="";
            Console.WriteLine("Bienvenido a Espotifai");
            while (stopper!=DEFAULT_STOPPER)
            {
                Console.WriteLine("\nque funcion desea utilizar?\n");
                Console.WriteLine("(1)Agregar Cancion \n(2)VerCanciones \n(3)Ver canciones por criterio \n(4)Salir del programa\n");
                stopper= Console.ReadLine();
                switch (stopper)
                {
                    case "1":// Agregar Cancion
                        Console.WriteLine("Ingrese el nombre de la cancion: ");
                        string nameofsong = Console.ReadLine();

                        Console.WriteLine("Ingrese el nombre del album: ");
                        string nameofalbum = Console.ReadLine();

                        Console.WriteLine("Ingrese el nombre del artista: ");
                        string nameofartist = Console.ReadLine();

                        Console.WriteLine("Ingrese el nombre del genero: ");
                        string nameofgenre = Console.ReadLine();

                        Cancion cancion = new Cancion(nameofsong, nameofalbum, nameofartist, nameofgenre);
                        bool comprobador = sp.AgregarCancion(cancion);
                        if (comprobador)
                        {
                            Console.WriteLine("\nLa Cancion se anadio correctamente");
                        }
                        else
                        {
                            Console.WriteLine("\nLa cancion ya se encuentra en el repertorio");
                        }
                        break;

                    case "2"://Ver cancion
                        sp.VerCancion();
                        break;


                    case "3": //Canciones por criterio
                        Console.WriteLine("Ingrese el criterio a utilizar: ");
                        string criterio = Console.ReadLine();
                        Console.WriteLine("Ingrese el valor del criterio: ");
                        string valor = Console.ReadLine();
                        List<Cancion>cancionesvalidas=sp.CancionesPorCriterio(criterio, valor);
                        foreach (Cancion i in cancionesvalidas)
                        {
                            Console.WriteLine(i.Informacion());
                        }
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
