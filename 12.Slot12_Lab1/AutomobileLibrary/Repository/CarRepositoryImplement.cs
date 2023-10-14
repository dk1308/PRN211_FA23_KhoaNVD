using AutomobileLibrary.BusinessObject;
using AutomobileLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileLibrary.Repository
{
    public class CarRepositoryImplement : ICarRepository
    {
        public void DeleteCar(int carID) => CarDBContext.Instance.DeleteCar(carID);

        public IEnumerable<Car> GetAll() => CarDBContext.Instance.GetAllCars();

        public Car GetById(int id) => CarDBContext.Instance.GetCarByID(id);

        public void InsertNewCar(Car car) => CarDBContext.Instance.InsertNewCar(car);

        public void UpdateCar(Car car) => CarDBContext.Instance.UpdateCar(car);

    }
}
