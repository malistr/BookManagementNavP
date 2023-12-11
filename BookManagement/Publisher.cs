using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement
{
    public class Publisher:BaseModel
    {
        [Display(Name= "Address")]
        public string Address { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}
