using System;
using System.Collections.Generic;
using System.Text;

namespace GameMain.Base
{
    /// <summary>
    /// 盔甲
    /// </summary>
    public class Armor
    {
        /// <summary>
        /// 盔甲价格
        /// </summary>
        protected int Price { get; set; }

        /// <summary>
        /// 盔甲防御力
        /// </summary>
        public int DEF { get; set; }

        /// <summary>
        /// 盔甲名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 盔甲等级
        /// </summary>
        public string Rank { get; set; }

        public Armor(string rank, string name, int price, int def)
        {
            Rank = rank;
            Name = name;
            Price = price;
            DEF = def;
        }

        public int GetPrice()
        {
            return Price;
        }

        public int GetDEF()
        {
            return DEF;
        }

        public string GetName()
        {
            return Name;
        }

        public string GetRank()
        {
            return Rank;
        }



    }
}
