using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Character
{
    class Queen:Characters
    {
        public Queen(string name)
            :base(name)
        {
            base.name = name;
            weapon = new Bow();
        }

        public override void ChangeWeapon(IWeaponBehaviour w)
        {
            weapon = w;
        }

        public override string Says()
        {
            return "I am the powerful Queens!\r\n";
        }

        public override string useWeapon()
        {
            return weapon.UseWeapon();
        }
    }
}
