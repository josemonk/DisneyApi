using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DisneyApiSoftka.Models
{
    public class MyDbContext :DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext>options) : base(options)
        {

        }

        public DbSet<Personaje> personajes { get; set; }

        public DbSet<Pelicula> Peliculas { get; set; }
    }
}
