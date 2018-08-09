using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedToKnowThisStuff
{
   class GameCode
    {
        public int count = 0;
        public int RNDgenerator()
        {
            Random rndNumber = new Random();
            int rnd = rndNumber.Next(1, 7);
            return rnd;

            //we can do this in real world
            //return  rndNumber.Next(1, 7);
        }
    }
}
