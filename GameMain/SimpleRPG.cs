﻿using System;
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
    public partial class SimpleRPG : Form
    {
        public static object Lock = new object();

        private GameEngine game;
        delegate void UpdateUIDelegate(Model model);
        UpdateUIDelegate dUpdateUI;

        public SimpleRPG()
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
                ShowInfo(model);
            }
        }

        private void ShowInfo(Model model)
        {
            lock (Lock)
            {
                if (model.GameMsg.IsNotEmpty())
                {
                    txtGame.Text += "\r\n" + model.GameMsg + "\r\n";
                    txtGame.SelectionStart = txtGame.Text.Length;
                    txtGame.ScrollToCaret();
                }

                if (model.User.IsNotEmpty())
                {
                    txtUser.Text = model.User;
                }

                if (model.Fight != null)
                {
                    txtFightUser.Text = model.Fight.User;
                    txtFightEnemy.Text = model.Fight.Enemy;
                }

                txtCommand.Text = "";
                txtCommand.Focus();
            }
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
            txtGame.Text = "";
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
