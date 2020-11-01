using GameMain.Base;
using GameMain.Characters;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMain
{
    public class CharacterFactory
    {
        public Func<string, int> GetCommand;

        public CharacterFactory(Func<string, int> getCommand)
        {
            GetCommand = getCommand;
        }

        public void ChooseCharacter(Player character)
        {
            int flag = GetCommand("请选择职业：\n1.战士\t2.法师\t3.妖怪");
            character.GetRole(ChooseCharacter(flag));
        }

        private Character ChooseCharacter(int flag)
        {
            switch (flag)
            {
                case 1:
                    return new Warrior();
                case 2:
                    return new Wizard();
                case 3:
                    return new Monster();
                default:
                    int newFlag = GetCommand("选项有误，请重新选择职业：\n1.战士\t2.法师\t3.妖怪");
                    return ChooseCharacter(newFlag);
            }
        }
    }
}
