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
            if (listofsongs.Contains(cancion))
            {
                return false;
            }
            else
            {
                listofsongs.Add(cancion);
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


    }
}
