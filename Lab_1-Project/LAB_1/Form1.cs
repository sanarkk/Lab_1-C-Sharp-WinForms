namespace LAB_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            foreach (int i in checkedListBox1.CheckedIndices)
            {
                checkedListBox1.SetItemCheckState(i, CheckState.Unchecked);
            }
            if (radioButton1.Checked == true)
            {
                checkedListBox1.SetItemCheckState(2, CheckState.Checked);
                checkedListBox1.SetItemCheckState(3, CheckState.Checked);
                checkedListBox1.SetItemCheckState(7, CheckState.Checked);
                checkedListBox1.SetItemCheckState(8, CheckState.Checked);
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            string input;

            input = listBox1.Text;

            if (radioButton6.Checked == true)
            {
                if (input == "")
                {
                    MessageBox.Show("List is clear!");
                    radioButton6.Checked = false;
                }
                else
                    listBox1.ForeColor = Color.Red;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (string s in checkedListBox1.CheckedItems)
            {
                listBox1.Text = s;
                listBox1.Items.Add(s);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string input;

            input = listBox1.Text;

            if (input == "")
                MessageBox.Show("List is clear!");
            else
            {
                listBox1.Items.Clear();
                listBox1.Text = "";
            }
                
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (int i in checkedListBox1.CheckedIndices)
            {
                checkedListBox1.SetItemCheckState(i, CheckState.Unchecked);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            foreach (int i in checkedListBox1.CheckedIndices)
            {
                checkedListBox1.SetItemCheckState(i, CheckState.Unchecked);
            }
            if (radioButton2.Checked == true)
            {
                checkedListBox1.SetItemCheckState(5, CheckState.Checked);
                checkedListBox1.SetItemCheckState(6, CheckState.Checked);
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            foreach (int i in checkedListBox1.CheckedIndices)
            {
                checkedListBox1.SetItemCheckState(i, CheckState.Unchecked);
            }
            if (radioButton3.Checked == true)
            {
                checkedListBox1.SetItemCheckState(0, CheckState.Checked);
                checkedListBox1.SetItemCheckState(1, CheckState.Checked);
                checkedListBox1.SetItemCheckState(4, CheckState.Checked);
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            foreach (int i in checkedListBox1.CheckedIndices)
            {
                checkedListBox1.SetItemCheckState(i, CheckState.Unchecked);
            }
            if(radioButton4.Checked == true)
            {
                checkedListBox1.SetItemCheckState(0, CheckState.Checked);
                checkedListBox1.SetItemCheckState(1, CheckState.Checked);
                checkedListBox1.SetItemCheckState(2, CheckState.Checked);
                checkedListBox1.SetItemCheckState(3, CheckState.Checked);
                checkedListBox1.SetItemCheckState(4, CheckState.Checked);
                checkedListBox1.SetItemCheckState(5, CheckState.Checked);
                checkedListBox1.SetItemCheckState(6, CheckState.Checked);
                checkedListBox1.SetItemCheckState(7, CheckState.Checked);
                checkedListBox1.SetItemCheckState(8, CheckState.Checked);
            }
            

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            string input;

            input = listBox1.Text;

            if (radioButton5.Checked == true)
            {
                if (input == "")
                {
                    MessageBox.Show("List is clear!");
                    radioButton5.Checked = false;
                }
                else
                    listBox1.ForeColor = Color.Green;
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            string input;

            input = listBox1.Text;

            if (radioButton7.Checked == true)
            {
                if (input == "")
                {
                    MessageBox.Show("List is clear!");
                    radioButton7.Checked = false;
                }
                else
                    listBox1.ForeColor = Color.Blue;
            }
        }



        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show(listBox1.Text);
            }
        }
        
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            checkedListBox1.SetItemCheckState(0, CheckState.Checked);
        }
    }
}