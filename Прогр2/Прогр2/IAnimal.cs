﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Прогр2
{
    public interface IAnimal
    {
        void moveAnimal(Graphics g);
        void drawAnimal(Graphics g);
        void setPos(int x, int y);
        void grow(int a);
    }
}
