using GameMain.Base;
using GameMain.Characters;
using GameMain.Stores;
using GameMain.Stores.Armors;
using GameMain.Stores.Weapons;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMain
{
    public class StoreManager
    {
        public WeaponStore CreatWeaponStore(Character character)
        {
            if (character is Warrior)
            {
                return new WarriorWeaponStore();
            }
            else if (character is Wizard)
            {
                return new WizardWeaponStore();
            }
            else if (character is Monster)
            {
                return new MonsterWeaponStore();
            }

            return null;
        }

        public ArmorStore CreatArmorStore(Character character)
        {
            if (character is Warrior)
            {
                return new WarriorArmorStore();
            }
            else if (character is Wizard)
            {
                return new WizardArmorStore();
            }
            else if (character is Monster)
            {
                return new MonsterArmorStore();
            }

            return null;
        }
    }
}
