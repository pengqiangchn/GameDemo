namespace GameMain
{
    partial class GameMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbUserInfo = new System.Windows.Forms.GroupBox();
            this.txtUser = new System.Windows.Forms.RichTextBox();
            this.gbGameInfo = new System.Windows.Forms.GroupBox();
            this.txtGame = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReGame = new System.Windows.Forms.LinkLabel();
            this.btnClean = new System.Windows.Forms.LinkLabel();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPet = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtFightUser = new System.Windows.Forms.RichTextBox();
            this.txtFightEnemy = new System.Windows.Forms.RichTextBox();
            this.gbUserInfo.SuspendLayout();
            this.gbGameInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbUserInfo
            // 
            this.gbUserInfo.Controls.Add(this.txtUser);
            this.gbUserInfo.Location = new System.Drawing.Point(12, 11);
            this.gbUserInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbUserInfo.Name = "gbUserInfo";
            this.gbUserInfo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbUserInfo.Size = new System.Drawing.Size(593, 126);
            this.gbUserInfo.TabIndex = 0;
            this.gbUserInfo.TabStop = false;
            this.gbUserInfo.Text = "角色信息";
            // 
            // txtUser
            // 
            this.txtUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUser.Location = new System.Drawing.Point(3, 16);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(587, 108);
            this.txtUser.TabIndex = 2;
            this.txtUser.Text = "";
            // 
            // gbGameInfo
            // 
            this.gbGameInfo.Controls.Add(this.txtGame);
            this.gbGameInfo.Location = new System.Drawing.Point(12, 141);
            this.gbGameInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbGameInfo.Name = "gbGameInfo";
            this.gbGameInfo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbGameInfo.Size = new System.Drawing.Size(593, 263);
            this.gbGameInfo.TabIndex = 0;
            this.gbGameInfo.TabStop = false;
            this.gbGameInfo.Text = "游戏信息";
            // 
            // txtGame
            // 
            this.txtGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGame.Location = new System.Drawing.Point(3, 16);
            this.txtGame.Name = "txtGame";
            this.txtGame.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtGame.Size = new System.Drawing.Size(587, 245);
            this.txtGame.TabIndex = 1;
            this.txtGame.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReGame);
            this.groupBox1.Controls.Add(this.btnClean);
            this.groupBox1.Controls.Add(this.btnOk);
            this.groupBox1.Controls.Add(this.txtCommand);
            this.groupBox1.Location = new System.Drawing.Point(12, 409);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(853, 48);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "游戏命令";
            // 
            // btnReGame
            // 
            this.btnReGame.AutoSize = true;
            this.btnReGame.Location = new System.Drawing.Point(804, 21);
            this.btnReGame.Name = "btnReGame";
            this.btnReGame.Size = new System.Drawing.Size(29, 12);
            this.btnReGame.TabIndex = 3;
            this.btnReGame.TabStop = true;
            this.btnReGame.Text = "重置";
            this.btnReGame.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnReGame_LinkClicked);
            // 
            // btnClean
            // 
            this.btnClean.AutoSize = true;
            this.btnClean.Location = new System.Drawing.Point(560, 21);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(53, 12);
            this.btnClean.TabIndex = 2;
            this.btnClean.TabStop = true;
            this.btnClean.Text = "清空信息";
            this.btnClean.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnClean_LinkClicked);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(137, 16);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "确认";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtCommand
            // 
            this.txtCommand.Location = new System.Drawing.Point(6, 18);
            this.txtCommand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(125, 21);
            this.txtCommand.TabIndex = 0;
            this.txtCommand.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCommand_KeyDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPet);
            this.groupBox2.Location = new System.Drawing.Point(611, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(292, 126);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "宠物信息";
            // 
            // txtPet
            // 
            this.txtPet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPet.Location = new System.Drawing.Point(3, 16);
            this.txtPet.Name = "txtPet";
            this.txtPet.Size = new System.Drawing.Size(286, 108);
            this.txtPet.TabIndex = 2;
            this.txtPet.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtFightEnemy);
            this.groupBox3.Controls.Add(this.txtFightUser);
            this.groupBox3.Location = new System.Drawing.Point(614, 141);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(289, 264);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "对战信息";
            // 
            // txtFightUser
            // 
            this.txtFightUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtFightUser.Location = new System.Drawing.Point(3, 16);
            this.txtFightUser.Name = "txtFightUser";
            this.txtFightUser.Size = new System.Drawing.Size(140, 246);
            this.txtFightUser.TabIndex = 2;
            this.txtFightUser.Text = "";
            // 
            // txtFightEnemy
            // 
            this.txtFightEnemy.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtFightEnemy.Location = new System.Drawing.Point(146, 16);
            this.txtFightEnemy.Name = "txtFightEnemy";
            this.txtFightEnemy.Size = new System.Drawing.Size(140, 246);
            this.txtFightEnemy.TabIndex = 3;
            this.txtFightEnemy.Text = "";
            // 
            // GameMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 513);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbGameInfo);
            this.Controls.Add(this.gbUserInfo);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "GameMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GameMain_FormClosed);
            this.Load += new System.EventHandler(this.GameMain_Load);
            this.gbUserInfo.ResumeLayout(false);
            this.gbGameInfo.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbUserInfo;
        private System.Windows.Forms.GroupBox gbGameInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        #region Windows 窗体设计器生成的代码


        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtCommand;
        private System.Windows.Forms.LinkLabel btnClean;
        private System.Windows.Forms.LinkLabel btnReGame;
        private System.Windows.Forms.RichTextBox txtGame;
        private System.Windows.Forms.RichTextBox txtUser;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox txtPet;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox txtFightUser;
        private System.Windows.Forms.RichTextBox txtFightEnemy;
    }
}

