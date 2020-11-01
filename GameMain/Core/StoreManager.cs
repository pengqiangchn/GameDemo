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
            switch (character.Role)
            {
                case Enums.CharacterRoleEnum.Warrior:
                    {
                        character.WeaponStore = new WarriorWeaponStore(GetCommand);
                    }
                    break;
                case Enums.CharacterRoleEnum.Wizard:
                    {
                        character.WeaponStore = new WizardWeaponStore(GetCommand);
                    }
                    break;
                case Enums.CharacterRoleEnum.Monster:
                    {
                        character.WeaponStore = new MonsterWeaponStore(GetCommand);
                    }
                    break;
                case Enums.CharacterRoleEnum.None:
                default:
                    break;
            }
        }

        public void CreatArmorStore(Character character)
        {
            switch (character.Role)
            {
                case Enums.CharacterRoleEnum.Warrior:
                    {
                        character.ArmorStore = new WarriorArmorStore(GetCommand);
                    }
                    break;
                case Enums.CharacterRoleEnum.Wizard:
                    {
                        character.ArmorStore = new WizardArmorStore(GetCommand);
                    }
                    break;
                case Enums.CharacterRoleEnum.Monster:
                    {
                        character.ArmorStore = new MonsterArmorStore(GetCommand);
                    }
                    break;
                case Enums.CharacterRoleEnum.None:
                default:
                    break;
            }
        }
    }
}
