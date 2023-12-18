using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam
{
    public partial class Form2 : Form
    {
        public Tuple<string, string, string, string> output { get; set; }
        public Form2(string name = "", string address = "", string gender = "", string number = "")
        {
            InitializeComponent();
            textBoxName.Text = name;
            textBoxAddress.Text = address;
            comboBoxGender.Text = gender;
            textBoxNumber.Text = number.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text != "" && textBoxAddress.Text != "" && comboBoxGender.SelectedItem != null && textBoxNumber.Text != "")
            { 
                output = Tuple.Create(textBoxName.Text, textBoxAddress.Text, comboBoxGender.Text, textBoxNumber.Text);
                DialogResult = DialogResult.OK;
            }
        }
    }
}
