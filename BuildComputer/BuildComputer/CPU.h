#pragma once
#include "ComputerComponent.h"

class CPU : public ComputerComponent
{
protected:
	string speed;
	string numOfCore;
public:
	CPU();
	string printThis() override;
	~CPU();
};

