using GameMain.Base;
using GameMain.Qeuip.Armors;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMain.Stores.Armors
{
    public class WarriorArmorStore : ArmorStore
    {
        public WarriorArmorStore()
        {
            ArmorList = new List<Armor>()
            {
                new WarriorArmor(Enums.QeuipRankEnum.Rank1,"铠甲",300, 30),
                new WarriorArmor(Enums.QeuipRankEnum.Rank2,"铠甲",600, 60),
                new WarriorArmor(Enums.QeuipRankEnum.Rank3,"铠甲",1200, 120),
                new WarriorArmor(Enums.QeuipRankEnum.Rank4,"铠甲",2000, 200),
                new WarriorArmor(Enums.QeuipRankEnum.Rank5,"铠甲",4000, 400),
                new WarriorArmor(Enums.QeuipRankEnum.Rank6,"铠甲",7000, 700),
            };
        }
    }
}
