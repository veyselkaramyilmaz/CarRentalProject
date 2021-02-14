using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());



            foreach (var car in carManager.GetByDailyPrice(225,250))
            {
                Console.WriteLine(car.Descriptions);
            }
            Console.WriteLine("---------------------------------------------");





            ColorManager colorManager = new ColorManager(new EfColorDal());


            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.ColorName);
            }

            Console.WriteLine("---------------------------------------------");

            BrandManager brandManager = new BrandManager(new EfBrandDal());

            foreach (var brand in brandManager.GetAllByBrandName("Tesla"))
            {
                Console.WriteLine(brand.BrandName);
            }
        }
    }
}
