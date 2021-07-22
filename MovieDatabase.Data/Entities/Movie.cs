using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabase.Data.Entities
{
    public enum MaturityRating
    {
        G = 1,
        PG,
        PG_13,
        R,
        NC_17
    }
   public class Movie
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int RunTime { get; set; }
        public List<string> Genres { get; set; }
        public List<string> Actors { get; set; }
        public DateTime Release { get; set; }
        public MaturityRating Maturity { get; set; }
        public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();
    }
}
