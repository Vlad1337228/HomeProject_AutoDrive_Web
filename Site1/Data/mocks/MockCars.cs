using Site1.Data.Interfaces;
using Site1.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site1.Data.mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars 
        {
            get {
                return new List<Car>
                {
                    new Car{name="Tesla",
                        shortDesc="model 3",
                        longDesc="ТИХИЙ , СПОКОЙНЫЙ",
                        img="/img/tesla.jpg",
                        price=45000,
                        isFavorite=true,
                        availabel=true,
                        Category=_categoryCars.AllCategories.First()
                    },
                    new Car{name="BMW",
                        shortDesc="M5-COMPITITION",
                        longDesc="ЖЕСТКИЙ АВТО, ДЛЯ ДЕРЗКИХ , ЕЗЖА",
                        img="/img/bmw.jpg",
                        price=50000,
                        isFavorite=false,
                        availabel=true,
                        Category=_categoryCars.AllCategories.Last()
                    }
                };
            }
        }
        public IEnumerable<Car> getFavCars
        {
            get;
            set;
        }
        public Car getObjectCar(int catId)
        {
            throw new NotImplementedException();
        }
    }
}
