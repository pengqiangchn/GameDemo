using GameMain.Base;
using GameMain.Qeuip.Armors;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMain.Stores.Armors
{
    public class WarriorArmorStore : ArmorStore
    {
        public override Armor CreatArmor(int flag)
        {
            switch (flag)
            {
                case 1: return new WarriorArmor1();
                case 2: return new WarriorArmor2();
                case 3: return new WarriorArmor3();
                case 4: return new WarriorArmor4();
            }
            return null;
        }

        public override void Show()
        {
            Console.WriteLine($"1.白银铠甲 300金币 +30防御力");
            Console.WriteLine($"2.黄金铠甲 600金币 +60防御力");
            Console.WriteLine($"3.白金铠甲 1200金币 +100防御力");
            Console.WriteLine($"4.钻石铠甲 2000金币 +200防御力");
        }
    }
}
