using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMain.Enums
{
    public enum CharacterRoleEnum
    {
        /// <summary>
        /// 无装备
        /// </summary>
        [Description("无")]
        None = 0,

        /// <summary>
        /// 战士
        /// </summary>
        [Description("战士")]
        Warrior = 1,

        /// <summary>
        /// 法师
        /// </summary>
        [Description("法师")]
        Wizard = 2,

        /// <summary>
        /// 妖怪
        /// </summary>
        [Description("妖怪")]
        Monster = 3,
    }
}
