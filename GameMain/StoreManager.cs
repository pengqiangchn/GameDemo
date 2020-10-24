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
        public WeaponStore CreatWeaponStore(string name)
        {
            if (name == "战士")
                return new WarriorWeaponStore();
            if (name == "法师")
                return new WizardWeaponStore();
            if (name == "妖怪")
                return new MonsterWeaponStore();

            return null;
        }

        public ArmorStore CreatArmorStore(string name)
        {
            if (name == "战士")
                return new WarriorArmorStore();
            if (name == "法师")
                return new WizardArmorStore();
            if (name == "妖怪")
                return new MonsterArmorStore();

            return null;
        }
    }
}
