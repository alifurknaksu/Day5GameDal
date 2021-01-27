using Day5GameDal.IAbstract;
using System;
using System.Collections.Generic;
using System.Text;
using Day5GameDal.Units;

namespace Day5GameDal.Concrete
{
    class SaleManager : ISaleManager
    {
        public void Sale(Games game, Customer customer)
        {
            Console.WriteLine("{0} Id numaralı kullanıcı {1} isimli oyunu satın aldı. Bedel = {2}", customer.Id, game.GameName, game.Price);
        }
     
        public bool BlackFridaySale(Games game, Customer customer)
        {
            double discount = 0.50;
            game.Price = game.Price * discount;
            return true;
        }

        public bool GameDaySale(Games game, Customer customer)
        {
            double discount = 0.75;
            game.Price = game.Price * discount;
            return false;
        }
    }
}
