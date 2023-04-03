using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;

namespace WebApplication1.Models
{
    public class Movies
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MoviesCategories MoviesCategory { get; set; }
        public List<Actor_movies> Actor_Movies { get; set; }
        public int IDCinema { get; set; }
        [ForeignKey("IDCinema")]
        public Cinema cinema { get; set; }
        public int IDProducer { get; set; }
        [ForeignKey("IDProducer")]
        public Producer producer { get; set; }
    }
}
