#pragma once
#include "ComputerComponent.h"

class RAM : public ComputerComponent
{
protected:
	string compacity;
public:
	RAM();
	string printThis() override;
	~RAM();
};

