using GameMain.Base;
using GameMain.Base.Weapons;
using GameMain.Qeuip.Weapons;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMain.Stores.Weapons
{
    public class WarriorWeaponStore : WeaponStore
    {
        public WarriorWeaponStore()
        {
            WeaponList = new List<Weapon>()
            {
                new WarriorWeapon(Enums.QeuipRankEnum.Rank1,"巨剑",500, 70),
                new WarriorWeapon(Enums.QeuipRankEnum.Rank2,"巨剑",1000, 130),
                new WarriorWeapon(Enums.QeuipRankEnum.Rank3,"巨剑",1800, 220),
                new WarriorWeapon(Enums.QeuipRankEnum.Rank4,"巨剑",3000, 350),
                new WarriorWeapon(Enums.QeuipRankEnum.Rank5,"巨剑",5000, 500),
                new WarriorWeapon(Enums.QeuipRankEnum.Rank6,"巨剑",7500, 700),
            };
        }
    }
}
