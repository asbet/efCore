using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace efCore.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string BookName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public List<Author> Author { get; set; }
        public List<Review> Reviews { get; set; }
        public DateTime PublishDate { get; set; }

    }
}
