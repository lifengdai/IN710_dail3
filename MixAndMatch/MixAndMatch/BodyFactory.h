#pragma once
#include "Ifactory.h"
#include "Body.h"

class BodyFactory :	public Ifactory
{
private:
	Body body;
public:
	BodyFactory();
	~BodyFactory();

	// Inherited via Ifactory
	virtual gcroot<Bitmap^> createBodyparts(string) override;
};

