using GameMain.Base;
using GameMain.Qeuip.Armors;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMain.Stores.Armors
{
    public class MonsterArmorStore : ArmorStore
    {
        public MonsterArmorStore()
        {
            ArmorList = new List<Armor>()
            {
                new MonsterArmor(Enums.QeuipRankEnum.Rank1,"鳞甲",350, 35),
                new MonsterArmor(Enums.QeuipRankEnum.Rank2,"鳞甲",700, 70),
                new MonsterArmor(Enums.QeuipRankEnum.Rank3,"鳞甲",1350, 130),
                new MonsterArmor(Enums.QeuipRankEnum.Rank4,"鳞甲",2300, 220),
                new MonsterArmor(Enums.QeuipRankEnum.Rank5,"鳞甲",4500, 450),
                new MonsterArmor(Enums.QeuipRankEnum.Rank6,"鳞甲",6000, 600),
            };
        }
    }
}
