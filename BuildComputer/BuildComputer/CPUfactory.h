#pragma once
#include "Ifactory.h"
#include "CPU.h"
#include "GameCPU.h"
#include "BusinessCPU.h"
#include "MultimediaCPU.h"

class CPUfactory : public Ifactory
{
public:
	CPUfactory();
	virtual ComputerComponent* create(int) override;
	~CPUfactory();
};

