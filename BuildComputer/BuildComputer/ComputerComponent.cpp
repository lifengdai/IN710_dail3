#include "ComputerComponent.h"

ComputerComponent::ComputerComponent()
{

}

string ComputerComponent::printThis()
{
	string display = to_string(price);
	display += "     " + name;
	return display;
}

int ComputerComponent::getPrice()
{
	return price;
}

ComputerComponent::~ComputerComponent()
{
	
}
