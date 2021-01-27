using Day5GameDal.IAbstract;
using Day5GameDal.Concrete;
using Day5GameDal.Units;
using System;

namespace Day5GameDal
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer() {
                Id = 4, 
                FirstName = "Ali",
                LastName = "Aksu", 
                TcNo = "1234567890" };

            Games game1 = new Games() {
                Id =3, 
                GameName = "Rust", 
                Price = 29.00, };

            CheckManager checkManager = new CheckManager();
            CustomerDal customerDal = new CustomerDal();


            if (checkManager.CustomerCheck(customer1))
            {
                customerDal.Add(customer1);
            }
            else
            {
                Console.WriteLine("Birey E Devlet'te bulunamadı.");
            }


            GamesDal gameManager = new GamesDal();
            SaleManager saleManager = new SaleManager();


            gameManager.Add(game1);

            if (saleManager.BlackFridaySale(game1, customer1))
            {
                saleManager.Sale(game1, customer1);
            }
            else if (saleManager.GameDaySale(game1, customer1))
            {
                saleManager.Sale(game1, customer1);
            }
            else
            {
                saleManager.Sale(game1, customer1);
            }
        }
    }
}