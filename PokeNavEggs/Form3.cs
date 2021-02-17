using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace PokeNavEggs
{
    public partial class Form3 : Form
    {
        public List<Profile> Profiles = new List<Profile>() { };
        public Profile profile;
        public bool editMode = false;

        public Form3(Profile profileInput=null)
        {
            InitializeComponent();
            if (profileInput == null)
            {
                profile = new Profile();
            }
            else
            {
                editMode = true;
                profile = profileInput;
                NameTextBox.Text = profile.Name;
                TID.Value = profile.TID;
                SID.Value = profile.SID;
                HasLightningRod.Checked = profile.HasLightningRod;
                IsRoaming.Checked = profile.IsRoaming;
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    if (profile.TrainersChecked.Contains(i))
                    {
                        checkedListBox1.SetItemChecked(i, true);
                    }
                }
            }
            using (var sr = new StreamReader("./profiles.xml"))
            {
                XmlSerializer xs = new XmlSerializer(typeof(List<Profile>));
                Profiles = (List<Profile>)xs.Deserialize(sr);
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            profile.Name = NameTextBox.Text;
            profile.TID = (uint)TID.Value;
            profile.SID = (uint)SID.Value;
            profile.HasLightningRod = HasLightningRod.Checked;
            profile.IsRoaming = IsRoaming.Checked;
            profile.Trainers = new List<string>() { };
            profile.TrainersChecked = new List<int>() { };
            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                profile.Trainers.Add(checkedListBox1.CheckedItems[i].ToString());
                profile.TrainersChecked.Add(i);
            }
            if (checkedListBox1.CheckedItems.Count < 1)
            {
                MessageBox.Show("Please select at least one trainer.");
                return;
            }
            if (NameTextBox.Text.Length < 1)
            {
                MessageBox.Show("Please enter a profile name.");
                return;
            }
            if (!editMode)
            {
                for (int i = 0; i < Profiles.Count; i++)
                {
                    if (Profiles[i].Name == NameTextBox.Text)
                    {
                        MessageBox.Show("Please enter a unique profile name.");
                        return;
                    }
                }
            }
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < checkedListBox1.Items.Count; x++)
            {
                checkedListBox1.SetItemCheckState(x, CheckState.Checked);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < checkedListBox1.Items.Count; x++)
            {
                checkedListBox1.SetItemCheckState(x, CheckState.Unchecked);
            }
        }
    }
}
