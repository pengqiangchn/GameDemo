using GameMain.Base;
using GameMain.Base.Weapons;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMain.Stores.Weapons
{
    public abstract class WeaponStore : Store<Weapon>
    {
        protected List<Weapon> WeaponList;

        public override Weapon Creat(int flag)
        {
            if (WeaponList.Count > flag - 1)
            {

                return WeaponList[flag];
            }
            else
            {
                return null;
            }
        }

        public override void Show()
        {
            string msg = "";
            for (int i = 0; i < WeaponList.Count; i++)
            {
                var armor = WeaponList[i];

                msg += $"{i + 1}. {armor.FullName} {armor.Price}金币 +{armor.DEF}攻击力\r\n";
            }

            Console.WriteLine(msg);
        }

    }
}
