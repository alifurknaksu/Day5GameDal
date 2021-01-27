using Day5GameDal.IAbstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Day5GameDal.Units
{
    class Games : IGames
    {
        public int Id { get; set; }
        public string GameName { get ; set ; }
        public double Price { get ; set; }
        public string GameDlcs { get ; set ; }
    }
}
