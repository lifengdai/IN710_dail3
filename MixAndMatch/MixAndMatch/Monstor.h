#pragma once
#include "BodyParts.h"

class Monstor
{
private:
	gcroot<Bitmap^> head;
	gcroot<Bitmap^> body;
	gcroot<Bitmap^> legs;

public:
	Monstor();
	static Monstor* create(gcroot<Bitmap^>, gcroot<Bitmap^>, gcroot<Bitmap^>);
	gcroot<Bitmap^> getHead();
	gcroot<Bitmap^> getBody();
	gcroot<Bitmap^> getLegs();
	~Monstor();
};

