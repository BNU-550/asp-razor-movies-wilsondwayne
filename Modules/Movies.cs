using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DwayneRazorMovies.Modules
{
    public enum Genres
    {
        Action, Drama, Horror, Comedy
    }

    public class Movies
    {
        [Key]
        public int ID { get; set; }

        [StringLength(70)]
        public string Title { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime RelaseDate { get; set; }
        public Genres Genre { get; set; }
               public decimal Price { get; set; }
    }
}
