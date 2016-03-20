#include "BodyParts.h"

BodyParts::BodyParts()
{
}

map<string, gcroot<Bitmap^>> BodyParts::Dictionary()
{
	return dictionary;
}


BodyParts::~BodyParts()
{
}
