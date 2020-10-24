using GameMain.Base;
using GameMain.Qeuip.Weapons;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMain.Stores.Weapons
{
    public class WarriorWeaponStore : WeaponStore
    {
        public override Weapon CreatWeapon(int flag)
        {
            switch (flag)
            {
                case 1: return new WarriorWeapon1();
                case 2: return new WarriorWeapon2();
                case 3: return new WarriorWeapon3();
                case 4: return new WarriorWeapon4();
            }
            return null;
        }

        public override void Show()
        {
            Console.WriteLine($"1.白银巨剑 500金币 +70攻击力");
            Console.WriteLine($"2.黄金巨剑 1000金币 +130攻击力");
            Console.WriteLine($"3.白金巨剑 1800金币 +220攻击力");
            Console.WriteLine($"4.钻石巨剑 3000金币 +350攻击力");
        }
    }
}
