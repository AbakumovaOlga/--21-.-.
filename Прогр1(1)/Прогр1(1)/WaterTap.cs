using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Прогр1_1_
{
    class WaterTap
    {

        private bool open { set; get; }
        public bool Open { set { open = value; } get { return open; } }


        public void Wash(Egg egg)
        {
            if (open)
            {
                egg.Dirty = false;
                Console.WriteLine("Яйцо вымыто");
            }
        }
    }
}
