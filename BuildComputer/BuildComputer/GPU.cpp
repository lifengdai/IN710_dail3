#include "GPU.h"

GPU::GPU()
{
}

string GPU::printThis()
{
	return ComputerComponent::printThis() + ", " + compacity + ", " + memoryInterface;
}


GPU::~GPU()
{
}
