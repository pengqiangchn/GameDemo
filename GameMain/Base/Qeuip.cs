using GameMain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMain.Base
{
    public abstract class Qeuip
    {
        protected int _price;
        protected int _def;
        protected int _atk;
        protected string _name;
        protected QeuipRankEnum _rank;

        /// <summary>
        /// 等级
        /// </summary>
        public string Rank { get { return _rank.ToDescription(); } }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get { return _name; } }

        /// <summary>
        /// 攻击力
        /// </summary>
        public int ATK { get { return _atk; } }

        /// <summary>
        /// 防御力
        /// </summary>
        public int DEF { get { return _def; } }

        /// <summary>
        /// 价格
        /// </summary>
        public int Price { get { return _price; } }

        /// <summary>
        /// 等级名称
        /// </summary>
        public string FullName { get { return _rank.ToDescription() + _name; } }

    }
}
