using Day5GameDal.IAbstract;
using Day5GameDal.Units;
using System;
using System.Collections.Generic;
using System.Text;

namespace Day5GameDal.Concrete
{
    class CustomerDal : ICustomerDal
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("{0} {1} isimli müşteri sisteme eklendi.", customer.FirstName, customer.LastName); ; ;
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("{0} {1} isimli müşteri sistemden silindi.", customer.FirstName, customer.LastName);

        }

        public void Update(Customer customer)
        {
            Console.WriteLine("{0} {1} isimli müşteri sistemde güncellendi.", customer.FirstName, customer.LastName);

        }

    
    }
}
