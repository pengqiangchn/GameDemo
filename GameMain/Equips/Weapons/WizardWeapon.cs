using GameMain.Base;
using GameMain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMain.Qeuips.Weapons
{
    public class WizardWeapon : Weapon
    {
        public WizardWeapon(QeuipRankEnum rank, string name, int price = 0, int atk = 0)
            : base(rank, name, price, atk) { }
    }

}
