using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement
{
    public class BookDetail:BaseModel
    {
        public string Summary { get; set; }

        public Book Book { get; set; }
    }
}
