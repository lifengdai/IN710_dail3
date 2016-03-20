#include "Head.h"

Head::Head()
{
	addParts();
}

Head::~Head()
{
}

void Head::addParts()
{
	//should use for loop
	dictionary.insert(cratePair("fairy", createBitmap("Fairy_0.png")));
	dictionary.insert(cratePair("frankenstein", createBitmap("Frankenstein_0.png")));
	dictionary.insert(cratePair("skeleton", createBitmap("Skeleton_0.png")));
	dictionary.insert(cratePair("vampire", createBitmap("Vampire_0.png")));
	dictionary.insert(cratePair("werewolf", createBitmap("Werewolf_0.png")));
	dictionary.insert(cratePair("witch", createBitmap("Witch_0.png")));
}

pair<string, gcroot<Bitmap^>> Head::cratePair(string s, gcroot<Bitmap^> b)
{
	return make_pair(s, b);
}

gcroot<Bitmap^> Head::createBitmap(string file)
{
	gcroot<Bitmap^> bitmap;
	bitmap->FromFile("C:/Users/´÷Àû·á/Documents/Visual Studio 2015/Projects/MixAndMatch/Pictures/" + gcnew String(file.c_str()));
	return bitmap;
}
