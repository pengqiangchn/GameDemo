using GameMain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMain.Qeuip.Weapons
{
    public class WarriorWeapon : Weapon
    {
        public WarriorWeapon(int price = 0, int atk = 0, string name = "", string rank = "")
            : base(price, atk, name, rank)
        {

        }
    }

    public class WarriorWeapon1 : WarriorWeapon
    {
        public WarriorWeapon1(int price = 500, int atk = 70, string name = "巨剑", string rank = "白银")
            : base(price, atk, name, rank)
        {

        }
    }

    public class WarriorWeapon2 : WarriorWeapon
    {
        public WarriorWeapon2(int price = 1000, int atk = 130, string name = "巨剑", string rank = "黄金")
            : base(price, atk, name, rank)
        {

        }
    }

    public class WarriorWeapon3 : WarriorWeapon
    {
        public WarriorWeapon3(int price = 1800, int atk = 220, string name = "巨剑", string rank = "白金")
            : base(price, atk, name, rank)
        {

        }
    }

    public class WarriorWeapon4 : WarriorWeapon
    {
        public WarriorWeapon4(int price = 3000, int atk = 350, string name = "巨剑", string rank = "钻石")
            : base(price, atk, name, rank)
        {

        }
    }


}
