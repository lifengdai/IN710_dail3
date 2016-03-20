#include "HeadFactory.h"

HeadFactory::HeadFactory()
{
}

HeadFactory::~HeadFactory()
{
}

gcroot<Bitmap^> HeadFactory::createBodyparts(string key)
{
	return head.Dictionary().at(key);
}
