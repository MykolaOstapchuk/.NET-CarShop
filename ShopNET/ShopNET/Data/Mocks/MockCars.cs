using ShopNET.Data.Interfaces;
using ShopNET.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopNET.Data.Mocks{
    public class MockCars : IAllCars{

        private readonly ICarCategory _categoryCars = new MockCategory();

        public IEnumerable<Car> Cars {
            get {
                return new List<Car>{
                    new Car {
                        name = "Tesla Model X",
                        shortDesc ="Good car",
                        longDesc ="Konstruktorzy pojazdu Model X postawili na wszechstronność i osiągi — standardowo montowany jest w nim napęd AWD; ma on również największą w swojej klasie przestrzeń bagażową, a ponadto może przewieźć do siedmiu osób.",
                        img ="/img/teslax.jpg",
                        price =45000,
                        isFavourite =false,
                        available =true,
                        Category = _categoryCars.AllCategories.First()
                    },
                    new Car {
                        name = "Singer Vehicle Design",
                        shortDesc ="But that doesn’t take away from the product: 964-designation air-cooled 911s ‘restored, reimagined, reborn’.",
                        longDesc ="All the beauty and timeless elegance of the old stuff, with rampantly modern bits finagled into the cracks. So you get a seam-welded chassis, composite body panels, sophisticated modern springs and dampers, and engines blueprinted/enhanced by Ed Pink Racing.",
                        img ="/img/singer.jpg",
                        price =10000,
                        isFavourite =true,
                        available =true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car {
                        name = "Tesla Model S",
                        shortDesc ="Model S stworzono z myślą o szybkości i zasięgu.",
                        longDesc ="Ma więcej niż nieziemskie przyspieszenie, niezrównane osiągi i elegancką sylwetkę.",
                        img ="/img/teslas.jpg",
                        price =55300,
                        isFavourite =true,
                        available =true,
                        Category = _categoryCars.AllCategories.First()
                    },
                    new Car {
                        name = "Volkswagen Passat 1.4",
                        shortDesc ="Dobry samochod",
                        longDesc ="Samochod dla prawdziwych mezczyzn",
                        img ="/img/passa1.jpg",
                        price =15300,
                        isFavourite =false,
                        available =true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car {
                        name = "BMW X3 XDrive20d",
                        shortDesc ="BMW dobra firma samochodow",
                        longDesc ="Autoryzowany Dealer BMW I MINI - PREMIUM ARENA oferuje do sprzedaży samochód używany BMW G01 X3 M-Pakiet 190KM, Kolor: Biały Alpinweiss Rok produkcji: 2018. ",
                        img ="/img/bmwx3.jpg",
                        price =25300,
                        isFavourite =true,
                        available =true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car {
                        name = "Fiat 500",
                        shortDesc ="The 500 is small, but if you don’t need space it could be your only car.",
                        longDesc ="Whereas the Honda e or Mini electric would have to be second cars to anyone who ever drives beyond conurbations rather than just within them. It’s not as fun to drive as those are, mind. It’s trying harder to feel normal. ",
                        img ="/img/fiat500.jpg",
                        price =60000,
                        isFavourite =false,
                        available =true,
                        Category = _categoryCars.AllCategories.First()
                    },
                    new Car {
                        name = "Audi e-tron",
                        shortDesc ="Audi refers to this as ‘concept clarity’.",
                        longDesc ="This is an electric car that doesn’t seek to blur boundaries or act radical, but simply persuade regular SUV buyers to make the jump. ",
                        img ="/img/audie.jpg",
                        price =60000,
                        isFavourite =false,
                        available =true,
                        Category = _categoryCars.AllCategories.First()
                    },
                    new Car {
                        name = "Ring Brothers Defiant",
                        shortDesc ="Charger called ‘Defector’ and even an AMX Javelin from 1972 called ‘Defiant’.",
                        longDesc ="But despite the company’s fondness for a decent name, the cars are all famous for one thing: being very modern interpretations of gorgeous older vehicles, executed with the very best modern engineering possible.",
                        img ="/img/ringbr.jpg",
                        price =50100,
                        isFavourite =true,
                        available =true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car {
                        name = "Land Rover Defender Works",
                        shortDesc ="Bit of a weird one, this, seeing as it’s produced by the manufacturer itself, but the recent ‘Works’ V8 Defender counts because the car is out of production.",
                        longDesc ="Ok, so it gets thoroughly uprated suspension, but still. And best of all, it still just looks like the Defender we all know and love… and your elbows will still be forced out of the side window by ergonomics designed by someone with very strange proportions.",
                        img ="/img/landrover.jpg",
                        price =55300,
                        isFavourite =true,
                        available =true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car {
                        name = "Peugeot e-208",
                        shortDesc ="The 208 is a very sweet supermini but it has flaws.",
                        longDesc ="Not that roomy, not quite the best to drive. And the e-208 has those same flaws. But it has all the 208’s many attractions too.”",
                        img ="/img/peugeot.jpg",
                        price =34000,
                        isFavourite =false,
                        available =true,
                        Category = _categoryCars.AllCategories.First()
                    }
                };
            }
        }

        //add other car to this function
        //create other geters for elctric/classic/sport car
        public IEnumerable<Car> getFavCars {
            get {
                //addFavouriteCar
                return new List<Car>{
                    new Car {
                        name = "Tesla Model S",
                        shortDesc ="Model S stworzono z myślą o szybkości i zasięgu.",
                        longDesc ="Ma więcej niż nieziemskie przyspieszenie, niezrównane osiągi i elegancką sylwetkę.",
                        img ="/img/teslas.jpg",
                        price =55300,
                        isFavourite =true,
                        available =true,
                        Category = _categoryCars.AllCategories.First()
                    },
                    new Car {
                        name = "Audi e-tron",
                        shortDesc ="Audi refers to this as ‘concept clarity’.",
                        longDesc ="This is an electric car that doesn’t seek to blur boundaries or act radical, but simply persuade regular SUV buyers to make the jump. ",
                        img ="/img/audie.jpg",
                        price =60000,
                        isFavourite =false,
                        available =true,
                        Category = _categoryCars.AllCategories.First()
                    },
                    new Car {
                        name = "BMW X3 XDrive20d",
                        shortDesc ="BMW dobra firma samochodow",
                        longDesc ="Autoryzowany Dealer BMW I MINI - PREMIUM ARENA oferuje do sprzedaży samochód używany BMW G01 X3 M-Pakiet 190KM, Kolor: Biały Alpinweiss Rok produkcji: 2018. ",
                        img ="/img/bmwx3.jpg",
                        price =25300,
                        isFavourite =true,
                        available =true,
                        Category = _categoryCars.AllCategories.Last()
                    }
                };
            }
        }

        public IEnumerable<Car> getElectro
        {
            get
            {
                return new List<Car>{
                    new Car {
                        name = "Tesla Model X",
                        shortDesc ="Good car",
                        longDesc ="Konstruktorzy pojazdu Model X postawili na wszechstronność i osiągi — standardowo montowany jest w nim napęd AWD; ma on również największą w swojej klasie przestrzeń bagażową, a ponadto może przewieźć do siedmiu osób.",
                        img ="/img/teslax.jpg",
                        price =45000,
                        isFavourite =false,
                        available =true,
                        Category = _categoryCars.AllCategories.First()
                    },
                    new Car {
                        name = "Peugeot e-208",
                        shortDesc ="The 208 is a very sweet supermini but it has flaws.",
                        longDesc ="Not that roomy, not quite the best to drive. And the e-208 has those same flaws. But it has all the 208’s many attractions too.”",
                        img ="/img/peugeot.jpg",
                        price =34000,
                        isFavourite =false,
                        available =true,
                        Category = _categoryCars.AllCategories.First()
                    },
                    new Car {
                        name = "Tesla Model S",
                        shortDesc ="Model S stworzono z myślą o szybkości i zasięgu.",
                        longDesc ="Ma więcej niż nieziemskie przyspieszenie, niezrównane osiągi i elegancką sylwetkę.",
                        img ="/img/teslas.jpg",
                        price =55300,
                        isFavourite =true,
                        available =true,
                        Category = _categoryCars.AllCategories.First()
                    },
                    new Car {
                        name = "Fiat 500",
                        shortDesc ="The 500 is small, but if you don’t need space it could be your only car.",
                        longDesc ="Whereas the Honda e or Mini electric would have to be second cars to anyone who ever drives beyond conurbations rather than just within them. It’s not as fun to drive as those are, mind. It’s trying harder to feel normal. ",
                        img ="/img/fiat500.jpg",
                        price =60000,
                        isFavourite =false,
                        available =true,
                        Category = _categoryCars.AllCategories.First()
                    },
                    new Car {
                        name = "Audi e-tron",
                        shortDesc ="Audi refers to this as ‘concept clarity’.",
                        longDesc ="This is an electric car that doesn’t seek to blur boundaries or act radical, but simply persuade regular SUV buyers to make the jump. ",
                        img ="/img/audie.jpg",
                        price =60000,
                        isFavourite =false,
                        available =true,
                        Category = _categoryCars.AllCategories.First()
                    }
                };
            }
        }

        public IEnumerable<Car> getClassic
        {
            get
            {
                return new List<Car>{
                    new Car {
                        name = "Ring Brothers Defiant",
                        shortDesc ="Charger called ‘Defector’ and even an AMX Javelin from 1972 called ‘Defiant’.",
                        longDesc ="But despite the company’s fondness for a decent name, the cars are all famous for one thing: being very modern interpretations of gorgeous older vehicles, executed with the very best modern engineering possible.",
                        img ="/img/ringbr.jpg",
                        price =50100,
                        isFavourite =true,
                        available =true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car {
                        name = "Land Rover Defender Works",
                        shortDesc ="Bit of a weird one, this, seeing as it’s produced by the manufacturer itself, but the recent ‘Works’ V8 Defender counts because the car is out of production.",
                        longDesc ="Ok, so it gets thoroughly uprated suspension, but still. And best of all, it still just looks like the Defender we all know and love… and your elbows will still be forced out of the side window by ergonomics designed by someone with very strange proportions.",
                        img ="/img/landrover.jpg",
                        price =55300,
                        isFavourite =true,
                        available =true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car {
                        name = "Volkswagen Passat 1.4",
                        shortDesc ="Dobry samochod",
                        longDesc ="Samochod dla prawdziwych mezczyzn",
                        img ="/img/passa1.jpg",
                        price =15300,
                        isFavourite =false,
                        available =true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car {
                        name = "BMW X3 XDrive20d",
                        shortDesc ="BMW dobra firma samochodow",
                        longDesc ="Autoryzowany Dealer BMW I MINI - PREMIUM ARENA oferuje do sprzedaży samochód używany BMW G01 X3 M-Pakiet 190KM, Kolor: Biały Alpinweiss Rok produkcji: 2018. ",
                        img ="/img/bmwx3.jpg",
                        price =25300,
                        isFavourite =true,
                        available =true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car {
                        name = "Singer Vehicle Design",
                        shortDesc ="But that doesn’t take away from the product: 964-designation air-cooled 911s ‘restored, reimagined, reborn’.",
                        longDesc ="All the beauty and timeless elegance of the old stuff, with rampantly modern bits finagled into the cracks. So you get a seam-welded chassis, composite body panels, sophisticated modern springs and dampers, and engines blueprinted/enhanced by Ed Pink Racing.",
                        img ="/img/singer.jpg",
                        price =10000,
                        isFavourite =true,
                        available =true,
                        Category = _categoryCars.AllCategories.Last()
                    }
                };
            }
        }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
