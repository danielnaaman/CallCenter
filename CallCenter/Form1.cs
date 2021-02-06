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
        // Hebrew
        private string currentCallerHebrew; // The current caller's phone number in internationalized format
        private int durationHebrew = 0; // The duration of the current call
        private bool isHebrewOnHold = false; // Is the current call on hold

        // Arabic
        private string currentCallerArabic; // The current caller's phone number in internationalized format
        private int durationArabic = 0; // The duration of the current call
        private bool isArabicOnHold = false; // Is the current call on hold

        // Russian
        private string currentCallerRussian; // The current caller's phone number in internationalized format
        private int durationRussian = 0; // The duration of the current call
        private bool isRussianOnHold = false; // Is the current call on hold

        public Form1()
        {
            InitializeComponent();
        }

        // The music button adds lovely music to project
        private void button_Music_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(CallCenter.Properties.Resources.holding);
            simpleSound.Play();
        }

        // The TransferTo button transfers the selected caller to a different queue
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

        // The Next button promotes the number on the top of the queue to a call and hangs up the previous call
        private void button_Next_Click(object sender, EventArgs e)
        {
            Button b;
            b = sender as Button;

            if (b.Name.EndsWith("Hebrew") && listBox_Hebrew.SelectedItem != null)
            {
                currentCallerHebrew = listBox_Hebrew.Items[0].ToString();
                listBox_Hebrew.Items.Remove(listBox_Hebrew.Items[0]);
                label_NumberHebrew.Text = "Number: " + currentCallerHebrew;
                durationHebrew = -1;
                timer_HebrewDuration.Start();
                button_HoldHebrew.Enabled = true;
            }

            else if (b.Name.EndsWith("Arabic") && listBox_Arabic.SelectedItem != null)
            {
                currentCallerArabic = listBox_Arabic.Items[0].ToString();
                listBox_Arabic.Items.Remove(listBox_Arabic.Items[0]);
                label_NumberArabic.Text = "Number: " + currentCallerArabic;
                durationArabic = -1;
                timer_ArabicDuration.Start();
                button_HoldArabic.Enabled = true;
            }

            else // Russian
            {
                if (listBox_Russian.SelectedItem != null)
                { 
                    currentCallerRussian = listBox_Russian.Items[0].ToString();
                    listBox_Russian.Items.Remove(listBox_Russian.Items[0]);
                    label_NumberRussian.Text = "Number: " + currentCallerRussian;
                    durationRussian = -1;
                    timer_RussianDuration.Start();
                    button_HoldRussian.Enabled = true;
                }
            }
        }

        // The Hold button holds the call and pauses the timer for the current caller
        private void button_Hold_Click(object sender, EventArgs e)
        {
            Button b;
            b = sender as Button;

            if (b.Name.EndsWith("Hebrew") && !isHebrewOnHold)
            {
                timer_HebrewDuration.Stop();
                b.Text = "Resume";
                label_DurationHebrew.Text = "Duration (in seconds): " + durationHebrew.ToString() + " [ON HOLD]";
                isHebrewOnHold = !isHebrewOnHold;
            }

            else if (b.Name.EndsWith("Hebrew") && isHebrewOnHold)
            {
                timer_HebrewDuration.Start();
                b.Text = "Hold";
                isHebrewOnHold = !isHebrewOnHold;
            }

            else if (b.Name.EndsWith("Arabic") && !isArabicOnHold)
            {
                timer_ArabicDuration.Stop();
                b.Text = "Resume";
                label_DurationArabic.Text = "Duration (in seconds): " + durationArabic.ToString() + " [ON HOLD]";
                isArabicOnHold = !isArabicOnHold;
            }

            else if (b.Name.EndsWith("Arabic") && isArabicOnHold)
            {
                timer_ArabicDuration.Start();
                b.Text = "Hold";
                isArabicOnHold = !isArabicOnHold;
            }

            else if (b.Name.EndsWith("Russian") && !isRussianOnHold) // Russian
            {
                timer_RussianDuration.Stop();
                b.Text = "Resume";
                label_DurationRussian.Text = "Duration (in seconds): " + durationRussian.ToString() + " [ON HOLD]";
                isRussianOnHold = !isRussianOnHold;
            }

            else // Russian
            {
                timer_RussianDuration.Start();
                b.Text = "Hold";
                isRussianOnHold = !isRussianOnHold;
            }
        }

        // The scam button scams the current client on the phone 
        private void button_Scam_Click(object sender, EventArgs e)
        {
            while (true)
            {
                MessageBox.Show("You have been granted a lifetime premium subscription to F2A!"); // yes, this is purposefully annoying.
            }
        }

        // The tick operations add one second to each ongoing call
        private void timer_HebrewDuration_Tick(object sender, EventArgs e)
        {
            durationHebrew++;
            label_DurationHebrew.Text = "Duration (in seconds): " + durationHebrew.ToString();
        }

        private void timer_RussianDuration_Tick(object sender, EventArgs e)
        {
            durationRussian++;
            label_DurationRussian.Text = "Duration (in seconds): " + durationRussian.ToString();
        }

        private void timer_ArabicDuration_Tick(object sender, EventArgs e)
        {
            durationArabic++;
            label_DurationArabic.Text = "Duration (in seconds): " + durationArabic.ToString();
        }
    }
}