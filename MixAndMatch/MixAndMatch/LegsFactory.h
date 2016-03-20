#pragma once
#include "Ifactory.h"
#include "Legs.h"

class LegsFactory :	public Ifactory
{
private:
	Legs legs;
public:
	LegsFactory();
	~LegsFactory();

	// Inherited via Ifactory
	virtual gcroot<Bitmap^> createBodyparts(string) override;
};

