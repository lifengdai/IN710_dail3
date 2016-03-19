#pragma once
#include "Computer.h"
#include "CPUfactory.h"
#include "RAMfactory.h"
#include "GPUfactory.h"

class Maker
{
private:
	CPUfactory cpuf;
	RAMfactory ramf;
	GPUfactory gpuf;

public:
	Maker();
	Computer* GameComputerAssemblyLine();
	Computer* BusinessComputerAssemblyLine();
	Computer* MultimediaComputerAssemblyLine();
	~Maker();
};

