namespace Isaiah_Colon_CPT_206_Final_Project
{
    partial class RacingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RacingForm));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gameOverLabel = new System.Windows.Forms.Label();
            this.coinLabel = new System.Windows.Forms.Label();
            this.restartTextBox = new System.Windows.Forms.TextBox();
            this.accelerationBar = new System.Windows.Forms.ProgressBar();
            this.accelerationBarTextBox = new System.Windows.Forms.TextBox();
            this.lifePictureBox1 = new System.Windows.Forms.PictureBox();
            this.restartImage = new System.Windows.Forms.PictureBox();
            this.coin3 = new System.Windows.Forms.PictureBox();
            this.coin2 = new System.Windows.Forms.PictureBox();
            this.coin4 = new System.Windows.Forms.PictureBox();
            this.coin1 = new System.Windows.Forms.PictureBox();
            this.enemy2 = new System.Windows.Forms.PictureBox();
            this.enemy3 = new System.Windows.Forms.PictureBox();
            this.enemy1 = new System.Windows.Forms.PictureBox();
            this.playerPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lifePictureBox3 = new System.Windows.Forms.PictureBox();
            this.lifePictureBox2 = new System.Windows.Forms.PictureBox();
            this.pausePictureBox = new System.Windows.Forms.PictureBox();
            this.playPictureBox = new System.Windows.Forms.PictureBox();
            this.pauseLabel = new System.Windows.Forms.Label();
            this.healthLabel = new System.Windows.Forms.Label();
            this.returnButton = new System.Windows.Forms.PictureBox();
            this.returnLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.lifePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restartImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lifePictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lifePictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pausePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gameOverLabel
            // 
            this.gameOverLabel.AutoSize = true;
            this.gameOverLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gameOverLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            this.gameOverLabel.ForeColor = System.Drawing.Color.Red;
            this.gameOverLabel.Location = new System.Drawing.Point(95, 125);
            this.gameOverLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gameOverLabel.Name = "gameOverLabel";
            this.gameOverLabel.Size = new System.Drawing.Size(257, 44);
            this.gameOverLabel.TabIndex = 14;
            this.gameOverLabel.Text = "GAME OVER";
            // 
            // coinLabel
            // 
            this.coinLabel.AutoSize = true;
            this.coinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coinLabel.ForeColor = System.Drawing.Color.Yellow;
            this.coinLabel.Location = new System.Drawing.Point(48, 4);
            this.coinLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.coinLabel.Name = "coinLabel";
            this.coinLabel.Size = new System.Drawing.Size(59, 20);
            this.coinLabel.TabIndex = 19;
            this.coinLabel.Text = "Coins:";
            // 
            // restartTextBox
            // 
            this.restartTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.restartTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.restartTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter);
            this.restartTextBox.ForeColor = System.Drawing.Color.Red;
            this.restartTextBox.Location = new System.Drawing.Point(118, 259);
            this.restartTextBox.Name = "restartTextBox";
            this.restartTextBox.Size = new System.Drawing.Size(214, 26);
            this.restartTextBox.TabIndex = 21;
            this.restartTextBox.Text = "Click button to:";
            this.restartTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // accelerationBar
            // 
            this.accelerationBar.Location = new System.Drawing.Point(306, 23);
            this.accelerationBar.Name = "accelerationBar";
            this.accelerationBar.Size = new System.Drawing.Size(100, 10);
            this.accelerationBar.TabIndex = 22;
            // 
            // accelerationBarTextBox
            // 
            this.accelerationBarTextBox.BackColor = System.Drawing.SystemColors.GrayText;
            this.accelerationBarTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.accelerationBarTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accelerationBarTextBox.ForeColor = System.Drawing.Color.Yellow;
            this.accelerationBarTextBox.Location = new System.Drawing.Point(306, 4);
            this.accelerationBarTextBox.Name = "accelerationBarTextBox";
            this.accelerationBarTextBox.Size = new System.Drawing.Size(100, 13);
            this.accelerationBarTextBox.TabIndex = 23;
            this.accelerationBarTextBox.Text = "Acceleration Bar:";
            // 
            // lifePictureBox1
            // 
            this.lifePictureBox1.Image = global::Isaiah_Colon_CPT_206_Final_Project.Properties.Resources._8_bit_life;
            this.lifePictureBox1.Location = new System.Drawing.Point(374, 449);
            this.lifePictureBox1.Name = "lifePictureBox1";
            this.lifePictureBox1.Size = new System.Drawing.Size(38, 34);
            this.lifePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lifePictureBox1.TabIndex = 24;
            this.lifePictureBox1.TabStop = false;
            // 
            // restartImage
            // 
            this.restartImage.Image = ((System.Drawing.Image)(resources.GetObject("restartImage.Image")));
            this.restartImage.Location = new System.Drawing.Point(92, 281);
            this.restartImage.Margin = new System.Windows.Forms.Padding(2);
            this.restartImage.Name = "restartImage";
            this.restartImage.Size = new System.Drawing.Size(257, 68);
            this.restartImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.restartImage.TabIndex = 20;
            this.restartImage.TabStop = false;
            this.restartImage.Click += new System.EventHandler(this.RestartClickEvent);
            // 
            // coin3
            // 
            this.coin3.Image = ((System.Drawing.Image)(resources.GetObject("coin3.Image")));
            this.coin3.Location = new System.Drawing.Point(279, 261);
            this.coin3.Margin = new System.Windows.Forms.Padding(2);
            this.coin3.Name = "coin3";
            this.coin3.Size = new System.Drawing.Size(17, 16);
            this.coin3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin3.TabIndex = 18;
            this.coin3.TabStop = false;
            // 
            // coin2
            // 
            this.coin2.Image = ((System.Drawing.Image)(resources.GetObject("coin2.Image")));
            this.coin2.Location = new System.Drawing.Point(165, 47);
            this.coin2.Margin = new System.Windows.Forms.Padding(2);
            this.coin2.Name = "coin2";
            this.coin2.Size = new System.Drawing.Size(17, 16);
            this.coin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin2.TabIndex = 17;
            this.coin2.TabStop = false;
            // 
            // coin4
            // 
            this.coin4.Image = ((System.Drawing.Image)(resources.GetObject("coin4.Image")));
            this.coin4.Location = new System.Drawing.Point(351, 47);
            this.coin4.Margin = new System.Windows.Forms.Padding(2);
            this.coin4.Name = "coin4";
            this.coin4.Size = new System.Drawing.Size(17, 16);
            this.coin4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin4.TabIndex = 16;
            this.coin4.TabStop = false;
            // 
            // coin1
            // 
            this.coin1.Image = ((System.Drawing.Image)(resources.GetObject("coin1.Image")));
            this.coin1.Location = new System.Drawing.Point(92, 227);
            this.coin1.Margin = new System.Windows.Forms.Padding(2);
            this.coin1.Name = "coin1";
            this.coin1.Size = new System.Drawing.Size(17, 16);
            this.coin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin1.TabIndex = 15;
            this.coin1.TabStop = false;
            // 
            // enemy2
            // 
            this.enemy2.Image = ((System.Drawing.Image)(resources.GetObject("enemy2.Image")));
            this.enemy2.Location = new System.Drawing.Point(279, 47);
            this.enemy2.Margin = new System.Windows.Forms.Padding(2);
            this.enemy2.Name = "enemy2";
            this.enemy2.Size = new System.Drawing.Size(35, 62);
            this.enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy2.TabIndex = 13;
            this.enemy2.TabStop = false;
            // 
            // enemy3
            // 
            this.enemy3.Image = ((System.Drawing.Image)(resources.GetObject("enemy3.Image")));
            this.enemy3.Location = new System.Drawing.Point(327, 145);
            this.enemy3.Margin = new System.Windows.Forms.Padding(2);
            this.enemy3.Name = "enemy3";
            this.enemy3.Size = new System.Drawing.Size(35, 62);
            this.enemy3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy3.TabIndex = 12;
            this.enemy3.TabStop = false;
            // 
            // enemy1
            // 
            this.enemy1.Image = ((System.Drawing.Image)(resources.GetObject("enemy1.Image")));
            this.enemy1.Location = new System.Drawing.Point(47, 125);
            this.enemy1.Margin = new System.Windows.Forms.Padding(2);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(35, 62);
            this.enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy1.TabIndex = 7;
            this.enemy1.TabStop = false;
            // 
            // playerPictureBox
            // 
            this.playerPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("playerPictureBox.Image")));
            this.playerPictureBox.Location = new System.Drawing.Point(85, 346);
            this.playerPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.playerPictureBox.Name = "playerPictureBox";
            this.playerPictureBox.Size = new System.Drawing.Size(45, 55);
            this.playerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerPictureBox.TabIndex = 6;
            this.playerPictureBox.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pictureBox6.Location = new System.Drawing.Point(411, -9);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(7, 567);
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pictureBox5.Location = new System.Drawing.Point(37, -1);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(7, 558);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pictureBox4.Location = new System.Drawing.Point(221, 447);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(7, 109);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pictureBox3.Location = new System.Drawing.Point(221, 293);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(7, 109);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pictureBox2.Location = new System.Drawing.Point(221, 145);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(7, 109);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pictureBox1.Location = new System.Drawing.Point(221, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(7, 109);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lifePictureBox3
            // 
            this.lifePictureBox3.Image = global::Isaiah_Colon_CPT_206_Final_Project.Properties.Resources._8_bit_life;
            this.lifePictureBox3.Location = new System.Drawing.Point(311, 449);
            this.lifePictureBox3.Name = "lifePictureBox3";
            this.lifePictureBox3.Size = new System.Drawing.Size(38, 34);
            this.lifePictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lifePictureBox3.TabIndex = 25;
            this.lifePictureBox3.TabStop = false;
            // 
            // lifePictureBox2
            // 
            this.lifePictureBox2.Image = global::Isaiah_Colon_CPT_206_Final_Project.Properties.Resources._8_bit_life;
            this.lifePictureBox2.Location = new System.Drawing.Point(342, 449);
            this.lifePictureBox2.Name = "lifePictureBox2";
            this.lifePictureBox2.Size = new System.Drawing.Size(38, 34);
            this.lifePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lifePictureBox2.TabIndex = 26;
            this.lifePictureBox2.TabStop = false;
            // 
            // pausePictureBox
            // 
            this.pausePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pausePictureBox.Image")));
            this.pausePictureBox.Location = new System.Drawing.Point(-2, 4);
            this.pausePictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.pausePictureBox.Name = "pausePictureBox";
            this.pausePictureBox.Size = new System.Drawing.Size(46, 38);
            this.pausePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pausePictureBox.TabIndex = 27;
            this.pausePictureBox.TabStop = false;
            this.pausePictureBox.Click += new System.EventHandler(this.pausePictureBox_Click);
            // 
            // playPictureBox
            // 
            this.playPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("playPictureBox.Image")));
            this.playPictureBox.Location = new System.Drawing.Point(-2, 4);
            this.playPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.playPictureBox.Name = "playPictureBox";
            this.playPictureBox.Size = new System.Drawing.Size(46, 38);
            this.playPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playPictureBox.TabIndex = 28;
            this.playPictureBox.TabStop = false;
            this.playPictureBox.Click += new System.EventHandler(this.playPictureBox_Click);
            // 
            // pauseLabel
            // 
            this.pauseLabel.AutoSize = true;
            this.pauseLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pauseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            this.pauseLabel.ForeColor = System.Drawing.Color.Red;
            this.pauseLabel.Location = new System.Drawing.Point(135, 125);
            this.pauseLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pauseLabel.Name = "pauseLabel";
            this.pauseLabel.Size = new System.Drawing.Size(179, 44);
            this.pauseLabel.TabIndex = 29;
            this.pauseLabel.Text = "PAUSED";
            // 
            // healthLabel
            // 
            this.healthLabel.AutoSize = true;
            this.healthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthLabel.ForeColor = System.Drawing.Color.Red;
            this.healthLabel.Location = new System.Drawing.Point(254, 466);
            this.healthLabel.Name = "healthLabel";
            this.healthLabel.Size = new System.Drawing.Size(60, 17);
            this.healthLabel.TabIndex = 30;
            this.healthLabel.Text = "Health:";
            // 
            // returnButton
            // 
            this.returnButton.Image = ((System.Drawing.Image)(resources.GetObject("returnButton.Image")));
            this.returnButton.Location = new System.Drawing.Point(-2, 46);
            this.returnButton.Margin = new System.Windows.Forms.Padding(2);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(46, 38);
            this.returnButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.returnButton.TabIndex = 31;
            this.returnButton.TabStop = false;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // returnLabel
            // 
            this.returnLabel.AutoSize = true;
            this.returnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnLabel.ForeColor = System.Drawing.Color.Gold;
            this.returnLabel.Location = new System.Drawing.Point(49, 59);
            this.returnLabel.Name = "returnLabel";
            this.returnLabel.Size = new System.Drawing.Size(228, 17);
            this.returnLabel.TabIndex = 32;
            this.returnLabel.Text = "<< Click to return to car select";
            // 
            // exitButton
            // 
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.Location = new System.Drawing.Point(-2, 88);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(46, 38);
            this.exitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exitButton.TabIndex = 33;
            this.exitButton.TabStop = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // RacingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(449, 495);
            this.Controls.Add(this.returnLabel);
            this.Controls.Add(this.healthLabel);
            this.Controls.Add(this.restartTextBox);
            this.Controls.Add(this.gameOverLabel);
            this.Controls.Add(this.pauseLabel);
            this.Controls.Add(this.lifePictureBox2);
            this.Controls.Add(this.lifePictureBox3);
            this.Controls.Add(this.accelerationBar);
            this.Controls.Add(this.accelerationBarTextBox);
            this.Controls.Add(this.restartImage);
            this.Controls.Add(this.coinLabel);
            this.Controls.Add(this.coin3);
            this.Controls.Add(this.coin2);
            this.Controls.Add(this.coin4);
            this.Controls.Add(this.coin1);
            this.Controls.Add(this.enemy2);
            this.Controls.Add(this.enemy3);
            this.Controls.Add(this.enemy1);
            this.Controls.Add(this.playerPictureBox);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lifePictureBox1);
            this.Controls.Add(this.pausePictureBox);
            this.Controls.Add(this.playPictureBox);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.exitButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RacingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.lifePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restartImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lifePictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lifePictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pausePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox playerPictureBox;
        private System.Windows.Forms.PictureBox enemy1;
        private System.Windows.Forms.PictureBox enemy3;
        private System.Windows.Forms.PictureBox enemy2;
        private System.Windows.Forms.Label gameOverLabel;
        private System.Windows.Forms.PictureBox coin1;
        private System.Windows.Forms.PictureBox coin4;
        private System.Windows.Forms.PictureBox coin2;
        private System.Windows.Forms.PictureBox coin3;
        private System.Windows.Forms.Label coinLabel;
        private System.Windows.Forms.PictureBox restartImage;
        private System.Windows.Forms.TextBox restartTextBox;
        private System.Windows.Forms.ProgressBar accelerationBar;
        private System.Windows.Forms.TextBox accelerationBarTextBox;
        private System.Windows.Forms.PictureBox lifePictureBox1;
        private System.Windows.Forms.PictureBox lifePictureBox3;
        private System.Windows.Forms.PictureBox lifePictureBox2;
        private System.Windows.Forms.PictureBox pausePictureBox;
        private System.Windows.Forms.PictureBox playPictureBox;
        private System.Windows.Forms.Label pauseLabel;
        private System.Windows.Forms.Label healthLabel;
        private System.Windows.Forms.PictureBox returnButton;
        private System.Windows.Forms.Label returnLabel;
        private System.Windows.Forms.PictureBox exitButton;
    }
}

