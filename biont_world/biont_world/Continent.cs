using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biont_world
{
    public abstract class Continent
    {
        public const int COUNT = 4;
        protected ListBox displaybox;
        protected Random rGen;
        protected int types;
        protected Graphics canvas;
        protected iFactory factory;

        public Continent(ListBox displaybox, Random rGen, int types, Graphics canvas)
        {
            this.displaybox = displaybox;
            this.rGen = rGen;
            this.types = types;
            this.canvas = canvas;
        }

        public void run()
        {
            Biont biont;
            displaybox.Items.Clear();
            for (int i = 0; i < COUNT; i++)
            {
                int choice = rGen.Next(types);
                biont = factory.create(choice);
                displaybox.Items.Add(biont.ToString());
                canvas.DrawImage(biont.Image, 20, 20 + i * 150, 150, 150);
            }
        }
    }
}
