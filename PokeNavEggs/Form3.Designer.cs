namespace PokeNavEggs
{
    partial class Form3
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
            this.GenderCB = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.GenderRatioCB = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AbilityCB = new System.Windows.Forms.ComboBox();
            this.ShinyCB = new System.Windows.Forms.ComboBox();
            this.NatureCB = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Frame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EggRand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Call = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SID = new System.Windows.Forms.NumericUpDown();
            this.TID = new System.Windows.Forms.NumericUpDown();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.CompatabilityCB = new System.Windows.Forms.ComboBox();
            this.HasLightningRod = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EndingFrame = new System.Windows.Forms.NumericUpDown();
            this.StartingFrame = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.Progress = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndingFrame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartingFrame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
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
            this.GenderCB.Location = new System.Drawing.Point(729, 51);
            this.GenderCB.Name = "GenderCB";
            this.GenderCB.Size = new System.Drawing.Size(46, 21);
            this.GenderCB.TabIndex = 73;
            this.GenderCB.Tag = "Any";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(545, 55);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 13);
            this.label14.TabIndex = 72;
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
            this.GenderRatioCB.Location = new System.Drawing.Point(593, 51);
            this.GenderRatioCB.Name = "GenderRatioCB";
            this.GenderRatioCB.Size = new System.Drawing.Size(130, 21);
            this.GenderRatioCB.TabIndex = 71;
            this.GenderRatioCB.Tag = "Any";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(545, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 13);
            this.label13.TabIndex = 70;
            this.label13.Text = "SID:";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(416, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 13);
            this.label12.TabIndex = 69;
            this.label12.Text = "TID:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 68;
            this.label11.Text = "Compatability:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(250, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 67;
            this.label10.Text = "Lightning Rod?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 66;
            this.label6.Text = "Frame Range:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(402, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 65;
            this.label9.Text = "Nature:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(407, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 64;
            this.label8.Text = "Ability:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(408, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 63;
            this.label7.Text = "Shiny:";
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
            this.AbilityCB.Location = new System.Drawing.Point(450, 51);
            this.AbilityCB.Name = "AbilityCB";
            this.AbilityCB.Size = new System.Drawing.Size(89, 21);
            this.AbilityCB.TabIndex = 62;
            this.AbilityCB.Tag = "Any";
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
            this.ShinyCB.Location = new System.Drawing.Point(450, 105);
            this.ShinyCB.Name = "ShinyCB";
            this.ShinyCB.Size = new System.Drawing.Size(89, 21);
            this.ShinyCB.TabIndex = 61;
            this.ShinyCB.Tag = "Any";
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
            this.NatureCB.Location = new System.Drawing.Point(450, 78);
            this.NatureCB.Name = "NatureCB";
            this.NatureCB.Size = new System.Drawing.Size(89, 21);
            this.NatureCB.TabIndex = 60;
            this.NatureCB.Tag = "Any";
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
            this.dataGridView1.Location = new System.Drawing.Point(25, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(757, 302);
            this.dataGridView1.TabIndex = 58;
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
            // SID
            // 
            this.SID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SID.Location = new System.Drawing.Point(593, 23);
            this.SID.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.SID.Name = "SID";
            this.SID.Size = new System.Drawing.Size(89, 20);
            this.SID.TabIndex = 57;
            // 
            // TID
            // 
            this.TID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TID.Location = new System.Drawing.Point(450, 25);
            this.TID.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.TID.Name = "TID";
            this.TID.Size = new System.Drawing.Size(89, 20);
            this.TID.TabIndex = 56;
            // 
            // GenerateButton
            // 
            this.GenerateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GenerateButton.Location = new System.Drawing.Point(25, 105);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(227, 21);
            this.GenerateButton.TabIndex = 53;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            // 
            // CompatabilityCB
            // 
            this.CompatabilityCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CompatabilityCB.FormattingEnabled = true;
            this.CompatabilityCB.Items.AddRange(new object[] {
            "Don\'t like",
            "Like",
            "Like a lot"});
            this.CompatabilityCB.Location = new System.Drawing.Point(120, 78);
            this.CompatabilityCB.Name = "CompatabilityCB";
            this.CompatabilityCB.Size = new System.Drawing.Size(121, 21);
            this.CompatabilityCB.TabIndex = 51;
            this.CompatabilityCB.Tag = "Don\'t Like";
            // 
            // HasLightningRod
            // 
            this.HasLightningRod.AutoSize = true;
            this.HasLightningRod.Location = new System.Drawing.Point(335, 80);
            this.HasLightningRod.Name = "HasLightningRod";
            this.HasLightningRod.Size = new System.Drawing.Size(15, 14);
            this.HasLightningRod.TabIndex = 50;
            this.HasLightningRod.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(231, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 43;
            this.label1.Text = "~";
            // 
            // EndingFrame
            // 
            this.EndingFrame.Location = new System.Drawing.Point(253, 26);
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
            this.EndingFrame.TabIndex = 42;
            this.EndingFrame.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // StartingFrame
            // 
            this.StartingFrame.Location = new System.Drawing.Point(120, 26);
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
            this.StartingFrame.TabIndex = 41;
            this.StartingFrame.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 77;
            this.label2.Text = "Calibration Range:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(231, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 17);
            this.label3.TabIndex = 76;
            this.label3.Text = "~";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(253, 52);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(105, 20);
            this.numericUpDown1.TabIndex = 75;
            this.numericUpDown1.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(120, 52);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(105, 20);
            this.numericUpDown2.TabIndex = 74;
            // 
            // Progress
            // 
            this.Progress.Location = new System.Drawing.Point(25, 144);
            this.Progress.Name = "Progress";
            this.Progress.Size = new System.Drawing.Size(756, 23);
            this.Progress.TabIndex = 78;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 514);
            this.Controls.Add(this.Progress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.numericUpDown2);
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
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SID);
            this.Controls.Add(this.TID);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.CompatabilityCB);
            this.Controls.Add(this.HasLightningRod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EndingFrame);
            this.Controls.Add(this.StartingFrame);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndingFrame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartingFrame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox GenderCB;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox GenderRatioCB;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox AbilityCB;
        private System.Windows.Forms.ComboBox ShinyCB;
        private System.Windows.Forms.ComboBox NatureCB;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frame;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn EggRand;
        private System.Windows.Forms.DataGridViewTextBoxColumn PID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nature;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ability;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Call;
        private System.Windows.Forms.NumericUpDown SID;
        private System.Windows.Forms.NumericUpDown TID;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.ComboBox CompatabilityCB;
        private System.Windows.Forms.CheckBox HasLightningRod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown EndingFrame;
        private System.Windows.Forms.NumericUpDown StartingFrame;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.ProgressBar Progress;
    }
}