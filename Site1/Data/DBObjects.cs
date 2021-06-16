using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Site1.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site1.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {

            if(!content.Category.Any())
            {
                content.Category.AddRange(Categories.Select(c=>c.Value));
            }
            if (!content.Car.Any())
            {
                content.AddRange(
                     new Car
                     {
                         name = "Tesla",
                         shortDesc = "model 3",
                         longDesc = "ТИХИЙ , СПОКОЙНЫЙ",
                         img = "/img/tesla.jpg",
                         price = 45000,
                         isFavorite = true,
                         availabel = true,
                         Category = Categories["Электромобили"]
                     },
                    new Car
                    {
                        name = "BMW",
                        shortDesc = "M5-COMPITITION",
                        longDesc = "ЖЕСТКИЙ АВТО, ДЛЯ ДЕРЗКИХ , ЕЗЖА",
                        img = "/img/bmw.jpg",
                        price = 50000,
                        isFavorite = false,
                        availabel = true,
                        Category = Categories["Бензиновые автомобили"]
                    }
                    );
            }
            content.SaveChanges();
        }
        private static Dictionary<string, Category> category;
        public static Dictionary<string,Category> Categories
        {
            get
            {
                if(category==null)
                {
                    var list = new Category[]
                    {
                        new Category{categoryName="Электромобили", desc="Современный вид транспорта" },
                        new Category{categoryName="Бензиновые автомобили", desc="Машины с двигателем внутреннего сгорания" },
                    };
                    category = new Dictionary<string, Category>();
                    foreach(var e in list)
                    {
                        category.Add(e.categoryName, e);
                    }
                }
                return category;
            }
        }
    }
}
