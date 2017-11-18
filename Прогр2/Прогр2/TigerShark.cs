using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Прогр2
{
    public class TigerShark : Shark
    {
        private bool bands;
        private Color dopColor;

        public TigerShark(double speed, int Age, int weight, Color color, bool bands, Color dopColor) : base(speed, Age, weight, color)
        {
            this.bands = bands;
            this.dopColor = dopColor;
        }
        protected override void draw1Shark(Graphics g)
        {
            base.draw1Shark(g);
            if (bands)
            {
                //Drawing2
                Pen pen = new Pen(dopColor);

                g.DrawLine(pen, startPosX + Age * 3, startPosY - Weight, startPosX + Age * 4, startPosY);
                g.DrawLine(pen, startPosX + Age * 6, startPosY - Weight / 2, startPosX + Age * 7, startPosY);
            }
        }
    }
}
