using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Прогр1_1_
{
    class Stove
    {
        private Pan pan;
        private bool state;
        public bool State { set { state = value; } get { return state; } }
        public Pan Pan { set { pan = value; } get { return pan; } }

        public void Cooking()
        {
            if (State)
            {
                while (!pan.IsReady())
                {
                    pan.Cook();
                }
            }
        }
    }
}
