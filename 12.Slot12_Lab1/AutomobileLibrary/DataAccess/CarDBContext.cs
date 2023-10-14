using AutomobileLibrary.BusinessObject;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileLibrary.DataAccess
{

    public class CarDBContext
    {
        public static List<Car> cars = new List<Car>
        {
            new Car{CarID = 1, CarName = "MyCar", CarManufacturer = "BMW", CarPrice=50000, CarReleaseYear = 2015},
            new Car{CarID = 2, CarName = "HerCar", CarManufacturer = "Audi", CarPrice=40000, CarReleaseYear = 2017}
        };
        public static readonly object instanceObject = new object();
        public static CarDBContext instance;
        public static CarDBContext Instance
        {
            get
            {
                lock (instanceObject)
                {
                    if (instance == null)
                        return new CarDBContext();
                }
                return instance;
            }
        }

        public List<Car> GetAllCars() => cars;
        public Car GetCarByID(int carID) => cars.SingleOrDefault(res => res.CarID == carID);
        public void InsertNewCar(Car car)
        {
            if (GetCarByID(car.CarID) != null)
            {
                Console.WriteLine("Car already exists!");
                return;
            }
            cars.Add(car);
        }
        public void DeleteCar(int CarID)
        {
            if (GetCarByID(CarID) == null)
            {
                Console.WriteLine("Car does not exist!");
                return;
            }
            cars.Remove(GetCarByID(CarID));
        }
        public void UpdateCar(Car car)
        {
            if (GetCarByID(car.CarID) == null)
            {
                Console.WriteLine("Car does not exist!");
                return;
            }
            int idx = cars.IndexOf(GetCarByID(car.CarID));
            cars[idx] = car;
        }
    }
}
