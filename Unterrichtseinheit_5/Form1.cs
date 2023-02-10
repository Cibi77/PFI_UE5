using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unterrichtseinheit_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LblGrp1L1.Text = ChkGrp1B1.Checked ? "aktiv" : "inaktiv";
            LblGrp1L2.Text = ChkGrp1B2.Checked ? "aktiv" : "inaktiv";
            LblGrp1L3.Text = ChkGrp1B3.Checked ? "aktiv" : "inaktiv";
        }

       
        private void RadGrp1_CheckedChanged(object sender, EventArgs e)
        {
            LblGrp2L1.Text = RadGrp1B1.Checked ? "aktiv" : "inaktiv";
            LblGrp2L2.Text = RadGrp1B2.Checked ? "aktiv" : "inaktiv";
            LblGrp2L3.Text = RadGrp1B3.Checked ? "aktiv" : "inaktiv";
        }

        private void TrkValue_Scroll(object sender, EventArgs e)
        {
            LblOutput.Text = Convert.ToString(TrkValue.Value);
        }

        private void CmdRandomValue_Click(object sender, EventArgs e)
        {
            /*      if (TmrRandomValue.Enabled)
                  {
                      TmrRandomValue.Stop();
                      CmdRandomValue.Text = "Start";
                  }
                  else
                  {
                      TmrRandomValue.Start();
                      CmdRandomValue.Text = "Stop";
                  }
            */

            // Kurzschreibweise von oben:
            CmdRandomValue.Text = TmrRandomValue.Enabled ? "Start" : "Stop";

            TmrRandomValue.Enabled =  !(TmrRandomValue.Enabled);
        }

        private void TmrRandomValue_Tick(object sender, EventArgs e)
        {
            Random randomValue = new Random();
            int random = randomValue.Next(0, 101); //oben exkludiert, unten inkludiert

            LblOutput.Text = random.ToString();
            TrkValue.Value = random;
        }

        private void ChkGrp1_CheckedChanged(object sender, EventArgs e)
        {
            LblGrp1L1.Text = ChkGrp1B1.Checked ? "aktiv" : "inaktiv";
            LblGrp1L2.Text = ChkGrp1B2.Checked ? "aktiv" : "inaktiv";
            LblGrp1L3.Text = ChkGrp1B3.Checked ? "aktiv" : "inaktiv";
        }
    }
}
