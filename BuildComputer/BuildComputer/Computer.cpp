#include "Computer.h"

Computer::Computer()
{
	cpu = nullptr;
	ram = nullptr;
	gpu = nullptr;
}

Computer* Computer::CreateComputer(CPU* cpu, RAM* ram, GPU* gpu)
{
	Computer* computer = new Computer;
	computer->cpu = cpu;
	computer->ram = ram;
	computer->gpu = gpu;
	return computer;
}

void Computer::printToDisplay(ListBox^ lb)
{
	String^ display = gcnew String("price     Component");
	String^ sperater = gcnew String("--------------------");
	lb->Items->Add(display);
	lb->Items->Add(sperater);
	lb->Items->Add(gcnew String(cpu->printThis().c_str()));
	lb->Items->Add(gcnew String(ram->printThis().c_str()));
	lb->Items->Add(gcnew String(gpu->printThis().c_str()));
	lb->Items->Add(sperater);
	lb->Items->Add("Total Price: " + gcnew String(computerPrice().c_str()));
}

string Computer::computerPrice()
{
	int total = cpu->getPrice() + ram->getPrice() + gpu->getPrice();
	return to_string(total);
}

Computer::~Computer()
{
}
