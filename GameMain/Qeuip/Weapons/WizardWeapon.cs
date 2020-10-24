using GameMain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMain.Qeuip.Weapons
{
    public class WizardWeapon : Weapon
    {
        public WizardWeapon(int price = 0, int atk = 0, string name = "", string rank = "")
            : base(price, atk, name, rank) { }
    }

    public class WizardWeapon1 : WizardWeapon
    {
        public WizardWeapon1(int price = 400, int atk = 50, string name = "法杖", string rank = "白银")
            : base(price, atk, name, rank) { }
    }

    public class WizardWeapon2 : WizardWeapon
    {
        public WizardWeapon2(int price = 800, int atk = 100, string name = "法杖", string rank = "黄金")
            : base(price, atk, name, rank)
        {

        }
    }

    public class WizardWeapon3 : WizardWeapon
    {
        public WizardWeapon3(int price = 1500, int atk = 180, string name = "法杖", string rank = "白金")
            : base(price, atk, name, rank)
        {

        }
    }

    public class WizardWeapon4 : WizardWeapon
    {
        public WizardWeapon4(int price = 2500, int atk = 300, string name = "法杖", string rank = "钻石")
            : base(price, atk, name, rank)
        {

        }
    }

}
