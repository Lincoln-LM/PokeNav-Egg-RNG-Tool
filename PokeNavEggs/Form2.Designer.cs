namespace PokeNavEggs
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.SelectButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.checkedListBox1.Location = new System.Drawing.Point(12, 12);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(235, 424);
            this.checkedListBox1.TabIndex = 0;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SubmitButton.Location = new System.Drawing.Point(12, 478);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(235, 32);
            this.SubmitButton.TabIndex = 1;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // SelectButton
            // 
            this.SelectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SelectButton.Location = new System.Drawing.Point(12, 440);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(115, 32);
            this.SelectButton.TabIndex = 2;
            this.SelectButton.Text = "Select All";
            this.SelectButton.UseVisualStyleBackColor = true;
            this.SelectButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearButton.Location = new System.Drawing.Point(132, 440);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(115, 32);
            this.ClearButton.TabIndex = 3;
            this.ClearButton.Text = "Clear All";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 522);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.checkedListBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Trainers";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.Button ClearButton;
    }
}