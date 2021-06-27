using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

// Bar d'energie: EGet
// Bar de vie: HealthGet
// Score: ScoreInfo
// drone: Mplayer

// Ce jeu à été à 100% inventer par @Ndebilloez sur twitter.
// @NDebilloez est l'auteur original de ce jeux.

namespace DroneGames
{
    public partial class GamesWin : Form
    {

        int PlayerPv = 100;
        int batteryLevel = 100;
        int speedPlayer = 10;
        int stopSpawn = 0;
        int batteryCount = 0;

        //int X;
        //int Y;

        int[] posXRandom = {
          700,
          290,
          40,
          710,
          360
        };
        int[] posYrandom = {
          372,
          264,
          137,
          124,
          264
        };

        int monsterSp = 4;
        int astSpeed = 6;

        string direction;

        bool right, left, up, down;
        bool end = false;

        int scoreUp = 0;

        List<PictureBox> monsterL = new List<PictureBox>();

        Random number = new Random();

        public GamesWin()
        {
            InitializeComponent();
            injectSpawnMonsterLeft();
            direction = "unknown";
        }
        private static void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e) => Console.WriteLine("The Elapsed event was raised at {0}", e.SignalTime);

        private void Loading(object sender, EventArgs e) => Console.WriteLine("Game is loading...");

        private void isDownKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                right = true;
                left = false;
                up = false;
                down = false;
                direction = "right";
            }
            if (e.KeyCode == Keys.Left)
            {
                left = true;
                right = false;
                up = false;
                down = false;
                direction = "left";
            }
            if (e.KeyCode == Keys.Down)
            {
                left = false;
                right = false;
                up = false;
                down = true;
                direction = "down";
            }
            if (e.KeyCode == Keys.Up)
            {
                left = false;
                right = false;
                up = true;
                down = false;
                direction = "up";
            }
            if (e.KeyCode == Keys.Space && batteryLevel >= 30)
            {
                goProj();
            }
            if (end == true && e.KeyCode == Keys.P)
            {
                replay();
            }
            // get coord by player
            /*if(e.KeyCode == Keys.Enter)
            {
                X = Mplayer.Left + (Mplayer.Width / 2);
                Y = Mplayer.Top + (Mplayer.Width / 2);

                Console.WriteLine($"x = {X} et y = {Y}");
            }*/
        }
        private void spawnBattery()
        {
            speedPlayer = 8;

            int posRand = number.Next(0, 4);

            Console.WriteLine($"Les points aléatoires sont en {posXRandom[posRand]} et {posYrandom[posRand]}.");

            int posChoiceX = posXRandom[posRand];
            int posChoiceY = posYrandom[posRand];

            PictureBox battery = new PictureBox();

            battery.Image = Properties.Resources.accumulator;
            battery.Location = new Point(posChoiceX, posChoiceY);
            battery.Tag = "Energy";

            this.Controls.Add(battery);

        }

        private void isUpKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                right = false;
                left = false;
                up = false;
                down = false;
                direction = "unknown";
            }
            if (e.KeyCode == Keys.Left)
            {
                left = false;
                right = false;
                up = false;
                down = false;
                direction = "unknown";
            }
            if (e.KeyCode == Keys.Down)
            {
                left = false;
                right = false;
                up = false;
                down = false;
                direction = "unknown";
            }
            if (e.KeyCode == Keys.Up)
            {
                left = false;
                right = false;
                up = false;
                down = false;
                direction = "unknown";
            }

        }

        private void checkerOne(object sender, EventArgs e)
        {
            if (direction == "unknown")
            {
                PlayerPv -= 5;
            }
        }

        private void goProj()
        {
            batteryLevel -= 8;
            Projectiles node = new Projectiles();
            node.projLeft = Mplayer.Left + (Mplayer.Width / 2); // position gauche droite
            node.projHight = Mplayer.Top + (Mplayer.Height / 2); // Position en hauteur
            node.launch(this);
        }

        private void clockEvent(object sender, EventArgs e)
        {
            ScoreInfo.Text = $"Score: {scoreUp}";

            if (scoreUp < 0)
            {
                scoreUp = 0;
            }
            if (batteryLevel < 29 && batteryCount == 0)
            {
                monsterSp = 2;
                batteryCount = 1;
                spawnBattery();
                spawnOnWinRock();
            }

            if (PlayerPv > 1)
            {
                HealthGet.Value = PlayerPv;
            }
            else
            {
                end = true;
                //batteryLevel = 100;
                //PlayerPv = 100;
                stopGame();
            }

            if (batteryLevel > 1)
            {
                EGet.Value = batteryLevel;
            }

            if (right == true && direction == "right" && Mplayer.Left + Mplayer.Width < this.ClientSize.Width)
            {
                Mplayer.Left += speedPlayer;
            }
            if (left == true && direction == "left" && Mplayer.Left > 0)
            {
                Mplayer.Left -= speedPlayer;
            }
            if (up == true && direction == "up" && Mplayer.Top > 0)
            {
                Mplayer.Top -= speedPlayer;
            }
            if (down == true && direction == "down" && Mplayer.Top + Mplayer.Width < this.ClientSize.Height - 58)
            {
                Mplayer.Top += speedPlayer;
            }
            if (Mplayer.Left == 100 && Mplayer.Top == this.ClientSize.Height + 50)
            {
                Mplayer.Location = new Point(478, 490);
            }
            foreach (Control entityBar in this.Controls)
            {
                if (entityBar is ProgressBar && (string)entityBar.Name == "EGet" || entityBar is ProgressBar && (string)entityBar.Name == "HealthGet")
                {
                    if (Mplayer.Bounds.IntersectsWith(entityBar.Bounds))
                    {
                        Mplayer.Location = new Point(478, 490);
                    }
                }
            }
            foreach (Control entityText in this.Controls)
            {
                if (entityText is Label && (string)entityText.Name == "HalthPv" || entityText is Label && (string)entityText.Name == "BatteryInfo" || entityText is Label && (string)entityText.Name == "ScoreInfo")
                {
                    if (Mplayer.Bounds.IntersectsWith(entityText.Bounds))
                    {
                        Mplayer.Location = new Point(478, 490);
                    }
                }
            }

            foreach (Control entityBat in this.Controls)
            {
                if (entityBat is PictureBox && (string)entityBat.Tag == "Energy")
                {
                    if (Mplayer.Bounds.IntersectsWith(entityBat.Bounds))
                    {
                        batteryCount = 0;
                        monsterSp = 4;
                        this.Controls.Remove(entityBat);
                        ((PictureBox)entityBat).Dispose();
                        batteryLevel += 60;
                        speedPlayer = 10;
                    }
                }
            }

            foreach (Control entityText in this.Controls)
            {
                if (entityText is Label && (string)entityText.Name == "HalthPv" || entityText is Label && (string)entityText.Name == "BatteryInfo" || entityText is Label && (string)entityText.Name == "ScoreInfo")
                {
                    if (Mplayer.Bounds.IntersectsWith(entityText.Bounds))
                    {
                        Mplayer.Location = new Point(478, 490);
                    }
                }
            }
            foreach (Control entityP in this.Controls)
            {
                if (entityP is PictureBox && (string)entityP.Tag == "Patern")
                {
                    if (Mplayer.Bounds.IntersectsWith(entityP.Bounds))
                    {
                        Mplayer.Location = new Point(478, 490);
                        PlayerPv -= 5;
                    }
                }
            }
            foreach (Control entityF in this.Controls)
            {
                if (entityF is PictureBox && (string)entityF.Tag == "endFlag")
                {
                    if (Mplayer.Bounds.IntersectsWith(entityF.Bounds))
                    {
                        Mplayer.Location = new Point(478, 490);
                        PlayerPv -= 3;
                    }
                }
            }

            foreach (Control entityA in this.Controls)
            {
                if (entityA is PictureBox && (string)entityA.Tag == "asteroid")
                {
                    if (Mplayer.Bounds.IntersectsWith(entityA.Bounds))
                    {
                        PlayerPv -= 5;
                    }
                    if (StonePosY.Bounds.IntersectsWith(entityA.Bounds) || StonePosX.Bounds.IntersectsWith(entityA.Bounds) || StonePosZ.Bounds.IntersectsWith(entityA.Bounds) || StonePosA.Bounds.IntersectsWith(entityA.Bounds) || StonePosB.Bounds.IntersectsWith(entityA.Bounds))
                    {
                        this.Controls.Remove(entityA);
                        ((PictureBox)entityA).Dispose();
                    }
                }
            }

            foreach (Control entityProj in this.Controls)
            {
                if (entityProj is PictureBox && (string)entityProj.Tag == "projBall")
                {
                    foreach (Control entityMonster in this.Controls)
                    {
                        if (entityProj is PictureBox && (string)entityProj.Tag == "projBall" && entityMonster is PictureBox && (string)entityMonster.Tag == "monster")
                        {
                            if (entityProj.Bounds.IntersectsWith(entityMonster.Bounds))
                            {
                                scoreUp++;
                                this.Controls.Remove(entityProj);
                                this.Controls.Remove(entityMonster);
                                ((PictureBox)entityMonster).Dispose();
                                ((PictureBox)entityProj).Dispose();
                                stopSpawn--;
                                monsterL.Clear();
                                injectSpawnMonsterLeft();
                            }
                        }
                    }
                }
                if (entityProj is PictureBox && (string)entityProj.Tag == "monster")
                {
                    entityProj.Left += monsterSp;

                    if (entityProj.Left + entityProj.Width > this.ClientSize.Width)
                    {
                        this.Controls.Remove(entityProj);
                        ((PictureBox)entityProj).Dispose();
                        monsterL.Clear();
                        scoreUp--;
                        stopSpawn--;
                        injectSpawnMonsterLeft();
                    }

                    if (Mplayer.Bounds.IntersectsWith(entityProj.Bounds))
                    {
                        PlayerPv -= 1;
                    }
                }

                if (entityProj is PictureBox && (string)entityProj.Tag == "asteroid")
                {
                    entityProj.Top += astSpeed;
                }

                if (entityProj is PictureBox && (string)entityProj.Tag == "projBall")
                {
                    if (StonePosY.Bounds.IntersectsWith(entityProj.Bounds) || StonePosX.Bounds.IntersectsWith(entityProj.Bounds) || StonePosZ.Bounds.IntersectsWith(entityProj.Bounds) || StonePosA.Bounds.IntersectsWith(entityProj.Bounds) || StonePosB.Bounds.IntersectsWith(entityProj.Bounds))
                    {
                        this.Controls.Remove(entityProj);
                        ((PictureBox)entityProj).Dispose();
                    }
                }
            }
        }
        private void injectSpawnMonsterLeft()
        {
            if (stopSpawn > 2 && monsterL.Count < 3)
            {
                return;
            }
            else
            {
                for (int i = 0; i < 2; i++)
                {
                    spawnMonsterLeft();
                }
            }
        }
        private void spawnOnWinRock()
        {
            for (int i = 0; i < 20; i++)
            {
                spawnRock();
            }
        }
        private void spawnMonsterLeft()
        {
            stopSpawn++;
            PictureBox monsterPicture = new PictureBox();
            monsterPicture.Image = Properties.Resources.monster;
            monsterPicture.Tag = "monster";
            monsterPicture.Left = number.Next(0, this.ClientSize.Width - 200);
            monsterPicture.Top = 510;

            monsterL.Add(monsterPicture);
            this.Controls.Add(monsterPicture);
        }
        private void spawnRock()
        {
            PictureBox asteroid = new PictureBox();
            asteroid.Top = number.Next(0, this.ClientSize.Height);
            asteroid.Tag = "asteroid";
            asteroid.Left = number.Next(0, this.ClientSize.Width - 10);
            asteroid.Image = Properties.Resources.rock;

            this.Controls.Add(asteroid);
        }

        private void stopGame()
        {

            foreach (Control entityEnd in this.Controls)
            {
                if (entityEnd is PictureBox && (string)entityEnd.Tag == "monster")
                {
                    this.Controls.Remove(entityEnd);
                    ((PictureBox)entityEnd).Dispose();
                    monsterL.Clear();
                }
                if (entityEnd is PictureBox && (string)entityEnd.Tag == "projBall")
                {
                    this.Controls.Remove(entityEnd);
                    ((PictureBox)entityEnd).Dispose();

                }
                if (entityEnd is PictureBox && (string)entityEnd.Tag == "asteroid")
                {
                    this.Controls.Remove(entityEnd);
                    ((PictureBox)entityEnd).Dispose();
                }
                if (entityEnd is PictureBox && (string)entityEnd.Tag == "Energy")
                {
                    this.Controls.Remove(entityEnd);
                    ((PictureBox)entityEnd).Dispose();
                }
            }
            PlayerPv = 0;
            
            Mplayer.Image = Properties.Resources.tombstone;
            Mplayer.Location = new Point(478, 490);
            direction = "unknown";

        }
        private void replay()
        {
            end = false;
            clockSpeedValue.Stop();
            
            Mplayer.Image = Properties.Resources.drone;

            scoreUp = 0;

            batteryLevel = 100;
            PlayerPv = 100;

            monsterSp = 4;
            astSpeed = 6;

            stopSpawn = 0;
            batteryCount = 0;

            right = false;
            left = false;
            up = false;
            down = false;

            injectSpawnMonsterLeft();
            direction = "unknown";
            monsterL.Clear();
            clockSpeedValue.Start();

            speedPlayer = 10;
        }
    }
}
