using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement
{
    public class BookStand:BaseModel
    {
        public int Number { get; set; }

        public virtual ICollection<Book> Books { get; set;}
    }
}
