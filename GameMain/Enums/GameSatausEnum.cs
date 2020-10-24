using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMain.Enums
{
    public enum GameSatausEnum
    {
        /// <summary>
        /// 停止
        /// </summary>
        [Description("停止")]
        Stop = 2,


        /// <summary>
        /// 进行中
        /// </summary>
        [Description("进行中")]
        Start = 4,

        ///// <summary>
        ///// 暂停
        ///// </summary>
        //[Description("暂停")]
        //Pause = 6,

    }
}
