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

        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();
            botList = new List<Bots>();
            shipList = new List<Ship>();
            rand = new Random();
            initBotsAndShips();
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
                int colorChangeSpeed = rand.Next(1, 5);
                do
                {
                    xSpeed = rand.Next(-15, 15);
                    ySpeed = rand.Next(-15, 15);
                } while (xSpeed == 0 && ySpeed == 0);
                botList.Add(new Bots(g, new SolidBrush(Color.Cyan)));
                shipList.Add(new Ship(botList[i], g, new SolidBrush(Color.Red), x, y, xSpeed, ySpeed, colorChangeSpeed));
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
            checkNeeTurn();
        }

        private void changeShipColor()
        {
            for (int i = 0; i < 5; i++)
            {
                shipList[i].ChangeColor();
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
