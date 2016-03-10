using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Character
{
    public abstract class Characters
    {
        protected string name;
        protected IWeaponBehaviour weapon;

        public Characters(string name)
        {
            this.name = name;
        }

        public string StateName()
        {
            return "My name is " + name + "\r\n";
        }

        public abstract string Says();

        public abstract string useWeapon();

        public abstract void ChangeWeapon(IWeaponBehaviour w);

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
    }
}
