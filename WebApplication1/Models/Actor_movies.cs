using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Actor_movies
    {
        public int IdMovies { get; set; }
        public Movies movies { get; set; }
        public int IDActor { get; set; }
        public Actor actor { get; set; } 

    }
}
