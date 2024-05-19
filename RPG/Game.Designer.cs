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
            Saction = new Label();
            cboWeapon = new ComboBox();
            cboPotions = new ComboBox();
            btnWeap = new Button();
            btnPos = new Button();
            btnNorth = new Button();
            btnEast = new Button();
            btnWest = new Button();
            btnSouth = new Button();
            rtbLocation = new RichTextBox();
            rtbMsg = new RichTextBox();
            dgvInv = new DataGridView();
            dgvQuests = new DataGridView();
            gb1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvQuests).BeginInit();
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
            gb1.Size = new Size(156, 155);
            gb1.TabIndex = 8;
            gb1.TabStop = false;
            gb1.Text = "Stats";
            // 
            // Saction
            // 
            Saction.AutoSize = true;
            Saction.Location = new Point(408, 528);
            Saction.Name = "Saction";
            Saction.Size = new Size(45, 15);
            Saction.TabIndex = 9;
            Saction.Text = "Action:";
            // 
            // cboWeapon
            // 
            cboWeapon.FormattingEnabled = true;
            cboWeapon.Location = new Point(538, 546);
            cboWeapon.Name = "cboWeapon";
            cboWeapon.Size = new Size(121, 23);
            cboWeapon.TabIndex = 10;
            // 
            // cboPotions
            // 
            cboPotions.FormattingEnabled = true;
            cboPotions.Location = new Point(538, 575);
            cboPotions.Name = "cboPotions";
            cboPotions.Size = new Size(121, 23);
            cboPotions.TabIndex = 11;
            // 
            // btnWeap
            // 
            btnWeap.Location = new Point(399, 546);
            btnWeap.Name = "btnWeap";
            btnWeap.Size = new Size(75, 23);
            btnWeap.TabIndex = 12;
            btnWeap.Text = "Use:";
            btnWeap.UseVisualStyleBackColor = true;
            // 
            // btnPos
            // 
            btnPos.Location = new Point(399, 575);
            btnPos.Name = "btnPos";
            btnPos.Size = new Size(75, 23);
            btnPos.TabIndex = 13;
            btnPos.Text = "Use:";
            btnPos.UseVisualStyleBackColor = true;
            // 
            // btnNorth
            // 
            btnNorth.Location = new Point(399, 400);
            btnNorth.Name = "btnNorth";
            btnNorth.Size = new Size(75, 23);
            btnNorth.TabIndex = 14;
            btnNorth.Text = "North";
            btnNorth.UseVisualStyleBackColor = true;
            // 
            // btnEast
            // 
            btnEast.Location = new Point(315, 440);
            btnEast.Name = "btnEast";
            btnEast.Size = new Size(75, 23);
            btnEast.TabIndex = 15;
            btnEast.Text = "East";
            btnEast.UseVisualStyleBackColor = true;
            // 
            // btnWest
            // 
            btnWest.Location = new Point(494, 440);
            btnWest.Name = "btnWest";
            btnWest.Size = new Size(75, 23);
            btnWest.TabIndex = 16;
            btnWest.Text = "West";
            btnWest.UseVisualStyleBackColor = true;
            // 
            // btnSouth
            // 
            btnSouth.Location = new Point(399, 476);
            btnSouth.Name = "btnSouth";
            btnSouth.Size = new Size(75, 23);
            btnSouth.TabIndex = 17;
            btnSouth.Text = "South";
            btnSouth.UseVisualStyleBackColor = true;
            // 
            // rtbLocation
            // 
            rtbLocation.Location = new Point(315, 18);
            rtbLocation.Name = "rtbLocation";
            rtbLocation.Size = new Size(392, 96);
            rtbLocation.TabIndex = 18;
            rtbLocation.Text = "";
            // 
            // rtbMsg
            // 
            rtbMsg.Location = new Point(315, 120);
            rtbMsg.Name = "rtbMsg";
            rtbMsg.Size = new Size(392, 248);
            rtbMsg.TabIndex = 19;
            rtbMsg.Text = "";
            // 
            // dgvInv
            // 
            dgvInv.AllowUserToAddRows = false;
            dgvInv.AllowUserToDeleteRows = false;
            dgvInv.AllowUserToResizeColumns = false;
            dgvInv.AllowUserToResizeRows = false;
            dgvInv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInv.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvInv.Enabled = false;
            dgvInv.Location = new Point(12, 173);
            dgvInv.MultiSelect = false;
            dgvInv.Name = "dgvInv";
            dgvInv.ReadOnly = true;
            dgvInv.Size = new Size(297, 150);
            dgvInv.TabIndex = 20;
            // 
            // dgvQuests
            // 
            dgvQuests.AllowUserToAddRows = false;
            dgvQuests.AllowUserToDeleteRows = false;
            dgvQuests.AllowUserToResizeColumns = false;
            dgvQuests.AllowUserToResizeRows = false;
            dgvQuests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQuests.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvQuests.Enabled = false;
            dgvQuests.Location = new Point(12, 329);
            dgvQuests.MultiSelect = false;
            dgvQuests.Name = "dgvQuests";
            dgvQuests.ReadOnly = true;
            dgvQuests.Size = new Size(297, 293);
            dgvQuests.TabIndex = 21;
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 651);
            Controls.Add(dgvQuests);
            Controls.Add(dgvInv);
            Controls.Add(rtbMsg);
            Controls.Add(rtbLocation);
            Controls.Add(btnSouth);
            Controls.Add(btnWest);
            Controls.Add(btnEast);
            Controls.Add(btnNorth);
            Controls.Add(btnPos);
            Controls.Add(btnWeap);
            Controls.Add(cboPotions);
            Controls.Add(cboWeapon);
            Controls.Add(Saction);
            Controls.Add(gb1);
            Name = "Game";
            Text = "Howk Vs World";
            gb1.ResumeLayout(false);
            gb1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInv).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvQuests).EndInit();
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
        private GroupBox gb1;
        private Label Saction;
        private ComboBox cboWeapon;
        private ComboBox cboPotions;
        private Button btnWeap;
        private Button btnPos;
        private Button btnNorth;
        private Button btnEast;
        private Button btnWest;
        private Button btnSouth;
        private RichTextBox rtbLocation;
        private RichTextBox rtbMsg;
        private DataGridView dgvInv;
        private DataGridView dgvQuests;
    }
}
