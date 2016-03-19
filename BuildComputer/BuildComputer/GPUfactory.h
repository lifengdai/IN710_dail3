#pragma once
#include "Ifactory.h"
#include "GPU.h"
#include "GameGPU.h"
#include "BusinessGPU.h"
#include "MultimediaGPU.h"

class GPUfactory : public Ifactory
{
public:
	GPUfactory();
	virtual ComputerComponent* create(int) override;
	~GPUfactory();
};

