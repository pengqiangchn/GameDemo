using GameMain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMain.Qeuip.Weapons
{
    public class MonsterWeapon : Weapon
    {
        public MonsterWeapon(int price = 0, int atk = 0, string name = "", string rank = "")
            : base(price, atk, name, rank) { }
    }

    public class MonsterWeapon1 : MonsterWeapon
    {
        public MonsterWeapon1(int price = 450, int atk = 60, string name = "灵刃", string rank = "白银")
            : base(price, atk, name, rank) { }
    }

    public class MonsterWeapon2 : MonsterWeapon
    {
        public MonsterWeapon2(int price = 900, int atk = 120, string name = "灵刃", string rank = "黄金")
            : base(price, atk, name, rank) { }
    }

    public class MonsterWeapon3 : MonsterWeapon
    {
        public MonsterWeapon3(int price = 1650, int atk = 200, string name = "灵刃", string rank = "白金")
            : base(price, atk, name, rank) { }
    }

    public class MonsterWeapon4 : MonsterWeapon
    {
        public MonsterWeapon4(int price = 2750, int atk = 320, string name = "灵刃", string rank = "钻石")
            : base(price, atk, name, rank) { }
    }
}
