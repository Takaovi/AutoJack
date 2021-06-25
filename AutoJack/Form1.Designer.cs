namespace AutoJack
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
            ((System.ComponentModel.ISupportInitialize)(this.startFromUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countToUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedBar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sanoinaCheckBox
            // 
            this.sanoinaCheckBox.AutoSize = true;
            this.sanoinaCheckBox.Location = new System.Drawing.Point(9, 122);
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
            this.hellCheckBox.Location = new System.Drawing.Point(9, 145);
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
            this.tila.Location = new System.Drawing.Point(16, 22);
            this.tila.Name = "tila";
            this.tila.Size = new System.Drawing.Size(117, 16);
            this.tila.TabIndex = 3;
            this.tila.Text = "Ready to start (F8)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Start from";
            // 
            // startFromUpDown
            // 
            this.startFromUpDown.Location = new System.Drawing.Point(9, 32);
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
            this.startFromUpDown.Size = new System.Drawing.Size(93, 20);
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
            this.countToUpDown.Location = new System.Drawing.Point(124, 32);
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
            this.countToUpDown.Size = new System.Drawing.Size(93, 20);
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
            this.label2.Location = new System.Drawing.Point(121, 16);
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
            this.jumpBetween.Location = new System.Drawing.Point(9, 99);
            this.jumpBetween.Name = "jumpBetween";
            this.jumpBetween.Size = new System.Drawing.Size(95, 17);
            this.jumpBetween.TabIndex = 8;
            this.jumpBetween.Text = "Jump between";
            this.jumpBetween.UseVisualStyleBackColor = true;
            this.jumpBetween.CheckedChanged += new System.EventHandler(this.jumpBetween_CheckedChanged);
            // 
            // openchatTextBox
            // 
            this.openchatTextBox.Location = new System.Drawing.Point(9, 70);
            this.openchatTextBox.Name = "openchatTextBox";
            this.openchatTextBox.Size = new System.Drawing.Size(22, 20);
            this.openchatTextBox.TabIndex = 9;
            this.openchatTextBox.Text = "/";
            this.openchatTextBox.TextChanged += new System.EventHandler(this.openchatTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Open chat key";
            // 
            // speedBar
            // 
            this.speedBar.LargeChange = 1;
            this.speedBar.Location = new System.Drawing.Point(124, 99);
            this.speedBar.Maximum = 100;
            this.speedBar.Minimum = 1;
            this.speedBar.Name = "speedBar";
            this.speedBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.speedBar.RightToLeftLayout = true;
            this.speedBar.Size = new System.Drawing.Size(93, 45);
            this.speedBar.TabIndex = 1;
            this.speedBar.TickFrequency = 0;
            this.speedBar.Value = 50;
            this.speedBar.ValueChanged += new System.EventHandler(this.speedBar_ValueChanged);
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Location = new System.Drawing.Point(121, 75);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(55, 13);
            this.speedLabel.TabIndex = 12;
            this.speedLabel.Text = "Delay (50)";
            // 
            // hellCapsCheckBox
            // 
            this.hellCapsCheckBox.AutoSize = true;
            this.hellCapsCheckBox.Checked = true;
            this.hellCapsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hellCapsCheckBox.Location = new System.Drawing.Point(29, 168);
            this.hellCapsCheckBox.Name = "hellCapsCheckBox";
            this.hellCapsCheckBox.Size = new System.Drawing.Size(70, 17);
            this.hellCapsCheckBox.TabIndex = 13;
            this.hellCapsCheckBox.Text = "Hell caps";
            this.hellCapsCheckBox.UseVisualStyleBackColor = true;
            this.hellCapsCheckBox.CheckedChanged += new System.EventHandler(this.hellCapsCheckBox_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.sanoinaCheckBox);
            this.groupBox1.Controls.Add(this.hellCapsCheckBox);
            this.groupBox1.Controls.Add(this.hellCheckBox);
            this.groupBox1.Controls.Add(this.speedLabel);
            this.groupBox1.Controls.Add(this.startFromUpDown);
            this.groupBox1.Controls.Add(this.speedBar);
            this.groupBox1.Controls.Add(this.countToUpDown);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.openchatTextBox);
            this.groupBox1.Controls.Add(this.jumpBetween);
            this.groupBox1.Location = new System.Drawing.Point(12, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 198);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(246, 267);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tila);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "AutoJack";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.startFromUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countToUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedBar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
    }
}

