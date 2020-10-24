using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMain.Enums
{
    public enum QeuipRankEnum
    {
        /// <summary>
        /// 无装备
        /// </summary>
        [Description("")]
        None = 0,

        /// <summary>
        /// 青铜
        /// </summary>
        [Description("青铜")]
        Rank1 = 1,

        /// <summary>
        /// 白银
        /// </summary>
        [Description("白银")]
        Rank2 = 2,

        /// <summary>
        /// 黄金
        /// </summary>
        [Description("黄金")]
        Rank3 = 3,

        /// <summary>
        /// 铂金
        /// </summary>
        [Description("铂金")]
        Rank4 = 4,

        /// <summary>
        /// 钻石
        /// </summary>
        [Description("钻石")]
        Rank5 = 5,

        /// <summary>
        /// 神话
        /// </summary>
        [Description("神话")]
        Rank6 = 6,

    }
}
