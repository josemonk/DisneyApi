using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DisneyApiSoftka.Models
{
    public class Pelicula
    {

        public int id { get; set; }

        public string titulo { get; set; }

        public int idPersonaje { get; set; }
        public Personaje personaje { get; set; }

    }
}
