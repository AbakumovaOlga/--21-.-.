using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Прогр2
{
    class Aquarium
    {
        ClassArray<Animal> aquarium;
        int countCell = 20;
        int cellW = 210;
        int cellH = 80;

        public Aquarium()
        {
            aquarium = new ClassArray<Animal>(countCell, null);
        }

        public int PutSharkInAquarium(Animal shark)
        {
            return aquarium + shark;
        }

        public Animal GetSharkinAquarium(int ticket)
        {
            return aquarium - ticket;
        }

        public void Draw(Graphics g, int w, int h)
        {
            DrawCells(g);
            for (int i = 0; i < countCell; i++)
            {
                var shark = aquarium.getObject(i);
                if (shark != null)
                {
                    shark.setPos(5 + i / 5 * cellW, i % 5 * cellH + 40);
                    shark.drawAnimal(g);
                }

            }
        }

        private void DrawCells(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
         //   g.DrawRectangle(pen, 0, 0, (countCell / 5) * cellH, 480);

            for (int i = 0; i < countCell / 5; i++)
            {
                for (int j = 0; j < 6; ++j)
                {
                     g.DrawLine(pen, i * cellW, j * cellH, i * cellW + 110, j * cellH);
                    g.DrawLine(pen, i * cellW, j * cellH, i * cellW , j * cellH+ 110);
                    g.DrawLine(pen, i * cellW + 110, j * cellH, i * cellW + 110, j * cellH + 110);
                    //g.DrawRectangle(pen, i * cellW, j * cellH, i * cellW + 110, j * cellH);
                }
               // g.DrawLine(pen, i * cellW, 0, i * cellW, 400);
            }
        }
    }
}

