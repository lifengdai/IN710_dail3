#pragma once
#include <string>

using namespace std;

class ComputerComponent
{
protected:
	string name;
	int price;

public:
	ComputerComponent();
	virtual string printThis();
	int getPrice();
	~ComputerComponent();
};

