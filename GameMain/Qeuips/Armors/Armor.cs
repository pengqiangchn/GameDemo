using GameMain.Base;
using GameMain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMain.Qeuips.Armors
{
    /// <summary>
    /// 盔甲
    /// </summary>
    public class Armor : Qeuip
    {
        public Armor()
        {
            _rank = QeuipRankEnum.None;
            _name = "无";
        }

        public Armor(QeuipRankEnum rank, string name, int price, int def)
        {
            _rank = rank;
            _name = name;
            _price = price;
            _def = def;
        }
    }
}
