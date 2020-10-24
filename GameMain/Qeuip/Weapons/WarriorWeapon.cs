using GameMain.Base;
using GameMain.Base.Weapons;
using GameMain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMain.Qeuip.Weapons
{
    public class WarriorWeapon : Weapon
    {
        public WarriorWeapon(QeuipRankEnum rank, string name, int price = 0, int atk = 0)
            : base(rank, name, price, atk) { }
    }

}
