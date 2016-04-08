using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PertrolBots
{
    class Ship
    {
        public delegate void OutOfFuelHandler(object o, EventArgs e);
        public event OutOfFuelHandler OutOfFuel;

        private Graphics graphics;
        private SolidBrush brush;
        private Form1 form;
        private int x;
        private int y;
        private int XSpeed;
        private int YSpeed;
        private int XSpeedIntermediate;
        private int YSpeedIntermediate;
        private int RColor;
        private int colorChangeSpeed;
        private bool outOfFuel;
        private bool fillShipFinished;
        private const int SIZE_SHIP = 50;

        public Ship(Form1 form, Graphics graphics, SolidBrush brush, int x, int y, int XSpeed, int YSpeed, int colorChangeSpeed)
        {
            this.graphics = graphics;
            this.brush = brush;
            this.x = x;
            this.y = y;
            this.XSpeed = XSpeed;
            XSpeedIntermediate = XSpeed;
            YSpeedIntermediate = YSpeed;
            this.YSpeed = YSpeed;
            RColor = 255;
            this.colorChangeSpeed = colorChangeSpeed;
            outOfFuel = false;
            fillShipFinished = false;
            this.form = form;
        }

        public void DrawShip()
        {
            graphics.FillRectangle(brush, x, y, SIZE_SHIP, SIZE_SHIP);
        }
        
        public void MoveShip()
        {
            x += XSpeed;
            y += YSpeed;
        }

        public void CheckNeedTurn(int xBounds, int yBounds)
        {
            if(x <= 0 || x + SIZE_SHIP >= xBounds)
            {
                XSpeed = -XSpeed;
            }
            if(y <= 0 || y + SIZE_SHIP * 3 >= yBounds)
            {
                YSpeed = -YSpeed;
            }
        }

        public void ChangeColor()
        {
            RColor -= colorChangeSpeed;

            if (RColor >= 0)
            {
                Color color = Color.FromArgb(RColor, 0, 0);
                brush.Color = color;
            }
            else
            {
                RColor = 0;
            }
        }

        public void BecomeRed()
        {
            RColor += colorChangeSpeed;
            if (RColor > 255)
            {
                RColor = 255;
            }
            else
            {
                Color color = Color.FromArgb(RColor, 0, 0);
                brush.Color = color;
            }
        }

        public void CheckNoFuelStop()
        {
            if(RColor == 0)
            {
                XSpeed = 0;
                YSpeed = 0;
                outOfFuel = true;
            }
        }

        public void OnOutOfFuel()
        {
            if (outOfFuel)
            {
                if (OutOfFuel != null)
                    OutOfFuel(this, new EventArgs());
            }
        }

        public void fill()
        {
            while(RColor != 255)
            {
                BecomeRed();               
                DrawShip();
                //Thread.Sleep(10);
            }
        }

        public int X
        {
            get { return x; }
        }

        public int Y
        {
            get { return y; }
        }
    }
}
