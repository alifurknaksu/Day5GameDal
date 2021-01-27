using Day5GameDal.IAbstract;
using System;
using System.Collections.Generic;
using System.Text;
using Day5GameDal.Units;

namespace Day5GameDal.Concrete
{
    class GamesDal : IGamesDal
    {
        public void Add(Games game)
        {
            Console.WriteLine("{0} isimli oyun sisteme eklendi.", game.GameName);
        }

        public void Delete(Games game)
        {
            Console.WriteLine("{0} isimli oyun sistemden silindi.", game.GameName);
        }

        public void Update(Games game)
        {
            Console.WriteLine("{0} isimli oyun sistemde güncellendi.", game.GameName);
        }
    }
}
