namespace Aufgabe_A5_1
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LblLives = new System.Windows.Forms.Label();
            this.LblPoints = new System.Windows.Forms.Label();
            this.LblGoal = new System.Windows.Forms.Label();
            this.TrkHandle = new System.Windows.Forms.TrackBar();
            this.TxtShield = new System.Windows.Forms.TextBox();
            this.TxtBall = new System.Windows.Forms.TextBox();
            this.TmrVelocity = new System.Windows.Forms.Timer(this.components);
            this.PnBorder = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.TrkHandle)).BeginInit();
            this.SuspendLayout();
            // 
            // LblLives
            // 
            this.LblLives.AutoSize = true;
            this.LblLives.Location = new System.Drawing.Point(21, 20);
            this.LblLives.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblLives.Name = "LblLives";
            this.LblLives.Size = new System.Drawing.Size(40, 13);
            this.LblLives.TabIndex = 0;
            this.LblLives.Text = "Leben:";
            // 
            // LblPoints
            // 
            this.LblPoints.AutoSize = true;
            this.LblPoints.Location = new System.Drawing.Point(104, 20);
            this.LblPoints.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblPoints.Name = "LblPoints";
            this.LblPoints.Size = new System.Drawing.Size(44, 13);
            this.LblPoints.TabIndex = 0;
            this.LblPoints.Text = "Punkte:";
            // 
            // LblGoal
            // 
            this.LblGoal.AutoSize = true;
            this.LblGoal.Location = new System.Drawing.Point(209, 20);
            this.LblGoal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblGoal.Name = "LblGoal";
            this.LblGoal.Size = new System.Drawing.Size(27, 13);
            this.LblGoal.TabIndex = 0;
            this.LblGoal.Text = "Ziel:";
            // 
            // TrkHandle
            // 
            this.TrkHandle.Location = new System.Drawing.Point(379, 49);
            this.TrkHandle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TrkHandle.Name = "TrkHandle";
            this.TrkHandle.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.TrkHandle.Size = new System.Drawing.Size(45, 260);
            this.TrkHandle.TabIndex = 1;
            this.TrkHandle.Scroll += new System.EventHandler(this.TrkHandle_Scroll);
            // 
            // TxtShield
            // 
            this.TxtShield.BackColor = System.Drawing.Color.Green;
            this.TxtShield.Location = new System.Drawing.Point(351, 253);
            this.TxtShield.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtShield.Multiline = true;
            this.TxtShield.Name = "TxtShield";
            this.TxtShield.Size = new System.Drawing.Size(15, 79);
            this.TxtShield.TabIndex = 2;
            // 
            // TxtBall
            // 
            this.TxtBall.BackColor = System.Drawing.Color.Maroon;
            this.TxtBall.Location = new System.Drawing.Point(24, 106);
            this.TxtBall.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtBall.Name = "TxtBall";
            this.TxtBall.Size = new System.Drawing.Size(15, 20);
            this.TxtBall.TabIndex = 3;
            // 
            // TmrVelocity
            // 
            this.TmrVelocity.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PnBorder
            // 
            this.PnBorder.Location = new System.Drawing.Point(429, 49);
            this.PnBorder.Name = "PnBorder";
            this.PnBorder.Size = new System.Drawing.Size(18, 321);
            this.PnBorder.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(509, 382);
            this.Controls.Add(this.TxtBall);
            this.Controls.Add(this.TxtShield);
            this.Controls.Add(this.TrkHandle);
            this.Controls.Add(this.LblGoal);
            this.Controls.Add(this.LblPoints);
            this.Controls.Add(this.LblLives);
            this.Controls.Add(this.PnBorder);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Aufgabe_A5-1-3_Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TrkHandle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblLives;
        private System.Windows.Forms.Label LblPoints;
        private System.Windows.Forms.Label LblGoal;
        private System.Windows.Forms.TrackBar TrkHandle;
        private System.Windows.Forms.TextBox TxtShield;
        private System.Windows.Forms.TextBox TxtBall;
        private System.Windows.Forms.Timer TmrVelocity;
        private System.Windows.Forms.Panel PnBorder;
    }
}

