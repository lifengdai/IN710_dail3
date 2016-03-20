#pragma once
#include "Monstor.h"
#include "HeadFactory.h"
#include "BodyFactory.h"
#include "LegsFactory.h"
#include "BodyParts.h"

using namespace System::Windows::Forms;

class MakeMonstor
{
private:
	HeadFactory hf;
	BodyFactory bf;
	LegsFactory lf;
	string keys[6] = { "fairy","frankenstein","skeleton","vampire","werewolf","witch" };
public:
	MakeMonstor(ComboBox^, ComboBox^, ComboBox^);
	Monstor* monstor(string, string, string);
	~MakeMonstor();
};

