using GameMain.Base;
using GameMain.Base.Weapons;
using GameMain.Enums;
using GameMain.Stores.Armors;
using GameMain.Stores.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GameMain
{
    public class GameEngine
    {
        private int GAME_PROCESS = 0;
        private GameSatausEnum GAME_STATUS = GameSatausEnum.Stop;
        private int GAME_SYSTEM_COMMAND = 1;
        private int GAME_USER_COMMAND = 0;

        private Model _model = new Model();

        private readonly Thread gameProcess;
        private Thread userCommand;

        public delegate void Progress(Model model);
        private Progress _progress;

        //public delegate void Command(int x);
        //private Command _command;


        public GameEngine(Progress progress)
        {
            _progress = progress;

            gameProcess = new Thread(Game);
        }


        private void UserCommand()
        {
            GAME_USER_COMMAND = 0;
            userCommand = new Thread(GetCommand);
            userCommand.Start();
            userCommand.Join();
        }

        /// <summary>
        /// 接收用户指令
        /// </summary>
        private void GetCommand()
        {
            while (GAME_USER_COMMAND == 0)
            {
            }
        }

        public void SetCommand(int userCommand)
        {
            GAME_USER_COMMAND = userCommand;
            _model.Msg = userCommand.ToString();
            _progress(_model);
        }

        private void Game()
        {
            while (GAME_PROCESS == 1)
            {
                CharacterFactory characterFactory = new CharacterFactory(); //角色产生工厂  
                StoreManager storeManager = new StoreManager(); //商店产生工厂（决定产生哪种职业的武器和盔甲） 
                Character player; //玩家一角色 

                int money; //每回合随机生成金币 
                var random = new Random();
                money = new Random().Next(100) + 200; //每回合生成200到300的金币

                int flag = 0, count = 0; //用于switch的flag和记录回合数的count 
                string readLine = "";
                const int treatCD = 4; //治疗术的CD，即四个回合 
                int player1NextTreat = 1, player2NextTreat = 1; //玩家一和玩家二下次可以使用治疗术的回合

                List<string> characterFlags = new List<string> { "1", "2", "3" };
                List<string> actFlags = new List<string> { "1", "2", "3", "4" };
                List<string> actMFlags = new List<string> { "0", "1", "2", "3", "4" };

                if (GAME_SYSTEM_COMMAND == 1)
                {
                    GAME_STATUS = GameSatausEnum.Start;



                }

                //如果没有暂停就 一直运行
                while (GAME_STATUS == GameSatausEnum.Start)
                {
                    ShowMsg("游戏开始");
                    SendMsg("玩家一请选择职业：\n1.战士\t2.法师\t3.妖怪");
                    player = characterFactory.CreatCharacter(GAME_USER_COMMAND);
                    player.ArmorStore = storeManager.CreatArmorStore(player);
                    player.WeaponStore = storeManager.CreatWeaponStore(player);

                    //开始游戏，选择需要干啥
                    while (true)
                    {
                        Home();
                    }


                }

                if (GAME_STATUS == GameSatausEnum.Stop)
                {
                    _model.Msg = "Stop";
                    _progress(_model);
                }
            }
        }

        //private void GameRunning()
        //{
        //    Home();
        //}

        private void Home()
        {
            Console.WriteLine($"*************");
            Console.WriteLine($"***欢迎归来***");
            Console.WriteLine($"*************");

            SendMsg($"请选择操作：\n1.冒险\n2.商店\n");

            switch (GAME_USER_COMMAND)
            {
                case 1: //冒险
                    break;
                case 2: //商店
                    break;

                default:
                    break;
            }
        }

        private void SendMsg(string msg)
        {
            ShowMsg(msg, true);
        }

        private void ShowMsg(string msg, bool isCallback = false)
        {
            _model.Msg = msg;
            _progress(_model);

            if (isCallback) UserCommand();
        }

        public void StartGame()
        {
            GAME_STATUS = GameSatausEnum.Start;
            GAME_SYSTEM_COMMAND = 0;
        }

        public void StopGame()
        {
            GAME_STATUS = GameSatausEnum.Stop;
        }

        public void ResetGame()
        {
            GAME_SYSTEM_COMMAND = 1;
            GAME_STATUS = GameSatausEnum.Stop;
        }

        public void StartEngine()
        {
            GAME_PROCESS = 1;
            GAME_STATUS = GameSatausEnum.Start;
            gameProcess.Start();
        }

        public void StopEngine()
        {
            GAME_PROCESS = 0;
            GAME_STATUS = GameSatausEnum.Stop;
            gameProcess.Abort();
        }

    }
}
