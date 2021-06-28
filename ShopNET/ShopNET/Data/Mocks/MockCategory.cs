using ShopNET.Data.Interfaces;
using ShopNET.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopNET.Data.Mocks{
    public class MockCategory : ICarCategory
    {
        public IEnumerable<Category> AllCategories {
            get {
                return new List<Category>{
                    new Category {categoryName = "Electro", desc = "Modern electrick car" },
                    new Category {categoryName = "Classic", desc = "Car with engine motor" },
                   };
            }
        }
    }
}
