using GameMain.Base;
using GameMain.Base.Weapons;
using GameMain.Qeuip.Weapons;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMain.Stores.Weapons
{
    public class MonsterWeaponStore : WeaponStore
    {
        public MonsterWeaponStore()
        {
            WeaponList = new List<Weapon>()
            {
                new MonsterWeapon(Enums.QeuipRankEnum.Rank1,"灵刃",450, 60),
                new MonsterWeapon(Enums.QeuipRankEnum.Rank2,"灵刃",900, 120),
                new MonsterWeapon(Enums.QeuipRankEnum.Rank3,"灵刃",1650, 200),
                new MonsterWeapon(Enums.QeuipRankEnum.Rank4,"灵刃",2750, 320),
                new MonsterWeapon(Enums.QeuipRankEnum.Rank5,"灵刃",4000, 400),
                new MonsterWeapon(Enums.QeuipRankEnum.Rank6,"灵刃",6000, 600),
            };
        }
    }
}
