using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
namespace prjMultiConverter
{//Created by Dinh Hoang Nhan, Nguyen
 //modified on 22-11-2021
 //Form Temperature exchange
    public partial class Temp : Form
    {
        public Temp()
        {
            InitializeComponent();
        }
        string dirPath = @".\Data\";
        string filePath = @".\Data\TempConversions.txt";
        private void radFToC_CheckedChanged(object sender, EventArgs e)
        {
            labIn.Text = "°F";
            labOut.Text = "°C";
            this.Text = "Temperature Conversion";
        }
        private void radCToF_CheckedChanged(object sender, EventArgs e)
        {
            labIn.Text = "°C";
            labOut.Text = "°F";
            this.Text = "Temperature Conversion";
        }
        private double CToF(double tempC) { return (tempC * 9 / 5 + 32); }
        private double FToC(double tempF) { return ((tempF - 32) * 5 / 9); }
        private void Temp_Load(object sender, EventArgs e)
        {
            txtIn.Text = "";
        }
        private void butConvert_Click(object sender, EventArgs e)
        {
            double tempIn = 0;
            double tempOut = 0;
            double tempC = 0, tempF = 0;
            FileStream fs = null;
            Regex num = new Regex(@"^\d*\.?\d*$");
            if (num.IsMatch(txtIn.Text))
            {
                tempIn = Convert.ToDouble(txtIn.Text);
                if (radCToF.Checked) { tempOut = CToF(tempIn); }
                else tempOut = FToC(tempIn);
                txtMesg.Text = "";
                txtMesg.BackColor = System.Drawing.Color.White;
                if (radCToF.Checked) { tempC = tempIn; tempF = tempOut; }
                else { tempC = tempOut; tempF = tempIn; }
                {
                    switch (tempC)
                    {
                        case 100: txtMesg.Text = "Water boils"; txtMesg.BackColor = System.Drawing.Color.Red; break;
                        case 40: txtMesg.Text = "Hot Bath"; txtMesg.BackColor = System.Drawing.Color.Red; break;
                        case 37: txtMesg.Text = "Body temperature"; txtMesg.BackColor = System.Drawing.Color.Green; break;
                        case 30: txtMesg.Text = "Beach weather"; txtMesg.BackColor = System.Drawing.Color.Green; break;
                        case 10: txtMesg.Text = "Cool Day"; txtMesg.BackColor = System.Drawing.Color.Blue; break;
                        case 0: txtMesg.Text = "Freezing point of water"; txtMesg.BackColor = System.Drawing.Color.Blue; break;
                        case -40: txtMesg.Text = "Extremely Cold Day\n(and the same number!)"; txtMesg.BackColor = System.Drawing.Color.Blue; break;
                        default:
                            if (tempC >= -30 && tempC <= -10) { txtMesg.Text = "Very Cold Day"; txtMesg.BackColor = System.Drawing.Color.Blue; }
                            if (tempC >= 20 && tempC < 30) { txtMesg.Text = "Room temperature"; txtMesg.BackColor = System.Drawing.Color.Green; }
                            if (tempF >= 98 && tempF <= 99) { txtMesg.Text = "Body temperature"; txtMesg.BackColor = System.Drawing.Color.Green; }
                            break;
                    }
                }
            }
            else
            {
                MessageBox.Show("You must enter a number in right format! ", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtOut.Text = tempOut.ToString();
            try
            {
                fs = new FileStream(filePath, FileMode.Append, FileAccess.Write);
                StreamWriter textOut = new StreamWriter(fs);
                textOut.Write(tempIn + " " + labIn.Text + " = " + tempOut + " " + labOut.Text + ", " + DateTime.Now.ToString("yyyy/MM/dd h:mm:ss tt").Replace("-", "/") + "\n");
                textOut.Close();
            }
            catch (FileNotFoundException) { MessageBox.Show(filePath + " not found.", "File Not Found"); }
            catch (DirectoryNotFoundException) { MessageBox.Show(dirPath + " not found.", "Directory Not Found"); }
            catch (IOException ex) { MessageBox.Show(ex.Message, "IOException"); }
            finally { if (fs != null) { fs.Close(); } }
        }
        private void butRead_Click(object sender, EventArgs e)
        {
            FileStream fs = null;
            int count = 0;
            int times = 1;
            try
            {
                fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                StreamReader textIn = new StreamReader(fs);
                string textToPrint = "";
                while (textIn.Peek() != -1)
                {
                    string row = textIn.ReadLine();
                    string[] columns = row.Split(',');
                    textToPrint += columns[0] + "\t Date: " + columns[1] + "\n";
                    ++count;
                    if (count % 10 == 0)
                    {
                        MessageBox.Show(textToPrint, "Dinh Hoang Nhan Nguyen-" + "Rows " + times + " to " + count, MessageBoxButtons.OK);
                        times = +10;
                        textToPrint = "";
                    }
                }
                if (count == 0) { MessageBox.Show("You don't have any data about Tempurature!", "Dinh Hoang Nhan Nguyen", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                if (count % 10 != 0) { MessageBox.Show(textToPrint, "Dinh Hoang Nhan Nguyen-" + "Last rows", MessageBoxButtons.OK); }
                textIn.Close();
            }
            catch (FileNotFoundException) { MessageBox.Show(filePath + " not found.", "File Not Found"); }
            catch (DirectoryNotFoundException) { MessageBox.Show(dirPath + " not found.", "Directory Not Found"); }
            catch (IOException ex) { MessageBox.Show(ex.Message, "IOException"); }
            finally { if (fs != null) { fs.Close(); } }
        }
        private void butExit_Click(object sender, EventArgs e)
        {
            byte btnVal = 0;
            btnVal = Convert.ToByte(MessageBox.Show("Do you really want to quite this application?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            if (btnVal == 6) { this.Close(); }
        }
    }
}
