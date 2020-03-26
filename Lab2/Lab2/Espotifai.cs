using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Espotifai
    {
        public Espotifai()//Constructor Default
        {

        }
        private List<Playlist> listofplaylist = new List<Playlist>();//lista de playlist
        private List<Cancion> listofsongs = new List<Cancion>();//lista de canciones
    

        public bool AgregarCancion(Cancion cancion)
        {
            if (listofsongs.Count == 0)
            {
                listofsongs.Add(cancion);
                return true;

            }
            else
            {
                foreach (Cancion i in listofsongs)
                {
                    if (i.Informacion() == cancion.Informacion())
                    {
                        return false;
                    }
                    else
                    {
                        listofsongs.Add(cancion);
                        return true;
                    }
                }
                return true;

            }
        } //Metodos

        public void VerCancion()
        {
            foreach (Cancion i in listofsongs)
            {
                Console.WriteLine(i.Informacion());
            }
        } //Metodos
        public List<Cancion> CancionesPorCriterio(string criterio, string valor)
        {
            List<Cancion> cancionesvalidas = new List<Cancion>();
            foreach (Cancion i in listofsongs)
            {
                switch (criterio)
                {
                    case "nombre":
                        if (i.Name1 == valor)
                        {
                            cancionesvalidas.Add(i);
                        }
                        break;
                    case "album":
                        if (i.Album1 == valor)
                        {
                            cancionesvalidas.Add(i);
                        }
                        break;
                    case "artista":
                        if (i.Artist1 == valor)
                        {
                            cancionesvalidas.Add(i);
                        }
                        break;
                    case "genero":
                        if (i.Genre1 == valor)
                        {
                            cancionesvalidas.Add(i);
                        }
                        break;
                    default:
                        Console.WriteLine("El criterio no es valido");
                        return (cancionesvalidas);
                }
            }
            if (cancionesvalidas.Count()==0)
                {
                Console.WriteLine("No se encontraron canciones, con el criterio solicitado");
                   return cancionesvalidas;
                }
            else
                {
                Console.WriteLine("\nSe encontraron las siguientes canciones:");
                   return cancionesvalidas;
                }


        } //Metodos
    }
}
