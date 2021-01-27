using Day5GameDal.IAbstract;
using System;
using System.Collections.Generic;
using System.Text;
using Day5GameDal.Units;

namespace Day5GameDal.Concrete
{
    class CheckManager 
    {
        public bool CustomerCheck(Customer customer)
        {

            Console.WriteLine("Kullanıcı E-Devlet sisteminden doğrulanıyor.");
            return true;
        }
    }
}
