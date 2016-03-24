using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinAndMatchCSharp
{
    class Head : BodyParts
    {
        public Head()
        {
            addParts();
        }

        protected override void addParts()
        {
            dictionary.Add("fairy", createBitmap("Fairy_0.png"));
            dictionary.Add("frankenstein", createBitmap("Frankenstein_0.png"));
            dictionary.Add("skeleton", createBitmap("Skeleton_0.png"));
            dictionary.Add("vampire", createBitmap("Vampire_0.png"));
            dictionary.Add("werewolf", createBitmap("Werewolf_0.png"));
            dictionary.Add("witch", createBitmap("Witch_0.png"));
        }
    }
}
