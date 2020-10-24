using GameMain.Enums;
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
        private int GAME_SYSTEM_COMMAND = 0;
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
                //int count = 0;

                if (GAME_SYSTEM_COMMAND == 1)
                {
                    GAME_STATUS = GameSatausEnum.Start;
                }

                //如果没有暂停就 一直运行
                while (GAME_STATUS == GameSatausEnum.Start)
                {
                    //count++;
                    //_model.Msg = count.ToString();
                    //_progress(_model);
                    //Thread.Sleep(1000);
                    _model.Msg = "请选择职业";
                    _progress(_model);
                    UserCommand();

                    _model.Msg = "选好了";
                    _progress(_model);

                }

                if (GAME_STATUS == GameSatausEnum.Stop)
                {
                    _model.Msg = "Stop";
                    _progress(_model);
                }
            }
        }

        public void StartGame()
        {
            GAME_STATUS = GameSatausEnum.Start;
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
