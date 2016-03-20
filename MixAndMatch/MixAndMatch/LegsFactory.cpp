#include "LegsFactory.h"

LegsFactory::LegsFactory()
{
}


LegsFactory::~LegsFactory()
{
}

gcroot<Bitmap^> LegsFactory::createBodyparts(string key)
{
	return legs.Dictionary().at(key);
}
