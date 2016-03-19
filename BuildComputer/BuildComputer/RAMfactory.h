#pragma once
#include "Ifactory.h"
#include "RAM.h"
#include "GameRAM.h"
#include "BusinessRAM.h"
#include "MultimediaRAM.h"

class RAMfactory :	public Ifactory
{
public:
	RAMfactory();
	virtual ComputerComponent* create(int) override;
	~RAMfactory();
};

