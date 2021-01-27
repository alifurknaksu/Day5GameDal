using System;
using System.Collections.Generic;
using System.Text;
using Day5GameDal.Units;

namespace Day5GameDal.IAbstract
{
    interface ICustomerDal
    {
        void Add(Customer customer);
        void Delete(Customer customer);
        void Update(Customer customer);
    }
}
