﻿namespace RPG
{
    partial class Game
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblHit = new Label();
            lblGold = new Label();
            lblExp = new Label();
            lblLevel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 20);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "Hit Points:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 46);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 1;
            label2.Text = "Gold:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 100);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 2;
            label3.Text = "Level:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 74);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 3;
            label4.Text = "Exp:";
            // 
            // lblHit
            // 
            lblHit.AutoSize = true;
            lblHit.Location = new Point(110, 19);
            lblHit.Name = "lblHit";
            lblHit.Size = new Size(0, 15);
            lblHit.TabIndex = 4;
            // 
            // lblGold
            // 
            lblGold.AutoSize = true;
            lblGold.Location = new Point(110, 45);
            lblGold.Name = "lblGold";
            lblGold.Size = new Size(0, 15);
            lblGold.TabIndex = 5;
            // 
            // lblExp
            // 
            lblExp.AutoSize = true;
            lblExp.Location = new Point(110, 73);
            lblExp.Name = "lblExp";
            lblExp.Size = new Size(0, 15);
            lblExp.TabIndex = 6;
            // 
            // lblLevel
            // 
            lblLevel.AutoSize = true;
            lblLevel.Location = new Point(110, 99);
            lblLevel.Name = "lblLevel";
            lblLevel.Size = new Size(0, 15);
            lblLevel.TabIndex = 7;
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 651);
            Controls.Add(lblLevel);
            Controls.Add(lblExp);
            Controls.Add(lblGold);
            Controls.Add(lblHit);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Game";
            Text = "Howk Vs World";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblHit;
        private Label lblGold;
        private Label lblExp;
        private Label lblLevel;
    }
}
