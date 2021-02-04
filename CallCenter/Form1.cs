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

namespace CallCenter
{
    public partial class Form1 : Form
    {
        private string currentCallerHebrew;
        private int durationHebrew = 0;
        private string currentCallerArabic;
        private int durationArabic = 0;
        private string currentCallerRussian;
        private int durationRussian = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_TransferTo_Click(object sender, EventArgs e)
        {
            Button b;
            b = sender as Button;
            string temp;

            if (b.Name.EndsWith("Hebrew"))
            {
                if (listBox_Arabic.SelectedItem != null)
                {
                    temp = listBox_Arabic.SelectedItem.ToString();
                    listBox_Arabic.Items.Remove(listBox_Arabic.SelectedItem);
                    listBox_Hebrew.Items.Add(temp);
                }
            }

            else if (b.Name.EndsWith("ArabicRight"))
            {
                if (listBox_Hebrew.SelectedItem != null)
                {
                    temp = listBox_Hebrew.SelectedItem.ToString();
                    listBox_Hebrew.Items.Remove(listBox_Hebrew.SelectedItem);
                    listBox_Arabic.Items.Add(temp);
                }
            }

            else if (b.Name.EndsWith("Russian"))
            {
                if (listBox_Arabic.SelectedItem != null)
                {
                    temp = listBox_Arabic.SelectedItem.ToString();
                    listBox_Arabic.Items.Remove(listBox_Arabic.SelectedItem);
                    listBox_Russian.Items.Add(temp);
                }
            }

            else // Arabic Left
            {
                if (listBox_Russian.SelectedItem != null)
                {
                    temp = listBox_Russian.SelectedItem.ToString();
                    listBox_Russian.Items.Remove(listBox_Russian.SelectedItem);
                    listBox_Arabic.Items.Add(temp);
                }
            }
        }

        private void timer_HebrewDuration_Tick(object sender, EventArgs e)
        {
            durationHebrew++;
            label_DurationHebrew.Text = durationHebrew.ToString();
        }

        private void button_Next(object sender, EventArgs e)
        {
            Button b;
            b = sender as Button;

            if (b.Name.EndsWith("Hebrew"))
            {
                currentCallerHebrew = listBox_Hebrew.Items[0].ToString();
                listBox_Hebrew.Items.Remove(listBox_Hebrew.Items[0]);
                label_NumberHebrew.Text = "Number: " + currentCallerHebrew;
                timer_HebrewDuration.Start();
            }

            else if (b.Name.EndsWith("Arabic"))
            {
                currentCallerArabic = listBox_Arabic.Items[0].ToString();
                listBox_Arabic.Items.Remove(listBox_Arabic.Items[0]);
                label_NumberArabic.Text = "Number: " + currentCallerArabic;
            }

            else // Russian
            {
                currentCallerRussian = listBox_Russian.Items[0].ToString();
                listBox_Russian.Items.Remove(listBox_Russian.Items[0]);
                label_NumberRussian.Text = "Number: " + currentCallerRussian;
            }
        }

        private void button_Hold_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(CallCenter.Properties.Resources.holding);
            simpleSound.Play();
        }

        private void timer_RussianDuration_Tick(object sender, EventArgs e)
        {
            durationRussian++;
        }

        private void timer_ArabicDuration_Tick(object sender, EventArgs e)
        {
            durationArabic++;
        }
    }
}
