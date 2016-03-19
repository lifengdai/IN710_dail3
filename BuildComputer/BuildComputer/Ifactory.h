#pragma once
#include "ComputerComponent.h"

__interface Ifactory
{
public:
	virtual ComputerComponent* create(int) = 0;
};
