using GameMain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMain.Base
{
    public abstract class Store<T>
    {
        /// <summary>
        /// 创建
        /// </summary>
        /// <param name="flag"></param>
        /// <returns></returns>
        public abstract T Creat(int flag);

        /// <summary>
        /// 信息展示
        /// </summary>
        public abstract void Show();

    }
}
