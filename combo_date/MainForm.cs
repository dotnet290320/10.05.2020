using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win1005a
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            string selection;

            if (dayCmbBx.SelectedIndex <= 0)
            {
                MessageBox.Show("Please select a day");
                return;
            }

            if (monthCmbBx.SelectedIndex <= 0)
            {
                MessageBox.Show("Please select a month");
                return;
            }

            if (yearCmbBx.SelectedIndex <= 0)
            {
                MessageBox.Show("Please select a year");
                return;
            }
            selection = $"Selected:\n {dayCmbBx.SelectedItem} {monthCmbBx.SelectedItem} {yearCmbBx.SelectedItem}";

            MessageBox.Show(selection, "Your selection...");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // will run when the form is created + loaded
            dayCmbBx.Items.Clear();
            dayCmbBx.Items.AddRange(new string[] {
                "-- Select --",
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday"});
            dayCmbBx.SelectedIndex = 0;

            monthCmbBx.Items.Clear();
            monthCmbBx.Items.AddRange(
                new string[] {
                    "-- Select --",
                "January",
                "February",
                "March",
                "April",
                "May",
                "June",
                "July",
                "August",
                "September",
                "October",
                "November",
                "December"
            });
            monthCmbBx.SelectedIndex = 0;

            yearCmbBx.Items.Clear();
            yearCmbBx.Items.Add("-- Select --");
            for (int year = 1980; year <= 2020; year++)
            {
                yearCmbBx.Items.Add(year);
            }
            yearCmbBx.SelectedIndex = 0;

        }
    }
}
