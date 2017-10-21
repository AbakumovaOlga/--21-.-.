using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Прогр1_1_
{
    class Egg
    {
        private int ready;
        public int Ready { get { return ready; } }

        private bool have_eggshell = true;

        public bool Have_eggshell { set { have_eggshell = value; } get { return have_eggshell; } }


        //
        private bool dirty = true;
        public bool Dirty { set { dirty = value; } get { return dirty; } }

        //
        public void Cook()
        {
            if (Ready < 10)
            {
                ready++;
                Console.WriteLine("Яйца готовятся" + Ready);
            }
        }
    }
}
