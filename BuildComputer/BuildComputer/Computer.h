#pragma once
#include "CPU.h"
#include "GPU.h"
#include "RAM.h"

using namespace System::Windows::Forms;
using namespace System;

class Computer
{
private:
	CPU* cpu;
	RAM* ram;
	GPU* gpu;
	string computerPrice();

public:
	Computer();
	static Computer* CreateComputer(CPU*, RAM*, GPU*);
	void printToDisplay(ListBox^);
	~Computer();
};

