namespace PokeNavEggs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.StartingFrame = new System.Windows.Forms.NumericUpDown();
            this.EndingFrame = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TargetFrame = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.PlusMinus = new System.Windows.Forms.NumericUpDown();
            this.PlusMinusButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.HasLightningRod = new System.Windows.Forms.CheckBox();
            this.CompatabilityCB = new System.Windows.Forms.ComboBox();
            this.Calibration = new System.Windows.Forms.NumericUpDown();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.TrainersButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TID = new System.Windows.Forms.NumericUpDown();
            this.SID = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Delay = new System.Windows.Forms.NumericUpDown();
            this.NatureCB = new System.Windows.Forms.ComboBox();
            this.ShinyCB = new System.Windows.Forms.ComboBox();
            this.AbilityCB = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.GenderRatioCB = new System.Windows.Forms.ComboBox();
            this.GenderCB = new System.Windows.Forms.ComboBox();
            this.Frame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EggRand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Call = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.StartingFrame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndingFrame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TargetFrame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlusMinus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Calibration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Delay)).BeginInit();
            this.SuspendLayout();
            // 
            // StartingFrame
            // 
            this.StartingFrame.Location = new System.Drawing.Point(101, 24);
            this.StartingFrame.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.StartingFrame.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.StartingFrame.Name = "StartingFrame";
            this.StartingFrame.Size = new System.Drawing.Size(105, 20);
            this.StartingFrame.TabIndex = 0;
            this.StartingFrame.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // EndingFrame
            // 
            this.EndingFrame.Location = new System.Drawing.Point(234, 24);
            this.EndingFrame.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.EndingFrame.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.EndingFrame.Name = "EndingFrame";
            this.EndingFrame.Size = new System.Drawing.Size(105, 20);
            this.EndingFrame.TabIndex = 1;
            this.EndingFrame.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "~";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Target Frame:";
            // 
            // TargetFrame
            // 
            this.TargetFrame.Location = new System.Drawing.Point(99, 50);
            this.TargetFrame.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.TargetFrame.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TargetFrame.Name = "TargetFrame";
            this.TargetFrame.Size = new System.Drawing.Size(89, 20);
            this.TargetFrame.TabIndex = 4;
            this.TargetFrame.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "±";
            // 
            // PlusMinus
            // 
            this.PlusMinus.Location = new System.Drawing.Point(220, 52);
            this.PlusMinus.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.PlusMinus.Name = "PlusMinus";
            this.PlusMinus.Size = new System.Drawing.Size(72, 20);
            this.PlusMinus.TabIndex = 6;
            this.PlusMinus.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // PlusMinusButton
            // 
            this.PlusMinusButton.Location = new System.Drawing.Point(298, 52);
            this.PlusMinusButton.Name = "PlusMinusButton";
            this.PlusMinusButton.Size = new System.Drawing.Size(25, 20);
            this.PlusMinusButton.TabIndex = 7;
            this.PlusMinusButton.Text = "↑";
            this.PlusMinusButton.UseVisualStyleBackColor = true;
            this.PlusMinusButton.Click += new System.EventHandler(this.PlusMinusButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(679, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Delay:";
            // 
            // HasLightningRod
            // 
            this.HasLightningRod.AutoSize = true;
            this.HasLightningRod.Location = new System.Drawing.Point(259, 79);
            this.HasLightningRod.Name = "HasLightningRod";
            this.HasLightningRod.Size = new System.Drawing.Size(15, 14);
            this.HasLightningRod.TabIndex = 9;
            this.HasLightningRod.UseVisualStyleBackColor = true;
            // 
            // CompatabilityCB
            // 
            this.CompatabilityCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CompatabilityCB.FormattingEnabled = true;
            this.CompatabilityCB.Items.AddRange(new object[] {
            "Don\'t like",
            "Like",
            "Like a lot"});
            this.CompatabilityCB.Location = new System.Drawing.Point(99, 102);
            this.CompatabilityCB.Name = "CompatabilityCB";
            this.CompatabilityCB.Size = new System.Drawing.Size(121, 21);
            this.CompatabilityCB.TabIndex = 10;
            this.CompatabilityCB.Tag = "Don\'t Like";
            // 
            // Calibration
            // 
            this.Calibration.Location = new System.Drawing.Point(99, 76);
            this.Calibration.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Calibration.Name = "Calibration";
            this.Calibration.Size = new System.Drawing.Size(71, 20);
            this.Calibration.TabIndex = 11;
            this.Calibration.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // GenerateButton
            // 
            this.GenerateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GenerateButton.Location = new System.Drawing.Point(553, 105);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(227, 21);
            this.GenerateButton.TabIndex = 12;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // TrainersButton
            // 
            this.TrainersButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TrainersButton.Location = new System.Drawing.Point(553, 78);
            this.TrainersButton.Name = "TrainersButton";
            this.TrainersButton.Size = new System.Drawing.Size(227, 21);
            this.TrainersButton.TabIndex = 13;
            this.TrainersButton.Text = "Trainers";
            this.TrainersButton.UseVisualStyleBackColor = true;
            this.TrainersButton.Click += new System.EventHandler(this.TrainersButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Calibration:";
            // 
            // TID
            // 
            this.TID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TID.Location = new System.Drawing.Point(455, 25);
            this.TID.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.TID.Name = "TID";
            this.TID.Size = new System.Drawing.Size(89, 20);
            this.TID.TabIndex = 15;
            // 
            // SID
            // 
            this.SID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SID.Location = new System.Drawing.Point(584, 24);
            this.SID.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.SID.Name = "SID";
            this.SID.Size = new System.Drawing.Size(89, 20);
            this.SID.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Frame,
            this.Index,
            this.EggRand,
            this.PID,
            this.Nature,
            this.Ability,
            this.Gender,
            this.Call});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(24, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(757, 335);
            this.dataGridView1.TabIndex = 22;
            // 
            // Delay
            // 
            this.Delay.Location = new System.Drawing.Point(722, 24);
            this.Delay.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.Delay.Name = "Delay";
            this.Delay.Size = new System.Drawing.Size(58, 20);
            this.Delay.TabIndex = 23;
            // 
            // NatureCB
            // 
            this.NatureCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NatureCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NatureCB.FormattingEnabled = true;
            this.NatureCB.Items.AddRange(new object[] {
            "Any",
            "Hardy",
            "Lonely",
            "Brave",
            "Adamant",
            "Naughty",
            "Bold",
            "Docile",
            "Relaxed",
            "Impish",
            "Lax",
            "Timid",
            "Hasty",
            "Serious",
            "Jolly",
            "Naive",
            "Modest",
            "Mild",
            "Quiet",
            "Bashful",
            "Rash",
            "Calm",
            "Gentle",
            "Sassy",
            "Careful",
            "Quirky"});
            this.NatureCB.Location = new System.Drawing.Point(455, 78);
            this.NatureCB.Name = "NatureCB";
            this.NatureCB.Size = new System.Drawing.Size(89, 21);
            this.NatureCB.TabIndex = 24;
            this.NatureCB.Tag = "Any";
            // 
            // ShinyCB
            // 
            this.ShinyCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ShinyCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ShinyCB.FormattingEnabled = true;
            this.ShinyCB.Items.AddRange(new object[] {
            "Any",
            "Star",
            "Square",
            "Star/Square"});
            this.ShinyCB.Location = new System.Drawing.Point(455, 105);
            this.ShinyCB.Name = "ShinyCB";
            this.ShinyCB.Size = new System.Drawing.Size(89, 21);
            this.ShinyCB.TabIndex = 25;
            this.ShinyCB.Tag = "Any";
            // 
            // AbilityCB
            // 
            this.AbilityCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AbilityCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AbilityCB.FormattingEnabled = true;
            this.AbilityCB.Items.AddRange(new object[] {
            "Any",
            "1",
            "2"});
            this.AbilityCB.Location = new System.Drawing.Point(455, 51);
            this.AbilityCB.Name = "AbilityCB";
            this.AbilityCB.Size = new System.Drawing.Size(89, 21);
            this.AbilityCB.TabIndex = 26;
            this.AbilityCB.Tag = "Any";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(413, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Shiny:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(412, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Ability:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(407, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Nature:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Frame Range:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(174, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Lightning Rod?";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 105);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "Compatability:";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(421, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 13);
            this.label12.TabIndex = 36;
            this.label12.Text = "TID:";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(550, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 13);
            this.label13.TabIndex = 37;
            this.label13.Text = "SID:";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(550, 54);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 13);
            this.label14.TabIndex = 39;
            this.label14.Text = "Gender:";
            // 
            // GenderRatioCB
            // 
            this.GenderRatioCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GenderRatioCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenderRatioCB.FormattingEnabled = true;
            this.GenderRatioCB.Items.AddRange(new object[] {
            "Genderless",
            "50% ♂ / 50% ♀",
            "25% ♂ / 75% ♀",
            "75% ♂ / 25% ♀",
            "87.5% ♂ / 12.5% ♀",
            "100% ♂",
            "100% ♀"});
            this.GenderRatioCB.Location = new System.Drawing.Point(598, 50);
            this.GenderRatioCB.Name = "GenderRatioCB";
            this.GenderRatioCB.Size = new System.Drawing.Size(130, 21);
            this.GenderRatioCB.TabIndex = 38;
            this.GenderRatioCB.Tag = "Any";
            // 
            // GenderCB
            // 
            this.GenderCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GenderCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenderCB.FormattingEnabled = true;
            this.GenderCB.Items.AddRange(new object[] {
            "Any",
            "♂",
            "♀"});
            this.GenderCB.Location = new System.Drawing.Point(734, 50);
            this.GenderCB.Name = "GenderCB";
            this.GenderCB.Size = new System.Drawing.Size(46, 21);
            this.GenderCB.TabIndex = 40;
            this.GenderCB.Tag = "Any";
            // 
            // Frame
            // 
            this.Frame.HeaderText = "Frame";
            this.Frame.Name = "Frame";
            this.Frame.Width = 105;
            // 
            // Index
            // 
            this.Index.HeaderText = "Index";
            this.Index.Name = "Index";
            this.Index.Width = 60;
            // 
            // EggRand
            // 
            this.EggRand.HeaderText = "Egg Rand";
            this.EggRand.Name = "EggRand";
            this.EggRand.Width = 80;
            // 
            // PID
            // 
            this.PID.HeaderText = "PID";
            this.PID.Name = "PID";
            this.PID.Width = 90;
            // 
            // Nature
            // 
            this.Nature.HeaderText = "Nature";
            this.Nature.Name = "Nature";
            this.Nature.Width = 70;
            // 
            // Ability
            // 
            this.Ability.HeaderText = "Ability";
            this.Ability.Name = "Ability";
            this.Ability.Width = 70;
            // 
            // Gender
            // 
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            this.Gender.Width = 70;
            // 
            // Call
            // 
            this.Call.HeaderText = "Call";
            this.Call.Name = "Call";
            this.Call.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 514);
            this.Controls.Add(this.GenderCB);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.GenderRatioCB);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AbilityCB);
            this.Controls.Add(this.ShinyCB);
            this.Controls.Add(this.NatureCB);
            this.Controls.Add(this.Delay);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SID);
            this.Controls.Add(this.TID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TrainersButton);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.Calibration);
            this.Controls.Add(this.CompatabilityCB);
            this.Controls.Add(this.HasLightningRod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PlusMinusButton);
            this.Controls.Add(this.PlusMinus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TargetFrame);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EndingFrame);
            this.Controls.Add(this.StartingFrame);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "PokeNav Egg Tool";
            ((System.ComponentModel.ISupportInitialize)(this.StartingFrame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndingFrame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TargetFrame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlusMinus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Calibration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Delay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown StartingFrame;
        private System.Windows.Forms.NumericUpDown EndingFrame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown TargetFrame;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown PlusMinus;
        private System.Windows.Forms.Button PlusMinusButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox HasLightningRod;
        private System.Windows.Forms.ComboBox CompatabilityCB;
        private System.Windows.Forms.NumericUpDown Calibration;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.Button TrainersButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown TID;
        private System.Windows.Forms.NumericUpDown SID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.NumericUpDown Delay;
        private System.Windows.Forms.ComboBox NatureCB;
        private System.Windows.Forms.ComboBox ShinyCB;
        private System.Windows.Forms.ComboBox AbilityCB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox GenderRatioCB;
        private System.Windows.Forms.ComboBox GenderCB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frame;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn EggRand;
        private System.Windows.Forms.DataGridViewTextBoxColumn PID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nature;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ability;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Call;
    }
}

