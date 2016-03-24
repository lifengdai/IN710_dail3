using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildComputerCSharp
{
    class Maker
    {
        private CPUfactory cpuf;
        private RAMfactory ramf;
        private GPUfactory gpuf;

        public Maker()
        {
            cpuf = new CPUfactory();
            ramf = new RAMfactory();
            gpuf = new GPUfactory();
        }

        public Computer GameComputerAssemblyLine()
        {
            return Computer.CreateComputer((GameCPU)cpuf.create(0), (GameRAM)ramf.create(0), (GameGPU)gpuf.create(0));
        }
        public Computer BusinessComputerAssemblyLine()
        {
            return Computer.CreateComputer((BusinessCPU)cpuf.create(1), (BusinessRAM)ramf.create(1), (BusinessGPU)gpuf.create(1));
        }
        public Computer MultimediaComputerAssemblyLine()
        {
            return Computer.CreateComputer((MultimediaCPU)cpuf.create(2), (MultimediaRAM)ramf.create(2), (MultimediaGPU)gpuf.create(2));
        }
    }
}
