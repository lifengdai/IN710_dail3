using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PertrolBots
{
    class Bots
    {
        private Graphics graphics;
        private SolidBrush brush;
        private Ship ships;
        private Timer timer;
        private int x;
        private int y;
        private int XSpeedIntermediate;
        private int YSpeedIntermediate;
        private const int SIZE = 15;

        public Bots(Timer timer, Ship ships, Graphics graphics, SolidBrush brush, int x, int y)
        {
            this.ships = ships;
            this.graphics = graphics;
            this.brush = brush;
            this.x = x;
            this.y = y;
            XSpeedIntermediate = x;
            YSpeedIntermediate = y;
            this.timer = timer;
            ships.OutOfFuel += new Ship.OutOfFuelHandler(BeCalled);
            ships.FuelFill += new Ship.FuelFillHandler(Return);
        }

        public void drawBots()
        {
            graphics.FillEllipse(brush, x, y, SIZE, SIZE);
        }

        public void BeCalled(object o, EventArgs e)
        {           
            x = ((Ship)o).X;
            y = ((Ship)o).Y;
            timer.Tick += new EventHandler(((Ship)o).Fill);
            timer.Start();
        }

        public void Return(object o, EventArgs e)
        {
            x = XSpeedIntermediate;
            y = YSpeedIntermediate;
            ((Ship)o).XSpeed1 = ((Ship)o).XSpeedIntermediate1;
            ((Ship)o).YSpeed1 = ((Ship)o).YSpeedIntermediate1;
        }
    }
}
