using System;
using System.Collections.Generic;
using System.Text;
using Day5GameDal.Units;

namespace Day5GameDal.IAbstract
{
    interface ISaleManager
    {
        void Sale(Games game, Customer customer);
        bool BlackFridaySale(Games game, Customer customer);
        bool GameDaySale(Games game, Customer customer);
    }
}
