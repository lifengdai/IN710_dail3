#pragma once
#include "Ifactory.h"
#include "Head.h"

class HeadFactory : public Ifactory
{
private:
	Head head;
public:
	HeadFactory();
	~HeadFactory();

	// Inherited via Ifactory
	virtual gcroot<Bitmap^> createBodyparts(string) override;
};

