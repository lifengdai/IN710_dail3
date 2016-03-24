using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinAndMatchCSharp
{
    class Body : BodyParts
    {
        public Body()
        {
            addParts();
        }

        protected override void addParts()
        {
            dictionary.Add("fairy", createBitmap("Fairy_1.png"));
            dictionary.Add("frankenstein", createBitmap("Frankenstein_1.png"));
            dictionary.Add("skeleton", createBitmap("Skeleton_1.png"));
            dictionary.Add("vampire", createBitmap("Vampire_1.png"));
            dictionary.Add("werewolf", createBitmap("Werewolf_1.png"));
            dictionary.Add("witch", createBitmap("Witch_1.png"));
        }
    }
}
