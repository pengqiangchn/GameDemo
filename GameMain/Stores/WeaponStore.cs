using GameMain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMain.Stores
{
    public abstract class WeaponStore
    {
        public abstract void Show(); //武器信息展示 

        public abstract Weapon CreatWeapon(int flag); //创建武器 

    }
}
