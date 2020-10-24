using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameMain
{
    public partial class GameMain : Form
    {
        private GameEngine game;
        delegate void UpdateUIDelegate(Model model);
        UpdateUIDelegate dUpdateUI;

        public GameMain()
        {
            InitializeComponent();
        }

        private void GameMain_Load(object sender, EventArgs e)
        {
            InitGame();
        }

        private void InitGame()
        {
            dUpdateUI = Progress;
            game = new GameEngine(Progress);
            game.StartEngine();
        }

        private void Progress(Model model)
        {
            if (this.InvokeRequired)
            {
                Invoke(dUpdateUI, model);
            }
            else
            {
                var info = GetInfo(model);

                txtGameInfo.Text += info.Item1;
                txtGameInfo.SelectionStart = txtGameInfo.Text.Length;
                txtGameInfo.ScrollToCaret();

                txtUserInfo.Text = info.Item2;

                txtCommand.Text = "";

                txtCommand.Focus();
            }
        }

        private Tuple<string, string> GetInfo(Model model)
        {
            string gameInfo = "\r\n" + model.Msg + "\r\n";

            string userInfo = @"asdad";


            Tuple<string, string> info = new Tuple<string, string>(gameInfo, userInfo);

            return info;
        }

        private void txtCommand_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int command = 0;
                int.TryParse(txtCommand.Text, out command);

                game.SetCommand(command);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int command = 0;
            int.TryParse(txtCommand.Text, out command);

            game.SetCommand(command);
        }

        private void btnReGame_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            game.ResetGame();
        }

        private void btnClean_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtGameInfo.Text = "";
        }

        private void GameMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            game.StopEngine();
        }

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            game.StopEngine();

            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}
