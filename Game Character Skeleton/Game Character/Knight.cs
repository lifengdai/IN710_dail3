using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Character
{
    class Knight:Characters
    {
        public Knight(string name) :
            base(name)
        {
            base.name = name;
            weapon = new Knife();
        }

        public override void ChangeWeapon(IWeaponBehaviour w)
        {
            weapon = w;
        }

        public override string Says()
        {
            return "I am a chivalrous Kight!\r\n";
        }

        public override string useWeapon()
        {
            return weapon.UseWeapon();
        }
    }
}
