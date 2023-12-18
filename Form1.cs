namespace Exam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            if(form2.ShowDialog() == DialogResult.OK)
                PhonebookDataGrid.Rows.Add(form2.output.Item1, form2.output.Item2, form2.output.Item3, form2.output.Item4);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PhonebookDataGrid.SelectedRows.Count != 0)
            {
                Form2 form2 = new Form2(PhonebookDataGrid.SelectedRows[0].Cells[0].Value.ToString(),
                                        PhonebookDataGrid.SelectedRows[0].Cells[1].Value.ToString(),
                                        PhonebookDataGrid.SelectedRows[0].Cells[2].Value.ToString(),
                                        PhonebookDataGrid.SelectedRows[0].Cells[3].Value.ToString());
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    int index = PhonebookDataGrid.SelectedRows[0].Index;
                    PhonebookDataGrid.Rows.RemoveAt(index);
                    PhonebookDataGrid.Rows.Insert(index, form2.output.Item1, form2.output.Item2, form2.output.Item3, form2.output.Item4);
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PhonebookDataGrid.SelectedRows.Count == 1)
                PhonebookDataGrid.Rows.Remove(PhonebookDataGrid.SelectedRows[0]);
            if (PhonebookDataGrid.SelectedRows.Count > 1)
            {
                for (int i = 0; i < PhonebookDataGrid.SelectedRows.Count; i++)
                    PhonebookDataGrid.Rows.Remove(PhonebookDataGrid.SelectedRows[i]);
                PhonebookDataGrid.Rows.Remove(PhonebookDataGrid.SelectedRows[0]);
            }
        }

        private void saveToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Binary|*.bin";
            saveFileDialog1.Title = "Save file";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                using (FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create))
                using (BinaryWriter bw = new BinaryWriter(fs))
                {
                    if (PhonebookDataGrid.RowCount < 2)
                    {
                        bw.Write(0);
                        return;
                    }
                    int n = PhonebookDataGrid.RowCount;

                    bw.Write(n);

                    string name;
                    string address;
                    string gender;
                    string number;

                    for (int i = 0; i < n; i++)
                    {
                        name = PhonebookDataGrid.Rows[i].Cells[0].Value.ToString();
                        address = PhonebookDataGrid.Rows[i].Cells[1].Value.ToString();
                        gender = PhonebookDataGrid.Rows[i].Cells[2].Value.ToString();
                        number = PhonebookDataGrid.Rows[i].Cells[3].Value.ToString();

                        bw.Write(name);
                        bw.Write(address);
                        bw.Write(gender);
                        bw.Write(number);
                    }
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Binary|*.bin";
            openFileDialog1.Title = "Open file";
            openFileDialog1.ShowDialog();
            using (FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open))
            using (BinaryReader br = new BinaryReader(fs))
            {
                int n;
                string name;
                string address;
                string gender;
                string number;

                n = br.ReadInt32();

                PhonebookDataGrid.Rows.Clear();

                for (int i = 0; i < n; i++)
                {
                    name = br.ReadString();
                    address = br.ReadString();
                    gender = br.ReadString();
                    number = br.ReadString();
                    

                    PhonebookDataGrid.Rows.Add(name, address, gender, number);
                }
            }
        }

        private void byNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            if(form4.ShowDialog() == DialogResult.OK)
            {
                List<DataGridViewRow> results = new List<DataGridViewRow>();
                string data = form4.output;
                foreach (DataGridViewRow row in PhonebookDataGrid.Rows)
                {
                    if(string.Compare((string)row.Cells[0].Value, data) == 0)
                    {
                        results.Add(row);
                    }
                }

                if(results.Count == 0)
                    MessageBox.Show("No results!");
                else
                {
                    Tuple<string, string, string, string>[] output = new Tuple<string, string, string, string>[results.Count];
                    for (int i = 0;i < results.Count;i++)
                    {
                        output[i] = new Tuple<string, string, string, string>(
                            results[i].Cells[0].Value.ToString(),
                            results[i].Cells[1].Value.ToString(),
                            results[i].Cells[2].Value.ToString(),
                            results[i].Cells[3].Value.ToString());

                    }
                    Form3 form3 = new Form3(output, results.Count);
                    form3.Show();
                }
                
            }
            
        }

        private void byNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            if (form4.ShowDialog() == DialogResult.OK)
            {
                List<DataGridViewRow> results = new List<DataGridViewRow>();
                string data = form4.output;
                foreach (DataGridViewRow row in PhonebookDataGrid.Rows)
                {
                    if (string.Compare((string)row.Cells[3].Value, data) == 0)
                    {
                        results.Add(row);
                    }
                }

                if (results.Count == 0)
                    MessageBox.Show("No results!");
                else
                {
                    Tuple<string, string, string, string>[] output = new Tuple<string, string, string, string>[results.Count];
                    for (int i = 0; i < results.Count; i++)
                    {
                        output[i] = new Tuple<string, string, string, string>(
                            results[i].Cells[0].Value.ToString(),
                            results[i].Cells[1].Value.ToString(),
                            results[i].Cells[2].Value.ToString(),
                            results[i].Cells[3].Value.ToString());

                    }
                    Form3 form3 = new Form3(output, results.Count);
                    form3.Show();
                }

            }
        }
    }
}