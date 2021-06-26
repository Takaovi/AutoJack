namespace AutoJack
{
    partial class AutoJack
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
            this.sanoinaCheckBox = new System.Windows.Forms.CheckBox();
            this.hellCheckBox = new System.Windows.Forms.CheckBox();
            this.tila = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.startFromUpDown = new System.Windows.Forms.NumericUpDown();
            this.countToUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.jumpBetween = new System.Windows.Forms.CheckBox();
            this.openchatTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.speedBar = new System.Windows.Forms.TrackBar();
            this.speedLabel = new System.Windows.Forms.Label();
            this.hellCapsCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.hyphenCheckBox = new System.Windows.Forms.CheckBox();
            this.fullstopCheckBox = new System.Windows.Forms.CheckBox();
            this.begincapitalCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.testingGround = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.copytestingButton = new System.Windows.Forms.Button();
            this.cleartestingButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.currentNumber = new System.Windows.Forms.Label();
            this.currentWait = new System.Windows.Forms.Label();
            this.numbermodeCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.startFromUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countToUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedBar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // sanoinaCheckBox
            // 
            this.sanoinaCheckBox.AutoSize = true;
            this.sanoinaCheckBox.Location = new System.Drawing.Point(78, 19);
            this.sanoinaCheckBox.Name = "sanoinaCheckBox";
            this.sanoinaCheckBox.Size = new System.Drawing.Size(57, 17);
            this.sanoinaCheckBox.TabIndex = 1;
            this.sanoinaCheckBox.Text = "Words";
            this.sanoinaCheckBox.UseVisualStyleBackColor = true;
            this.sanoinaCheckBox.CheckedChanged += new System.EventHandler(this.sanoinaCheckBox_CheckedChanged);
            // 
            // hellCheckBox
            // 
            this.hellCheckBox.AutoSize = true;
            this.hellCheckBox.Location = new System.Drawing.Point(136, 19);
            this.hellCheckBox.Name = "hellCheckBox";
            this.hellCheckBox.Size = new System.Drawing.Size(73, 17);
            this.hellCheckBox.TabIndex = 2;
            this.hellCheckBox.Text = "Hell mode";
            this.hellCheckBox.UseVisualStyleBackColor = true;
            this.hellCheckBox.CheckedChanged += new System.EventHandler(this.hellCheckBox_CheckedChanged);
            // 
            // tila
            // 
            this.tila.AutoSize = true;
            this.tila.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tila.Location = new System.Drawing.Point(8, 11);
            this.tila.Name = "tila";
            this.tila.Size = new System.Drawing.Size(117, 16);
            this.tila.TabIndex = 3;
            this.tila.Text = "Ready to start (F8)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Start from";
            // 
            // startFromUpDown
            // 
            this.startFromUpDown.Location = new System.Drawing.Point(13, 36);
            this.startFromUpDown.Maximum = new decimal(new int[] {
            -469762049,
            -590869294,
            5421010,
            0});
            this.startFromUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.startFromUpDown.Name = "startFromUpDown";
            this.startFromUpDown.Size = new System.Drawing.Size(73, 20);
            this.startFromUpDown.TabIndex = 5;
            this.startFromUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.startFromUpDown.ValueChanged += new System.EventHandler(this.startFromUpDown_ValueChanged);
            // 
            // countToUpDown
            // 
            this.countToUpDown.Location = new System.Drawing.Point(92, 36);
            this.countToUpDown.Maximum = new decimal(new int[] {
            -469762049,
            -590869294,
            5421010,
            0});
            this.countToUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.countToUpDown.Name = "countToUpDown";
            this.countToUpDown.Size = new System.Drawing.Size(73, 20);
            this.countToUpDown.TabIndex = 6;
            this.countToUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.countToUpDown.ValueChanged += new System.EventHandler(this.countToUpDown_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Count to";
            // 
            // jumpBetween
            // 
            this.jumpBetween.AutoSize = true;
            this.jumpBetween.Checked = true;
            this.jumpBetween.CheckState = System.Windows.Forms.CheckState.Checked;
            this.jumpBetween.Location = new System.Drawing.Point(13, 69);
            this.jumpBetween.Name = "jumpBetween";
            this.jumpBetween.Size = new System.Drawing.Size(138, 17);
            this.jumpBetween.TabIndex = 8;
            this.jumpBetween.Text = "Jump between numbers";
            this.jumpBetween.UseVisualStyleBackColor = true;
            this.jumpBetween.CheckedChanged += new System.EventHandler(this.jumpBetween_CheckedChanged);
            // 
            // openchatTextBox
            // 
            this.openchatTextBox.Location = new System.Drawing.Point(180, 36);
            this.openchatTextBox.Name = "openchatTextBox";
            this.openchatTextBox.Size = new System.Drawing.Size(22, 20);
            this.openchatTextBox.TabIndex = 9;
            this.openchatTextBox.Text = "/";
            this.openchatTextBox.TextChanged += new System.EventHandler(this.openchatTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Open chat key";
            // 
            // speedBar
            // 
            this.speedBar.LargeChange = 1;
            this.speedBar.Location = new System.Drawing.Point(13, 110);
            this.speedBar.Maximum = 100;
            this.speedBar.Minimum = 1;
            this.speedBar.Name = "speedBar";
            this.speedBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.speedBar.RightToLeftLayout = true;
            this.speedBar.Size = new System.Drawing.Size(272, 45);
            this.speedBar.TabIndex = 1;
            this.speedBar.TickFrequency = 5;
            this.speedBar.Value = 50;
            this.speedBar.ValueChanged += new System.EventHandler(this.speedBar_ValueChanged);
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Location = new System.Drawing.Point(19, 95);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(55, 13);
            this.speedLabel.TabIndex = 12;
            this.speedLabel.Text = "Delay (50)";
            // 
            // hellCapsCheckBox
            // 
            this.hellCapsCheckBox.AutoSize = true;
            this.hellCapsCheckBox.Location = new System.Drawing.Point(75, 20);
            this.hellCapsCheckBox.Name = "hellCapsCheckBox";
            this.hellCapsCheckBox.Size = new System.Drawing.Size(50, 17);
            this.hellCapsCheckBox.TabIndex = 13;
            this.hellCapsCheckBox.Text = "Caps";
            this.hellCapsCheckBox.UseVisualStyleBackColor = true;
            this.hellCapsCheckBox.CheckedChanged += new System.EventHandler(this.capsCheckBox_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(7, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 290);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.speedBar);
            this.groupBox5.Controls.Add(this.speedLabel);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.jumpBetween);
            this.groupBox5.Controls.Add(this.startFromUpDown);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.countToUpDown);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.openchatTextBox);
            this.groupBox5.Location = new System.Drawing.Point(9, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(299, 157);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Main";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.hyphenCheckBox);
            this.groupBox4.Controls.Add(this.fullstopCheckBox);
            this.groupBox4.Controls.Add(this.hellCapsCheckBox);
            this.groupBox4.Controls.Add(this.begincapitalCheckBox);
            this.groupBox4.Location = new System.Drawing.Point(9, 236);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(299, 47);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Grammar";
            // 
            // hyphenCheckBox
            // 
            this.hyphenCheckBox.AutoSize = true;
            this.hyphenCheckBox.Location = new System.Drawing.Point(9, 20);
            this.hyphenCheckBox.Name = "hyphenCheckBox";
            this.hyphenCheckBox.Size = new System.Drawing.Size(63, 17);
            this.hyphenCheckBox.TabIndex = 14;
            this.hyphenCheckBox.Text = "Hyphen";
            this.hyphenCheckBox.UseVisualStyleBackColor = true;
            this.hyphenCheckBox.CheckedChanged += new System.EventHandler(this.hyphenCheckBox_CheckedChanged);
            // 
            // fullstopCheckBox
            // 
            this.fullstopCheckBox.AutoSize = true;
            this.fullstopCheckBox.Location = new System.Drawing.Point(130, 20);
            this.fullstopCheckBox.Name = "fullstopCheckBox";
            this.fullstopCheckBox.Size = new System.Drawing.Size(65, 17);
            this.fullstopCheckBox.TabIndex = 15;
            this.fullstopCheckBox.Text = "Full stop";
            this.fullstopCheckBox.UseVisualStyleBackColor = true;
            this.fullstopCheckBox.CheckedChanged += new System.EventHandler(this.fullstopCheckBox_CheckedChanged);
            // 
            // begincapitalCheckBox
            // 
            this.begincapitalCheckBox.AutoSize = true;
            this.begincapitalCheckBox.Location = new System.Drawing.Point(201, 20);
            this.begincapitalCheckBox.Name = "begincapitalCheckBox";
            this.begincapitalCheckBox.Size = new System.Drawing.Size(87, 17);
            this.begincapitalCheckBox.TabIndex = 16;
            this.begincapitalCheckBox.Text = "Begin capital";
            this.begincapitalCheckBox.UseVisualStyleBackColor = true;
            this.begincapitalCheckBox.CheckedChanged += new System.EventHandler(this.begincapitalCheckBox_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numbermodeCheckBox);
            this.groupBox3.Controls.Add(this.hellCheckBox);
            this.groupBox3.Controls.Add(this.sanoinaCheckBox);
            this.groupBox3.Location = new System.Drawing.Point(9, 182);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(299, 48);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Modes";
            // 
            // testingGround
            // 
            this.testingGround.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testingGround.Location = new System.Drawing.Point(6, 19);
            this.testingGround.Name = "testingGround";
            this.testingGround.Size = new System.Drawing.Size(417, 311);
            this.testingGround.TabIndex = 15;
            this.testingGround.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.copytestingButton);
            this.groupBox2.Controls.Add(this.cleartestingButton);
            this.groupBox2.Controls.Add(this.testingGround);
            this.groupBox2.Location = new System.Drawing.Point(327, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(429, 362);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Testing ground";
            // 
            // copytestingButton
            // 
            this.copytestingButton.FlatAppearance.BorderSize = 0;
            this.copytestingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copytestingButton.Location = new System.Drawing.Point(307, 333);
            this.copytestingButton.Name = "copytestingButton";
            this.copytestingButton.Size = new System.Drawing.Size(55, 23);
            this.copytestingButton.TabIndex = 17;
            this.copytestingButton.Text = "Copy";
            this.copytestingButton.UseVisualStyleBackColor = true;
            this.copytestingButton.Click += new System.EventHandler(this.copytestingButton_Click);
            // 
            // cleartestingButton
            // 
            this.cleartestingButton.FlatAppearance.BorderSize = 0;
            this.cleartestingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cleartestingButton.Location = new System.Drawing.Point(368, 333);
            this.cleartestingButton.Name = "cleartestingButton";
            this.cleartestingButton.Size = new System.Drawing.Size(55, 23);
            this.cleartestingButton.TabIndex = 16;
            this.cleartestingButton.Text = "Clear";
            this.cleartestingButton.UseVisualStyleBackColor = true;
            this.cleartestingButton.Click += new System.EventHandler(this.cleartestingButton_Click);
            // 
            // openButton
            // 
            this.openButton.FlatAppearance.BorderSize = 0;
            this.openButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openButton.Location = new System.Drawing.Point(288, 11);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(33, 23);
            this.openButton.TabIndex = 17;
            this.openButton.Text = ">";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.currentNumber);
            this.groupBox6.Controls.Add(this.currentWait);
            this.groupBox6.Location = new System.Drawing.Point(7, 332);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(314, 66);
            this.groupBox6.TabIndex = 18;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Information";
            // 
            // currentNumber
            // 
            this.currentNumber.AutoSize = true;
            this.currentNumber.Location = new System.Drawing.Point(11, 41);
            this.currentNumber.Name = "currentNumber";
            this.currentNumber.Size = new System.Drawing.Size(111, 13);
            this.currentNumber.TabIndex = 1;
            this.currentNumber.Text = "Currently typing: None";
            // 
            // currentWait
            // 
            this.currentWait.AutoSize = true;
            this.currentWait.Location = new System.Drawing.Point(11, 21);
            this.currentWait.Name = "currentWait";
            this.currentWait.Size = new System.Drawing.Size(126, 13);
            this.currentWait.TabIndex = 0;
            this.currentWait.Text = "Current typing wait: None";
            // 
            // numbermodeCheckBox
            // 
            this.numbermodeCheckBox.AutoSize = true;
            this.numbermodeCheckBox.Checked = true;
            this.numbermodeCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.numbermodeCheckBox.Location = new System.Drawing.Point(9, 19);
            this.numbermodeCheckBox.Name = "numbermodeCheckBox";
            this.numbermodeCheckBox.Size = new System.Drawing.Size(68, 17);
            this.numbermodeCheckBox.TabIndex = 3;
            this.numbermodeCheckBox.Text = "Numbers";
            this.numbermodeCheckBox.UseVisualStyleBackColor = true;
            this.numbermodeCheckBox.CheckedChanged += new System.EventHandler(this.numbermodeCheckBox_CheckedChanged);
            // 
            // AutoJack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(328, 406);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tila);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AutoJack";
            this.ShowIcon = false;
            this.Text = "AutoJack";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.startFromUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countToUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedBar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox sanoinaCheckBox;
        private System.Windows.Forms.CheckBox hellCheckBox;
        private System.Windows.Forms.Label tila;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown startFromUpDown;
        private System.Windows.Forms.NumericUpDown countToUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox jumpBetween;
        private System.Windows.Forms.TextBox openchatTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar speedBar;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.CheckBox hellCapsCheckBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox hyphenCheckBox;
        private System.Windows.Forms.CheckBox begincapitalCheckBox;
        private System.Windows.Forms.CheckBox fullstopCheckBox;
        private System.Windows.Forms.RichTextBox testingGround;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cleartestingButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label currentWait;
        private System.Windows.Forms.Label currentNumber;
        private System.Windows.Forms.Button copytestingButton;
        private System.Windows.Forms.CheckBox numbermodeCheckBox;
    }
}

