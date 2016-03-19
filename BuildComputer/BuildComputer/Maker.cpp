#include "Maker.h"

Maker::Maker()
{
}

Computer* Maker::GameComputerAssemblyLine()
{
	return Computer::CreateComputer((GameCPU*)cpuf.create(0), (GameRAM*)ramf.create(0), (GameGPU*)gpuf.create(0));
}

Computer* Maker::BusinessComputerAssemblyLine()
{
	return Computer::CreateComputer((BusinessCPU*)cpuf.create(1), (BusinessRAM*)ramf.create(1), (BusinessGPU*)gpuf.create(1));
}

Computer* Maker::MultimediaComputerAssemblyLine()
{
	return Computer::CreateComputer((MultimediaCPU*)cpuf.create(2), (MultimediaRAM*)ramf.create(2), (MultimediaGPU*)gpuf.create(2));
}

Maker::~Maker()
{
}
