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
    public partial class Form3 : Form
    {
        public Form3(Tuple<string, string, string, string>[] input, int size)
        {
            InitializeComponent();
            for (int i = 0; i < size; i++)
                PhonebookDataGrid.Rows.Add(input[i].Item1, input[i].Item2, input[i].Item3, input[i].Item4);
            
        }
    }
}
