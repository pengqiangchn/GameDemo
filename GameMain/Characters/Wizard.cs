using GameMain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMain.Characters
{
    public class Wizard : Character
    {
        public Wizard(int health = 2000, int atk = 50, int def = 40, int money = 500, string name = "法师")
            : base(health, atk, def, money, name) { }
    }
}
