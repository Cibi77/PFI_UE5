namespace Unterrichtseinheit_5
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ChkGrp1B1 = new System.Windows.Forms.CheckBox();
            this.LblGrp1L1 = new System.Windows.Forms.Label();
            this.ChkGrp1B2 = new System.Windows.Forms.CheckBox();
            this.LblGrp1L2 = new System.Windows.Forms.Label();
            this.ChkGrp1B3 = new System.Windows.Forms.CheckBox();
            this.LblGrp1L3 = new System.Windows.Forms.Label();
            this.RadGrp1B1 = new System.Windows.Forms.RadioButton();
            this.LblGrp2L1 = new System.Windows.Forms.Label();
            this.RadGrp1B2 = new System.Windows.Forms.RadioButton();
            this.LblGrp2L2 = new System.Windows.Forms.Label();
            this.RadGrp1B3 = new System.Windows.Forms.RadioButton();
            this.LblGrp2L3 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TrkValue = new System.Windows.Forms.TrackBar();
            this.LblOutput = new System.Windows.Forms.Label();
            this.CmdRandomValue = new System.Windows.Forms.Button();
            this.TmrRandomValue = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrkValue)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "5. Unterrichtseinheit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(411, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Checkboxen, Radiobutton, Groupbox, Trackbar, RAndom, Timer";
            // 
            // ChkGrp1B1
            // 
            this.ChkGrp1B1.AutoSize = true;
            this.ChkGrp1B1.Location = new System.Drawing.Point(45, 101);
            this.ChkGrp1B1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ChkGrp1B1.Name = "ChkGrp1B1";
            this.ChkGrp1B1.Size = new System.Drawing.Size(63, 17);
            this.ChkGrp1B1.TabIndex = 2;
            this.ChkGrp1B1.Text = "Demo 1";
            this.ChkGrp1B1.UseVisualStyleBackColor = true;
            this.ChkGrp1B1.CheckedChanged += new System.EventHandler(this.ChkGrp1_CheckedChanged);
            // 
            // LblGrp1L1
            // 
            this.LblGrp1L1.AutoSize = true;
            this.LblGrp1L1.Location = new System.Drawing.Point(117, 101);
            this.LblGrp1L1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblGrp1L1.Name = "LblGrp1L1";
            this.LblGrp1L1.Size = new System.Drawing.Size(16, 13);
            this.LblGrp1L1.TabIndex = 3;
            this.LblGrp1L1.Text = "...";
            // 
            // ChkGrp1B2
            // 
            this.ChkGrp1B2.AutoSize = true;
            this.ChkGrp1B2.Location = new System.Drawing.Point(47, 128);
            this.ChkGrp1B2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ChkGrp1B2.Name = "ChkGrp1B2";
            this.ChkGrp1B2.Size = new System.Drawing.Size(63, 17);
            this.ChkGrp1B2.TabIndex = 2;
            this.ChkGrp1B2.Text = "Demo 2";
            this.ChkGrp1B2.UseVisualStyleBackColor = true;
            this.ChkGrp1B2.CheckedChanged += new System.EventHandler(this.ChkGrp1_CheckedChanged);
            // 
            // LblGrp1L2
            // 
            this.LblGrp1L2.AutoSize = true;
            this.LblGrp1L2.Location = new System.Drawing.Point(118, 128);
            this.LblGrp1L2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblGrp1L2.Name = "LblGrp1L2";
            this.LblGrp1L2.Size = new System.Drawing.Size(16, 13);
            this.LblGrp1L2.TabIndex = 3;
            this.LblGrp1L2.Text = "...";
            // 
            // ChkGrp1B3
            // 
            this.ChkGrp1B3.AutoSize = true;
            this.ChkGrp1B3.Location = new System.Drawing.Point(47, 154);
            this.ChkGrp1B3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ChkGrp1B3.Name = "ChkGrp1B3";
            this.ChkGrp1B3.Size = new System.Drawing.Size(63, 17);
            this.ChkGrp1B3.TabIndex = 2;
            this.ChkGrp1B3.Text = "Demo 3";
            this.ChkGrp1B3.UseVisualStyleBackColor = true;
            this.ChkGrp1B3.CheckedChanged += new System.EventHandler(this.ChkGrp1_CheckedChanged);
            // 
            // LblGrp1L3
            // 
            this.LblGrp1L3.AutoSize = true;
            this.LblGrp1L3.Location = new System.Drawing.Point(118, 154);
            this.LblGrp1L3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblGrp1L3.Name = "LblGrp1L3";
            this.LblGrp1L3.Size = new System.Drawing.Size(16, 13);
            this.LblGrp1L3.TabIndex = 3;
            this.LblGrp1L3.Text = "...";
            // 
            // RadGrp1B1
            // 
            this.RadGrp1B1.AutoSize = true;
            this.RadGrp1B1.Location = new System.Drawing.Point(30, 16);
            this.RadGrp1B1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RadGrp1B1.Name = "RadGrp1B1";
            this.RadGrp1B1.Size = new System.Drawing.Size(68, 17);
            this.RadGrp1B1.TabIndex = 4;
            this.RadGrp1B1.TabStop = true;
            this.RadGrp1B1.Text = "Männlich";
            this.RadGrp1B1.UseVisualStyleBackColor = true;
            this.RadGrp1B1.CheckedChanged += new System.EventHandler(this.RadGrp1_CheckedChanged);
            // 
            // LblGrp2L1
            // 
            this.LblGrp2L1.AutoSize = true;
            this.LblGrp2L1.Location = new System.Drawing.Point(99, 16);
            this.LblGrp2L1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblGrp2L1.Name = "LblGrp2L1";
            this.LblGrp2L1.Size = new System.Drawing.Size(16, 13);
            this.LblGrp2L1.TabIndex = 5;
            this.LblGrp2L1.Text = "...";
            // 
            // RadGrp1B2
            // 
            this.RadGrp1B2.AutoSize = true;
            this.RadGrp1B2.Location = new System.Drawing.Point(30, 41);
            this.RadGrp1B2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RadGrp1B2.Name = "RadGrp1B2";
            this.RadGrp1B2.Size = new System.Drawing.Size(66, 17);
            this.RadGrp1B2.TabIndex = 4;
            this.RadGrp1B2.TabStop = true;
            this.RadGrp1B2.Text = "Weiblich";
            this.RadGrp1B2.UseVisualStyleBackColor = true;
            this.RadGrp1B2.CheckedChanged += new System.EventHandler(this.RadGrp1_CheckedChanged);
            // 
            // LblGrp2L2
            // 
            this.LblGrp2L2.AutoSize = true;
            this.LblGrp2L2.Location = new System.Drawing.Point(99, 41);
            this.LblGrp2L2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblGrp2L2.Name = "LblGrp2L2";
            this.LblGrp2L2.Size = new System.Drawing.Size(16, 13);
            this.LblGrp2L2.TabIndex = 5;
            this.LblGrp2L2.Text = "...";
            // 
            // RadGrp1B3
            // 
            this.RadGrp1B3.AutoSize = true;
            this.RadGrp1B3.Location = new System.Drawing.Point(30, 67);
            this.RadGrp1B3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RadGrp1B3.Name = "RadGrp1B3";
            this.RadGrp1B3.Size = new System.Drawing.Size(55, 17);
            this.RadGrp1B3.TabIndex = 4;
            this.RadGrp1B3.TabStop = true;
            this.RadGrp1B3.Text = "Divers";
            this.RadGrp1B3.UseVisualStyleBackColor = true;
            this.RadGrp1B3.CheckedChanged += new System.EventHandler(this.RadGrp1_CheckedChanged);
            // 
            // LblGrp2L3
            // 
            this.LblGrp2L3.AutoSize = true;
            this.LblGrp2L3.Location = new System.Drawing.Point(99, 67);
            this.LblGrp2L3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblGrp2L3.Name = "LblGrp2L3";
            this.LblGrp2L3.Size = new System.Drawing.Size(16, 13);
            this.LblGrp2L3.TabIndex = 5;
            this.LblGrp2L3.Text = "...";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(332, 101);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(66, 17);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Option A";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.RadGrp1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(332, 128);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(66, 17);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Option B";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.RadGrp1_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(332, 151);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(66, 17);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Option C";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.RadGrp1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RadGrp1B1);
            this.groupBox1.Controls.Add(this.LblGrp2L3);
            this.groupBox1.Controls.Add(this.RadGrp1B2);
            this.groupBox1.Controls.Add(this.LblGrp2L2);
            this.groupBox1.Controls.Add(this.RadGrp1B3);
            this.groupBox1.Controls.Add(this.LblGrp2L1);
            this.groupBox1.Location = new System.Drawing.Point(147, 86);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(173, 105);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Geschlecht";
            // 
            // TrkValue
            // 
            this.TrkValue.LargeChange = 10;
            this.TrkValue.Location = new System.Drawing.Point(47, 222);
            this.TrkValue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TrkValue.Maximum = 100;
            this.TrkValue.Minimum = 1;
            this.TrkValue.Name = "TrkValue";
            this.TrkValue.Size = new System.Drawing.Size(306, 45);
            this.TrkValue.TabIndex = 7;
            this.TrkValue.TickFrequency = 20;
            this.TrkValue.Value = 5;
            this.TrkValue.Scroll += new System.EventHandler(this.TrkValue_Scroll);
            // 
            // LblOutput
            // 
            this.LblOutput.AutoSize = true;
            this.LblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOutput.Location = new System.Drawing.Point(361, 222);
            this.LblOutput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblOutput.Name = "LblOutput";
            this.LblOutput.Size = new System.Drawing.Size(21, 20);
            this.LblOutput.TabIndex = 8;
            this.LblOutput.Text = "...";
            // 
            // CmdRandomValue
            // 
            this.CmdRandomValue.Location = new System.Drawing.Point(478, 222);
            this.CmdRandomValue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CmdRandomValue.Name = "CmdRandomValue";
            this.CmdRandomValue.Size = new System.Drawing.Size(87, 38);
            this.CmdRandomValue.TabIndex = 9;
            this.CmdRandomValue.Text = "Start";
            this.CmdRandomValue.UseVisualStyleBackColor = true;
            this.CmdRandomValue.Click += new System.EventHandler(this.CmdRandomValue_Click);
            // 
            // TmrRandomValue
            // 
            this.TmrRandomValue.Interval = 1000;
            this.TmrRandomValue.Tick += new System.EventHandler(this.TmrRandomValue_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 331);
            this.Controls.Add(this.CmdRandomValue);
            this.Controls.Add(this.LblOutput);
            this.Controls.Add(this.TrkValue);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.LblGrp1L3);
            this.Controls.Add(this.LblGrp1L2);
            this.Controls.Add(this.LblGrp1L1);
            this.Controls.Add(this.ChkGrp1B3);
            this.Controls.Add(this.ChkGrp1B2);
            this.Controls.Add(this.ChkGrp1B1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrkValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ChkGrp1B1;
        private System.Windows.Forms.Label LblGrp1L1;
        private System.Windows.Forms.CheckBox ChkGrp1B2;
        private System.Windows.Forms.Label LblGrp1L2;
        private System.Windows.Forms.CheckBox ChkGrp1B3;
        private System.Windows.Forms.Label LblGrp1L3;
        private System.Windows.Forms.RadioButton RadGrp1B1;
        private System.Windows.Forms.Label LblGrp2L1;
        private System.Windows.Forms.RadioButton RadGrp1B2;
        private System.Windows.Forms.Label LblGrp2L2;
        private System.Windows.Forms.RadioButton RadGrp1B3;
        private System.Windows.Forms.Label LblGrp2L3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar TrkValue;
        private System.Windows.Forms.Label LblOutput;
        private System.Windows.Forms.Button CmdRandomValue;
        private System.Windows.Forms.Timer TmrRandomValue;
    }
}

