#pragma once
#include <string>
#include <gcroot.h>
#include <map>

using namespace std;
using namespace System::Drawing;
using namespace System;

class BodyParts
{
protected:
	map<string, gcroot<Bitmap^>> dictionary;
	virtual pair<string, gcroot<Bitmap^>> cratePair(string, gcroot<Bitmap^>) = 0;
	virtual void addParts() = 0;
	virtual gcroot<Bitmap^> createBitmap(string) = 0;
public:
	BodyParts();
	map<string, gcroot<Bitmap^>> Dictionary();
	~BodyParts();
};

