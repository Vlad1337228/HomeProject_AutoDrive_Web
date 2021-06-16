using Site1.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site1.Data.Interfaces
{
    public interface ICarsCategory
    {
       IEnumerable<Category> AllCategories { get; }
    }
}
