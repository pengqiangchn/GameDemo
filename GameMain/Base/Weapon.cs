using System;
using System.Collections.Generic;
using System.Text;

namespace GameMain.Base
{
    public class Weapon
    {
        /// <summary>
        /// 武器价格
        /// </summary>
        protected int Price { get; set; }

        /// <summary>
        /// 武器攻击力
        /// </summary>
        protected int ATK { get; set; }

        /// <summary>
        /// 武器名称
        /// </summary>
        protected string Name { get; set; }

        /// <summary>
        /// 武器等级
        /// </summary>
        protected string Rank { get; set; }

        public Weapon(int price = 0, int atk = 0, string name = "", string rank = "")
        {
            Price = price; ATK = atk; Name = name; Rank = rank;
        }

        public int GetPrice()
        {
            return Price;
        }

        public int GetATK()
        {
            return ATK;
        }

        public string GetName()
        {
            return Name;
        }

        public string GetRank()
        {
            return Rank;
        }

    };
}
