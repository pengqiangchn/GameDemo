using GameMain.Base;
using GameMain.Qeuip.Weapons;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMain.Stores.Weapons
{
    public class WizardWeaponStore : WeaponStore
    {
        public override Weapon CreatWeapon(int flag)
        {
            switch (flag)
            {
                case 1: return new WizardWeapon1();
                case 2: return new WizardWeapon2();
                case 3: return new WizardWeapon3();
                case 4: return new WizardWeapon4();
            }
            return null;
        }

        public override void Show()
        {
            Console.WriteLine($"1.白银法杖 400金币 +50攻击力");
            Console.WriteLine($"2.黄金法杖 800金币 +100攻击力");
            Console.WriteLine($"3.白金法杖 1500金币 +180攻击力");
            Console.WriteLine($"4.钻石法杖 2500金币 +300攻击力");
        }
    }
}
