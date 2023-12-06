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
    public partial class Form1 : Form
    {
        public Profile Default = new Profile();
        public List<Profile> Profiles = new List<Profile>() { };
        public List<string> natures = new List<string> {
                "Hardy","Lonely","Brave","Adamant","Naughty",
                "Bold","Docile","Relaxed","Impish","Lax",
                "Timid","Hasty","Serious","Jolly","Naive",
                "Modest","Mild","Quiet","Bashful","Rash",
                "Calm","Gentle","Sassy","Careful","Quirky"};
        public Dictionary<string, Color> shinyColor = new Dictionary<string, Color> { { "No", Color.White }, { "Star", ColorTranslator.FromHtml("#FFD700") }, { "Square", Color.Orange } };
        public List<uint> ratios = new List<uint> { 255, 127, 192, 63, 31, 0, 254 };

        public Form1()
        {
            InitializeComponent();

            ShinyCB.Text = "Any";
            NatureCB.Text = "Any";
            AbilityCB.Text = "Any";
            GenderCB.Text = "Any";
            GenderRatioCB.Text = "Genderless";
            CompatabilityCB.Text = "Don't Like";

            try
            {
                using (var sr = new StreamReader("./profiles.xml"))
                {
                    XmlSerializer xs = new XmlSerializer(typeof(List<Profile>));
                    Profiles = (List<Profile>)xs.Deserialize(sr);
                }

                Profiles.Add(Default);
                Profiles.Remove(Profiles[Profiles.Count - 1]);
            } catch
            {
                Default.TID = 12345;
                Default.SID = 54321;
                Default.HasLightningRod = true;
                Default.IsRoaming = false;
                Default.TrainersChecked = new List<int>() { };
                Default.Trainers = new List<string>() { "Call" };
                Default.Name = "Default";

                Profiles = new List<Profile>() { Default };
                XmlSerializer xs = new XmlSerializer(typeof(List<Profile>));

                var path = "./profiles.xml";
                FileStream file = File.Create(path);

                xs.Serialize(file, Profiles);
                file.Close();
            }

            ProfileCB.Items.Clear();

            for (int i = 0; i < Profiles.Count; i++)
            {
                ProfileCB.Items.Add(Profiles[i].Name + " - " + Profiles[i].TID.ToString() + "/" + Profiles[i].SID.ToString());
            }

            ProfileCB.SelectedIndex = 0;

            if (Profiles[0].IsRoaming)
            {
                Calibration.Value = 21;
            }
            else
            {
                Calibration.Value = 20;
            }
        }

        public string GetGender(uint gender, uint ratio)
        {
            if (ratio == 255)
            {
                return "○";
            } else if (ratio == 254)
            {
                return "♀";
            } else if (ratio == 0)
            {
                return "♂";
            } else
            {
                return gender > ratio ? "♂" : "♀";
            }
        }

        private State Generate(uint frame, uint targetFrame, PokeRNG baserng, bool hasLightningRod, uint compatability, uint genderRatio, uint tid, uint sid, List<string> trainerlist)
        {
            State result = new State
            {
                Index = (int)frame - (int)targetFrame,
                PID = "---",
                Nature = "---",
                Ability = "---",
                Gender = "---",
                Call = "No Call",
                Shiny = "No",
                Frame = frame,
            };

            uint txor = tid ^ sid;
            PokeRNG rng = new PokeRNG(baserng.seed);
            result.EggRand = rng.nextUShort() * 100 >> 16;

            if (compatability > result.EggRand)
            {
                PokeRNG rng2 = new PokeRNG(frame & 0xFFFF);
                uint low = (rng.nextUShort() % 0xFFFE) + 1;
                uint high = rng2.nextUShort();
                uint pid = (high << 16) | low;
                uint pxor = low ^ high;
                result.Shiny = pxor / 8 == txor / 8 ? pxor == txor ? "Square" : "Star" : "No";

                result.PID = pid.ToString("X");
                result.Nature = natures[(int)(pid%25)];
                result.Ability = ((pid & 1) + 1).ToString();
                result.Gender = GetGender(pid & 255, genderRatio).ToString();
            }

            if ((rng.nextUShort() % 10) < (hasLightningRod ? 6 : 3))
            {
                result.Call = trainerlist[(int)(rng.nextUShort() % trainerlist.Count)];
            }

            return result;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            Profile selectedProfile = Profiles[ProfileCB.SelectedIndex];
            uint startingFrame = (uint)StartingFrame.Value;
            uint lastFrame = (uint)EndingFrame.Value;
            uint targetFrame = (uint)TargetFrame.Value;
            uint calibration = (uint)Calibration.Value;
            uint delay = (uint)Delay.Value;
            uint tid = selectedProfile.TID;
            uint sid = selectedProfile.SID;
            uint compatability = (uint)(CompatabilityCB.SelectedIndex == 0 ? 20 : CompatabilityCB.SelectedIndex == 1 ? 50 : 70);
            uint genderRatio = ratios[GenderRatioCB.SelectedIndex];

            PokeRNG rng = new PokeRNG(0);
            rng.advance(startingFrame + calibration + delay);
            startingFrame += delay;
            lastFrame += delay;

            for (uint frame = startingFrame; frame <= lastFrame; frame++)
            {
                State state = Generate(frame, targetFrame+delay+delay, rng, selectedProfile.HasLightningRod, compatability, genderRatio, tid, sid, selectedProfile.Trainers);

                bool flag = true;
                if (AbilityCB.Text != "Any" & AbilityCB.Text != state.Ability)
                {
                    flag = false;
                }
                if (NatureCB.Text != "Any" & NatureCB.Text != state.Nature)
                {
                    flag = false;
                }
                if (ShinyCB.Text != "Any" & ShinyCB.Text != state.Shiny & !(ShinyCB.Text == "Star/Square" & state.Shiny != "No"))
                {
                    flag = false;
                }
                if (GenderCB.Text != "Any" & GenderCB.Text != state.Gender)
                {
                    flag = false;
                }
                if (flag)
                {
                    int row = dataGridView1.Rows.Add(state.Frame-delay, state.Index+delay, state.EggRand, state.PID, state.Nature, state.Ability, state.Gender, state.Call);
                    dataGridView1.Rows[row].DefaultCellStyle.BackColor = shinyColor[state.Shiny];
                }

                rng.nextUInt();
            }
        }

        private void PlusMinusButton_Click(object sender, EventArgs e)
        {
            decimal min = TargetFrame.Value - PlusMinus.Value;
            decimal max = TargetFrame.Value + PlusMinus.Value;
            min = min <= 0 ? 1 : min;
            max = max <= 0 ? 1 : max;
            StartingFrame.Value = min;
            EndingFrame.Value = max;
        }

        private void ProfilesButton_Click(object sender, EventArgs e)
        {
            var formPopup = new Form2();
            formPopup.ShowDialog();

            using (var sr = new StreamReader("./profiles.xml"))
            {
                XmlSerializer xs = new XmlSerializer(typeof(List<Profile>));
                Profiles = (List<Profile>)xs.Deserialize(sr);
            }

            ProfileCB.Items.Clear();

            for (int i = 0; i < Profiles.Count; i++)
            {
                ProfileCB.Items.Add(Profiles[i].Name + " - " + Profiles[i].TID.ToString() + "/" + Profiles[i].SID.ToString());
            }

            ProfileCB.SelectedIndex = 0;

            if (Profiles[0].IsRoaming)
            {
                Calibration.Value = 21;
            }
        }

        private void datagrive_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex != -1 && e.RowIndex != -1 && e.Button == MouseButtons.Right)
            {
                DataGridViewCell c = (sender as DataGridView)[e.ColumnIndex, e.RowIndex];
                if (!c.Selected)
                {
                    c.DataGridView.ClearSelection();
                    c.DataGridView.CurrentCell = c;
                    c.Selected = true;
                }
            }
        }

        private void hitFrameChangeDelayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var a = dataGridView1.SelectedCells;
            if (a.Count > 1)
            {
                MessageBox.Show("Please only select one cell in the row of the hit frame.");
            }
            else if (a.Count == 0)
            {
                MessageBox.Show("Please select a cell in the row of the hit frame.");
            }
            else
            {
                int index = int.Parse(a[0].OwningRow.Cells[1].Value.ToString());
                Delay.Value = Delay.Value + index > 0 ? Delay.Value + index : 0;
                TargetFrame.Value = TargetFrame.Value - index > 1 ? TargetFrame.Value - index : 1;
            }
        }
        private void setTargetFrameChangeDelayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var a = dataGridView1.SelectedCells;
            if (a.Count > 1)
            {
                MessageBox.Show("Please only select one cell in the row of the target frame.");
            }
            else if (a.Count == 0)
            {
                MessageBox.Show("Please select a cell in the row of the target frame.");
            }
            else
            {
                int index = int.Parse(a[0].OwningRow.Cells[0].Value.ToString());
                TargetFrame.Value = index;
            }
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex != -1 && e.RowIndex != -1 && e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                DataGridViewCell c = (sender as DataGridView)[e.ColumnIndex, e.RowIndex];
                if (!c.Selected)
                {
                    c.DataGridView.ClearSelection();
                    c.DataGridView.CurrentCell = c;
                    c.Selected = true;
                }
            }
        }

        private void ProfileCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox s = (ComboBox)sender;
            if (Profiles[s.SelectedIndex].IsRoaming)
            {
                Calibration.Value = 21;
            }
            else
            {
                Calibration.Value = 20;
            }
        }
    }
}
