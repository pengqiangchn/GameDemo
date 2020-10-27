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
        public Func<string, int> GetCommand;

        public StoreManager(Func<string, int> getCommand)
        {
            GetCommand = getCommand;
        }

        public void CreatStore(Character character)
        {
            CreatWeaponStore(character);
            CreatArmorStore(character);
        }

        public void CreatWeaponStore(Character character)
        {
            if (character is Warrior)
            {
                character.WeaponStore = new WarriorWeaponStore(GetCommand);
            }
            else if (character is Wizard)
            {
                character.WeaponStore = new WarriorWeaponStore(GetCommand);
            }
            else if (character is Monster)
            {
                character.WeaponStore = new WarriorWeaponStore(GetCommand);
            }
        }

        public void CreatArmorStore(Character character)
        {
            if (character is Warrior)
            {
                character.ArmorStore = new WarriorArmorStore(GetCommand);
            }
            else if (character is Wizard)
            {
                character.ArmorStore = new WizardArmorStore(GetCommand);
            }
            else if (character is Monster)
            {
                character.ArmorStore = new MonsterArmorStore(GetCommand);
            }
        }
    }
}
