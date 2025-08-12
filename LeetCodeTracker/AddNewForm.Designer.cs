namespace LeetCodeTracker
{
    partial class AddNewForm
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
            problemNameTB = new TextBox();
            label1 = new Label();
            problemDescriptionTB = new TextBox();
            label2 = new Label();
            label3 = new Label();
            easyRadio = new RadioButton();
            medRadio = new RadioButton();
            hardRadio = new RadioButton();
            addProblemBtn = new Button();
            SuspendLayout();
            // 
            // problemNameTB
            // 
            problemNameTB.BackColor = SystemColors.ControlLightLight;
            problemNameTB.Location = new Point(142, 84);
            problemNameTB.Name = "problemNameTB";
            problemNameTB.Size = new Size(377, 39);
            problemNameTB.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(240, 33);
            label1.Name = "label1";
            label1.Size = new Size(185, 32);
            label1.TabIndex = 3;
            label1.Text = "Problem Name";
            // 
            // problemDescriptionTB
            // 
            problemDescriptionTB.BackColor = SystemColors.ControlLightLight;
            problemDescriptionTB.Location = new Point(142, 193);
            problemDescriptionTB.Name = "problemDescriptionTB";
            problemDescriptionTB.Size = new Size(377, 39);
            problemDescriptionTB.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(298, 142);
            label2.Name = "label2";
            label2.Size = new Size(61, 32);
            label2.TabIndex = 5;
            label2.Text = "Link";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(269, 256);
            label3.Name = "label3";
            label3.Size = new Size(120, 32);
            label3.TabIndex = 6;
            label3.Text = "Difficulty";
            // 
            // easyRadio
            // 
            easyRadio.AutoSize = true;
            easyRadio.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            easyRadio.Location = new Point(142, 316);
            easyRadio.Name = "easyRadio";
            easyRadio.Size = new Size(95, 36);
            easyRadio.TabIndex = 7;
            easyRadio.TabStop = true;
            easyRadio.Text = "Easy";
            easyRadio.UseVisualStyleBackColor = true;
            // 
            // medRadio
            // 
            medRadio.AutoSize = true;
            medRadio.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            medRadio.Location = new Point(253, 316);
            medRadio.Name = "medRadio";
            medRadio.Size = new Size(140, 36);
            medRadio.TabIndex = 8;
            medRadio.TabStop = true;
            medRadio.Text = "Medium";
            medRadio.UseVisualStyleBackColor = true;
            // 
            // hardRadio
            // 
            hardRadio.AutoSize = true;
            hardRadio.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hardRadio.Location = new Point(418, 316);
            hardRadio.Name = "hardRadio";
            hardRadio.Size = new Size(101, 36);
            hardRadio.TabIndex = 9;
            hardRadio.TabStop = true;
            hardRadio.Text = "Hard";
            hardRadio.UseVisualStyleBackColor = true;
            // 
            // addProblemBtn
            // 
            addProblemBtn.BackColor = Color.Black;
            addProblemBtn.ForeColor = SystemColors.ButtonHighlight;
            addProblemBtn.Location = new Point(253, 383);
            addProblemBtn.Name = "addProblemBtn";
            addProblemBtn.Size = new Size(150, 46);
            addProblemBtn.TabIndex = 10;
            addProblemBtn.Text = "Add";
            addProblemBtn.UseVisualStyleBackColor = false;
            addProblemBtn.Click += addProblemBtn_Click;
            // 
            // AddNewForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            BackgroundImage = Properties.Resources.ChatGPT_Image_Jul_10__2025__11_43_16_AM;
            ClientSize = new Size(661, 450);
            Controls.Add(addProblemBtn);
            Controls.Add(hardRadio);
            Controls.Add(medRadio);
            Controls.Add(easyRadio);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(problemDescriptionTB);
            Controls.Add(label1);
            Controls.Add(problemNameTB);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "AddNewForm";
            Text = "Add New Problem";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox problemNameTB;
        private Label label1;
        private TextBox problemDescriptionTB;
        private Label label2;
        private Label label3;
        private RadioButton easyRadio;
        private RadioButton medRadio;
        private RadioButton hardRadio;
        private Button addProblemBtn;
    }
}