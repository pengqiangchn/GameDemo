﻿using GameMain.Base;
using GameMain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMain.Qeuips.Armors
{
    public class WarriorArmor : Armor
    {
        public WarriorArmor(QeuipRankEnum rank, string name, int price = 0, int def = 0)
            : base(rank, name, price, def)
        {

        }
    }
}
