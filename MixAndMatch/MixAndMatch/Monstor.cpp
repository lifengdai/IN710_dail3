#include "Monstor.h"

Monstor::Monstor()
{
}

Monstor* Monstor::create(gcroot<Bitmap^> head, gcroot<Bitmap^> body, gcroot<Bitmap^> legs)
{
	Monstor* monstor = new Monstor();
	monstor->head = head;
	monstor->body = body;
	monstor->legs = legs;
	return monstor;
}

gcroot<Bitmap^> Monstor::getHead()
{
	return head;
}

gcroot<Bitmap^> Monstor::getBody()
{
	return body;
}

gcroot<Bitmap^> Monstor::getLegs()
{
	return legs;
}

Monstor::~Monstor()
{
}
