#include "CPUfactory.h"

CPUfactory::CPUfactory()
{

}

CPUfactory::~CPUfactory()
{

}

ComputerComponent* CPUfactory::create(int code)
{
	ComputerComponent* cc = nullptr;

	switch (code)
	{
	case 0:
		cc = new GameCPU();
		break;
	case 1:
		cc = new BusinessCPU();
		break;
	case 2:
		cc = new MultimediaCPU();
		break;
	}

	return cc;
}
