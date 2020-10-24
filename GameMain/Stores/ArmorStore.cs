using GameMain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMain.Stores
{
    public abstract class ArmorStore
    {
        public abstract void Show(); //盔甲信息展示 

        public abstract Armor CreatArmor(int flag); //创建盔甲 

    }
}
