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
    public partial class Form2 : Form
    {
        public Form2(List<int> checks)
        {
            InitializeComponent();
            for (int x=0; x < checkedListBox1.Items.Count; x++)
            {
                if (checks.Contains(x)) {
                    checkedListBox1.SetItemCheckState(x, CheckState.Checked);
                }
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            XmlSerialization.WriteToXmlFile("./checked.xml", getTrainersChecked());
            Close();
        }
        public List<string> getTrainers()
        {
            List<string> t = new List<string> { "Call" };
            if (checkedListBox1.CheckedItems.Count != 0)
            {
                t.Clear();
                for (int x = 0; x < checkedListBox1.CheckedItems.Count; x++)
                {
                    t.Add(checkedListBox1.CheckedItems[x].ToString());
                }
            }
            return t;
        }
        public List<int> getTrainersChecked()
        {
            List<int> checks = new List<int> { };
            for (int x=0;x < checkedListBox1.CheckedIndices.Count;x++)
            {
                checks.Add(checkedListBox1.CheckedIndices[x]);
            }
            return checks;
        }
    }
}
