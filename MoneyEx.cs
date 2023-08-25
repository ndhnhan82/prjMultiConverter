using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
namespace prjMultiConverter
{//Created by Dinh Hoang Nhan, Nguyen
 //modified on 22-11-2021
 //Form money exchange
    public partial class MoneyEx : Form
    {
        double amountOut = 0;
        double amountIn = 0;
        const double usd = 0.77918;
        const double euro = 0.68901;
        const double gbp = 0.58882;
        const double vnd = 17783;
        string dirPath = @".\Data\";
        string filePath = @".\Data\MoneyConversions.txt";
        FileStream fs = null;
        //Last updated Dec 3, 2021, 20:27 UTC
        //1 CAD = 0.77918 USD
        //1CAD = 0.68901 UERO
        //1CAD = 0.58882 GBP
        //1CAD = 17,783 VND
        public MoneyEx() { InitializeComponent(); }
        private void button3_Click(object sender, EventArgs e)
        {
            byte btnVal = 0;
            btnVal = Convert.ToByte(MessageBox.Show("Do you want\n to quit the application\n Money Exchange ?", "Exit?", MessageBoxButtons.YesNo));
            if (btnVal == 6) { this.Close(); }
        }
        private void MoneyEx_Load(object sender, EventArgs e)
        {
            txtIn.Focus();
            if (!Directory.Exists(dirPath))
                Directory.CreateDirectory(dirPath);
            radCadIn.Checked = true;
            radCadOut.Checked = true;
            txtIn.Text = txtOut.Text = "0";
        }
        private string currencyIn()
        {
            if (radCadIn.Checked) { return "CAD"; }
            else if (radEurIn.Checked) { return "EUR"; }
            else if (radGbpIn.Checked) { return "GBP"; }
            else if (radUsdIn.Checked) { return "USD"; }
            else { return "VND"; }
        }
        private string currencyOut()
        {
            if (radCadOut.Checked) { return "CAD"; }
            else if (radEurOut.Checked) { return "EUR"; }
            else if (radGbpOut.Checked) { return "GBP"; }
            else if (radUsdOut.Checked) { return "USD"; }
            else { return "VND"; }
        }
        private double CadToUsd(double amount) { return amount * usd; }
        private double CadToEur(double amount) { return amount * euro; }
        private double CadToGbp(double amount) { return amount * gbp; }
        private double CadToVnd(double amount) { return amount * vnd; }
        private double VndToCad(double amount) { return amount / vnd; }
        private double GbpToCad(double amount) { return amount / gbp; }
        private double EurToCad(double amount) { return amount / euro; }
        private double UsdToCad(double amount) { return amount / usd; }
        private void butRead_Click(object sender, EventArgs e)
        {

            int count = 0;
            int times = 1;
            try
            {
                fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                StreamReader textIn = new StreamReader(fs);
                string textToPrint = "";
                string row = "";
                string[] columns;
                while (textIn.Peek() != -1)
                {
                    row = textIn.ReadLine();
                    columns = row.Split(',');
                    textToPrint += columns[0] + ".\t Date: " + columns[1] + "\r\n";
                    ++count;
                    if (count % 10 == 0)
                    {
                        MessageBox.Show(textToPrint, "Dinh Hoang Nhan Nguyen-" + "Rows " + times + " to " + count, MessageBoxButtons.OK);
                        times = +10;
                        textToPrint = "";
                    }
                }
                if (count == 0) { MessageBox.Show("You don't have any data about Money exchange!", "Dinh Hoang Nhan Nguyen", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                if (count % 10 != 0) { MessageBox.Show(textToPrint, "Dinh Hoang Nhan Nguyen-" + "Last rows", MessageBoxButtons.OK); }
                textIn.Close();
            }
            catch (FileNotFoundException) { MessageBox.Show(filePath + " not found.", "File Not Found"); }
            catch (DirectoryNotFoundException) { MessageBox.Show(dirPath + " not found.", "Directory Not Found"); }
            catch (IOException ex) { MessageBox.Show(ex.Message, "IOException"); }
            finally { if (fs != null) { fs.Close(); } }
        }
        private void butConvert_Click(object sender, EventArgs e)
        {
            Regex num = new Regex(@"^\d*\.?\d*$");
            if (num.IsMatch(txtIn.Text))
            {
                amountIn = Convert.ToDouble(txtIn.Text);
                if ((radCadIn.Checked))
                {
                    if (radCadOut.Checked) { amountOut = amountIn; }
                    else if (radEurOut.Checked) { amountOut = CadToEur(amountIn); }
                    else if (radGbpOut.Checked) { amountOut = CadToGbp(amountIn); }
                    else if (radUsdOut.Checked) { amountOut = CadToUsd(amountIn); }
                    else if (radVndOut.Checked) { amountOut = CadToVnd(amountIn); }
                }
                else if (radEurIn.Checked)
                {
                    if (radCadOut.Checked) { amountOut = EurToCad(amountIn); }
                    else if (radEurOut.Checked) { amountOut = amountIn; }
                    else if (radGbpOut.Checked) { amountOut = CadToGbp(EurToCad(amountIn)); }
                    else if (radUsdOut.Checked) { amountOut = CadToUsd(EurToCad(amountIn)); }
                    else if (radVndOut.Checked) { amountOut = CadToVnd(EurToCad(amountIn)); }
                }
                else if (radGbpIn.Checked)
                {
                    if (radCadOut.Checked) { amountOut = GbpToCad(amountIn); }
                    else if (radEurOut.Checked) { amountOut = CadToEur(GbpToCad(amountIn)); }
                    else if (radGbpOut.Checked) { amountOut = amountIn; }
                    else if (radUsdOut.Checked) { amountOut = CadToUsd(GbpToCad(amountIn)); }
                    else if (radVndOut.Checked) { amountOut = CadToVnd(GbpToCad(amountIn)); }
                }
                else if (radUsdIn.Checked)
                {
                    if (radCadOut.Checked) { amountOut = UsdToCad(amountIn); }
                    else if (radEurOut.Checked) { amountOut = CadToEur(UsdToCad(amountIn)); }
                    else if (radGbpOut.Checked) { amountOut = CadToGbp(UsdToCad(amountIn)); }
                    else if (radUsdOut.Checked) { amountOut = amountIn; }
                    else if (radVndOut.Checked) { amountOut = CadToVnd(UsdToCad(amountIn)); }
                }
                else if (radVndIn.Checked)
                {
                    if (radCadOut.Checked) { amountOut = VndToCad(amountIn); }
                    else if (radEurOut.Checked) { amountOut = CadToEur(VndToCad(amountIn)); }
                    else if (radGbpOut.Checked) { amountOut = CadToGbp(VndToCad(amountIn)); }
                    else if (radUsdOut.Checked) { amountOut = CadToUsd(VndToCad(amountIn)); }
                    else if (radVndOut.Checked) { amountOut = amountIn; }
                }
            }
            else
            {
                txtIn.Focus();
                MessageBox.Show("You must enter a number in a right format!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                fs = new FileStream(filePath, FileMode.Append, FileAccess.Write);
                StreamWriter textOut = new StreamWriter(fs);
                if ((txtIn.Text != "") && (txtIn.Text != "0"))
                    textOut.Write(amountIn + " " + currencyIn() + " = " + Math.Round(amountOut, 2) + " " + currencyOut() + ", " + DateTime.Now.ToString("yyyy/MM/dd h:mm:ss tt").Replace("-", "/") + "\n");
                textOut.Close();
            }
            catch (FileNotFoundException) { MessageBox.Show(filePath + " not found.", "File Not Found"); }
            catch (DirectoryNotFoundException) { MessageBox.Show(dirPath + " not found.", "Directory Not Found"); }
            catch (IOException ex)
            { MessageBox.Show(ex.Message, "IOException"); }
            finally { if (fs != null) { fs.Close(); } }
            txtOut.Text = Math.Round(amountOut, 2).ToString();
        }
    }
}
