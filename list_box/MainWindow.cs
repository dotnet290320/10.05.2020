using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win1005b
{
    public partial class MainWindow : Form
    {
        double _sum = 0.0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void addBn_Click(object sender, EventArgs e)
        {
            string s1 = (sender as Button).Name;
            if (numberTxtBx.Text == "")
            {
                MessageBox.Show("Enter a number before clicking ADD", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Double.TryParse(numberTxtBx.Text, out double number)) // ! (condition)
                //   0 == 0 true
                // !(0 == 0) false
                // (0 != 0)
            {
                MessageBox.Show("Enter a valid floating point number before clicking ADD", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            numbersLst.Items.Add(number);
            _sum += number;

            // scroll to bottom
            // [ 7, 8, 10]
            //   0  1  2  <zero based>
            // index of last = 2 [length - 1]
            numbersLst.SelectedIndex = numbersLst.Items.Count - 1;
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (numbersLst.Items.Count <= 0)
            {
                MessageBox.Show("Cannot remove items from an empty list", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // remove last:
            // numbersLst.Items.RemoveAt(numbersLst.Items.Count - 1);

            // remove selected
            if (numbersLst.SelectedIndex < 0)
            {
                MessageBox.Show("Please select an item before clicking REMOVE", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _sum -= Convert.ToDouble(numbersLst.Items[numbersLst.SelectedIndex]);

            numbersLst.Items.RemoveAt(numbersLst.SelectedIndex);
            
        }

        private void sumBtn_Click(object sender, EventArgs e)
        {
            // first solution
            //double sum = 0.0;
            //for (int i = 0; i < numbersLst.Items.Count; i++)
            //{
            //    double current_item = Convert.ToDouble(numbersLst.Items[i]);
            //    sum += current_item;
            //}
            //MessageBox.Show($"SUM = {sum}");

            // second solution
            MessageBox.Show($"SUM = {_sum}");
        }

        //private void numbersLst_DoubleClick(object sender, EventArgs e)
        //{

        //}
    }
}
