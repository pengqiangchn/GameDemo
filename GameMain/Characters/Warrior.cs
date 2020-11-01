using GameMain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMain.Characters
{
    public class Warrior : Player
    {
        public Warrior(int health = 2000, int atk = 70, int def = 20, int money = 500, string name = "战士")
            : base(health, atk, def, money, name)
        {
            Role = Enums.CharacterRoleEnum.Warrior;
        }
    }
}
