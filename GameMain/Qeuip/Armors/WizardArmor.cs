using GameMain.Base;
using GameMain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMain.Qeuip.Armors
{
    public class WizardArmor : Armor
    {
        public WizardArmor(QeuipRankEnum rank, string name, int price = 0, int def = 0)
            : base(rank, name, price, def)
        {

        }
    }
}
