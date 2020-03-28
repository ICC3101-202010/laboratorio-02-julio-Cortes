using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Playlist
    {
        private string Name;
        private List<Cancion> Listcanciones;
        public string Name1 { get => Name; set => Name = value; }
        public List<Cancion> Listcanciones1 { get => Listcanciones; set => Listcanciones = value; }//atributos get y set
        public Playlist(string name,List<Cancion> listcanciones)//constructor
        {
            this.Name = name;
            this.Listcanciones = listcanciones;
        }
        public string Informacion()
        {
            string info = "El nombre de la playlist es: " + Name + " \ny las canciones que se encuentran en ella son: \n";
            foreach (Cancion i in Listcanciones)
            {
                info +="\n"+i.Informacion()+"\n";

            }
            return info;
        }
    }
}
