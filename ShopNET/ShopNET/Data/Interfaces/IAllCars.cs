using ShopNET.Data.Models;
using System.Collections.Generic;

namespace ShopNET.Data.Interfaces
{
    public interface IAllCars{

        IEnumerable<Car> Cars { get; }
        IEnumerable<Car> getFavCars { get; }
        IEnumerable<Car> getClassic { get; }
        IEnumerable<Car> getElectro { get; }
        Car getObjectCar(int carId);

    }
}
