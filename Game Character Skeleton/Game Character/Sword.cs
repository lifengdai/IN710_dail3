﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Character
{
    class Sword : IWeaponBehaviour
    {
        public string UseWeapon()
        {
            return "I slice with my sword";
        }
    }
}
