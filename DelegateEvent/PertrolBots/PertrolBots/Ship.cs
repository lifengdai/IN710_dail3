using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PertrolBots
{
    class Ship
    {
        public delegate void OutOfFuelHandler(object o, EventArgs e);
        public event OutOfFuelHandler OutOfFuel;
        public delegate void FuelFillHandler(object o, EventArgs e);
        public event FuelFillHandler FuelFill;

        private Graphics graphics;
        private SolidBrush brush;
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
        private bool filling;
        private const int SIZE_SHIP = 50;

        public Ship(Graphics graphics, SolidBrush brush, int x, int y, int XSpeed, int YSpeed, int colorChangeSpeed)
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
            filling = false;
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
                XSpeedIntermediate = -XSpeedIntermediate;
            }
            if(y <= 0 || y + SIZE_SHIP * 3 >= yBounds)
            {
                YSpeed = -YSpeed;
                YSpeedIntermediate = -YSpeedIntermediate;
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
                fillShipFinished = false;
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

        public void OnFUelFull()
        {
            if (fillShipFinished)
                if (FuelFill != null)
                    FuelFill(this, new EventArgs());
        }

        public void Fill(object o, EventArgs e)
        {
            if (outOfFuel)
            {
                if (RColor == 255)
                {
                    fillShipFinished = true;
                    filling = false;
                    outOfFuel = false;
                }
                else
                {
                    BecomeRed();
                    DrawShip();
                    filling = true;
                }
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

        public bool Filling
        {
            get
            {
                return filling;
            }
        }

        public int XSpeedIntermediate1
        {
            get
            {
                return XSpeedIntermediate;
            }
        }

        public int YSpeedIntermediate1
        {
            get
            {
                return YSpeedIntermediate;
            }
        }

        public int XSpeed1
        {
            set
            {
                XSpeed = value;
            }
        }

        public int YSpeed1
        {
            set
            {
                YSpeed = value;
            }
        }

        public bool OutOfFuel1
        {
            get
            {
                return outOfFuel;
            }

            set
            {
                outOfFuel = value;
            }
        }

        public bool FillShipFinished
        {
            get
            {
                return fillShipFinished;
            }

            set
            {
                fillShipFinished = value;
            }
        }
    }
}
