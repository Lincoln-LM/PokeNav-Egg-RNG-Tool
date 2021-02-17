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
    public partial class Form2 : Form
    {
        public List<Profile> Profiles = new List<Profile>() { };
        public Form2()
        {
            InitializeComponent();
            using (var sr = new StreamReader("./profiles.xml"))
            {

                XmlSerializer xs = new XmlSerializer(typeof(List<Profile>));
                Profiles = (List<Profile>)xs.Deserialize(sr);
                for (int i = 0; i < Profiles.Count; i++)
                {
                    dataGridView1.Rows.Add(Profiles[i].Name, Profiles[i].TID, Profiles[i].SID, Profiles[i].HasLightningRod, Profiles[i].IsRoaming, Profiles[i].Trainers.Count);
                }
            }
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Profile>));

            var path = "./profiles.xml";
            FileStream file = File.Create(path);

            xs.Serialize(file, Profiles);
            file.Close();
            Close();
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            var formPopup = new Form3(null);
            formPopup.ShowDialog();
            Profile profile = formPopup.profile;
            Profiles.Add(profile);

            dataGridView1.Rows.Add(profile.Name, profile.TID, profile.SID, profile.HasLightningRod, profile.IsRoaming, profile.Trainers.Count);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            var a = dataGridView1.SelectedCells;
            if (a.Count > 1)
            {
                MessageBox.Show("Please only select one cell in the row of the profile.");
            }
            else if (a.Count == 0)
            {
                MessageBox.Show("Please select a cell in the row of the profile.");
            }
            else
            {
                int index = a[0].RowIndex;
                var formPopup = new Form3(Profiles[index]);
                formPopup.ShowDialog();
                Profile profile = formPopup.profile;
                Profiles[index] = profile;
                dataGridView1.Rows.Clear();
                for (int i = 0; i < Profiles.Count; i++)
                {
                    dataGridView1.Rows.Add(Profiles[i].Name, Profiles[i].TID, Profiles[i].SID, Profiles[i].HasLightningRod, Profiles[i].IsRoaming, Profiles[i].Trainers.Count);
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var a = dataGridView1.SelectedCells;
            if (a.Count > 1)
            {
                MessageBox.Show("Please only select one cell in the row of the profile.");
            }
            else if (a.Count == 0)
            {
                MessageBox.Show("Please select a cell in the row of the profile.");
            }
            else
            {
                if (Profiles.Count < 2)
                {
                    MessageBox.Show("You cannot delete your last profile.");
                    return;
                }
                int index = a[0].RowIndex;
                Profiles.Remove(Profiles[index]);
                dataGridView1.Rows.Clear();
                for (int i = 0; i < Profiles.Count; i++)
                {
                    dataGridView1.Rows.Add(Profiles[i].Name, Profiles[i].TID, Profiles[i].SID, Profiles[i].HasLightningRod, Profiles[i].IsRoaming, Profiles[i].Trainers.Count);
                }
            }
        }
    }
}
