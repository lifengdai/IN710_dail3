using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PertrolBots
{
    public partial class Form1 : Form
    {
        private List<Bots> botList;
        private List<Ship> shipList;
        private Random rand;
        private Graphics g;
        private int xBottomLeft;

        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();
            botList = new List<Bots>();
            shipList = new List<Ship>();
            rand = new Random();
            initBotsAndShips();
            xBottomLeft = 0;
            timer1.Start();         
        }

        private void initBotsAndShips()
        {
            for (int i = 0; i < 5; i++)
            {
                int x = rand.Next(0, 300);
                int y = rand.Next(0, 300);
                int xSpeed = 0;
                int ySpeed = 0;
                xBottomLeft += 30;
                int yButtomLeft = Height - 80;
                int colorChangeSpeed = rand.Next(5, 10);
                do
                {
                    xSpeed = rand.Next(-15, 15);
                    ySpeed = rand.Next(-15, 15);
                } while (xSpeed == 0 && ySpeed == 0);
                shipList.Add(new Ship(g, new SolidBrush(Color.Red), x, y, xSpeed, ySpeed, colorChangeSpeed));
                botList.Add(new Bots(timer2, shipList[i], g, new SolidBrush(Color.Cyan), xBottomLeft, yButtomLeft));
            }
        }

        private void drawShips()
        {
            for (int i = 0; i < 5; i++)
            {
                shipList[i].DrawShip();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveAllShip();
            Refresh();
            changeShipColor();
            drawShips();
            drawBots();
            checkNeeTurn();
            TrunBlackStop();
            fireEvent();
            fuelFill();
        }

        private void fuelFill()
        {
            for (int i = 0; i < 5; i++)
            {
                shipList[i].OnFUelFull();
            }
        }

        private void fireEvent()
        {
            for (int i = 0; i < 5; i++)
            {
                shipList[i].OnOutOfFuel();
            }
        }

        private void drawBots()
        {
            for (int i = 0; i < 5; i++)
            {
                botList[i].drawBots();
            }
        }

        private void TrunBlackStop()
        {
            for (int i = 0; i < 5; i++)
            {
                shipList[i].CheckNoFuelStop();
            }
        }

        private void changeShipColor()
        {
            for (int i = 0; i < 5; i++)
            {
                if (!shipList[i].Filling)
                {
                    shipList[i].ChangeColor();
                }
            }
        }

        private void checkNeeTurn()
        {
            for (int i = 0; i < 5; i++)
            {
                shipList[i].CheckNeedTurn(Width, Height);
            }
        }

        private void moveAllShip()
        {
            for (int i = 0; i < 5; i++)
            {
                shipList[i].MoveShip();
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            drawShips();
        }
    }
}
