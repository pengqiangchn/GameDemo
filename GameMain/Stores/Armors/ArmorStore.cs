using GameMain.Base;
using GameMain.Qeuips.Armors;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMain.Stores.Armors
{
    public abstract class ArmorStore : Store<Armor>
    {
        protected List<Armor> ArmorList;

        public override Armor Creat(int flag)
        {
            if (flag > 0 && ArmorList.Count > flag - 1)
            {

                return ArmorList[flag - 1];
            }
            else
            {
                return null;
            }
        }

        public override Armor Show()
        {
            string msg = "请选择需购买的武器:\r\n";
            for (int i = 0; i < ArmorList.Count; i++)
            {
                var armor = ArmorList[i];

                msg += $"{i + 1}. {armor.FullName} {armor.Price}金币 +{armor.DEF}防御力\r\n";
            }

            int flag = GetCommand(msg);
            return Creat(flag);
        }
    }
}
