using GameMain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMain.Qeuip.Armors
{
    public class WarriorArmor : Armor
    {
        public WarriorArmor(string rank, string name, int price = 0, int def = 0)
            : base(rank, name, price, def)
        {

        }
    }

    //public class WarriorArmor1 : WarriorArmor
    //{
    //    public WarriorArmor1(int price = 300, int def = 30, string name = "铠甲", string rank = "白银")
    //        : base(price, def, name, rank)
    //    {

    //    }
    //}

    //public class WarriorArmor2 : WarriorArmor
    //{
    //    public WarriorArmor2(int price = 600, int def = 60, string name = "铠甲", string rank = "黄金")
    //        : base(price, def, name, rank)
    //    {

    //    }
    //}

    //public class WarriorArmor3 : WarriorArmor
    //{
    //    public WarriorArmor3(int price = 1200, int def = 100, string name = "铠甲", string rank = "白金")
    //        : base(price, def, name, rank)
    //    {

    //    }
    //}
    //public class WarriorArmor4 : WarriorArmor
    //{
    //    public WarriorArmor4(int price = 2000, int def = 200, string name = "铠甲", string rank = "钻石")
    //        : base(price, def, name, rank)
    //    {

    //    }
    //}

}
