#include "MakeMonstor.h"

MakeMonstor::MakeMonstor(ComboBox^ head, ComboBox^ body, ComboBox^ legs)
{
	for (int i = 0; i < keys->length(); i++)
	{
		head->Items->Add(gcnew String(keys[i].c_str()));
		body->Items->Add(gcnew String(keys[i].c_str()));
		legs->Items->Add(gcnew String(keys[i].c_str()));
	}
}

Monstor* MakeMonstor::monstor(string head, string body, string legs)
{
	return Monstor::create(hf.createBodyparts(head), bf.createBodyparts(body), lf.createBodyparts(legs));
}


MakeMonstor::~MakeMonstor()
{
}
