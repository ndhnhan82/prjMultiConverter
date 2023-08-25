﻿using System;
using System.IO;
using System.Windows.Forms;
namespace prjMultiConverter
{//Created by Dinh Hoang Nhan, Nguyen
 //modified on 22-11-2021
 //Form LotoMax
    public partial class Lotto_Max : Form
    {
        public Lotto_Max() { InitializeComponent(); }
        string dirPath = @".\Data\";
        string filePath = @".\Data\LottoNbrs.txt";
        private void button3_Click(object sender, EventArgs e)
        {
            byte btnVal = 0;
            btnVal = Convert.ToByte(MessageBox.Show("Do you want to quit this application ?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            if (btnVal == 6) { this.Close(); }
        }

        private void butGenerate(object sender, EventArgs e)
        {
            string textToPrint = "";
            FileStream fs = null;
            Random random = new Random();
            int randomNumber = 0;
            int bonus = random.Next(1, 50);
            try
            {
                fs = new FileStream(filePath, FileMode.Append, FileAccess.Write);
                StreamWriter textOut = new StreamWriter(fs);
                textOut.Write("Max, " + DateTime.Now.ToString("yyyy/MM/dd h:mm:ss tt").Replace("-", "/") + ", ");
                for (int i = 0; i <= 5; i++)
                {
                    randomNumber = random.Next(1, 50);
                    textToPrint += randomNumber + "\r\n";
                    textOut.Write(randomNumber + ",");
                }
                randomNumber = random.Next(1, 50);
                textToPrint += randomNumber + "\r\n";
                textOut.WriteLine(randomNumber + " Bonus " + bonus);
                textToPrint += bonus;
                textBox1.Text = textToPrint;
                textOut.Close();
            }
            catch (FileNotFoundException) { MessageBox.Show(filePath + " not found.", "File Not Found"); }
            catch (DirectoryNotFoundException) { MessageBox.Show(dirPath + " not found.", "Directory Not Found"); }
            catch (IOException ex) { MessageBox.Show(ex.Message, "IOException"); }
            finally
            { if (fs != null) { fs.Close(); } }
        }
        private void butRead_file(object sender, EventArgs e)
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
                    if (columns[0] == "Max")
                    {
                        textToPrint += "Date: " + columns[1] + "\n\tLotto Max: "
                            + columns[2] + " "
                            + columns[3] + " "
                            + columns[4] + " "
                            + columns[5] + " "
                            + columns[6] + " "
                            + columns[7] + " "
                            + columns[8] + " " + "\n";
                        ++count;
                        if (count % 10 == 0)
                        {
                            MessageBox.Show(textToPrint, "Dinh Hoang Nhan Nguyen-" + "Rows " + times + " to " + count, MessageBoxButtons.OK);
                            times = +10;
                            textToPrint = "";
                        }
                    }
                }
                if (count == 0) { MessageBox.Show("You don't have any data about Lotto Max!", "Dinh Hoang Nhan Nguyen", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                if (count % 10 != 0) { MessageBox.Show(textToPrint, "Dinh Hoang Nhan Nguyen-" + "Last rows", MessageBoxButtons.OK); }
                textIn.Close();
            }
            catch (FileNotFoundException) { MessageBox.Show(filePath + " not found.", "File Not Found"); }
            catch (DirectoryNotFoundException) { MessageBox.Show(dirPath + " not found.", "Directory Not Found"); }
            catch (IOException ex) { MessageBox.Show(ex.Message, "IOException"); }
            finally { if (fs != null) { fs.Close(); } }
        }
        private void Lotto_Max_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(dirPath))
                Directory.CreateDirectory(dirPath);
        }
    }
}
