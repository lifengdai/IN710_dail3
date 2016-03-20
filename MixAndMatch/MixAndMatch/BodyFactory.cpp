#include "BodyFactory.h"



BodyFactory::BodyFactory()
{
}


BodyFactory::~BodyFactory()
{
}

gcroot<Bitmap^> BodyFactory::createBodyparts(string key)
{
	return body.Dictionary().at(key);
}
