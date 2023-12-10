using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efCore.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string AuthorName { get; set; } = string.Empty;
        public List<Book> Books { get; set; }  
    }
}
