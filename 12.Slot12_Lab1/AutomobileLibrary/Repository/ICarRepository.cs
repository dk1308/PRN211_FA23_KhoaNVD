using AutomobileLibrary.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileLibrary.Repository
{
    public interface ICarRepository
    {
        public IEnumerable<Car> GetAll();
        public Car GetById(int id);
        public void InsertNewCar(Car car);
        public void UpdateCar(Car car);
        public void DeleteCar(int carID);
    }
}
