using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace Isaiah_Colon_CPT_206_Final_Project
{

    public partial class RacingForm : Form
    {
        //instance of db        
        DataClasses1DataContext db = new DataClasses1DataContext();

        //Variables
        int enemyBumpsCounter = 0; //Holds amount of collisions
        int lifeCounter = 0; //Holds amount of lives
        int speedParamater; //Holds acceleration paramaters
        int collectedcoins = 0; //Holds amount of coins collected
        bool gameIsOver = false; //game running        
        int gameSpeed = 0; //Speed of game

        //Random Variables
        Random r = new Random();
        int x;

        //Recieves selection from user
        public int CarNum { get; set; }
        
        public RacingForm()
        {
            InitializeComponent();
            
            //Disable labels at start of program
            restartImage.Visible = false;
            restartImage.Enabled = false;
            gameOverLabel.Visible = false;
            pauseLabel.Visible = false;
            returnButton.Visible = false;
            returnLabel.Visible = false;
            exitButton.Visible = false;

            restartTextBox.Enabled = false;
            restartTextBox.Visible = false;
            accelerationBarTextBox.Enabled = false;

            //Set gameSpeed until start
            gameSpeed = 0;

        }


        
        public void ChangeAcceleration()
        {
            //LINQ to get acceleration for selected car
            var result = (from item in db.CarStats
                          where item.car_id == CarNum
                          select item.acceleration).FirstOrDefault();
            
            speedParamater = (int)result;
            
        }

        //Passes car life count to variable
        void LifeCount()
        {
            //LINQ to get life count for selected car
            var result = (from item in db.CarStats
                          where item.car_id == CarNum
                          select item.enemyBumps).FirstOrDefault();
                                   
            lifeCounter = (int)result;
        }        
        
        public void Collision() //gives car lives and takes away upon impact
        {
            //LINQ to get life count for selected car
            var result = (from item in db.CarStats
                          where item.car_id == CarNum
                          select item.enemyBumps).FirstOrDefault();                                                            

            //When Collision happens
            if (playerPictureBox.Bounds.IntersectsWith(enemy1.Bounds) || playerPictureBox.Bounds.IntersectsWith(enemy2.Bounds) || playerPictureBox.Bounds.IntersectsWith(enemy3.Bounds))
            {
                lifeCounter--;
                enemyBumpsCounter++;

                
                // Ends game
                if (enemyBumpsCounter == (int)result) 
                {
                    gameOver();
                }
                else if (enemyBumpsCounter != (int)result * 2) //Relocates enemy if not end of game
                {
                    if (playerPictureBox.Bounds.IntersectsWith(enemy1.Bounds))
                    {
                        x = r.Next(50, 400);
                        enemy1.Location = new Point(x, 0);
                    }
                    if (playerPictureBox.Bounds.IntersectsWith(enemy2.Bounds))
                    {
                        x = r.Next(50, 400);
                        enemy2.Location = new Point(x, 0);
                    }
                    if (playerPictureBox.Bounds.IntersectsWith(enemy3.Bounds))
                    {
                        x = r.Next(200, 400);
                        enemy3.Location = new Point(x, 0);
                    }
                    
                }

            }          
                       

        }

        //Multiplies coin score depending on car selection 
        public void CoinMultiplier()
        {
            //LIINQ to get coin multiplier for selected car
            var result = (from item in db.CarStats
                          where item.car_id == CarNum
                          select item.coinScoreMultiplier).FirstOrDefault();

            collectedcoins = collectedcoins * (int)result;
            coinLabel.Text = "Coins: " + collectedcoins.ToString();
        }

        //Adds life back if coin count = 10
        public void AddLife()
        {
            if (collectedcoins == 5)
            {
                CoinMultiplier();
            }

            if (collectedcoins == 10)
            {
                lifeCounter++;
                enemyBumpsCounter--;
                collectedcoins = 0;
            }

            if (lifeCounter == 2)
            {
                lifePictureBox3.Visible = false;
                lifePictureBox2.Visible = true;
                lifePictureBox1.Visible = true;               

            }
            else if (lifeCounter == 1)
            {
                lifePictureBox3.Visible = false;
                lifePictureBox2.Visible = false;
                lifePictureBox1.Visible = true;
            }
            else if (lifeCounter == 3)
            {
                lifePictureBox3.Visible = true;
                lifePictureBox2.Visible = true;
                lifePictureBox1.Visible = true;
            }


        }

        public void ChangeCarImage()
        {            
            
            int carID = CarNum;
            if(carID == 1)
            {
                playerPictureBox.Image = Properties.Resources._8_bit_car_pink1; 
            }
            if (carID == 2)
            {
                playerPictureBox.Image = Properties.Resources._8_bit_car_black;
            }
            if (carID == 3)
            {
                playerPictureBox.Image = Properties.Resources._8_bit_car_blue;
            }

        }
    
        private void timer1_Tick(object sender, EventArgs e)
        {
            moveTrackLine(gameSpeed);
            enemyMove(gameSpeed);            
            moveCoins(gameSpeed);
            coinCollection();
            ChangeCarImage();
            ChangeAcceleration();
            accelerationBar.Value = gameSpeed * 4;

            if (lifeCounter == 0)
            {
                LifeCount();
            }

            Collision();
            AddLife();            
                        
        }
        
        //Method to collect coins and relocate them once collected        
        void coinCollection() 
        {
            if (playerPictureBox.Bounds.IntersectsWith(coin1.Bounds))
            {
                //Collects coin and adds to coin collection
                collectedcoins++;
                coinLabel.Text = "Coins: " + collectedcoins.ToString();

                //Respawns coin in new location
                x = r.Next(50, 400);
                coin1.Location = new Point(x, 0);

            }

            if (playerPictureBox.Bounds.IntersectsWith(coin2.Bounds))
            {
                collectedcoins++;
                coinLabel.Text = "Coins: " + collectedcoins.ToString();

                x = r.Next(50, 400);
                coin2.Location = new Point(x, 0);
            }

            if (playerPictureBox.Bounds.IntersectsWith(coin3.Bounds))
            {
                collectedcoins++;
                coinLabel.Text = "Coins: " + collectedcoins.ToString();

                x = r.Next(50, 400);
                coin3.Location = new Point(x, 0);
            }

            if (playerPictureBox.Bounds.IntersectsWith(coin4.Bounds))
            {
                collectedcoins++;
                coinLabel.Text = "Coins: " + collectedcoins.ToString();

                x = r.Next(50, 400);
                coin4.Location = new Point(x, 0);
            }
            
        }

        //Method for the enemy cars to move        
        void enemyMove(int speed)
        {
            //Randomly puts the enemy cars in different spots every time it goes past the screen
            if (enemy1.Top >= 900)
            {
                x = r.Next(50, 400);
                enemy1.Location = new Point(x, 0);
            }
            else { enemy1.Top += speed; }

            if (enemy2.Top >= 900)
            {
                x = r.Next(50, 400);
                enemy2.Location = new Point(x, 0);
            }
            else { enemy2.Top += speed; }

            if (enemy3.Top >= 900)
            {
                x = r.Next(200, 400);
                enemy3.Location = new Point(x, 0);
            }
            else { enemy3.Top += speed; }
            
        }

        //game running variable
        
        void gameOver()
        {            
            //Stops the game
            timer1.Enabled = false;
            gameOverLabel.Visible = true;

            //Removes hearts
            lifePictureBox3.Visible = false;
            lifePictureBox2.Visible = false;
            lifePictureBox1.Visible = false;

            //Brings Restart Image
            restartImage.Enabled = true;
            restartImage.Visible = true;
            healthLabel.Visible = false;

            restartTextBox.Visible = true;

            gameIsOver = true;

            playPictureBox.Enabled = false;
            pausePictureBox.Enabled = false;

            returnButton.Enabled = true;
            returnButton.Visible = true;

            returnLabel.Visible = true;

            exitButton.Visible = true;
            exitButton.Enabled = true;

        }

        //Method to move the coins
        void moveCoins(int speed)
        {
            //Randomly puts the coin in different spots every time it goes past the screen
            if (coin1.Top >= 900)
            {
                x = r.Next(50, 400);
                coin1.Location = new Point(x, 0);
            }
            else { coin1.Top += speed; }

            if (coin2.Top >= 900)
            {
                x = r.Next(50, 400);
                coin2.Location = new Point(x, 0);
            }
            else { coin2.Top += speed; }

            if (coin3.Top >= 900)
            {
                x = r.Next(200, 400);
                coin3.Location = new Point(x, 0);
            }
            else { coin3.Top += speed; }

            if (coin4.Top >= 900)
            {
                x = r.Next(200, 400);
                coin4.Location = new Point(x, 0);
            }
            else { coin4.Top += speed; }
        }

        //Method to move the track lines
        void moveTrackLine(int speed)
        {
            //Resets the lines so it looks like you are continuosly moving forward
            if (pictureBox1.Top >= 900)
            { pictureBox1.Top = 0;}
            else { pictureBox1.Top += speed; }

            if (pictureBox2.Top >= 900)
            { pictureBox2.Top = 0; }
            else { pictureBox2.Top += speed; }

            if (pictureBox3.Top >= 900)
            { pictureBox3.Top = 0; }
            else { pictureBox3.Top += speed; }

            if (pictureBox4.Top >= 900)
            { pictureBox4.Top = 0; }
            else { pictureBox4.Top += speed; }

            //Keeps moving the lines 
            pictureBox1.Top += speed;
            pictureBox2.Top += speed;
            pictureBox3.Top += speed;
            pictureBox4.Top += speed;

            
        }        

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                if(playerPictureBox.Left > 50)
                playerPictureBox.Left += -12;
            }
            if (e.KeyCode == Keys.Right)
            {
                if(playerPictureBox.Right < 410)
                playerPictureBox.Left += 12;
            }

            

            if (e.KeyCode==Keys.Up)
            {
                if(gameSpeed< speedParamater)
                {
                    gameSpeed++;
                }
            }

            if (e.KeyCode == Keys.Down)
            {
                if (gameSpeed > 0)
                {
                    gameSpeed--;
                }
            }


        }

        //Method to reset score
        public void ScoreReset()
        {
            //Resets score
            collectedcoins = 0;
            coinLabel.Text = "Coins: " + collectedcoins.ToString();

            enemyBumpsCounter = 0;
        }

        void ResetLocation()
        {
            //Resets object location
            playerPictureBox.Location = new Point(85, 346);

            enemy1.Location = new Point(47, 125);
            enemy2.Location = new Point(279, 47);
            enemy3.Location = new Point(327, 145);

            pictureBox1.Location = new Point(221, 0);
            pictureBox2.Location = new Point(221, 145);
            pictureBox3.Location = new Point(221, 293);
            pictureBox4.Location = new Point(221, 447);

            //Randomly puts the coin in different spots                      
            x = r.Next(50, 400);
            coin1.Location = new Point(x, 0);
            coin2.Location = new Point(x, 0);
            x = r.Next(200, 400);
            coin3.Location = new Point(x, 0);
            coin4.Location = new Point(x, 0);
        }
        public void gameRestart()
        {
            ScoreReset();

            ResetLocation();

            //Removes restart button
            restartImage.Visible = false;
            restartImage.Enabled = false;

            gameOverLabel.Visible = false;
            
            //Resets 
            gameSpeed = 0;
            timer1.Enabled = true;
            restartTextBox.Visible = false;
            gameIsOver = false;

            lifePictureBox3.Visible = true;
            lifePictureBox2.Visible = true;
            lifePictureBox1.Visible = true;

            //play/pause button
            pausePictureBox.Enabled = true;
            pausePictureBox.Visible = true;
            playPictureBox.Visible = false;
            playPictureBox.Enabled = false;

            returnButton.Enabled = false;
            returnButton.Visible = false;

            returnLabel.Visible = false;

            exitButton.Visible = false;
            exitButton.Enabled = false;
        }

        

        private void RestartClickEvent(object sender, EventArgs e)
        {
            gameRestart();

        }

        private void pausePictureBox_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            pausePictureBox.Enabled = false;
            pausePictureBox.Visible = false;
            playPictureBox.Visible = true;
            playPictureBox.Enabled = true;

            pauseLabel.Visible = true;

            returnButton.Enabled = true;
            returnButton.Visible = true;

            returnLabel.Visible = true;

            exitButton.Visible = true;
            exitButton.Enabled = true;
        }

        private void playPictureBox_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            pausePictureBox.Enabled = true;
            pausePictureBox.Visible = true;
            playPictureBox.Visible = false;
            playPictureBox.Enabled = false;

            pauseLabel.Visible = false;

            returnButton.Enabled = false;
            returnButton.Visible = false;

            returnLabel.Visible = false;

            exitButton.Visible = false;
            exitButton.Enabled = false;
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            CarSelect carSelect = new CarSelect();
            carSelect.Show();

            RacingForm racingForm = new RacingForm();
            racingForm.Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
