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
        public List<Cancion> listofsongs = new List<Cancion>();//
        //Metodos

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
        }

        public void VerCancion()
        {
            foreach (Cancion i in listofsongs)
            {
                Console.WriteLine(i.Informacion());
            }
        }
        public Cancion[] CancionesPorCriterio(string criterio, string valor)
        {
            List<Cancion> cancionesvalidas = new List<Cancion>();
            foreach (Cancion i in listofsongs)
            {
                switch (criterio)
                {
                    case "Nombre":
                        if (i.Name == valor)
                        {
                            cancionesvalidas.Add(i);
                        }
                        break;
                    case "Album":
                        if (i.Album == valor)
                        {
                            cancionesvalidas.Add(i);
                        }
                        break;
                    case "Artista":
                        if (i.Artist == valor)
                        {
                            cancionesvalidas.Add(i);
                        }
                        break;
                    case "Genero":
                        if (i.Genre == valor)
                        {
                            cancionesvalidas.Add(i);
                        }
                        break;
                    default:
                        Console.WriteLine("El criterio no es valido");
                        Cancion[] cancionesinvalidas = { };
                        return (cancionesinvalidas);
                }
            }
            if (cancionesvalidas.Count!=0)
                {
                    Cancion[] arraycanciones = cancionesvalidas.ToArray();
                    return arraycanciones;
                }
            else
                {
                    Cancion[] arraycanciones = cancionesvalidas.ToArray();
                    return arraycanciones;
                }
                
    	    
        }
    }
}
