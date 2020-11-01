using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMain
{
    public class Model
    {
        public string GameMsg { get; set; }

        public string User { get; set; }

        public Fight Fight { get; set; }

        public string Pet { get; set; }

        public Model(string gameMsg = "", string user = "")
        {
            GameMsg = gameMsg;
            User = user;
        }

    }

    public class Fight
    {
        public string User { get; set; }

        public string Enemy { get; set; }
    }
}
