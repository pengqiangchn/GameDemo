using GameMain.Base;
using GameMain.Qeuip.Weapons;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMain.Stores.Weapons
{
    public class MonsterWeaponStore : WeaponStore
    {
        public override Weapon CreatWeapon(int flag)
        {
            switch (flag)
            {
                case 1: return new MonsterWeapon1();
                case 2: return new MonsterWeapon2();
                case 3: return new MonsterWeapon3();
                case 4: return new MonsterWeapon4();
            }
            return null;
        }

        public override void Show()
        {
            Console.WriteLine($"1.白银灵刃 450金币 +60攻击力");
            Console.WriteLine($"2.黄金灵刃 900金币 +120攻击力");
            Console.WriteLine($"3.白金灵刃 1650金币 +200攻击力");
            Console.WriteLine($"4.钻石灵刃 2750金币 +320攻击力");
        }
    }
}
