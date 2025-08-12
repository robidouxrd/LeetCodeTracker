namespace LeetCodeTracker
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            button1 = new Button();
            button2 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            listView1 = new ListView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            deletetoolStripMenuItem = new ToolStripMenuItem();
            rdBtnEasy = new RadioButton();
            rdBtnMed = new RadioButton();
            rdBtnHard = new RadioButton();
            rdBtnAll = new RadioButton();
            label1 = new Label();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            resources.ApplyResources(button1, "button1");
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaptionText;
            resources.ApplyResources(button2, "button2");
            button2.Name = "button2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // listView1
            // 
            listView1.BackColor = SystemColors.MenuText;
            listView1.ContextMenuStrip = contextMenuStrip1;
            resources.ApplyResources(listView1, "listView1");
            listView1.ForeColor = SystemColors.HighlightText;
            listView1.FullRowSelect = true;
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.ColumnClick += listView1_ColumnClick;
            listView1.MouseDown += listView1_MouseDown;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(32, 32);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { deletetoolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(contextMenuStrip1, "contextMenuStrip1");
            // 
            // deletetoolStripMenuItem
            // 
            deletetoolStripMenuItem.Name = "deletetoolStripMenuItem";
            resources.ApplyResources(deletetoolStripMenuItem, "deletetoolStripMenuItem");
            deletetoolStripMenuItem.Click += deletetoolStripMenuItem_Click;
            // 
            // rdBtnEasy
            // 
            resources.ApplyResources(rdBtnEasy, "rdBtnEasy");
            rdBtnEasy.BackColor = SystemColors.ActiveCaptionText;
            rdBtnEasy.Name = "rdBtnEasy";
            rdBtnEasy.TabStop = true;
            rdBtnEasy.UseVisualStyleBackColor = false;
            rdBtnEasy.CheckedChanged += rdBtnEasy_CheckedChanged;
            // 
            // rdBtnMed
            // 
            resources.ApplyResources(rdBtnMed, "rdBtnMed");
            rdBtnMed.BackColor = SystemColors.ActiveCaptionText;
            rdBtnMed.Name = "rdBtnMed";
            rdBtnMed.TabStop = true;
            rdBtnMed.UseVisualStyleBackColor = false;
            rdBtnMed.CheckedChanged += rdBtnMed_CheckedChanged;
            // 
            // rdBtnHard
            // 
            resources.ApplyResources(rdBtnHard, "rdBtnHard");
            rdBtnHard.BackColor = SystemColors.ActiveCaptionText;
            rdBtnHard.Name = "rdBtnHard";
            rdBtnHard.TabStop = true;
            rdBtnHard.UseVisualStyleBackColor = false;
            rdBtnHard.CheckedChanged += rdBtnHard_CheckedChanged;
            // 
            // rdBtnAll
            // 
            resources.ApplyResources(rdBtnAll, "rdBtnAll");
            rdBtnAll.BackColor = SystemColors.ActiveCaptionText;
            rdBtnAll.Name = "rdBtnAll";
            rdBtnAll.TabStop = true;
            rdBtnAll.UseVisualStyleBackColor = false;
            rdBtnAll.CheckedChanged += rdBtnAll_CheckedChanged;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.BackColor = Color.ForestGreen;
            label1.FlatStyle = FlatStyle.Popup;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Name = "label1";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            Controls.Add(label1);
            Controls.Add(rdBtnAll);
            Controls.Add(rdBtnHard);
            Controls.Add(rdBtnMed);
            Controls.Add(rdBtnEasy);
            Controls.Add(listView1);
            Controls.Add(button2);
            Controls.Add(button1);
            ForeColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private System.Windows.Forms.Timer timer1;
        private ListView listView1;
        private RadioButton rdBtnEasy;
        private RadioButton rdBtnMed;
        private RadioButton rdBtnHard;
        private RadioButton rdBtnAll;
        private Label label1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem deletetoolStripMenuItem;
    }
}
