namespace LeetCodeTracker
{
    partial class PracticeForm
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            button1 = new Button();
            checkBox1 = new CheckBox();
            button2 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            TimerStartBtn = new Button();
            TimerStopBtn = new Button();
            TimerResetBtn = new Button();
            TimerLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.ForestGreen;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Impact", 24F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(406, 47);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(263, 80);
            label1.TabIndex = 8;
            label1.Text = "Practice";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveBorder;
            label3.FlatStyle = FlatStyle.Popup;
            label3.Font = new Font("Impact", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(163, 204);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(223, 65);
            label3.TabIndex = 9;
            label3.Text = "Problem:";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = SystemColors.ActiveBorder;
            linkLabel1.Font = new Font("Impact", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(379, 204);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(139, 65);
            linkLabel1.TabIndex = 10;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "None";
            linkLabel1.LinkClicked += LinkLabel1_LinkClicked;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Impact", 12F, FontStyle.Italic);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.ImeMode = ImeMode.NoControl;
            button1.Location = new Point(229, 305);
            button1.Margin = new Padding(6);
            button1.Name = "button1";
            button1.Size = new Size(226, 90);
            button1.TabIndex = 11;
            button1.Text = "Randomize";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = SystemColors.ActiveBorder;
            checkBox1.Font = new Font("Impact", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(302, 604);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(482, 69);
            checkBox1.TabIndex = 12;
            checkBox1.Text = "Successful Attempt";
            checkBox1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaptionText;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Impact", 12F, FontStyle.Italic);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.ImeMode = ImeMode.NoControl;
            button2.Location = new Point(386, 705);
            button2.Margin = new Padding(6);
            button2.Name = "button2";
            button2.Size = new Size(295, 128);
            button2.TabIndex = 13;
            button2.Text = "Finish";
            button2.UseVisualStyleBackColor = false;
            button2.Click += Button2_Click;
            // 
            // timer1
            // 
            timer1.Tick += Timer1_Tick;
            // 
            // TimerStartBtn
            // 
            TimerStartBtn.BackColor = SystemColors.ActiveCaptionText;
            TimerStartBtn.FlatStyle = FlatStyle.Flat;
            TimerStartBtn.Font = new Font("Impact", 12F, FontStyle.Italic);
            TimerStartBtn.ForeColor = SystemColors.ButtonHighlight;
            TimerStartBtn.ImeMode = ImeMode.NoControl;
            TimerStartBtn.Location = new Point(500, 444);
            TimerStartBtn.Margin = new Padding(6);
            TimerStartBtn.Name = "TimerStartBtn";
            TimerStartBtn.Size = new Size(133, 72);
            TimerStartBtn.TabIndex = 14;
            TimerStartBtn.Text = "Start";
            TimerStartBtn.UseVisualStyleBackColor = false;
            TimerStartBtn.Click += TimerStartBtn_Click;
            // 
            // TimerStopBtn
            // 
            TimerStopBtn.BackColor = SystemColors.ActiveCaptionText;
            TimerStopBtn.FlatStyle = FlatStyle.Flat;
            TimerStopBtn.Font = new Font("Impact", 12F, FontStyle.Italic);
            TimerStopBtn.ForeColor = SystemColors.ButtonHighlight;
            TimerStopBtn.ImeMode = ImeMode.NoControl;
            TimerStopBtn.Location = new Point(645, 444);
            TimerStopBtn.Margin = new Padding(6);
            TimerStopBtn.Name = "TimerStopBtn";
            TimerStopBtn.Size = new Size(127, 72);
            TimerStopBtn.TabIndex = 15;
            TimerStopBtn.Text = "Stop";
            TimerStopBtn.UseVisualStyleBackColor = false;
            TimerStopBtn.Click += TimerStopBtn_Click;
            // 
            // TimerResetBtn
            // 
            TimerResetBtn.BackColor = SystemColors.ActiveCaptionText;
            TimerResetBtn.FlatStyle = FlatStyle.Flat;
            TimerResetBtn.Font = new Font("Impact", 12F, FontStyle.Italic);
            TimerResetBtn.ForeColor = SystemColors.ButtonHighlight;
            TimerResetBtn.ImeMode = ImeMode.NoControl;
            TimerResetBtn.Location = new Point(784, 444);
            TimerResetBtn.Margin = new Padding(6);
            TimerResetBtn.Name = "TimerResetBtn";
            TimerResetBtn.Size = new Size(127, 72);
            TimerResetBtn.TabIndex = 16;
            TimerResetBtn.Text = "Reset";
            TimerResetBtn.UseVisualStyleBackColor = false;
            TimerResetBtn.Click += TimerResetBtn_Click;
            // 
            // TimerLabel
            // 
            TimerLabel.AutoSize = true;
            TimerLabel.BackColor = SystemColors.ActiveBorder;
            TimerLabel.FlatStyle = FlatStyle.Popup;
            TimerLabel.Font = new Font("Impact", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TimerLabel.ForeColor = SystemColors.ActiveCaptionText;
            TimerLabel.ImeMode = ImeMode.NoControl;
            TimerLabel.Location = new Point(599, 305);
            TimerLabel.Margin = new Padding(4, 0, 4, 0);
            TimerLabel.Name = "TimerLabel";
            TimerLabel.Size = new Size(222, 117);
            TimerLabel.TabIndex = 17;
            TimerLabel.Text = "0:00";
            // 
            // PracticeForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ChatGPT_Image_Jul_10__2025__11_43_16_AM;
            ClientSize = new Size(1049, 848);
            Controls.Add(TimerLabel);
            Controls.Add(TimerResetBtn);
            Controls.Add(TimerStopBtn);
            Controls.Add(TimerStartBtn);
            Controls.Add(button2);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(linkLabel1);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "PracticeForm";
            Text = "LeetCode Practice";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label3;
        private LinkLabel linkLabel1;
        private Button button1;
        private CheckBox checkBox1;
        private Button button2;
        private System.Windows.Forms.Timer timer1;
        private Button TimerStartBtn;
        private Button TimerStopBtn;
        private Button TimerResetBtn;
        private Label TimerLabel;
    }
}