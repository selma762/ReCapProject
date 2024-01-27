
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarTest();
            //BrandTest();
            //ColorTest();


        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            //colorManager.Add(new Color { ColorName = "Morumsu" });
            //colorManager.Update(new Color { Id=1002,ColorName = "Mor" });
            //colorManager.Delete(new Color { Id = 1002 });
            foreach (var colors in colorManager.GetById(5))
            {
                Console.WriteLine(colors.ColorName);
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            //brandManager.Add(new Brand { BrandName="Hızlı"});
            //brandManager.Update(new Brand { Id = 1002, BrandName = "Hızlı1" });
            //brandManager.Delete(new Brand { Id = 1002 });
            foreach (var brands in brandManager.GetById(22))
            {
                Console.WriteLine(brands.BrandName);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            //carManager.Add(new Car {BrandId=5,ColorId=3,ModelYear="2005",DailyPrice=50000,Description="Yeni araba" });
            //carManager.Update(new Car {Id=1002,BrandId=6,ColorId=3,ModelYear="2005",DailyPrice=25000,Description="Arabam yeni modeldir." });
            //carManager.Delete(new Car{Id=1002 });

            foreach (var cars in carManager.GetCarDetails())
            {
                Console.WriteLine("Id="+cars.Id +"\n" +"BrandName="+cars.BrandName+"\n"+"ColorName="+cars.ColorName+"\n"+"DailyPrice="+cars.DailyPrice);
                Console.WriteLine("-------------");
            }
        }
    }
}
