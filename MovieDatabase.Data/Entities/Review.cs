using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabase.Data.Entities
{
    public class Review
    {
        [Key]
        public int ID { get; set; }
        public string Text { get; set; }
        public Guid AuthorID { get; set; }
        public DateTimeOffset CreatedUTC { get; set; }
        [ForeignKey(nameof(Movie))]
        public int RevID { get; set; }
        public virtual Movie Movie { get; set; }
    }
}
