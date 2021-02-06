
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
            this.button_ScamHebrew = new System.Windows.Forms.Button();
            this.label_ChannelHebrew = new System.Windows.Forms.Label();
            this.label_ChannelArabic = new System.Windows.Forms.Label();
            this.button_ScamArabic = new System.Windows.Forms.Button();
            this.button_HoldArabic = new System.Windows.Forms.Button();
            this.button_NextArabic = new System.Windows.Forms.Button();
            this.button_TransferToArabicLeft = new System.Windows.Forms.Button();
            this.button_TransferToRussian = new System.Windows.Forms.Button();
            this.listBox_Arabic = new System.Windows.Forms.ListBox();
            this.label_ChannelRussian = new System.Windows.Forms.Label();
            this.button_ScamRussian = new System.Windows.Forms.Button();
            this.button_HoldRussian = new System.Windows.Forms.Button();
            this.button_NextRussian = new System.Windows.Forms.Button();
            this.listBox_Russian = new System.Windows.Forms.ListBox();
            this.label_NumberHebrew = new System.Windows.Forms.Label();
            this.label_DurationHebrew = new System.Windows.Forms.Label();
            this.label_DurationArabic = new System.Windows.Forms.Label();
            this.label_NumberArabic = new System.Windows.Forms.Label();
            this.label_NumberRussian = new System.Windows.Forms.Label();
            this.label_DurationRussian = new System.Windows.Forms.Label();
            this.button_Music = new System.Windows.Forms.Button();
            this.timer_HebrewDuration = new System.Windows.Forms.Timer(this.components);
            this.timer_RussianDuration = new System.Windows.Forms.Timer(this.components);
            this.timer_ArabicDuration = new System.Windows.Forms.Timer(this.components);
            this.label_Title = new System.Windows.Forms.Label();
            this.label_SubTitle = new System.Windows.Forms.Label();
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
            this.listBox_Hebrew.Location = new System.Drawing.Point(93, 168);
            this.listBox_Hebrew.Name = "listBox_Hebrew";
            this.listBox_Hebrew.Size = new System.Drawing.Size(170, 364);
            this.listBox_Hebrew.TabIndex = 0;
            // 
            // button_TransferToArabicRight
            // 
            this.button_TransferToArabicRight.Location = new System.Drawing.Point(280, 312);
            this.button_TransferToArabicRight.Name = "button_TransferToArabicRight";
            this.button_TransferToArabicRight.Size = new System.Drawing.Size(28, 23);
            this.button_TransferToArabicRight.TabIndex = 3;
            this.button_TransferToArabicRight.Text = ">";
            this.button_TransferToArabicRight.UseVisualStyleBackColor = true;
            this.button_TransferToArabicRight.Click += new System.EventHandler(this.button_TransferTo_Click);
            // 
            // button_TransferToHebrew
            // 
            this.button_TransferToHebrew.Location = new System.Drawing.Point(280, 341);
            this.button_TransferToHebrew.Name = "button_TransferToHebrew";
            this.button_TransferToHebrew.Size = new System.Drawing.Size(28, 23);
            this.button_TransferToHebrew.TabIndex = 4;
            this.button_TransferToHebrew.Text = "<";
            this.button_TransferToHebrew.UseVisualStyleBackColor = true;
            this.button_TransferToHebrew.Click += new System.EventHandler(this.button_TransferTo_Click);
            // 
            // button_NextHebrew
            // 
            this.button_NextHebrew.Location = new System.Drawing.Point(93, 139);
            this.button_NextHebrew.Name = "button_NextHebrew";
            this.button_NextHebrew.Size = new System.Drawing.Size(44, 23);
            this.button_NextHebrew.TabIndex = 7;
            this.button_NextHebrew.Text = "Next";
            this.button_NextHebrew.UseVisualStyleBackColor = true;
            this.button_NextHebrew.Click += new System.EventHandler(this.button_Next_Click);
            // 
            // button_HoldHebrew
            // 
            this.button_HoldHebrew.Enabled = false;
            this.button_HoldHebrew.Location = new System.Drawing.Point(143, 139);
            this.button_HoldHebrew.Name = "button_HoldHebrew";
            this.button_HoldHebrew.Size = new System.Drawing.Size(60, 23);
            this.button_HoldHebrew.TabIndex = 8;
            this.button_HoldHebrew.Text = "Hold";
            this.button_HoldHebrew.UseVisualStyleBackColor = true;
            this.button_HoldHebrew.Click += new System.EventHandler(this.button_Hold_Click);
            // 
            // button_ScamHebrew
            // 
            this.button_ScamHebrew.Location = new System.Drawing.Point(209, 139);
            this.button_ScamHebrew.Name = "button_ScamHebrew";
            this.button_ScamHebrew.Size = new System.Drawing.Size(54, 23);
            this.button_ScamHebrew.TabIndex = 9;
            this.button_ScamHebrew.Text = "Scam";
            this.button_ScamHebrew.UseVisualStyleBackColor = true;
            this.button_ScamHebrew.Click += new System.EventHandler(this.button_Scam_Click);
            // 
            // label_ChannelHebrew
            // 
            this.label_ChannelHebrew.AutoSize = true;
            this.label_ChannelHebrew.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ChannelHebrew.Location = new System.Drawing.Point(87, 537);
            this.label_ChannelHebrew.Name = "label_ChannelHebrew";
            this.label_ChannelHebrew.Size = new System.Drawing.Size(183, 18);
            this.label_ChannelHebrew.TabIndex = 10;
            this.label_ChannelHebrew.Text = "Tech Support (Hebrew)";
            // 
            // label_ChannelArabic
            // 
            this.label_ChannelArabic.AutoSize = true;
            this.label_ChannelArabic.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ChannelArabic.Location = new System.Drawing.Point(322, 537);
            this.label_ChannelArabic.Name = "label_ChannelArabic";
            this.label_ChannelArabic.Size = new System.Drawing.Size(173, 18);
            this.label_ChannelArabic.TabIndex = 17;
            this.label_ChannelArabic.Text = "Tech Support (Arabic)";
            // 
            // button_ScamArabic
            // 
            this.button_ScamArabic.Location = new System.Drawing.Point(440, 139);
            this.button_ScamArabic.Name = "button_ScamArabic";
            this.button_ScamArabic.Size = new System.Drawing.Size(54, 23);
            this.button_ScamArabic.TabIndex = 16;
            this.button_ScamArabic.Text = "Scam";
            this.button_ScamArabic.UseVisualStyleBackColor = true;
            this.button_ScamArabic.Click += new System.EventHandler(this.button_Scam_Click);
            // 
            // button_HoldArabic
            // 
            this.button_HoldArabic.Enabled = false;
            this.button_HoldArabic.Location = new System.Drawing.Point(374, 139);
            this.button_HoldArabic.Name = "button_HoldArabic";
            this.button_HoldArabic.Size = new System.Drawing.Size(60, 23);
            this.button_HoldArabic.TabIndex = 15;
            this.button_HoldArabic.Text = "Hold";
            this.button_HoldArabic.UseVisualStyleBackColor = true;
            this.button_HoldArabic.Click += new System.EventHandler(this.button_Hold_Click);
            // 
            // button_NextArabic
            // 
            this.button_NextArabic.Location = new System.Drawing.Point(324, 139);
            this.button_NextArabic.Name = "button_NextArabic";
            this.button_NextArabic.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button_NextArabic.Size = new System.Drawing.Size(44, 23);
            this.button_NextArabic.TabIndex = 14;
            this.button_NextArabic.Text = "Next";
            this.button_NextArabic.UseVisualStyleBackColor = true;
            this.button_NextArabic.Click += new System.EventHandler(this.button_Next_Click);
            // 
            // button_TransferToArabicLeft
            // 
            this.button_TransferToArabicLeft.Location = new System.Drawing.Point(511, 341);
            this.button_TransferToArabicLeft.Name = "button_TransferToArabicLeft";
            this.button_TransferToArabicLeft.Size = new System.Drawing.Size(28, 23);
            this.button_TransferToArabicLeft.TabIndex = 13;
            this.button_TransferToArabicLeft.Text = "<";
            this.button_TransferToArabicLeft.UseVisualStyleBackColor = true;
            this.button_TransferToArabicLeft.Click += new System.EventHandler(this.button_TransferTo_Click);
            // 
            // button_TransferToRussian
            // 
            this.button_TransferToRussian.Location = new System.Drawing.Point(511, 312);
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
            this.listBox_Arabic.Location = new System.Drawing.Point(324, 168);
            this.listBox_Arabic.Name = "listBox_Arabic";
            this.listBox_Arabic.Size = new System.Drawing.Size(170, 364);
            this.listBox_Arabic.TabIndex = 11;
            // 
            // label_ChannelRussian
            // 
            this.label_ChannelRussian.AutoSize = true;
            this.label_ChannelRussian.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ChannelRussian.Location = new System.Drawing.Point(548, 537);
            this.label_ChannelRussian.Name = "label_ChannelRussian";
            this.label_ChannelRussian.Size = new System.Drawing.Size(187, 18);
            this.label_ChannelRussian.TabIndex = 24;
            this.label_ChannelRussian.Text = "Tech Support (Russian)";
            // 
            // button_ScamRussian
            // 
            this.button_ScamRussian.Location = new System.Drawing.Point(670, 139);
            this.button_ScamRussian.Name = "button_ScamRussian";
            this.button_ScamRussian.Size = new System.Drawing.Size(54, 23);
            this.button_ScamRussian.TabIndex = 23;
            this.button_ScamRussian.Text = "Scam";
            this.button_ScamRussian.UseVisualStyleBackColor = true;
            this.button_ScamRussian.Click += new System.EventHandler(this.button_Scam_Click);
            // 
            // button_HoldRussian
            // 
            this.button_HoldRussian.Enabled = false;
            this.button_HoldRussian.Location = new System.Drawing.Point(604, 139);
            this.button_HoldRussian.Name = "button_HoldRussian";
            this.button_HoldRussian.Size = new System.Drawing.Size(60, 23);
            this.button_HoldRussian.TabIndex = 22;
            this.button_HoldRussian.Text = "Hold";
            this.button_HoldRussian.UseVisualStyleBackColor = true;
            this.button_HoldRussian.Click += new System.EventHandler(this.button_Hold_Click);
            // 
            // button_NextRussian
            // 
            this.button_NextRussian.Location = new System.Drawing.Point(554, 139);
            this.button_NextRussian.Name = "button_NextRussian";
            this.button_NextRussian.Size = new System.Drawing.Size(44, 23);
            this.button_NextRussian.TabIndex = 21;
            this.button_NextRussian.Text = "Next";
            this.button_NextRussian.UseVisualStyleBackColor = true;
            this.button_NextRussian.Click += new System.EventHandler(this.button_Next_Click);
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
            this.listBox_Russian.Location = new System.Drawing.Point(554, 168);
            this.listBox_Russian.Name = "listBox_Russian";
            this.listBox_Russian.Size = new System.Drawing.Size(170, 364);
            this.listBox_Russian.TabIndex = 18;
            // 
            // label_NumberHebrew
            // 
            this.label_NumberHebrew.AutoSize = true;
            this.label_NumberHebrew.Location = new System.Drawing.Point(93, 120);
            this.label_NumberHebrew.Name = "label_NumberHebrew";
            this.label_NumberHebrew.Size = new System.Drawing.Size(47, 13);
            this.label_NumberHebrew.TabIndex = 25;
            this.label_NumberHebrew.Text = "Number:";
            // 
            // label_DurationHebrew
            // 
            this.label_DurationHebrew.AutoSize = true;
            this.label_DurationHebrew.Location = new System.Drawing.Point(93, 107);
            this.label_DurationHebrew.Name = "label_DurationHebrew";
            this.label_DurationHebrew.Size = new System.Drawing.Size(110, 13);
            this.label_DurationHebrew.TabIndex = 26;
            this.label_DurationHebrew.Text = "Duration (in seconds):";
            // 
            // label_DurationArabic
            // 
            this.label_DurationArabic.AutoSize = true;
            this.label_DurationArabic.Location = new System.Drawing.Point(321, 107);
            this.label_DurationArabic.Name = "label_DurationArabic";
            this.label_DurationArabic.Size = new System.Drawing.Size(110, 13);
            this.label_DurationArabic.TabIndex = 27;
            this.label_DurationArabic.Text = "Duration (in seconds):";
            // 
            // label_NumberArabic
            // 
            this.label_NumberArabic.AutoSize = true;
            this.label_NumberArabic.Location = new System.Drawing.Point(322, 123);
            this.label_NumberArabic.Name = "label_NumberArabic";
            this.label_NumberArabic.Size = new System.Drawing.Size(47, 13);
            this.label_NumberArabic.TabIndex = 28;
            this.label_NumberArabic.Text = "Number:";
            // 
            // label_NumberRussian
            // 
            this.label_NumberRussian.AutoSize = true;
            this.label_NumberRussian.Location = new System.Drawing.Point(552, 123);
            this.label_NumberRussian.Name = "label_NumberRussian";
            this.label_NumberRussian.Size = new System.Drawing.Size(47, 13);
            this.label_NumberRussian.TabIndex = 30;
            this.label_NumberRussian.Text = "Number:";
            // 
            // label_DurationRussian
            // 
            this.label_DurationRussian.AutoSize = true;
            this.label_DurationRussian.Location = new System.Drawing.Point(551, 107);
            this.label_DurationRussian.Name = "label_DurationRussian";
            this.label_DurationRussian.Size = new System.Drawing.Size(110, 13);
            this.label_DurationRussian.TabIndex = 29;
            this.label_DurationRussian.Text = "Duration (in seconds):";
            // 
            // button_Music
            // 
            this.button_Music.Location = new System.Drawing.Point(713, 13);
            this.button_Music.Name = "button_Music";
            this.button_Music.Size = new System.Drawing.Size(75, 23);
            this.button_Music.TabIndex = 31;
            this.button_Music.Text = "Hold Music";
            this.button_Music.UseVisualStyleBackColor = true;
            this.button_Music.Click += new System.EventHandler(this.button_Music_Click);
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
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.Location = new System.Drawing.Point(270, 13);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(275, 55);
            this.label_Title.TabIndex = 32;
            this.label_Title.Text = "Call Center";
            // 
            // label_SubTitle
            // 
            this.label_SubTitle.AutoSize = true;
            this.label_SubTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SubTitle.Location = new System.Drawing.Point(269, 68);
            this.label_SubTitle.Name = "label_SubTitle";
            this.label_SubTitle.Size = new System.Drawing.Size(276, 20);
            this.label_SubTitle.TabIndex = 33;
            this.label_SubTitle.Text = "by Daniel Naaman and Jonathan Levy";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 569);
            this.Controls.Add(this.label_SubTitle);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.button_Music);
            this.Controls.Add(this.label_NumberRussian);
            this.Controls.Add(this.label_DurationRussian);
            this.Controls.Add(this.label_NumberArabic);
            this.Controls.Add(this.label_DurationArabic);
            this.Controls.Add(this.label_DurationHebrew);
            this.Controls.Add(this.label_NumberHebrew);
            this.Controls.Add(this.label_ChannelRussian);
            this.Controls.Add(this.button_ScamRussian);
            this.Controls.Add(this.button_HoldRussian);
            this.Controls.Add(this.button_NextRussian);
            this.Controls.Add(this.listBox_Russian);
            this.Controls.Add(this.label_ChannelArabic);
            this.Controls.Add(this.button_ScamArabic);
            this.Controls.Add(this.button_HoldArabic);
            this.Controls.Add(this.button_NextArabic);
            this.Controls.Add(this.button_TransferToArabicLeft);
            this.Controls.Add(this.button_TransferToRussian);
            this.Controls.Add(this.listBox_Arabic);
            this.Controls.Add(this.label_ChannelHebrew);
            this.Controls.Add(this.button_ScamHebrew);
            this.Controls.Add(this.button_HoldHebrew);
            this.Controls.Add(this.button_NextHebrew);
            this.Controls.Add(this.button_TransferToHebrew);
            this.Controls.Add(this.button_TransferToArabicRight);
            this.Controls.Add(this.listBox_Hebrew);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Call Center by Jonathan Levy and Daniel Naaman";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Hebrew;
        private System.Windows.Forms.Button button_TransferToArabicRight;
        private System.Windows.Forms.Button button_TransferToHebrew;
        private System.Windows.Forms.Button button_NextHebrew;
        private System.Windows.Forms.Button button_HoldHebrew;
        private System.Windows.Forms.Button button_ScamHebrew;
        private System.Windows.Forms.Label label_ChannelHebrew;
        private System.Windows.Forms.Label label_ChannelArabic;
        private System.Windows.Forms.Button button_ScamArabic;
        private System.Windows.Forms.Button button_HoldArabic;
        private System.Windows.Forms.Button button_NextArabic;
        private System.Windows.Forms.Button button_TransferToArabicLeft;
        private System.Windows.Forms.Button button_TransferToRussian;
        private System.Windows.Forms.ListBox listBox_Arabic;
        private System.Windows.Forms.Label label_ChannelRussian;
        private System.Windows.Forms.Button button_ScamRussian;
        private System.Windows.Forms.Button button_HoldRussian;
        private System.Windows.Forms.Button button_NextRussian;
        private System.Windows.Forms.ListBox listBox_Russian;
        private System.Windows.Forms.Label label_NumberHebrew;
        private System.Windows.Forms.Label label_DurationHebrew;
        private System.Windows.Forms.Label label_DurationArabic;
        private System.Windows.Forms.Label label_NumberArabic;
        private System.Windows.Forms.Label label_NumberRussian;
        private System.Windows.Forms.Label label_DurationRussian;
        private System.Windows.Forms.Button button_Music;
        private System.Windows.Forms.Timer timer_HebrewDuration;
        private System.Windows.Forms.Timer timer_RussianDuration;
        private System.Windows.Forms.Timer timer_ArabicDuration;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label_SubTitle;
    }
}

