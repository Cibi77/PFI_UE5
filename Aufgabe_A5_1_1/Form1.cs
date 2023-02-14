using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aufgabe_A5_1_1
{
    public partial class Form1 : Form
    {
        int valueBlue = 0;
        int valueGreen = 0;
        int valueRed = 0;
        string hexRed = "";
        string hexGreen = "";
        string hexBlue = "";


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PnlOut.BackColor = Color.FromArgb(valueRed, valueGreen, valueBlue);
            switch (RadHex.Checked)
            {
                case true:
                    hexRed = Convert.ToString(valueRed, 16);
                    hexGreen = Convert.ToString(valueGreen, 16);
                    hexBlue = Convert.ToString(valueBlue, 16);
                    LblHexDez.Text = "# " + hexRed + hexGreen + hexBlue;
                    break;
                case false:
                    LblHexDez.Text = "Rot: " + Convert.ToString(valueRed) + " Grün: " + Convert.ToString(valueGreen) + " Blau: " + Convert.ToString(valueBlue);
                    break;
            }
        }

        private void Trk_Scroll(object sender, EventArgs e)
        {
            valueRed = TrkRed.Value;
            valueGreen = TrkGreen.Value;
            valueBlue = TrkBlue.Value;

            if (!ChkRed.Checked)
            {
                valueRed = 0;
            }
            if (!ChkGreen.Checked)
            {
                valueGreen = 0;
            }
            if (!ChkBlue.Checked)
            {
                valueBlue = 0;
            }

            switch (RadHex.Checked)
            {
                case true:
                    hexRed = Convert.ToString(valueRed, 16);
                    hexGreen = Convert.ToString(valueGreen, 16);
                    hexBlue = Convert.ToString(valueBlue, 16);
                    LblHexDez.Text = "# " + hexRed + hexGreen + hexBlue;
                    break;
                case false:
                    LblHexDez.Text = "Rot: " + Convert.ToString(valueRed) + " Grün: " + Convert.ToString(valueGreen) + " Blau: " + Convert.ToString(valueBlue);
                    break;
            }

            PnlOut.BackColor = Color.FromArgb(valueRed, valueGreen, valueBlue);
        }

        private void Chk_CheckedChanged(object sender, EventArgs e)
        {
            valueRed = TrkRed.Value;
            valueGreen = TrkGreen.Value;
            valueBlue = TrkBlue.Value;

            if (!ChkRed.Checked)
            {
                valueRed = 0;
            }
            if (!ChkGreen.Checked)
            {
                valueGreen = 0;
            }
            if (!ChkBlue.Checked)
            {
                valueBlue = 0;
            }

            switch (RadHex.Checked)
            {
                case true:
                    hexRed = Convert.ToString(valueRed, 16);
                    hexGreen = Convert.ToString(valueGreen, 16);
                    hexBlue = Convert.ToString(valueBlue, 16);
                    LblHexDez.Text = "# " + hexRed + hexGreen + hexBlue;
                    break;
                case false:
                    LblHexDez.Text = "Rot: " + Convert.ToString(valueRed) + " Grün: " + Convert.ToString(valueGreen) + " Blau: " + Convert.ToString(valueBlue);
                    break;
            }

            PnlOut.BackColor = Color.FromArgb(valueRed, valueGreen, valueBlue);
        }
    }
}
