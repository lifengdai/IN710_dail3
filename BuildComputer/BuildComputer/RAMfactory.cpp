#include "RAMfactory.h"

RAMfactory::RAMfactory()
{
}


RAMfactory::~RAMfactory()
{
}

ComputerComponent* RAMfactory::create(int code)
{
	ComputerComponent* cc = nullptr;

	switch (code)
	{
	case 0:
		cc = new GameRAM();
		break;
	case 1:
		cc = new BusinessRAM();
		break;
	case 2:
		cc = new MultimediaRAM();
		break;
	}

	return cc;
}
