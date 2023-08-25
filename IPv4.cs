using System;
using System.Windows.Forms;
//Created by Dinh Hoang Nhan, Nguyen
//modified on 22-11-2021
//Form IPv4
namespace prjMultiConverter
{
    public partial class IPv4 : Form
    {
        public IPv4()
        {
            InitializeComponent();
        }
        private void IPv4_Load(object sender, EventArgs e)
        {
            string today = DateTime.Now.ToLongDateString();
            label1.Text = "Today: " + today;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string s = txtIP.Text.Trim();
            byte[] digits = new byte[4];
            bool validIP = true;
            bool trycatch = false;
            int Count = 0;
            foreach (char c in s)
            {
                if (!(c == '0' || c == '1' || c == '2' || c == '3' || c == '4' || c == '5' ||
                    c == '6' || c == '7' || c == '8' || c == '9' || c == '.'))
                    validIP = false;
                if (c == '.') ++Count;
            }
            if (!validIP || Count != 3)
                validIP = false;
            else
            {
                string temp = s + ".";
                for (int i = 0; i < 4; i++)
                {
                    try
                    {
                        digits[i] = Convert.ToByte(temp.Substring(0, temp.IndexOf(".")));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("The bytes number " + (i + 1) + ": " +
                                        temp.Substring(0, temp.IndexOf(".")) + " is not valid!" +
                                        "\n" + ex.Message, "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        validIP = false;
                        trycatch = true;
                    }
                    temp = temp.Substring(temp.IndexOf(".") + 1, temp.Length - temp.IndexOf(".") - 1);
                    if (digits[i] < 0 || digits[i] > 255)
                    {
                        MessageBox.Show("The bytes number " + (i + 1) + ": " +
                                        digits[i].ToString() + "is not valid!");
                        validIP = false;
                    }
                }
            }
            if (validIP)
                MessageBox.Show(s + "\nThis IP is correct!", "Valid IP", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            else if (!validIP && !trycatch)
                MessageBox.Show(s + "\nThe Ip must have 4 bytes\n" +
                                    "Integer number between 0 and 255\n" +
                                    "separate by a dot(255.255.255.255)", "Error", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
        }
        private void butExit_Click(object sender, EventArgs e)
        {
            byte btnVal = 0;
            btnVal = Convert.ToByte(MessageBox.Show("Do you want to quit this application ?", "Confirm !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            if (btnVal == 6) { this.Close(); }
        }
        private void ButReset_Click(object sender, EventArgs e)
        {
            txtIP.Text = "";
            txtIP.Focus();
        }
    }
}
