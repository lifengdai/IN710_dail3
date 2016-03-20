#include "Legs.h"

Legs::Legs()
{
	addParts();
}


Legs::~Legs()
{
}

pair<string, gcroot<Bitmap^>> Legs::cratePair(string s, gcroot<Bitmap^> b)
{
	return make_pair(s, b);
}

void Legs::addParts()
{
	dictionary.insert(cratePair("fairy", createBitmap("Fairy_2.png")));
	dictionary.insert(cratePair("frankenstein", createBitmap("Frankenstein_2.png")));
	dictionary.insert(cratePair("skeleton", createBitmap("Skeleton_2.png")));
	dictionary.insert(cratePair("vampire", createBitmap("Vampire_2.png")));
	dictionary.insert(cratePair("werewolf", createBitmap("Werewolf_2.png")));
	dictionary.insert(cratePair("witch", createBitmap("Witch_2.png")));
}

gcroot<Bitmap^> Legs::createBitmap(string file)
{
	gcroot<Bitmap^> bitmap;
	bitmap->FromFile("C:/Users/´÷Àû·á/Documents/Visual Studio 2015/Projects/MixAndMatch/Pictures/" + gcnew String(file.c_str()));
	return bitmap;
}
