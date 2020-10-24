using GameMain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMain.Qeuip.Armors
{
    public class WizardArmor : Armor
    {
        public WizardArmor(int price = 0, int def = 0, string name = "", string rank = "")
            : base(price, def, name, rank)
        {

        }
    }

    public class WizardArmor1 : WizardArmor
    {
        public WizardArmor1(int price = 400, int def = 40, string name = "面纱", string rank = "白银")
            : base(price, def, name, rank)
        {

        }
    }

    public class WizardArmor2 : WizardArmor
    {
        public WizardArmor2(int price = 800, int def = 80, string name = "面纱", string rank = "黄金")
            : base(price, def, name, rank)
        {

        }
    }

    public class WizardArmor3 : WizardArmor
    {
        public WizardArmor3(int price = 1500, int def = 160, string name = "面纱", string rank = "白金")
            : base(price, def, name, rank)
        {

        }
    }
    public class WizardArmor4 : WizardArmor
    {
        public WizardArmor4(int price = 2500, int def = 250, string name = "面纱", string rank = "钻石")
            : base(price, def, name, rank)
        {

        }
    }

}
