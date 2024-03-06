using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        SoundPlayer player = new SoundPlayer(WindowsFormsApp1.Properties.Resources.moan);

        private void PlaySound(System.IO.Stream soundFileName)
        {
            try
            {
                // Create a SoundPlayer instance with the path to the sound file
                SoundPlayer soundPlayer = new SoundPlayer(soundFileName);

                // Play the sound
                soundPlayer.Play();
            }
            catch (Exception ex)
            {
                // Handle exceptions, e.g., file not found
                MessageBox.Show($"Error playing sound: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        String temp1 = "";
        String temp2 = "";
        enum Calc { None, Addition, Subtraction, Multiplication, Division }
        Calc calc = Calc.None;
        public Form1()
        {
            InitializeComponent();
        }

        private void UpdateDisplay()
        {
            if (calc == Calc.None)
                textBox1.Text = temp1;
            else
                textBox1.Text = temp2;
        }

        private void b1_Click(object sender, EventArgs e)
        {
            PlaySound(WindowsFormsApp1.Properties.Resources.ugh);

            if (calc == Calc.None)
                temp1 += "1";
            else 
                temp2 += "1";
            UpdateDisplay();
        }

        private void b2_Click(object sender, EventArgs e)
        {
            PlaySound(WindowsFormsApp1.Properties.Resources.oui);

            if (calc == Calc.None)
                temp1 += "2";
            else
                temp2 += "2";
            UpdateDisplay();
        }

        private void b3_Click(object sender, EventArgs e)
        {
            PlaySound(WindowsFormsApp1.Properties.Resources.sogood);

            if (calc == Calc.None)
                temp1 += "3";
            else
                temp2 += "3";
            UpdateDisplay();
        }

        private void b4_Click(object sender, EventArgs e)
        {
            player.Play();
            if (calc == Calc.None)
                temp1 += "4";
            else
                temp2 += "4";
            UpdateDisplay();
        }

        private void b5_Click(object sender, EventArgs e)
        {
            PlaySound(WindowsFormsApp1.Properties.Resources.gulp);

            if (calc == Calc.None)
                temp1 += "5";
            else
                temp2 += "5";
            UpdateDisplay();
        }

        private void b6_Click(object sender, EventArgs e)
        {
            PlaySound(WindowsFormsApp1.Properties.Resources.poosay);

            if (calc == Calc.None)
                temp1 += "6";
            else
                temp2 += "6";
            UpdateDisplay();
        }

        private void b7_Click(object sender, EventArgs e)
        {
            PlaySound(WindowsFormsApp1.Properties.Resources.poosay);
            if (calc == Calc.None)
                temp1 += "7";
            else
                temp2 += "7";
            UpdateDisplay();
        }

        private void b8_Click(object sender, EventArgs e)
        {
            PlaySound(WindowsFormsApp1.Properties.Resources.cum);
            if (calc == Calc.None)
                temp1 += "8";
            else
                temp2 += "8";
            UpdateDisplay();
        }

        private void b9_Click(object sender, EventArgs e)
        {
            PlaySound(WindowsFormsApp1.Properties.Resources.sogood);
            if (calc == Calc.None)
                temp1 += "9";
            else
                temp2 += "9";
            UpdateDisplay();
        }

        private void b0_Click(object sender, EventArgs e)
        {
            PlaySound(WindowsFormsApp1.Properties.Resources.gulp);
            if (calc == Calc.None)
                temp1 += "0";
            else
                temp2 += "0";
            UpdateDisplay();
        }

        private void bD_Click(object sender, EventArgs e)
        {
            player.Play();
            calc = Calc.Division;

            UpdateDisplay();
        }

        private void bM_Click(object sender, EventArgs e)
        {
            PlaySound(WindowsFormsApp1.Properties.Resources.cum);

            calc = Calc.Multiplication;

            UpdateDisplay();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            player.Play();
            if (calc == Calc.None)
            {
                if (temp1.Contains("."))
                    return;
                else
                {
                    if (temp1.Length <= 0)
                        temp1 += "0";
                    temp1 += ".";
                }
            }
            else
            {
                if (temp2.Contains("."))
                    return;
                else
                {
                    if (temp2.Length <= 0)
                        temp2 += "0";
                    temp2 += ".";
                }
            }
            UpdateDisplay();
        }

        private void bP_Click(object sender, EventArgs e)
        {
            PlaySound(WindowsFormsApp1.Properties.Resources.sogood);

            calc = Calc.Addition;
            UpdateDisplay();
        }

        private void bMI_Click(object sender, EventArgs e)
        {
            PlaySound(WindowsFormsApp1.Properties.Resources.oui);

            calc = Calc.Subtraction;
            UpdateDisplay();
        }

        private void bE_Click(object sender, EventArgs e)
        {
            PlaySound(WindowsFormsApp1.Properties.Resources.gulp);

            WindowsFormsApp1.Class1 lib = new Class1();
            if (calc == Calc.Addition)
                textBox1.Text = lib.Addition(float.Parse(temp1), float.Parse(temp2)).ToString();
            if (calc == Calc.Subtraction)
                textBox1.Text = lib.Subtraction(float.Parse(temp1), float.Parse(temp2)).ToString();
            if (calc == Calc.Multiplication)
                textBox1.Text = lib.Multiplication(float.Parse(temp1), float.Parse(temp2)).ToString();
            if (calc == Calc.Division)
                textBox1.Text = lib.Division(float.Parse(temp1), float.Parse(temp2)).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlaySound(WindowsFormsApp1.Properties.Resources.oui);

            calc = Calc.None;
            temp1 = "";
            temp2 = "";
            UpdateDisplay();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
