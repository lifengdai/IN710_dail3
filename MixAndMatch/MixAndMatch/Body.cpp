#include "Body.h"

Body::Body()
{
	addParts();
}

Body::~Body()
{
}

pair<string, gcroot<Bitmap^>> Body::cratePair(string s, gcroot<Bitmap^> b)
{
	return make_pair(s, b);
}

void Body::addParts()
{
	dictionary.insert(cratePair("fairy", createBitmap("Fairy_1.png")));
	dictionary.insert(cratePair("frankenstein", createBitmap("Frankenstein_1.png")));
	dictionary.insert(cratePair("skeleton", createBitmap("Skeleton_1.png")));
	dictionary.insert(cratePair("vampire", createBitmap("Vampire_1.png")));
	dictionary.insert(cratePair("werewolf", createBitmap("Werewolf_1.png")));
	dictionary.insert(cratePair("witch", createBitmap("Witch_1.png")));
}

gcroot<Bitmap^> Body::createBitmap(string file)
{
	gcroot<Bitmap^> bitmap;
	bitmap->FromFile("C:/Users/´÷Àû·á/Documents/Visual Studio 2015/Projects/MixAndMatch/Pictures/" + gcnew String(file.c_str()));
	return bitmap;
}
