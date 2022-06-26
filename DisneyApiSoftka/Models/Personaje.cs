using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DisneyApiSoftka.Models
{
    public class Personaje
    {
        public int id { get; set; }

        public string nombre { get; set; }

        public int edad { get; set; }

        public ICollection<Pelicula> Peliculas { get; set; } 
        
       
    }
}
