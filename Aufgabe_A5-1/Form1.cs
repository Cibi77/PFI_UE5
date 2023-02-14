using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace Aufgabe_A5_1
{
    public partial class Form1 : Form
    {
        int lives = 5;
        int points = 0;
        int goal = 0;
        int stepSize = 22;
        int position_shield = 0;
        int position_ball_x = 0;
        int position_ball_y = 0;
        int velocity = 5;

        public Form1()
        {
            InitializeComponent();
        }

        private void ResetBall()
        {
            Random randomValue = new Random();

            // Ballgeschwindigkeit zufällig definieren
            TmrVelocity.Interval = randomValue.Next(1, 20);

            // Ballposition zufällig definieren
            TxtBall.Location = new Point(position_ball_x, (position_ball_y + randomValue.Next(0, 201)));
        }

        private void TrkHandle_Scroll(object sender, EventArgs e)
        {
            TxtShield.Location = new Point(440, (position_shield - (TrkHandle.Value*stepSize)));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Ziel definieren
            Random randomValue = new Random();
            goal = randomValue.Next(500, 2001);
            LblGoal.Text = "Ziel: " + Convert.ToString(goal);

            // Startposition Schild bestimmen
            position_shield = TxtShield.Location.Y;

            // Leben ausgeben
            LblLives.Text = "Leben: "+ Convert.ToString(lives);

            // Ball Urprungsposition bestimmen
            position_ball_x = TxtBall.Location.X;
            position_ball_y = TxtBall.Location.Y; 

            ResetBall();

            // Starten
            TmrVelocity.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TxtBall.Location = new Point(TxtBall.Location.X + velocity, TxtBall.Location.Y);
            if (TxtBall.Bounds.IntersectsWith(TxtShield.Bounds))
            {
                // Ball gefangen
                points += 100;
                LblPoints.Text = "Punkte: " + Convert.ToString(points);
                ResetBall();

                if (points >= goal)
                {
                    TmrVelocity.Enabled = false;
                    MessageBox.Show(this, "     GEWONNEN!\r\n \r\nPunkteziel erreicht.");
                }
            }
            else if (TxtBall.Bounds.IntersectsWith(PnBorder.Bounds))
            {
                // Ball verpasst
                points -= 150;
                LblPoints.Text = "Punkte: " + Convert.ToString(points);
                lives -= 1;
                LblLives.Text = "Leben: " + Convert.ToString(lives);
                ResetBall();

                if (lives <= 0)
                {
                    // Verloren
                    TmrVelocity.Enabled = false;
                    MessageBox.Show(this, "      VERLOREN!\r\n  \r\nAlle Leben aufgebraucht");

                }
                
            }
            
        }
    }
}
