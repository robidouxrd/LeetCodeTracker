using LeetCodeTracker.Models;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace LeetCodeTracker
{
    public partial class PracticeForm : Form
    {
        public LcProblem PracticeProblem { get; set; }
        public ProblemCollection Problems;

        private readonly TimeSpan _target = TimeSpan.FromMinutes(20);
        private readonly Stopwatch _sw = new Stopwatch();

        public PracticeForm(LcProblem problem, ProblemCollection problems)
        {
            InitializeComponent();

            PracticeProblem = problem;
            Problems = problems;

            linkLabel1.Text = PracticeProblem?.Name ?? "(no problem)";

            timer1.Interval = 100;        
            timer1.Tick -= timer1_Tick;         
            timer1.Tick += timer1_Tick;

            TimerLabel.Text = _target.ToString(@"mm\:ss\.f");
        }

        public void changeProblemName(string name)
        {
            linkLabel1.Text = name;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(PracticeProblem?.Link))
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = PracticeProblem.Link,
                    UseShellExecute = true
                });
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PracticeProblem = Problems.getRandProblem();
            linkLabel1.Text = PracticeProblem?.Name ?? "(no problem)";
        }

        private void TimerStartBtn_Click(object sender, EventArgs e)
        {
            _sw.Start();
            timer1.Start();
        }

        private void TimerStopBtn_Click(object sender, EventArgs e)
        {
            _sw.Stop();
            timer1.Stop();
        }

        private void TimerResetBtn_Click(object sender, EventArgs e)
        {
            _sw.Reset();
            TimerLabel.Text = _target.ToString(@"mm\:ss\.f"); 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var remaining = _target - _sw.Elapsed;

            if (remaining <= TimeSpan.Zero)
            {
                TimerLabel.Text = "00:00.0";
                _sw.Stop();
                timer1.Stop();
                return;
            }

            TimerLabel.Text = remaining.ToString(@"mm\:ss\.f");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            if (checkBox1.Checked)
            {
                PracticeProblem.SuccessfulAttempts += 1;
                PracticeProblem.Attempts += 1;
            }
            else
            {
                PracticeProblem.Attempts += 1;
            }
            this.Close();
        }
    }
}
