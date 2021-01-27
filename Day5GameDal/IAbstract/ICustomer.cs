using System;
using System.Collections.Generic;
using System.Text;

namespace Day5GameDal.IAbstract
{
    public interface ICustomer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TcNo { get; set; }

    }
}