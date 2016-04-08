using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PertrolBots
{
    class Bots
    {
        private Graphics graphics;
        private SolidBrush brush;
        private Ship ships;
        private int x;
        private int y;
        private const int SIZE = 15;

        public Bots(Ship ships, Graphics graphics, SolidBrush brush, int x, int y)
        {
            this.ships = ships;
            this.graphics = graphics;
            this.brush = brush;
            this.x = x;
            this.y = y;
            ships.OutOfFuel += new Ship.OutOfFuelHandler(BeCalled);
        }

        public void drawBots()
        {
            graphics.FillEllipse(brush, x, y, SIZE, SIZE);
        }

        public void BeCalled(object o, EventArgs e)
        {
            x = ((Ship)o).X;
            y = ((Ship)o).Y;
            ((Ship)o).fill();         
        }
    }
}
