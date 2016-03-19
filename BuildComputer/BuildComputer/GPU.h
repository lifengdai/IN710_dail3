#pragma once
#include "ComputerComponent.h"

class GPU : public ComputerComponent
{
protected:
	string compacity;
	string memoryInterface;
public:
	GPU();
	string printThis() override;
	~GPU();
};