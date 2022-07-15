using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Average_Units_Shipped
{
    public partial class Form1 : Form
    {
        int[] numbers = new int[7];
        int total_num = 1;
        float avg = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
             Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            days_lbl.Text = "Day " + total_num;
        }

        private void enterbtn_Click(object sender, EventArgs e)
        {
            
            try
            {
                int input_number = Convert.ToInt32(inputbox.Text);
                if (input_number > 0 && input_number < 1000)
                {
                    displaybox.AppendText(inputbox.Text);
                    displaybox.AppendText(Environment.NewLine);
                    numbers[total_num - 1] = Convert.ToInt32(inputbox.Text);
                    total_num += 1;
                    days_lbl.Text = "Day " + total_num;
                    inputbox.Clear();
                    inputbox.Focus();

                }

                if (total_num > 7)
                {
                    inputbox.Enabled = false;
                    enterbtn.Enabled = false;
                    Results.Text = "Average per day : " + Convert.ToString(Math.Round(numbers.Average(), 2, MidpointRounding.ToEven));
                }
            }
            catch
            {
                inputbox.Focus();
            }
            

        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        private void resetbtn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                resetbtn.PerformClick();
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                resetbtn.PerformClick();
            }
        }

        private void inputbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                resetbtn.PerformClick();
            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            
        }
    }
}
