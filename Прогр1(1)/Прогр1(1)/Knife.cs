using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Прогр1_1_
{
    class Knife
    {
        public void Hit(Egg egg)
        {

            if (!egg.Dirty)
            {
                if (egg.Have_eggshell)
                {
                    egg.Have_eggshell = false;

                }
            }
        }
    }
}
