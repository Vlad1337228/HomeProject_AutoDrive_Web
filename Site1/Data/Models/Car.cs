using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site1.Data.Models
{
    public class Car
    {
        public int id { get; set; }
        public string name { get; set; }
        public string shortDesc { get; set; }//краткое описание
        public string longDesc { get; set; }//полноценное описание
        public string img { get; set; } // url адресс картинки
        public ushort price { get; set; }
        public bool isFavorite { get; set; }
        public bool availabel { get; set; }//есть на складе или нет(сколько)
        public int vategoryID { get; set; }
        public virtual Category Category { get; set; }//какая категория


    }
}
