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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.LblLives.BackColor = System.Drawing.Color.Transparent;
            this.LblLives.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLives.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.LblLives.Location = new System.Drawing.Point(12, 31);
            this.LblLives.Name = "LblLives";
            this.LblLives.Size = new System.Drawing.Size(87, 29);
            this.LblLives.TabIndex = 0;
            this.LblLives.Text = "Leben:";
            // 
            // LblPoints
            // 
            this.LblPoints.AutoSize = true;
            this.LblPoints.BackColor = System.Drawing.Color.Transparent;
            this.LblPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPoints.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.LblPoints.Location = new System.Drawing.Point(139, 31);
            this.LblPoints.Name = "LblPoints";
            this.LblPoints.Size = new System.Drawing.Size(93, 29);
            this.LblPoints.TabIndex = 0;
            this.LblPoints.Text = "Punkte:";
            // 
            // LblGoal
            // 
            this.LblGoal.AutoSize = true;
            this.LblGoal.BackColor = System.Drawing.Color.Transparent;
            this.LblGoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGoal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.LblGoal.Location = new System.Drawing.Point(300, 31);
            this.LblGoal.Name = "LblGoal";
            this.LblGoal.Size = new System.Drawing.Size(59, 29);
            this.LblGoal.TabIndex = 0;
            this.LblGoal.Text = "Ziel:";
            // 
            // TrkHandle
            // 
            this.TrkHandle.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TrkHandle.Location = new System.Drawing.Point(712, 106);
            this.TrkHandle.Name = "TrkHandle";
            this.TrkHandle.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.TrkHandle.Size = new System.Drawing.Size(69, 400);
            this.TrkHandle.TabIndex = 1;
            this.TrkHandle.Scroll += new System.EventHandler(this.TrkHandle_Scroll);
            // 
            // TxtShield
            // 
            this.TxtShield.BackColor = System.Drawing.Color.Green;
            this.TxtShield.Location = new System.Drawing.Point(663, 409);
            this.TxtShield.Multiline = true;
            this.TxtShield.Name = "TxtShield";
            this.TxtShield.Size = new System.Drawing.Size(20, 119);
            this.TxtShield.TabIndex = 2;
            // 
            // TxtBall
            // 
            this.TxtBall.BackColor = System.Drawing.Color.Maroon;
            this.TxtBall.Location = new System.Drawing.Point(36, 163);
            this.TxtBall.Name = "TxtBall";
            this.TxtBall.Size = new System.Drawing.Size(20, 26);
            this.TxtBall.TabIndex = 3;
            // 
            // TmrVelocity
            // 
            this.TmrVelocity.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PnBorder
            // 
            this.PnBorder.BackColor = System.Drawing.Color.Transparent;
            this.PnBorder.Location = new System.Drawing.Point(746, 59);
            this.PnBorder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PnBorder.Name = "PnBorder";
            this.PnBorder.Size = new System.Drawing.Size(35, 494);
            this.PnBorder.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(755, 588);
            this.Controls.Add(this.TxtBall);
            this.Controls.Add(this.TxtShield);
            this.Controls.Add(this.LblGoal);
            this.Controls.Add(this.LblPoints);
            this.Controls.Add(this.LblLives);
            this.Controls.Add(this.PnBorder);
            this.Controls.Add(this.TrkHandle);
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

