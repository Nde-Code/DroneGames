
namespace DroneGames
{
    partial class GamesWin
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GamesWin));
            this.HalthPv = new System.Windows.Forms.Label();
            this.BatteryInfo = new System.Windows.Forms.Label();
            this.ScoreInfo = new System.Windows.Forms.Label();
            this.HealthGet = new System.Windows.Forms.ProgressBar();
            this.EGet = new System.Windows.Forms.ProgressBar();
            this.clockSpeedValue = new System.Windows.Forms.Timer(this.components);
            this.Checker = new System.Windows.Forms.Timer(this.components);
            this.end_line = new System.Windows.Forms.PictureBox();
            this.StonePosB = new System.Windows.Forms.PictureBox();
            this.StonePosA = new System.Windows.Forms.PictureBox();
            this.StonePosZ = new System.Windows.Forms.PictureBox();
            this.StonePosY = new System.Windows.Forms.PictureBox();
            this.StonePosX = new System.Windows.Forms.PictureBox();
            this.grass15 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grass = new System.Windows.Forms.PictureBox();
            this.Mplayer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.end_line)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StonePosB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StonePosA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StonePosZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StonePosY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StonePosX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grass15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mplayer)).BeginInit();
            this.SuspendLayout();
            // 
            // HalthPv
            // 
            this.HalthPv.AutoSize = true;
            this.HalthPv.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HalthPv.ForeColor = System.Drawing.SystemColors.Window;
            this.HalthPv.Location = new System.Drawing.Point(13, 13);
            this.HalthPv.Name = "HalthPv";
            this.HalthPv.Size = new System.Drawing.Size(165, 31);
            this.HalthPv.TabIndex = 16;
            this.HalthPv.Tag = "TextBar";
            this.HalthPv.Text = "Point de vie:";
            // 
            // BatteryInfo
            // 
            this.BatteryInfo.AutoSize = true;
            this.BatteryInfo.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BatteryInfo.ForeColor = System.Drawing.SystemColors.Window;
            this.BatteryInfo.Location = new System.Drawing.Point(13, 60);
            this.BatteryInfo.Name = "BatteryInfo";
            this.BatteryInfo.Size = new System.Drawing.Size(112, 31);
            this.BatteryInfo.TabIndex = 17;
            this.BatteryInfo.Tag = "TextBar";
            this.BatteryInfo.Text = "Énergie:";
            // 
            // ScoreInfo
            // 
            this.ScoreInfo.AutoSize = true;
            this.ScoreInfo.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreInfo.ForeColor = System.Drawing.SystemColors.Window;
            this.ScoreInfo.Location = new System.Drawing.Point(13, 108);
            this.ScoreInfo.Name = "ScoreInfo";
            this.ScoreInfo.Size = new System.Drawing.Size(87, 31);
            this.ScoreInfo.TabIndex = 18;
            this.ScoreInfo.Tag = "TextBar";
            this.ScoreInfo.Text = "Score:";
            // 
            // HealthGet
            // 
            this.HealthGet.Location = new System.Drawing.Point(185, 20);
            this.HealthGet.Name = "HealthGet";
            this.HealthGet.Size = new System.Drawing.Size(294, 23);
            this.HealthGet.TabIndex = 19;
            // 
            // EGet
            // 
            this.EGet.Location = new System.Drawing.Point(131, 68);
            this.EGet.Name = "EGet";
            this.EGet.Size = new System.Drawing.Size(294, 23);
            this.EGet.TabIndex = 20;
            // 
            // clockSpeedValue
            // 
            this.clockSpeedValue.Enabled = true;
            this.clockSpeedValue.Interval = 20;
            this.clockSpeedValue.Tick += new System.EventHandler(this.clockEvent);
            // 
            // Checker
            // 
            this.Checker.Enabled = true;
            this.Checker.Interval = 3000;
            this.Checker.Tick += new System.EventHandler(this.checkerOne);
            // 
            // end_line
            // 
            this.end_line.Image = global::DroneGames.Properties.Resources.finish_line;
            this.end_line.Location = new System.Drawing.Point(1192, 610);
            this.end_line.Name = "end_line";
            this.end_line.Size = new System.Drawing.Size(64, 64);
            this.end_line.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.end_line.TabIndex = 27;
            this.end_line.TabStop = false;
            this.end_line.Tag = "endFlag";
            // 
            // StonePosB
            // 
            this.StonePosB.BackgroundImage = global::DroneGames.Properties.Resources.stone;
            this.StonePosB.Location = new System.Drawing.Point(1101, 60);
            this.StonePosB.Name = "StonePosB";
            this.StonePosB.Size = new System.Drawing.Size(169, 79);
            this.StonePosB.TabIndex = 25;
            this.StonePosB.TabStop = false;
            this.StonePosB.Tag = "Patern";
            // 
            // StonePosA
            // 
            this.StonePosA.BackgroundImage = global::DroneGames.Properties.Resources.stone;
            this.StonePosA.Location = new System.Drawing.Point(12, 237);
            this.StonePosA.Name = "StonePosA";
            this.StonePosA.Size = new System.Drawing.Size(171, 78);
            this.StonePosA.TabIndex = 24;
            this.StonePosA.TabStop = false;
            this.StonePosA.Tag = "Patern";
            // 
            // StonePosZ
            // 
            this.StonePosZ.BackgroundImage = global::DroneGames.Properties.Resources.stone;
            this.StonePosZ.Location = new System.Drawing.Point(719, 217);
            this.StonePosZ.Name = "StonePosZ";
            this.StonePosZ.Size = new System.Drawing.Size(257, 80);
            this.StonePosZ.TabIndex = 23;
            this.StonePosZ.TabStop = false;
            this.StonePosZ.Tag = "Patern";
            // 
            // StonePosY
            // 
            this.StonePosY.BackgroundImage = global::DroneGames.Properties.Resources.stone;
            this.StonePosY.Location = new System.Drawing.Point(799, 526);
            this.StonePosY.Name = "StonePosY";
            this.StonePosY.Size = new System.Drawing.Size(257, 79);
            this.StonePosY.TabIndex = 22;
            this.StonePosY.TabStop = false;
            this.StonePosY.Tag = "Patern";
            // 
            // StonePosX
            // 
            this.StonePosX.BackgroundImage = global::DroneGames.Properties.Resources.stone;
            this.StonePosX.Location = new System.Drawing.Point(93, 392);
            this.StonePosX.Name = "StonePosX";
            this.StonePosX.Size = new System.Drawing.Size(427, 80);
            this.StonePosX.TabIndex = 21;
            this.StonePosX.TabStop = false;
            this.StonePosX.Tag = "Patern";
            // 
            // grass15
            // 
            this.grass15.Image = global::DroneGames.Properties.Resources.grass;
            this.grass15.Location = new System.Drawing.Point(1206, 690);
            this.grass15.Name = "grass15";
            this.grass15.Size = new System.Drawing.Size(64, 64);
            this.grass15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.grass15.TabIndex = 15;
            this.grass15.TabStop = false;
            // 
            // pictureBox14
            // 
            this.pictureBox14.Image = global::DroneGames.Properties.Resources.grass;
            this.pictureBox14.Location = new System.Drawing.Point(1124, 690);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(64, 64);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox14.TabIndex = 14;
            this.pictureBox14.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = global::DroneGames.Properties.Resources.grass;
            this.pictureBox13.Location = new System.Drawing.Point(1044, 690);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(64, 64);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox13.TabIndex = 13;
            this.pictureBox13.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = global::DroneGames.Properties.Resources.grass;
            this.pictureBox12.Location = new System.Drawing.Point(963, 690);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(64, 64);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox12.TabIndex = 12;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::DroneGames.Properties.Resources.grass;
            this.pictureBox11.Location = new System.Drawing.Point(881, 690);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(64, 64);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox11.TabIndex = 11;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::DroneGames.Properties.Resources.grass;
            this.pictureBox10.Location = new System.Drawing.Point(800, 690);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(64, 64);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox10.TabIndex = 10;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::DroneGames.Properties.Resources.grass;
            this.pictureBox9.Location = new System.Drawing.Point(719, 690);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(64, 64);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox9.TabIndex = 9;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::DroneGames.Properties.Resources.grass;
            this.pictureBox8.Location = new System.Drawing.Point(638, 690);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(64, 64);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox8.TabIndex = 8;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::DroneGames.Properties.Resources.grass;
            this.pictureBox7.Location = new System.Drawing.Point(557, 690);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(64, 64);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox7.TabIndex = 7;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::DroneGames.Properties.Resources.grass;
            this.pictureBox6.Location = new System.Drawing.Point(477, 690);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(64, 64);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox6.TabIndex = 6;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::DroneGames.Properties.Resources.grass;
            this.pictureBox5.Location = new System.Drawing.Point(398, 690);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(64, 64);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::DroneGames.Properties.Resources.grass;
            this.pictureBox4.Location = new System.Drawing.Point(318, 690);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(64, 64);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DroneGames.Properties.Resources.grass;
            this.pictureBox3.Location = new System.Drawing.Point(237, 690);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 64);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DroneGames.Properties.Resources.grass;
            this.pictureBox2.Location = new System.Drawing.Point(158, 690);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DroneGames.Properties.Resources.grass;
            this.pictureBox1.Location = new System.Drawing.Point(78, 690);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // grass
            // 
            this.grass.Image = global::DroneGames.Properties.Resources.grass;
            this.grass.Location = new System.Drawing.Point(-1, 690);
            this.grass.Name = "grass";
            this.grass.Size = new System.Drawing.Size(64, 64);
            this.grass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.grass.TabIndex = 0;
            this.grass.TabStop = false;
            // 
            // Mplayer
            // 
            this.Mplayer.Image = global::DroneGames.Properties.Resources.drone;
            this.Mplayer.Location = new System.Drawing.Point(638, 526);
            this.Mplayer.Name = "Mplayer";
            this.Mplayer.Size = new System.Drawing.Size(64, 64);
            this.Mplayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Mplayer.TabIndex = 28;
            this.Mplayer.TabStop = false;
            // 
            // GamesWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1282, 753);
            this.Controls.Add(this.Mplayer);
            this.Controls.Add(this.end_line);
            this.Controls.Add(this.StonePosB);
            this.Controls.Add(this.StonePosA);
            this.Controls.Add(this.StonePosZ);
            this.Controls.Add(this.StonePosY);
            this.Controls.Add(this.StonePosX);
            this.Controls.Add(this.EGet);
            this.Controls.Add(this.HealthGet);
            this.Controls.Add(this.ScoreInfo);
            this.Controls.Add(this.BatteryInfo);
            this.Controls.Add(this.HalthPv);
            this.Controls.Add(this.grass15);
            this.Controls.Add(this.pictureBox14);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GamesWin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DroneGames";
            this.Load += new System.EventHandler(this.Loading);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.isDownKey);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.isUpKey);
            ((System.ComponentModel.ISupportInitialize)(this.end_line)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StonePosB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StonePosA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StonePosZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StonePosY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StonePosX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grass15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mplayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox grass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox grass15;
        private System.Windows.Forms.Label HalthPv;
        private System.Windows.Forms.Label BatteryInfo;
        private System.Windows.Forms.Label ScoreInfo;
        private System.Windows.Forms.ProgressBar HealthGet;
        private System.Windows.Forms.ProgressBar EGet;
        private System.Windows.Forms.PictureBox StonePosX;
        private System.Windows.Forms.PictureBox StonePosY;
        private System.Windows.Forms.PictureBox StonePosZ;
        private System.Windows.Forms.PictureBox StonePosA;
        private System.Windows.Forms.PictureBox StonePosB;
        private System.Windows.Forms.Timer clockSpeedValue;
        private System.Windows.Forms.Timer Checker;
        private System.Windows.Forms.PictureBox end_line;
        private System.Windows.Forms.PictureBox Mplayer;
    }
}

