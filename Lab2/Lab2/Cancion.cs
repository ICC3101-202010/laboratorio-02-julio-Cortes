using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Cancion
    {
        public string Name;
        public string Album;
        public string Artist;
        public string Genre; //caracteristicas cancion

        public string Informacion()
        {
            string info=("Nombre: " + Name + "\nAlbum: " + Album + "\nArtista: " +Artist+"\nGenre: "+Genre);
            return info;
        }



    }
}
