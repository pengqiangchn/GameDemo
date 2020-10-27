using GameMain.Base;
using GameMain.Qeuips.Weapons;
using System.Collections.Generic;

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

        public override Weapon Show()
        {
            string msg = "";
            for (int i = 0; i < WeaponList.Count; i++)
            {
                var armor = WeaponList[i];

                msg += $"{i + 1}. {armor.FullName} {armor.Price}金币 +{armor.DEF}攻击力\r\n";
            }

            int flag = getCommand(msg);
            return Creat(flag);
        }

    }
}
