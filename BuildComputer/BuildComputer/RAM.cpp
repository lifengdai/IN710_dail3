#include "RAM.h"

RAM::RAM()
{
}

string RAM::printThis()
{
	return ComputerComponent::printThis() + compacity;
}

RAM::~RAM()
{
}
