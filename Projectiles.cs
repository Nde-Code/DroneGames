using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;

namespace DroneGames
{
    public class Projectiles
    {
        public int projLeft { get; set; }
        public int projHight { get; set; }

        public int projJoule = 20;

        private PictureBox projBall = new PictureBox();
        private Timer clockRegulator = new Timer();

        public void launch(Form form)
        {
            projBall.BackColor = Color.Blue;
            projBall.Size = new Size(5, 10);
            projBall.Tag = "projBall";
            projBall.Name = "launching";
            projBall.Left = projLeft;// Position d'invoquation en x
            projBall.Top = projHight;// Position d'invoquation en y
            projBall.BringToFront();

            form.Controls.Add(projBall); 
            clockRegulator.Interval = projJoule;
            clockRegulator.Tick += new EventHandler(launchTimer);
            clockRegulator.Start();
        }
        private void launchTimer(object sender, EventArgs e)
        {
            // faire deplacer le projectile
            projBall.Top += projJoule;

            if (projBall.Top < 10 || projBall.Top > 800)
            {
                clockRegulator.Stop();
                clockRegulator.Dispose();
                projBall.Dispose();
                clockRegulator = null;
                projBall = null;
            }
        }
    }
}
