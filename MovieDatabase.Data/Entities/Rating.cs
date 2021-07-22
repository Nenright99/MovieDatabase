using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabase.Data.Entities
{
    public enum Stars
    {
        One = 1,
        Two,
        Three,
        Four,
        Five,
    }
    public class Rating
    {
        [Key]
        public int ID { get; set; }
        public Stars StarRating { get; set; }
        [ForeignKey(nameof(Movie))]
        public int RatingID { get; set; }
        public virtual Movie Movie { get; set; }
    }
}
