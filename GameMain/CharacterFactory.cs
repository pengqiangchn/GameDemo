using GameMain.Base;
using GameMain.Characters;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMain
{
    public class CharacterFactory
    {
        public Character CreatCharacter(int flag)
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
                    return null;
            }
        }
    }
}
