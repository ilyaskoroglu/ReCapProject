using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car> {

                new Car  {Id=1, BrandId=1, DailyPrice=250000, ModelYear=2019, Description="Ford Focus"},
                new Car  {Id=2, BrandId=1, DailyPrice=175000, ModelYear=2020, Description="Ford Fiesta"},
                new Car  {Id=3, BrandId=2, DailyPrice=200000, ModelYear=2017, Description="Renault Megane"},
                new Car  {Id=4, BrandId=2, DailyPrice=150000, ModelYear=2018, Description="Renault Clio"},
                new Car  {Id=5, BrandId=3, DailyPrice=100000, ModelYear=2015, Description="Fiat Egea"} 

            };
        }
        public void Add(Car car)
        {
            _cars.Add(car); 
        }

        public void Delete(Car car, Car carToDelete)
        {
            Car CarToDelete = _cars.SingleOrDefault(p => p.Id == car.Id);

            _cars.Remove(carToDelete);
        }

        public void Delete(Car car)
        {
            throw new NotImplementedException();
        }

        public List<Car> Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(p => p.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
            carToUpdate.DailyPrice = car.DailyPrice;
        }
    }
}
