using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Character
{
    public class King:Characters
    {
        public King(string name) :
            base(name)
        {
            base.name = name;
            weapon = new Sword();
        }

        public override void ChangeWeapon(IWeaponBehaviour w)
        {
            weapon = w;
        }

        public override string Says()
        {
            return "I am the most mighty of kings!\r\n";
        }

        public override string useWeapon()
        {
            return weapon.UseWeapon();
        }
    }
}
