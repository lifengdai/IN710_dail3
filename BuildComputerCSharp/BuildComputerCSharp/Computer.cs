using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuildComputerCSharp
{
    class Computer
    {
        private CPU cpu;
        private RAM ram;
        private GPU gpu;

        public Computer()
        {
            cpu = null;
            ram = null;
            gpu = null;
        }
        public static Computer CreateComputer(CPU cpu, RAM ram, GPU gpu)
        {
            Computer computer = new Computer();
            computer.cpu = cpu;
            computer.ram = ram;
            computer.gpu = gpu;
            return computer;
        }
        public void printToDisplay(ListBox lb)
        {
            string display = "price     Component";
            string sperater = "--------------------";
            lb.Items.Add(display);
            lb.Items.Add(sperater);
            lb.Items.Add(cpu.printThis());
            lb.Items.Add(ram.printThis());
            lb.Items.Add(gpu.printThis());
            lb.Items.Add(sperater);
            lb.Items.Add("Total Price: " + computerPrice());
        }

        private string computerPrice()
        {
            int total = cpu.getPrice() + ram.getPrice() + gpu.getPrice();
            return total.ToString();
        }
    }
}
