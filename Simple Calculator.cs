using System;
using System.IO;
using System.Windows.Forms;
//Created by Dinh Hoang Nhan, Nguyen
//modified on 22-11-2021
//Form SImple Calculator
namespace Project_420_CT2_AS
{
    public partial class Simple_Calculator : Form
    {
        string dirPath = @".\Data\";
        string filePath = @".\Data\Calculator.txt";
        FileStream fs = null;
        Calculator Cal = new Calculator();
        public Simple_Calculator()
        {
            InitializeComponent();

        }
        private void Simple_Calculator_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(dirPath))
                Directory.CreateDirectory(dirPath);
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "0") txtDisplay.Text += "1"; else txtDisplay.Text = "1";
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "0") txtDisplay.Text += "2"; else txtDisplay.Text = "2";
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "0") txtDisplay.Text += "3"; else txtDisplay.Text = "3";
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "0") txtDisplay.Text += "4"; else txtDisplay.Text = "4";
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "0") txtDisplay.Text += "5"; else txtDisplay.Text = "5";
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "0") txtDisplay.Text += "6"; else txtDisplay.Text = "6";
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "0") txtDisplay.Text += "7"; else txtDisplay.Text = "7";
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "0") txtDisplay.Text += "8"; else txtDisplay.Text = "8";
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "0") txtDisplay.Text += "9"; else txtDisplay.Text = "9";
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "0") txtDisplay.Text += "0";
        }
        private void button_dot_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += ".";
        }
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            decimal displayValue = Convert.ToDecimal(txtDisplay.Text);
            Cal.Add(displayValue);
            fs = new FileStream(filePath, FileMode.Append, FileAccess.Write);
            StreamWriter textOut = new StreamWriter(fs);
            textOut.Write(txtDisplay.Text + " + ");
            textOut.Close();
            txtDisplay.Text = "";
        }
        private void butMinus_Click(object sender, EventArgs e)
        {
            decimal displayValue = Convert.ToDecimal(txtDisplay.Text);
            fs = new FileStream(filePath, FileMode.Append, FileAccess.Write);
            StreamWriter textOut = new StreamWriter(fs);
            textOut.Write(txtDisplay.Text + " - ");
            textOut.Close();
            Cal.Subtract(displayValue);
            txtDisplay.Text = "";
        }
        private void butMuti_Click(object sender, EventArgs e)
        {
            decimal displayValue = Convert.ToDecimal(txtDisplay.Text);
            fs = new FileStream(filePath, FileMode.Append, FileAccess.Write);
            StreamWriter textOut = new StreamWriter(fs);
            textOut.Write(txtDisplay.Text + " * ");
            textOut.Close();
            Cal.Multiply(displayValue);
            txtDisplay.Text = "";
        }
        private void butDivid_Click(object sender, EventArgs e)
        {
            decimal displayValue = Convert.ToDecimal(txtDisplay.Text);
            fs = new FileStream(filePath, FileMode.Append, FileAccess.Write);
            StreamWriter textOut = new StreamWriter(fs);
            textOut.Write(txtDisplay.Text + " / ");
            textOut.Close();
            Cal.Divide(displayValue);
            txtDisplay.Text = "";
        }
        private void butEqual_Click(object sender, EventArgs e)
        {
            fs = new FileStream(filePath, FileMode.Append, FileAccess.Write);
            StreamWriter textOut = new StreamWriter(fs);
            textOut.Write(txtDisplay.Text + " = ");
            decimal displayValue = Convert.ToDecimal(txtDisplay.Text);
            if (Cal.Op == "/" && displayValue == 0)
            {
                MessageBox.Show("Can not divide by zero!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cal.Clear();
                textOut.Close();
            }
            else
            {
                Cal.Equals(displayValue);
                txtDisplay.Text = Convert.ToString(Cal.CurrentValue);
                textOut.WriteLine(txtDisplay.Text);
                textOut.Close();
            }
        }
        private void butClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
            Cal.Clear();
        }
        private void button18_Click(object sender, EventArgs e)
        {
            byte btnVal = 0;
            btnVal = Convert.ToByte(MessageBox.Show("Do you want to quit the application?", "Exit?", MessageBoxButtons.YesNo));
            if (btnVal == 6) { this.Close(); }
        }
    }
}
