﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Cancion
    {
        private string Name;
        private string Album;
        private string Artist;
        private string Genre; //caracteristicas cancion

        public string Album1 { get => Album; set => Album = value; }
        public string Name1 { get => Name; set => Name = value; }
        public string Artist1 { get => Artist; set => Artist = value; }
        public string Genre1 { get => Genre; set => Genre = value; }//get y set

        public Cancion(string name, string album, string artist, string genre) //constructor
        {
            if (name == "") { name = "Unknown"; }
            if (album == "") { album = "Unknown"; }
            if (artist == "") { artist = "Unknown"; }
            if (genre == "") { genre = "Unknown"; }//caso en que el usuario no ponga nada

            this.Name = name;
            this.Album = album;
            this.Artist = artist;
            this.Genre = genre;
        }

        public string Informacion()
        {
            string info=("Nombre: " + Name + "\nAlbum: " + Album + "\nArtista: " +Artist+"\nGenre: "+Genre);
            return info;
        }//metodo



    }
}
