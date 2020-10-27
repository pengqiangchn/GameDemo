using GameMain.Qeuips.Armors;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMain.Stores.Armors
{
    public class WizardArmorStore : ArmorStore
    {
        public WizardArmorStore(Func<string, int> getcommand)
        {
            GetCommand = getcommand;

            ArmorList = new List<Armor>()
            {
                new WizardArmor(Enums.QeuipRankEnum.Rank1,"面纱",400, 40),
                new WizardArmor(Enums.QeuipRankEnum.Rank2,"面纱",800, 80),
                new WizardArmor(Enums.QeuipRankEnum.Rank3,"面纱",1500, 150),
                new WizardArmor(Enums.QeuipRankEnum.Rank4,"面纱",2500, 250),
                new WizardArmor(Enums.QeuipRankEnum.Rank5,"面纱",4500, 450),
                new WizardArmor(Enums.QeuipRankEnum.Rank6,"面纱",6500, 600),
            };
        }
    }
}
