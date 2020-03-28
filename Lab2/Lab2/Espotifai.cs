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
        private List<Cancion> Listofsongs = new List<Cancion>();//lista de canciones
        private List<Playlist> Listofplaylist = new List<Playlist>();//lista de playlist

        public bool AgregarCancion(Cancion cancion)
        {
            if (Listofsongs.Count == 0)
            {
                Listofsongs.Add(cancion);
                return true;

            }
            else
            {
                foreach (Cancion i in Listofsongs)
                {
                    if (i.Informacion() == cancion.Informacion())
                    {
                        return false;
                    }
                }

                Listofsongs.Add(cancion);
                return true;


            }
        } //Metodos

        public void VerCancion()
        {
            foreach (Cancion i in Listofsongs)
            {
                Console.WriteLine(i.Informacion()+"\n");
            }
        } //Metodos

        public List<Cancion> CancionesPorCriterio(string criterio, string valor)
        {
            List<Cancion> cancionesvalidas = new List<Cancion>();
            foreach (Cancion i in Listofsongs)
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
                Console.WriteLine("\nSe encontraron las siguientes canciones:\n");
                foreach (Cancion i in cancionesvalidas)
                {
                    Console.WriteLine(i.Informacion() + "\n");
                }
                  return cancionesvalidas;
            }


        } //Metodos

        public bool GenerarPlaylist(string criterio, string valorCriterio, string nombrePlaylist)
        {
            List<Cancion> cancionesvalidas = CancionesPorCriterio(criterio, valorCriterio);
            Playlist playlist = new Playlist(nombrePlaylist, cancionesvalidas);
            if (cancionesvalidas.Count()==0)
            {
                return false;
            }
            if (Listofplaylist.Count != 0)
            {
                foreach (Playlist i in Listofplaylist)
                {
                    if (i.Informacion()==playlist.Informacion())
                    {
                        Console.WriteLine("Ya existe una playlist con ese nombre");
                        return false;
                    }

                }
                
            }

            Listofplaylist.Add(playlist);
            return true;
        }//Metodos

        public string VerMisPlaylist()
        {
            string info = "Las playlist son: \n";
            foreach (Playlist i in Listofplaylist)
            {
                info += i.Informacion()+"\n";
            }
            return info;
        }

    }
}

