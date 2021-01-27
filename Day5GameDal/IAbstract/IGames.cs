using System;
using System.Collections.Generic;
using System.Text;

namespace Day5GameDal.IAbstract
{
    interface IGames
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public double Price { get; set; }
        public string GameDlcs { get; set; }
    }
}
