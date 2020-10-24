using GameMain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMain.Qeuip.Armors
{
    public class MonsterArmor : Armor
    {
        public MonsterArmor(string rank, string name, int price = 0, int def = 0)
            : base(rank, name, price, def)
        {

        }
    }

    //public class MonsterArmor1 : MonsterArmor
    //{
    //    public MonsterArmor1(int price = 350, int def = 35, string name = "鳞甲", string rank = "白银")
    //        : base(rank, name, price, def)
    //    {

    //    }
    //}

    //public class MonsterArmor2 : MonsterArmor
    //{
    //    public MonsterArmor2(int price = 700, int def = 70, string name = "鳞甲", string rank = "黄金")
    //        : base(rank, name, price, def)
    //    {

    //    }
    //}

    //public class MonsterArmor3 : MonsterArmor
    //{
    //    public MonsterArmor3(int price = 1350, int def = 130, string name = "鳞甲", string rank = "白金")
    //        : base(rank, name, price, def)
    //    {

    //    }
    //}
    //public class MonsterArmor4 : MonsterArmor
    //{
    //    public MonsterArmor4(int price = 2300, int def = 220, string name = "鳞甲", string rank = "钻石")
    //        : base(rank, name, price, def)
    //    {

    //    }
    //}

}
