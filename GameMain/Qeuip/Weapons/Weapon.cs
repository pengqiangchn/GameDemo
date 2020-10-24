using GameMain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMain.Base.Weapons
{
    public class Weapon : Qeuip
    {
        public Weapon()
        {
            _rank = QeuipRankEnum.None;
            _name = "无";
        }

        public Weapon(QeuipRankEnum rank, string name, int price, int atk)
        {
            _rank = rank;
            _name = name;
            _price = price;
            _atk = atk;
        }

    };
}
