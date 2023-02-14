namespace Aufgabe_A5_1_1
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
            this.TrkRed = new System.Windows.Forms.TrackBar();
            this.LblRed = new System.Windows.Forms.Label();
            this.ChkRed = new System.Windows.Forms.CheckBox();
            this.TrkGreen = new System.Windows.Forms.TrackBar();
            this.LblGreen = new System.Windows.Forms.Label();
            this.ChkGreen = new System.Windows.Forms.CheckBox();
            this.TrkBlue = new System.Windows.Forms.TrackBar();
            this.LblBlue = new System.Windows.Forms.Label();
            this.ChkBlue = new System.Windows.Forms.CheckBox();
            this.PnlOut = new System.Windows.Forms.Panel();
            this.PnlGrp1 = new System.Windows.Forms.Panel();
            this.RadHex = new System.Windows.Forms.RadioButton();
            this.RadDez = new System.Windows.Forms.RadioButton();
            this.LblHexDez = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TrkRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrkGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrkBlue)).BeginInit();
            this.PnlGrp1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TrkRed
            // 
            this.TrkRed.Location = new System.Drawing.Point(121, 68);
            this.TrkRed.Maximum = 255;
            this.TrkRed.Name = "TrkRed";
            this.TrkRed.Size = new System.Drawing.Size(466, 69);
            this.TrkRed.TabIndex = 0;
            this.TrkRed.TickStyle = System.Windows.Forms.TickStyle.None;
            this.TrkRed.Scroll += new System.EventHandler(this.Trk_Scroll);
            // 
            // LblRed
            // 
            this.LblRed.AutoSize = true;
            this.LblRed.Location = new System.Drawing.Point(13, 68);
            this.LblRed.Name = "LblRed";
            this.LblRed.Size = new System.Drawing.Size(39, 20);
            this.LblRed.TabIndex = 1;
            this.LblRed.Text = "Rot:";
            // 
            // ChkRed
            // 
            this.ChkRed.AutoSize = true;
            this.ChkRed.Checked = true;
            this.ChkRed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkRed.Location = new System.Drawing.Point(630, 68);
            this.ChkRed.Name = "ChkRed";
            this.ChkRed.Size = new System.Drawing.Size(22, 21);
            this.ChkRed.TabIndex = 2;
            this.ChkRed.UseVisualStyleBackColor = true;
            this.ChkRed.CheckedChanged += new System.EventHandler(this.Chk_CheckedChanged);
            // 
            // TrkGreen
            // 
            this.TrkGreen.Location = new System.Drawing.Point(121, 143);
            this.TrkGreen.Maximum = 255;
            this.TrkGreen.Name = "TrkGreen";
            this.TrkGreen.Size = new System.Drawing.Size(466, 69);
            this.TrkGreen.TabIndex = 0;
            this.TrkGreen.TickStyle = System.Windows.Forms.TickStyle.None;
            this.TrkGreen.Scroll += new System.EventHandler(this.Trk_Scroll);
            // 
            // LblGreen
            // 
            this.LblGreen.AutoSize = true;
            this.LblGreen.Location = new System.Drawing.Point(13, 143);
            this.LblGreen.Name = "LblGreen";
            this.LblGreen.Size = new System.Drawing.Size(45, 20);
            this.LblGreen.TabIndex = 1;
            this.LblGreen.Text = "Grün";
            // 
            // ChkGreen
            // 
            this.ChkGreen.AutoSize = true;
            this.ChkGreen.Checked = true;
            this.ChkGreen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkGreen.Location = new System.Drawing.Point(630, 143);
            this.ChkGreen.Name = "ChkGreen";
            this.ChkGreen.Size = new System.Drawing.Size(22, 21);
            this.ChkGreen.TabIndex = 2;
            this.ChkGreen.UseVisualStyleBackColor = true;
            this.ChkGreen.CheckedChanged += new System.EventHandler(this.Chk_CheckedChanged);
            // 
            // TrkBlue
            // 
            this.TrkBlue.Location = new System.Drawing.Point(121, 218);
            this.TrkBlue.Maximum = 255;
            this.TrkBlue.Name = "TrkBlue";
            this.TrkBlue.Size = new System.Drawing.Size(466, 69);
            this.TrkBlue.TabIndex = 0;
            this.TrkBlue.TickStyle = System.Windows.Forms.TickStyle.None;
            this.TrkBlue.Scroll += new System.EventHandler(this.Trk_Scroll);
            // 
            // LblBlue
            // 
            this.LblBlue.AutoSize = true;
            this.LblBlue.Location = new System.Drawing.Point(13, 218);
            this.LblBlue.Name = "LblBlue";
            this.LblBlue.Size = new System.Drawing.Size(49, 20);
            this.LblBlue.TabIndex = 1;
            this.LblBlue.Text = "Blau: ";
            // 
            // ChkBlue
            // 
            this.ChkBlue.AutoSize = true;
            this.ChkBlue.Checked = true;
            this.ChkBlue.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkBlue.Location = new System.Drawing.Point(630, 218);
            this.ChkBlue.Name = "ChkBlue";
            this.ChkBlue.Size = new System.Drawing.Size(22, 21);
            this.ChkBlue.TabIndex = 2;
            this.ChkBlue.UseVisualStyleBackColor = true;
            this.ChkBlue.CheckedChanged += new System.EventHandler(this.Chk_CheckedChanged);
            // 
            // PnlOut
            // 
            this.PnlOut.Location = new System.Drawing.Point(131, 273);
            this.PnlOut.Name = "PnlOut";
            this.PnlOut.Size = new System.Drawing.Size(456, 96);
            this.PnlOut.TabIndex = 3;
            // 
            // PnlGrp1
            // 
            this.PnlGrp1.Controls.Add(this.RadDez);
            this.PnlGrp1.Controls.Add(this.RadHex);
            this.PnlGrp1.Location = new System.Drawing.Point(131, 400);
            this.PnlGrp1.Name = "PnlGrp1";
            this.PnlGrp1.Size = new System.Drawing.Size(456, 38);
            this.PnlGrp1.TabIndex = 4;
            // 
            // RadHex
            // 
            this.RadHex.AutoSize = true;
            this.RadHex.Checked = true;
            this.RadHex.Location = new System.Drawing.Point(14, 11);
            this.RadHex.Name = "RadHex";
            this.RadHex.Size = new System.Drawing.Size(125, 24);
            this.RadHex.TabIndex = 0;
            this.RadHex.TabStop = true;
            this.RadHex.Text = "Hexadezimal";
            this.RadHex.UseVisualStyleBackColor = true;
            // 
            // RadDez
            // 
            this.RadDez.AutoSize = true;
            this.RadDez.Location = new System.Drawing.Point(178, 11);
            this.RadDez.Name = "RadDez";
            this.RadDez.Size = new System.Drawing.Size(91, 24);
            this.RadDez.TabIndex = 0;
            this.RadDez.Text = "Dezimal";
            this.RadDez.UseVisualStyleBackColor = true;
            // 
            // LblHexDez
            // 
            this.LblHexDez.AutoSize = true;
            this.LblHexDez.Location = new System.Drawing.Point(131, 374);
            this.LblHexDez.Name = "LblHexDez";
            this.LblHexDez.Size = new System.Drawing.Size(18, 20);
            this.LblHexDez.TabIndex = 5;
            this.LblHexDez.Text = "#";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblHexDez);
            this.Controls.Add(this.PnlGrp1);
            this.Controls.Add(this.PnlOut);
            this.Controls.Add(this.ChkBlue);
            this.Controls.Add(this.ChkGreen);
            this.Controls.Add(this.ChkRed);
            this.Controls.Add(this.LblBlue);
            this.Controls.Add(this.LblGreen);
            this.Controls.Add(this.LblRed);
            this.Controls.Add(this.TrkBlue);
            this.Controls.Add(this.TrkGreen);
            this.Controls.Add(this.TrkRed);
            this.Name = "Form1";
            this.Text = "Aufgabe_A5_1_1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TrkRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrkGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrkBlue)).EndInit();
            this.PnlGrp1.ResumeLayout(false);
            this.PnlGrp1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar TrkRed;
        private System.Windows.Forms.Label LblRed;
        private System.Windows.Forms.CheckBox ChkRed;
        private System.Windows.Forms.TrackBar TrkGreen;
        private System.Windows.Forms.Label LblGreen;
        private System.Windows.Forms.CheckBox ChkGreen;
        private System.Windows.Forms.TrackBar TrkBlue;
        private System.Windows.Forms.Label LblBlue;
        private System.Windows.Forms.CheckBox ChkBlue;
        private System.Windows.Forms.Panel PnlOut;
        private System.Windows.Forms.Panel PnlGrp1;
        private System.Windows.Forms.RadioButton RadDez;
        private System.Windows.Forms.RadioButton RadHex;
        private System.Windows.Forms.Label LblHexDez;
    }
}

