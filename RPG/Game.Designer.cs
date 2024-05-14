namespace RPG
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
            gb1 = new GroupBox();
            groupBox1 = new GroupBox();
            DescBox = new Label();
            gb1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 33);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "Hit Points:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 59);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 1;
            label2.Text = "Gold:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 113);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 2;
            label3.Text = "Level:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 87);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 3;
            label4.Text = "Exp:";
            // 
            // lblHit
            // 
            lblHit.AutoSize = true;
            lblHit.Location = new Point(80, 33);
            lblHit.Name = "lblHit";
            lblHit.Size = new Size(0, 15);
            lblHit.TabIndex = 4;
            // 
            // lblGold
            // 
            lblGold.AutoSize = true;
            lblGold.Location = new Point(80, 59);
            lblGold.Name = "lblGold";
            lblGold.Size = new Size(0, 15);
            lblGold.TabIndex = 5;
            // 
            // lblExp
            // 
            lblExp.AutoSize = true;
            lblExp.Location = new Point(80, 87);
            lblExp.Name = "lblExp";
            lblExp.Size = new Size(0, 15);
            lblExp.TabIndex = 6;
            // 
            // lblLevel
            // 
            lblLevel.AutoSize = true;
            lblLevel.Location = new Point(80, 113);
            lblLevel.Name = "lblLevel";
            lblLevel.Size = new Size(0, 15);
            lblLevel.TabIndex = 7;
            // 
            // gb1
            // 
            gb1.Controls.Add(label1);
            gb1.Controls.Add(lblLevel);
            gb1.Controls.Add(label2);
            gb1.Controls.Add(lblExp);
            gb1.Controls.Add(label3);
            gb1.Controls.Add(lblGold);
            gb1.Controls.Add(label4);
            gb1.Controls.Add(lblHit);
            gb1.Location = new Point(12, 12);
            gb1.Name = "gb1";
            gb1.Size = new Size(156, 175);
            gb1.TabIndex = 8;
            gb1.TabStop = false;
            gb1.Text = "States";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(DescBox);
            groupBox1.Location = new Point(174, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(273, 460);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Description";
            // 
            // DescBox
            // 
            DescBox.AutoSize = true;
            DescBox.Location = new Point(6, 33);
            DescBox.MaximumSize = new Size(273, 0);
            DescBox.Name = "DescBox";
            DescBox.Size = new Size(0, 15);
            DescBox.TabIndex = 0;
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 651);
            Controls.Add(groupBox1);
            Controls.Add(gb1);
            Name = "Game";
            Text = "Howk Vs World";
            gb1.ResumeLayout(false);
            gb1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
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
        private GroupBox gb1;
        private GroupBox groupBox1;
        private Label DescBox;
    }
}
