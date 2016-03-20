#pragma once
#include "BodyParts.h"

__interface Ifactory
{
public:
	virtual  gcroot<Bitmap^> createBodyparts(string) = 0;
};
