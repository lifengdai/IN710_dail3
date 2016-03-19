#include "GPUfactory.h"

GPUfactory::GPUfactory()
{
}


GPUfactory::~GPUfactory()
{
}

ComputerComponent * GPUfactory::create(int code)
{
	ComputerComponent* cc = nullptr;

	switch (code)
	{
	case 0:
		cc = new GameGPU();
		break;
	case 1:
		cc = new BusinessGPU();
		break;
	case 2:
		cc = new MultimediaGPU();
		break;
	}

	return cc;
}
