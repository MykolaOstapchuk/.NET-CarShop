using ShopNET.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopNET.Data.Interfaces{
    public interface ICarCategory{

        IEnumerable<Category> AllCategories { get; }

    }
}
