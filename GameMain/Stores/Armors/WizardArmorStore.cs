using GameMain.Base;
using GameMain.Qeuip.Armors;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMain.Stores.Armors
{
    public class WizardArmorStore : ArmorStore
    {
        public override Armor CreatArmor(int flag)
        {
            switch (flag)
            {
                case 1: return new WizardArmor1();
                case 2: return new WizardArmor2();
                case 3: return new WizardArmor3();
                case 4: return new WizardArmor4();
            }
            return null;
        }

        public override void Show()
        {
            Console.WriteLine($"1.白银面纱 400金币 +40防御力");
            Console.WriteLine($"2.黄金面纱 800金币 +80防御力");
            Console.WriteLine($"3.白金面纱 1500金币 +160防御力");
            Console.WriteLine($"4.钻石面纱 2500金币 +250防御力");
        }
    }
}
