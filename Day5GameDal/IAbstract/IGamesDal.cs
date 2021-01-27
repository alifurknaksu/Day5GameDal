using System;
using System.Collections.Generic;
using System.Text;
using Day5GameDal.Units;

namespace Day5GameDal.IAbstract
{
    interface IGamesDal
    {
        void Add(Games game);
        void Update(Games game);
        void Delete(Games game);
    }
}
