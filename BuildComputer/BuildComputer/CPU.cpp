#include "CPU.h"

CPU::CPU()
{
	
}

string CPU::printThis()
{
	return ComputerComponent::printThis() + numOfCore + ", " + speed;
}

CPU::~CPU()
{
}
