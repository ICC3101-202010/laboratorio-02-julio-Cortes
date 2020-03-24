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
            Cancion Zoom = new Cancion();
            Zoom.Name = "Zoom";
            Zoom.Album = "Me veras Volver";
            Zoom.Artist = "Soda Stereo";
            Zoom.Genre = "Rock Latino";
            Console.WriteLine(Zoom.Informacion());
        }
    }
}
