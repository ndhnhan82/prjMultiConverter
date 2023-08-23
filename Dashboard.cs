using System;
using System.Windows.Forms;
//The Dashboard
//Created by Dinh Hoang Nhan, Nguyen
//modified on 22-11-2021
namespace Project_420_CT2_AS
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            byte btnVal = 0;
            btnVal = Convert.ToByte(MessageBox.Show("Do you really want to exit the application ?", "Exit?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question));
            if (btnVal == 1)
            { this.Close(); }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Lotto_Max objForm = new Lotto_Max();
            objForm.ShowDialog();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Lotto649 objForm = new Lotto649();
            objForm.ShowDialog();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            MoneyEx objForm = new MoneyEx();
            objForm.ShowDialog();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Temp objForm = new Temp();
            objForm.ShowDialog();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Simple_Calculator objForm = new Simple_Calculator();
            objForm.ShowDialog();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            IPv4 objForm = new IPv4();
            objForm.ShowDialog();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
