using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokeNavEggs
{
    public partial class Form1 : Form
    {
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
                trainersChecked = XmlSerialization.ReadFromXmlFile<List<int>>("./checked.xml");
            } catch
            {

            }
            var formPopup = new Form2(trainersChecked);
            trainers = formPopup.getTrainers();
            trainersChecked = formPopup.getTrainersChecked();
        }


        public List<int> trainersChecked = new List<int>() { };
        public List<string> natures = new List<string> {
                "Hardy","Lonely","Brave","Adamant","Naughty",
                "Bold","Docile","Relaxed","Impish","Lax",
                "Timid","Hasty","Serious","Jolly","Naive",
                "Modest","Mild","Quiet","Bashful","Rash",
                "Calm","Gentle","Sassy","Careful","Quirky"};

        public Dictionary<string, Color> shinyColor = new Dictionary<string,Color> { { "No",Color.White }, { "Star",ColorTranslator.FromHtml("#FFD700") }, { "Square", Color.Orange } };
        internal class State
        {
            public uint Frame
            {
                get;
                set;
            }
            public int Index
            {
                get;
                set;
            }
            public uint EggRand
            {
                get;
                set;
            }
            public string PID
            {
                get;
                set;
            }
            public string Nature
            {
                get;
                set;
            }
            public string Ability
            {
                get;
                set;
            }
            public string Gender
            {
                get;
                set;
            }
            public string Call
            {
                get;
                set;
            }
            public string Shiny
            {
                get;
                set;
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

        public List<uint> ratios = new List<uint> { 255, 127, 192, 63, 31, 0, 254 };
        public List<string> trainers = new List<string> { "Call" };

        private State Generate(uint frame, int targetFrame, PokeRNG baserng, bool hasLightningRod, uint compatability, uint genderRatio, uint tid, uint sid, List<string> trainerlist)
        {
            State result = new State
            {
                Index = targetFrame - (int)frame,
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
            if (result.EggRand <= compatability)
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
                result.Call = trainers[(int)(rng.nextUShort() % trainerlist.Count)];
            }
            return result;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            uint startingFrame = (uint)StartingFrame.Value;
            uint lastFrame = (uint)EndingFrame.Value;
            int targetFrame = (int)TargetFrame.Value;
            uint calibration = (uint)Calibration.Value;
            uint delay = (uint)Delay.Value;
            uint tid = (uint)TID.Value;
            uint sid = (uint)SID.Value;
            uint compatability = (uint)(CompatabilityCB.SelectedIndex == 0 ? 20 : CompatabilityCB.SelectedIndex == 1 ? 50 : 70);
            uint genderRatio = ratios[GenderRatioCB.SelectedIndex];
            PokeRNG rng = new PokeRNG(0);
            rng.advance(startingFrame + calibration + delay);

            for (uint frame = startingFrame; frame <= lastFrame; frame++)
            {
                State state = Generate(frame, targetFrame, rng, HasLightningRod.Checked, compatability, genderRatio, tid, sid, trainers);
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
                    int row = dataGridView1.Rows.Add(state.Frame, state.Index, state.EggRand, state.PID, state.Nature, state.Ability, state.Gender, state.Call);
                    dataGridView1.Rows[row].DefaultCellStyle.BackColor = shinyColor[state.Shiny];
                }
                rng.nextUInt();
            }
        }

        private void PlusMinusButton_Click(object sender, EventArgs e)
        {
            decimal min = (TargetFrame.Value - PlusMinus.Value);
            decimal max = (TargetFrame.Value + PlusMinus.Value);
            min = min <= 0 ? 1 : min;
            max = max <= 0 ? 1 : max;
            StartingFrame.Value = min;
            EndingFrame.Value = max;
        }

        private void TrainersButton_Click(object sender, EventArgs e)
        {
            var formPopup = new Form2(trainersChecked);
            formPopup.ShowDialog();
            trainers = formPopup.getTrainers();
            trainersChecked = formPopup.getTrainersChecked();
        }
    }
}
