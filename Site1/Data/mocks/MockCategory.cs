using Site1.Data.Interfaces;
using Site1.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site1.Data.mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get {
                return new List<Category>
                {
                    new Category{categoryName="Электромобили", desc="Современный вид транспорта" },
                    new Category{categoryName="Бензиновые автомобили", desc="Машины с двигателем внутреннего сгорания" },

                };
            }
        }
    }
}
