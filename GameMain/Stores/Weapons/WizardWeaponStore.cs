using GameMain.Qeuips.Weapons;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMain.Stores.Weapons
{
    public class WizardWeaponStore : WeaponStore
    {
        public WizardWeaponStore(Func<string, int> getcommand)
        {
            GetCommand = getcommand;
            WeaponList = new List<Weapon>()
            {
                new WizardWeapon(Enums.QeuipRankEnum.Rank1,"法杖",400, 50),
                new WizardWeapon(Enums.QeuipRankEnum.Rank2,"法杖",800, 100),
                new WizardWeapon(Enums.QeuipRankEnum.Rank3,"法杖",1500, 180),
                new WizardWeapon(Enums.QeuipRankEnum.Rank4,"法杖",2500, 300),
                new WizardWeapon(Enums.QeuipRankEnum.Rank5,"法杖",4000, 500),
                new WizardWeapon(Enums.QeuipRankEnum.Rank6,"法杖",8000, 800),
            };
        }
    }
}
