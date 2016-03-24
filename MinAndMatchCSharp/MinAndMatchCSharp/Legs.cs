using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinAndMatchCSharp
{
    class Legs : BodyParts
    {
        public Legs()
        {
            addParts();
        }

        protected override void addParts()
        {
            dictionary.Add("fairy", createBitmap("Fairy_2.png"));
            dictionary.Add("frankenstein", createBitmap("Frankenstein_2.png"));
            dictionary.Add("skeleton", createBitmap("Skeleton_2.png"));
            dictionary.Add("vampire", createBitmap("Vampire_2.png"));
            dictionary.Add("werewolf", createBitmap("Werewolf_2.png"));
            dictionary.Add("witch", createBitmap("Witch_2.png"));
        }
    }
}
