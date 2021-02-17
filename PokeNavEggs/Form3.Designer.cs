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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SID = new System.Windows.Forms.NumericUpDown();
            this.TID = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.HasLightningRod = new System.Windows.Forms.CheckBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SelectButton = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IsRoaming = new System.Windows.Forms.CheckBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TID)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 71);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 13);
            this.label13.TabIndex = 41;
            this.label13.Text = "SID:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 13);
            this.label12.TabIndex = 40;
            this.label12.Text = "TID:";
            // 
            // SID
            // 
            this.SID.Location = new System.Drawing.Point(52, 68);
            this.SID.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.SID.Name = "SID";
            this.SID.Size = new System.Drawing.Size(89, 20);
            this.SID.TabIndex = 38;
            // 
            // TID
            // 
            this.TID.Location = new System.Drawing.Point(52, 42);
            this.TID.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.TID.Name = "TID";
            this.TID.Size = new System.Drawing.Size(89, 20);
            this.TID.TabIndex = 39;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(147, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 43;
            this.label10.Text = "Lightning Rod?";
            // 
            // HasLightningRod
            // 
            this.HasLightningRod.AutoSize = true;
            this.HasLightningRod.Location = new System.Drawing.Point(244, 44);
            this.HasLightningRod.Name = "HasLightningRod";
            this.HasLightningRod.Size = new System.Drawing.Size(15, 14);
            this.HasLightningRod.TabIndex = 42;
            this.HasLightningRod.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(144, 479);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(115, 32);
            this.ClearButton.TabIndex = 46;
            this.ClearButton.Text = "Clear All";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // SelectButton
            // 
            this.SelectButton.Location = new System.Drawing.Point(18, 479);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(115, 32);
            this.SelectButton.TabIndex = 45;
            this.SelectButton.Text = "Select All";
            this.SelectButton.UseVisualStyleBackColor = true;
            this.SelectButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Aroma Lady Rose",
            "Ruin Maniac Andres",
            "Ruin Maniac Dusty",
            "Tuber Lola\t",
            "Tuber Ricky",
            "Sis and Bro Lila & Roy",
            "Cool Trainer Cristin",
            "Cool Trainer Brooke",
            "Cool Trainer Wilton",
            "Hex Maniac Valerie",
            "Lady Cindy",
            "Beauty Thalia",
            "Beauty Jessica",
            "Rich Boy Winston",
            "Pokemaniac Steve",
            "Swimmer Tony",
            "Black Belt Nob",
            "Black Belt Koji",
            "Guitarist Fernando",
            "Guitarist Dalton",
            "Kindler Bernie",
            "Camper Ethan",
            "Old Couple John & Jay",
            "Bug Maniac Jeffrey",
            "Psychic Cameron",
            "Psychic Jacki",
            "Gentleman Walter",
            "School Kid Karen",
            "School Kid Jerry",
            "Sr. and Jr. Anna & Meg",
            "Pokefan Isabel",
            "Pokefan Miguel",
            "Expert Timothy",
            "Expert Shelby",
            "Youngster Calvin",
            "Fisherman Elliot",
            "Triathlete Isaiah",
            "Triathlete Maria",
            "Triathlete Abigail",
            "Triathlete Dylan",
            "Triathlete Katelyn",
            "Triathlete Benjamin",
            "Triathlete Pablo",
            "Dragon Tamer Nicolas",
            "Bird Keeper Robert",
            "Ninja Boy Lao",
            "Battle Girl Cyndy",
            "Parasol Lady Madeline",
            "Swimmer Jenny",
            "Picknicker Diana",
            "Twins Amy & Liv",
            "Sailor Ernest",
            "Sailor Cory",
            "Collector Edwin",
            "PKMN Breeder Lydia",
            "PKMN Breeder Isaac",
            "PKMN Breeder Gabrielle",
            "PKMN Ranger Catherine",
            "PKMN Ranger Jackson",
            "Lass Haley\t",
            "Bug Catcher James",
            "Hiker Trent",
            "Hiker Sawyer",
            "Young Couple Kira & Dan"});
            this.checkedListBox1.Location = new System.Drawing.Point(18, 94);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(241, 379);
            this.checkedListBox1.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Lati@s Roaming?";
            // 
            // IsRoaming
            // 
            this.IsRoaming.AutoSize = true;
            this.IsRoaming.Location = new System.Drawing.Point(244, 70);
            this.IsRoaming.Name = "IsRoaming";
            this.IsRoaming.Size = new System.Drawing.Size(15, 14);
            this.IsRoaming.TabIndex = 47;
            this.IsRoaming.UseVisualStyleBackColor = true;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(94, 18);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(165, 20);
            this.NameTextBox.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Profile Name:";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(18, 517);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(241, 32);
            this.SubmitButton.TabIndex = 51;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 561);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IsRoaming);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.HasLightningRod);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.SID);
            this.Controls.Add(this.TID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(295, 600);
            this.MinimumSize = new System.Drawing.Size(295, 600);
            this.Name = "Form3";
            this.Text = "Profile Manager";
            ((System.ComponentModel.ISupportInitialize)(this.SID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown SID;
        private System.Windows.Forms.NumericUpDown TID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox HasLightningRod;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox IsRoaming;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SubmitButton;
    }
}