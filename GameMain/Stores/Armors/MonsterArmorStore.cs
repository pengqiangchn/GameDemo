using GameMain.Base;
using GameMain.Qeuip.Armors;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMain.Stores.Armors
{
    public class MonsterArmorStore : ArmorStore
    {
        public override Armor CreatArmor(int flag)
        {
            switch (flag)
            {
                case 1: return new MonsterArmor1();
                case 2: return new MonsterArmor2();
                case 3: return new MonsterArmor3();
                case 4: return new MonsterArmor4();
            }
            return null;
        }

        public override void Show()
        {
            Console.WriteLine($"1.白银鳞甲 350金币 +35防御力");
            Console.WriteLine($"2.黄金鳞甲 700金币 +70防御力");
            Console.WriteLine($"3.白金鳞甲 1350金币 +130防御力");
            Console.WriteLine($"4.钻石鳞甲 2300金币 +220防御力");
        }
    }
}
