using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement
{
    public class Book:BaseModel
    {
        public virtual ICollection<Publisher> Publishers { get; set;}
        public virtual ICollection<Category> Categories { get; set;}
        public virtual ICollection<Writer> Writers { get; set;}
        public int BookStandId {  get; set;}
        public BookStand BookStand { get; set;}

        public int BookDetailId { get; set; }
        public BookDetail BookDetail { get; set;}
    }
}
