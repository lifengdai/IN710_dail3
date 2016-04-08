using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PertrolBots
{
    class Ship
    {
        private Bots bots;
        private Graphics graphics;
        private SolidBrush brush;
        private int x;
        private int y;
        private int XSpeed;
        private int YSpeed;
        private int RColor;
        private int colorChangeSpeed;
        private const int SIZE_SHIP = 50;

        public Ship(Bots bots, Graphics graphics, SolidBrush brush, int x, int y, int XSpeed, int YSpeed, int colorChangeSpeed)
        {
            this.bots = bots;
            this.graphics = graphics;
            this.brush = brush;
            this.x = x;
            this.y = y;
            this.XSpeed = XSpeed;
            this.YSpeed = YSpeed;
            RColor = 255;
            this.colorChangeSpeed = colorChangeSpeed;
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
    }
}
