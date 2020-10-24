using GameMain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMain.Characters
{
    public class Monster : Character
    {
        public Monster(int health = 2000, int atk = 60, int def = 30, int money = 500, string name = "妖怪")
            : base(health, atk, def, money, name) { }
    }
}
