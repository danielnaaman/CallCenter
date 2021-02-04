
namespace CallCenter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listBox_Hebrew = new System.Windows.Forms.ListBox();
            this.button_TransferToArabicRight = new System.Windows.Forms.Button();
            this.button_TransferToHebrew = new System.Windows.Forms.Button();
            this.button_NextHebrew = new System.Windows.Forms.Button();
            this.button_HoldHebrew = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label_ChannelHebrew = new System.Windows.Forms.Label();
            this.label_ChannelArabic = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button_HoldArabic = new System.Windows.Forms.Button();
            this.button_NextArabic = new System.Windows.Forms.Button();
            this.button_TransferToArabicLeft = new System.Windows.Forms.Button();
            this.button_TransferToRussian = new System.Windows.Forms.Button();
            this.listBox_Arabic = new System.Windows.Forms.ListBox();
            this.label_ChannelRussian = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.button_HoldRussian = new System.Windows.Forms.Button();
            this.button_NextRussian = new System.Windows.Forms.Button();
            this.listBox_Russian = new System.Windows.Forms.ListBox();
            this.label_NumberHebrew = new System.Windows.Forms.Label();
            this.label_DurationHebrew = new System.Windows.Forms.Label();
            this.label_DurationArabic = new System.Windows.Forms.Label();
            this.label_NumberArabic = new System.Windows.Forms.Label();
            this.label_NumberRussian = new System.Windows.Forms.Label();
            this.label_DurationRussian = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer_HebrewDuration = new System.Windows.Forms.Timer(this.components);
            this.timer_RussianDuration = new System.Windows.Forms.Timer(this.components);
            this.timer_ArabicDuration = new System.Windows.Forms.Timer(this.components);
            this.timer_TotalDuration = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // listBox_Hebrew
            // 
            this.listBox_Hebrew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_Hebrew.FormattingEnabled = true;
            this.listBox_Hebrew.ItemHeight = 20;
            this.listBox_Hebrew.Items.AddRange(new object[] {
            "+972 (52) 103-4293",
            "+972 (55) 284-9549",
            "+972 (54) 309-3954",
            "+972 (52) 384-1848",
            "+972 (53) 993-9483"});
            this.listBox_Hebrew.Location = new System.Drawing.Point(93, 112);
            this.listBox_Hebrew.Name = "listBox_Hebrew";
            this.listBox_Hebrew.Size = new System.Drawing.Size(170, 364);
            this.listBox_Hebrew.TabIndex = 0;
            // 
            // button_TransferToArabicRight
            // 
            this.button_TransferToArabicRight.Location = new System.Drawing.Point(280, 256);
            this.button_TransferToArabicRight.Name = "button_TransferToArabicRight";
            this.button_TransferToArabicRight.Size = new System.Drawing.Size(28, 23);
            this.button_TransferToArabicRight.TabIndex = 3;
            this.button_TransferToArabicRight.Text = ">";
            this.button_TransferToArabicRight.UseVisualStyleBackColor = true;
            this.button_TransferToArabicRight.Click += new System.EventHandler(this.button_TransferTo_Click);
            // 
            // button_TransferToHebrew
            // 
            this.button_TransferToHebrew.Location = new System.Drawing.Point(280, 285);
            this.button_TransferToHebrew.Name = "button_TransferToHebrew";
            this.button_TransferToHebrew.Size = new System.Drawing.Size(28, 23);
            this.button_TransferToHebrew.TabIndex = 4;
            this.button_TransferToHebrew.Text = "<";
            this.button_TransferToHebrew.UseVisualStyleBackColor = true;
            this.button_TransferToHebrew.Click += new System.EventHandler(this.button_TransferTo_Click);
            // 
            // button_NextHebrew
            // 
            this.button_NextHebrew.Location = new System.Drawing.Point(93, 83);
            this.button_NextHebrew.Name = "button_NextHebrew";
            this.button_NextHebrew.Size = new System.Drawing.Size(44, 23);
            this.button_NextHebrew.TabIndex = 7;
            this.button_NextHebrew.Text = "Next";
            this.button_NextHebrew.UseVisualStyleBackColor = true;
            this.button_NextHebrew.Click += new System.EventHandler(this.button_Next);
            // 
            // button_HoldHebrew
            // 
            this.button_HoldHebrew.Location = new System.Drawing.Point(143, 83);
            this.button_HoldHebrew.Name = "button_HoldHebrew";
            this.button_HoldHebrew.Size = new System.Drawing.Size(60, 23);
            this.button_HoldHebrew.TabIndex = 8;
            this.button_HoldHebrew.Text = "Hold";
            this.button_HoldHebrew.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(209, 83);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(54, 23);
            this.button7.TabIndex = 9;
            this.button7.Text = "Scam";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // label_ChannelHebrew
            // 
            this.label_ChannelHebrew.AutoSize = true;
            this.label_ChannelHebrew.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ChannelHebrew.Location = new System.Drawing.Point(87, 481);
            this.label_ChannelHebrew.Name = "label_ChannelHebrew";
            this.label_ChannelHebrew.Size = new System.Drawing.Size(183, 18);
            this.label_ChannelHebrew.TabIndex = 10;
            this.label_ChannelHebrew.Text = "Tech Support (Hebrew)";
            // 
            // label_ChannelArabic
            // 
            this.label_ChannelArabic.AutoSize = true;
            this.label_ChannelArabic.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ChannelArabic.Location = new System.Drawing.Point(322, 481);
            this.label_ChannelArabic.Name = "label_ChannelArabic";
            this.label_ChannelArabic.Size = new System.Drawing.Size(173, 18);
            this.label_ChannelArabic.TabIndex = 17;
            this.label_ChannelArabic.Text = "Tech Support (Arabic)";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(440, 83);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(54, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Scam";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button_HoldArabic
            // 
            this.button_HoldArabic.Location = new System.Drawing.Point(374, 83);
            this.button_HoldArabic.Name = "button_HoldArabic";
            this.button_HoldArabic.Size = new System.Drawing.Size(60, 23);
            this.button_HoldArabic.TabIndex = 15;
            this.button_HoldArabic.Text = "Hold";
            this.button_HoldArabic.UseVisualStyleBackColor = true;
            // 
            // button_NextArabic
            // 
            this.button_NextArabic.Location = new System.Drawing.Point(324, 83);
            this.button_NextArabic.Name = "button_NextArabic";
            this.button_NextArabic.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button_NextArabic.Size = new System.Drawing.Size(44, 23);
            this.button_NextArabic.TabIndex = 14;
            this.button_NextArabic.Text = "Next";
            this.button_NextArabic.UseVisualStyleBackColor = true;
            this.button_NextArabic.Click += new System.EventHandler(this.button_Next);
            // 
            // button_TransferToArabicLeft
            // 
            this.button_TransferToArabicLeft.Location = new System.Drawing.Point(511, 285);
            this.button_TransferToArabicLeft.Name = "button_TransferToArabicLeft";
            this.button_TransferToArabicLeft.Size = new System.Drawing.Size(28, 23);
            this.button_TransferToArabicLeft.TabIndex = 13;
            this.button_TransferToArabicLeft.Text = "<";
            this.button_TransferToArabicLeft.UseVisualStyleBackColor = true;
            this.button_TransferToArabicLeft.Click += new System.EventHandler(this.button_TransferTo_Click);
            // 
            // button_TransferToRussian
            // 
            this.button_TransferToRussian.Location = new System.Drawing.Point(511, 256);
            this.button_TransferToRussian.Name = "button_TransferToRussian";
            this.button_TransferToRussian.Size = new System.Drawing.Size(28, 23);
            this.button_TransferToRussian.TabIndex = 12;
            this.button_TransferToRussian.Text = ">";
            this.button_TransferToRussian.UseVisualStyleBackColor = true;
            this.button_TransferToRussian.Click += new System.EventHandler(this.button_TransferTo_Click);
            // 
            // listBox_Arabic
            // 
            this.listBox_Arabic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_Arabic.FormattingEnabled = true;
            this.listBox_Arabic.ItemHeight = 20;
            this.listBox_Arabic.Items.AddRange(new object[] {
            "+972 (52) 103-4293",
            "+972 (55) 284-9549",
            "+972 (54) 309-3954",
            "+972 (52) 384-1848",
            "+972 (53) 993-9483"});
            this.listBox_Arabic.Location = new System.Drawing.Point(324, 112);
            this.listBox_Arabic.Name = "listBox_Arabic";
            this.listBox_Arabic.Size = new System.Drawing.Size(170, 364);
            this.listBox_Arabic.TabIndex = 11;
            // 
            // label_ChannelRussian
            // 
            this.label_ChannelRussian.AutoSize = true;
            this.label_ChannelRussian.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ChannelRussian.Location = new System.Drawing.Point(548, 481);
            this.label_ChannelRussian.Name = "label_ChannelRussian";
            this.label_ChannelRussian.Size = new System.Drawing.Size(187, 18);
            this.label_ChannelRussian.TabIndex = 24;
            this.label_ChannelRussian.Text = "Tech Support (Russian)";
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(670, 83);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(54, 23);
            this.button11.TabIndex = 23;
            this.button11.Text = "Scam";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button_HoldRussian
            // 
            this.button_HoldRussian.Location = new System.Drawing.Point(604, 83);
            this.button_HoldRussian.Name = "button_HoldRussian";
            this.button_HoldRussian.Size = new System.Drawing.Size(60, 23);
            this.button_HoldRussian.TabIndex = 22;
            this.button_HoldRussian.Text = "Hold";
            this.button_HoldRussian.UseVisualStyleBackColor = true;
            this.button_HoldRussian.Click += new System.EventHandler(this.button_Hold_Click);
            // 
            // button_NextRussian
            // 
            this.button_NextRussian.Location = new System.Drawing.Point(554, 83);
            this.button_NextRussian.Name = "button_NextRussian";
            this.button_NextRussian.Size = new System.Drawing.Size(44, 23);
            this.button_NextRussian.TabIndex = 21;
            this.button_NextRussian.Text = "Next";
            this.button_NextRussian.UseVisualStyleBackColor = true;
            this.button_NextRussian.Click += new System.EventHandler(this.button_Next);
            // 
            // listBox_Russian
            // 
            this.listBox_Russian.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_Russian.FormattingEnabled = true;
            this.listBox_Russian.ItemHeight = 20;
            this.listBox_Russian.Items.AddRange(new object[] {
            "+972 (52) 103-4293",
            "+972 (55) 284-9549",
            "+972 (54) 309-3954",
            "+972 (52) 384-1848",
            "+972 (53) 993-9483"});
            this.listBox_Russian.Location = new System.Drawing.Point(554, 112);
            this.listBox_Russian.Name = "listBox_Russian";
            this.listBox_Russian.Size = new System.Drawing.Size(170, 364);
            this.listBox_Russian.TabIndex = 18;
            // 
            // label_NumberHebrew
            // 
            this.label_NumberHebrew.AutoSize = true;
            this.label_NumberHebrew.Location = new System.Drawing.Point(93, 64);
            this.label_NumberHebrew.Name = "label_NumberHebrew";
            this.label_NumberHebrew.Size = new System.Drawing.Size(47, 13);
            this.label_NumberHebrew.TabIndex = 25;
            this.label_NumberHebrew.Text = "Number:";
            // 
            // label_DurationHebrew
            // 
            this.label_DurationHebrew.AutoSize = true;
            this.label_DurationHebrew.Location = new System.Drawing.Point(93, 51);
            this.label_DurationHebrew.Name = "label_DurationHebrew";
            this.label_DurationHebrew.Size = new System.Drawing.Size(110, 13);
            this.label_DurationHebrew.TabIndex = 26;
            this.label_DurationHebrew.Text = "Duration (in seconds):";
            // 
            // label_DurationArabic
            // 
            this.label_DurationArabic.AutoSize = true;
            this.label_DurationArabic.Location = new System.Drawing.Point(321, 51);
            this.label_DurationArabic.Name = "label_DurationArabic";
            this.label_DurationArabic.Size = new System.Drawing.Size(110, 13);
            this.label_DurationArabic.TabIndex = 27;
            this.label_DurationArabic.Text = "Duration (in seconds):";
            // 
            // label_NumberArabic
            // 
            this.label_NumberArabic.AutoSize = true;
            this.label_NumberArabic.Location = new System.Drawing.Point(322, 67);
            this.label_NumberArabic.Name = "label_NumberArabic";
            this.label_NumberArabic.Size = new System.Drawing.Size(47, 13);
            this.label_NumberArabic.TabIndex = 28;
            this.label_NumberArabic.Text = "Number:";
            // 
            // label_NumberRussian
            // 
            this.label_NumberRussian.AutoSize = true;
            this.label_NumberRussian.Location = new System.Drawing.Point(552, 67);
            this.label_NumberRussian.Name = "label_NumberRussian";
            this.label_NumberRussian.Size = new System.Drawing.Size(47, 13);
            this.label_NumberRussian.TabIndex = 30;
            this.label_NumberRussian.Text = "Number:";
            // 
            // label_DurationRussian
            // 
            this.label_DurationRussian.AutoSize = true;
            this.label_DurationRussian.Location = new System.Drawing.Point(551, 51);
            this.label_DurationRussian.Name = "label_DurationRussian";
            this.label_DurationRussian.Size = new System.Drawing.Size(110, 13);
            this.label_DurationRussian.TabIndex = 29;
            this.label_DurationRussian.Text = "Duration (in seconds):";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 31;
            this.button1.Text = "racism";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer_HebrewDuration
            // 
            this.timer_HebrewDuration.Interval = 1000;
            this.timer_HebrewDuration.Tick += new System.EventHandler(this.timer_HebrewDuration_Tick);
            // 
            // timer_RussianDuration
            // 
            this.timer_RussianDuration.Interval = 1000;
            this.timer_RussianDuration.Tick += new System.EventHandler(this.timer_RussianDuration_Tick);
            // 
            // timer_ArabicDuration
            // 
            this.timer_ArabicDuration.Interval = 1000;
            this.timer_ArabicDuration.Tick += new System.EventHandler(this.timer_ArabicDuration_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_NumberRussian);
            this.Controls.Add(this.label_DurationRussian);
            this.Controls.Add(this.label_NumberArabic);
            this.Controls.Add(this.label_DurationArabic);
            this.Controls.Add(this.label_DurationHebrew);
            this.Controls.Add(this.label_NumberHebrew);
            this.Controls.Add(this.label_ChannelRussian);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button_HoldRussian);
            this.Controls.Add(this.button_NextRussian);
            this.Controls.Add(this.listBox_Russian);
            this.Controls.Add(this.label_ChannelArabic);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button_HoldArabic);
            this.Controls.Add(this.button_NextArabic);
            this.Controls.Add(this.button_TransferToArabicLeft);
            this.Controls.Add(this.button_TransferToRussian);
            this.Controls.Add(this.listBox_Arabic);
            this.Controls.Add(this.label_ChannelHebrew);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button_HoldHebrew);
            this.Controls.Add(this.button_NextHebrew);
            this.Controls.Add(this.button_TransferToHebrew);
            this.Controls.Add(this.button_TransferToArabicRight);
            this.Controls.Add(this.listBox_Hebrew);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Hebrew;
        private System.Windows.Forms.Button button_TransferToArabicRight;
        private System.Windows.Forms.Button button_TransferToHebrew;
        private System.Windows.Forms.Button button_NextHebrew;
        private System.Windows.Forms.Button button_HoldHebrew;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label_ChannelHebrew;
        private System.Windows.Forms.Label label_ChannelArabic;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button_HoldArabic;
        private System.Windows.Forms.Button button_NextArabic;
        private System.Windows.Forms.Button button_TransferToArabicLeft;
        private System.Windows.Forms.Button button_TransferToRussian;
        private System.Windows.Forms.ListBox listBox_Arabic;
        private System.Windows.Forms.Label label_ChannelRussian;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button_HoldRussian;
        private System.Windows.Forms.Button button_NextRussian;
        private System.Windows.Forms.ListBox listBox_Russian;
        private System.Windows.Forms.Label label_NumberHebrew;
        private System.Windows.Forms.Label label_DurationHebrew;
        private System.Windows.Forms.Label label_DurationArabic;
        private System.Windows.Forms.Label label_NumberArabic;
        private System.Windows.Forms.Label label_NumberRussian;
        private System.Windows.Forms.Label label_DurationRussian;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer_HebrewDuration;
        private System.Windows.Forms.Timer timer_RussianDuration;
        private System.Windows.Forms.Timer timer_ArabicDuration;
        private System.Windows.Forms.Timer timer_TotalDuration;
    }
}

