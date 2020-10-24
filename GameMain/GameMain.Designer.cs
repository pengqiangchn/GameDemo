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
            this.gbGameInfo = new System.Windows.Forms.GroupBox();
            this.txtGameInfo = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReGame = new System.Windows.Forms.LinkLabel();
            this.btnClean = new System.Windows.Forms.LinkLabel();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.txtUserInfo = new System.Windows.Forms.RichTextBox();
            this.gbUserInfo.SuspendLayout();
            this.gbGameInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbUserInfo
            // 
            this.gbUserInfo.Controls.Add(this.txtUserInfo);
            this.gbUserInfo.Location = new System.Drawing.Point(660, 8);
            this.gbUserInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbUserInfo.Name = "gbUserInfo";
            this.gbUserInfo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbUserInfo.Size = new System.Drawing.Size(206, 261);
            this.gbUserInfo.TabIndex = 0;
            this.gbUserInfo.TabStop = false;
            this.gbUserInfo.Text = "角色信息";
            // 
            // gbGameInfo
            // 
            this.gbGameInfo.Controls.Add(this.txtGameInfo);
            this.gbGameInfo.Location = new System.Drawing.Point(10, 8);
            this.gbGameInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbGameInfo.Name = "gbGameInfo";
            this.gbGameInfo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbGameInfo.Size = new System.Drawing.Size(645, 263);
            this.gbGameInfo.TabIndex = 0;
            this.gbGameInfo.TabStop = false;
            this.gbGameInfo.Text = "游戏信息";
            // 
            // txtGameInfo
            // 
            this.txtGameInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGameInfo.Location = new System.Drawing.Point(3, 16);
            this.txtGameInfo.Name = "txtGameInfo";
            this.txtGameInfo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtGameInfo.Size = new System.Drawing.Size(639, 245);
            this.txtGameInfo.TabIndex = 1;
            this.txtGameInfo.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReGame);
            this.groupBox1.Controls.Add(this.btnClean);
            this.groupBox1.Controls.Add(this.btnOk);
            this.groupBox1.Controls.Add(this.txtCommand);
            this.groupBox1.Location = new System.Drawing.Point(10, 276);
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
            // txtUserInfo
            // 
            this.txtUserInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUserInfo.Location = new System.Drawing.Point(3, 16);
            this.txtUserInfo.Name = "txtUserInfo";
            this.txtUserInfo.Size = new System.Drawing.Size(200, 243);
            this.txtUserInfo.TabIndex = 2;
            this.txtUserInfo.Text = "";
            // 
            // GameMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 350);
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
        private System.Windows.Forms.RichTextBox txtGameInfo;
        private System.Windows.Forms.RichTextBox txtUserInfo;
    }
}

