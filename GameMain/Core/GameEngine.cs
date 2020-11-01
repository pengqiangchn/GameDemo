using GameMain.Base;
using GameMain.Enums;
using GameMain.Helper;
using GameMain.Qeuips.Weapons;
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
        private int GAME_USER_COMMAND = CONST.EMPTY_COMMAND;

        private readonly Thread gameProcess;

        public delegate void Progress(Model model);
        private Progress _progress;

        private Player _player;
        private readonly CharacterFactory _characterFactory;
        private readonly StoreManager _storeManager;

        public GameEngine(Progress progress)
        {
            _progress = progress;
            _player = new Player();
            _player.InfoChanged += new Character.InfoChangedEventHandler(progress);

            _characterFactory = new CharacterFactory(GetCommand); //角色产生工厂  
            _storeManager = new StoreManager(GetCommand); //商店产生工厂（决定产生哪种职业的武器和盔甲） 

            gameProcess = new Thread(Game);
        }

        private void Game()
        {

            while (GAME_PROCESS == 1)
            {
                //int money; //每回合随机生成金币 
                //var random = new Random();
                //money = new Random().Next(100) + 200; //每回合生成200到300的金币

                //int flag = 0, count = 0; //用于switch的flag和记录回合数的count 
                //string readLine = "";
                //const int treatCD = 4; //治疗术的CD，即四个回合 
                //int player1NextTreat = 1, player2NextTreat = 1; //玩家一和玩家二下次可以使用治疗术的回合

                if (GAME_SYSTEM_COMMAND == 1)
                {
                    GAME_STATUS = GameSatausEnum.Start;
                    _player.Fill(new Player());
                }

                //如果没有暂停就 一直运行
                while (GAME_STATUS == GameSatausEnum.Start)
                {
                    ShowMsg("游戏开始");
                    LoadGame();

                    //开始游戏，选择需要干啥
                    while (true)
                    {
                        Home();
                    }
                }

                if (GAME_STATUS == GameSatausEnum.Stop)
                {
                    _progress(new Model("Stop"));
                }
            }
        }

        private void LoadGame()
        {
            GetCommand("请选择操作：\r\n1.新的游戏\r\n2.继续游戏");
            switch (GAME_USER_COMMAND)
            {
                case 1:
                    {
                        _characterFactory.ChooseCharacter(_player);
                        _storeManager.CreatStore(_player);
                        break;
                    }
                case 2:
                    {
                        Read();
                        break;
                    }
                default:
                    {
                        ShowMsg("选择错误，请重新选择！");
                        LoadGame();
                        break;
                    }
            }
        }

        private void Read()
        {
            string userJson = FileHelper.LoadData();

            if (userJson.IsNotEmpty())
            {
            }
            else
            {
            }
        }

        private void Home()
        {
            string home = "*************\r\n" +
                          "***欢迎归来***\r\n" +
                          "*************\r\n";
            ShowMsg(home);
            GetCommand("请选择操作：\r\n1.冒险\r\n2.商店\r\n9.保存游戏");

            switch (GAME_USER_COMMAND)
            {
                case 1: //冒险
                    break;
                case 2: //商店
                    Shop();
                    break;
                case 99:
                    break;

                default:
                    break;
            }
        }

        private void Explore()
        {

        }

        private void Shop()
        {
            GetCommand("需购买的装备：\r\n1.武器\r\n2.盔甲\r\n0.返回上一级");

            Store(GAME_USER_COMMAND);

            if (GAME_USER_COMMAND == 0)
            {
                Home();
            }
        }

        private void Store(int storeFlag)
        {
            Equip equip = null;
            switch (storeFlag)
            {
                case 1: //武器
                    equip = _player.WeaponStore.Show();
                    break;
                case 2: //盔甲
                    equip = _player.ArmorStore.Show();
                    break;
                default:
                    GAME_USER_COMMAND = 0;
                    break;
            }

            if (GAME_USER_COMMAND != 0)
            {
                if (equip != null)
                {
                    if (_player.Money < equip.Price - _player.Weapon.Price)
                    {
                        ShowMsg("你的金币不够，请重新选择或输入0返回上一级!");
                        Store(storeFlag);
                    }
                    else
                    {
                        ShowMsg("购买成功！");
                        _player.GetEquip(equip);
                    }
                }
                else
                {
                    ShowMsg("选择错误，请重新选择或输入0返回上一级!");
                    Store(storeFlag);
                }
            }
        }

        private int GetCommand(string msg)
        {
            return ShowMsg(msg, true);
        }

        private int ShowMsg(string msg, bool isCallback = false)
        {
            int command = 0;

            _progress(new Model(msg));

            if (isCallback)
            {
                command = UserCommand();
            }

            return command;
        }

        private int UserCommand()
        {
            GAME_USER_COMMAND = CONST.EMPTY_COMMAND;
            Func<int> func = GetUserCommand;
            int command = func.Invoke();
            return command;
        }

        /// <summary>
        /// 接收用户指令
        /// </summary>
        private int GetUserCommand()
        {
            //等待接收
            while (GAME_USER_COMMAND == CONST.EMPTY_COMMAND)
            {
            }

            return GAME_USER_COMMAND;
        }

        public void SetCommand(int userCommand)
        {
            GAME_USER_COMMAND = userCommand;
            _progress(new Model(userCommand.ToString()));
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
            ShowMsg("重置游戏");
            GAME_SYSTEM_COMMAND = 1;
            GAME_USER_COMMAND = 0;
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
