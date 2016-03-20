#pragma once
#include "BodyParts.h"
#include <string>

class Head : public BodyParts
{
private:
	virtual void addParts() override;
	virtual pair<string, gcroot<Bitmap^>> cratePair(string, gcroot<Bitmap^>) override;
	virtual gcroot<Bitmap^> createBitmap(string) override;

public:
	Head();
	~Head();


};

