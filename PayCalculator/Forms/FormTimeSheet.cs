using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Threading;

namespace PayCalculator.Forms
{
    public partial class FormTimeSheet : Form
    {
        public FormTimeSheet()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FirefoxOptions Options = new FirefoxOptions();
            Options.AddArgument("--headless");
            IWebDriver drive = new FirefoxDriver(Options);
            drive.Url = "https://atg.ceccontrols.com/wts/index.jsp";
            string username = txtusername.Text;
            string password = txtpassword.Text;

            drive.FindElement(By.Id("username")).SendKeys(username);
            drive.FindElement(By.Id("j_password")).SendKeys(password);
            drive.FindElement(By.Id("submitbtn")).Click();

            drive.FindElement(By.XPath("//td[contains(text(),'HISTORY')]")).Click();
            drive.FindElement(By.XPath("//td[contains(text(),'APPROVED')]")).Click();

            var table = drive.FindElement(By.TagName("table"));
            var rows = table.FindElements(By.ClassName("lineitem")).Count;
            var rows_count = rows / 7;

            progressBar1.Minimum = 0;
            progressBar1.Maximum = rows_count;

            for (int i = 2; i < rows_count; i++) //rows_count
            {
                progressBar1.Value = i;
                Thread.Sleep(300);
                //*[@id="layer2"]/table/tbody/tr[12]/td[2]
                lblselect.Text = drive.FindElement(By.XPath("//*[@id='layer2']/table/tbody/tr[" + i + "]/td[2]")).Text;
                drive.FindElement(By.XPath("//*[@id='layer2']/table/tbody/tr[" + i + "]/td[2]")).Click();

                lblselect.Update();
                try
                {
                    drive.FindElement(By.XPath("//td[contains(text(),'Hours Summary')]")).Click();
                    Thread.Sleep(500);
                    drive.SwitchTo().Window(drive.WindowHandles[1]);
                    Thread.Sleep(500);

                    string timesheet = drive.FindElement(By.XPath("//html/body/pre")).Text;
                    
                    timesheet = lblselect.Text + "\r\n" + timesheet;
                    timesheet = timesheet.Replace("Basic:", "");
                    timesheet = timesheet.Replace("Standard Overtime:", "");
                    timesheet = timesheet.Replace("High Rate Overtime:", "");
                    timesheet = timesheet.Replace("Nights:", "");
                    timesheet = timesheet.Replace("Travel:", "");
                    timesheet = timesheet.Replace("Holiday:", "");
                    timesheet = timesheet.Replace("Bank", "");
                    timesheet = timesheet.Replace("Bank Holiday:", "");
                    timesheet = timesheet.Replace("Illness:", "");
                    timesheet = timesheet.Replace("Changeover:", "");
                    timesheet = timesheet.Replace("Total:", "");
                    dgtimesheet.Rows.Add(timesheet.Split('\n'));

                    Thread.Sleep(500);
                    drive.Close();
                    drive.SwitchTo().Window(drive.WindowHandles[0]);
                    drive.Navigate().Back();
                    lblselect.Text = "";
                }
                catch
                {
                    drive.Navigate().Back();
                }
            }
            drive.Close();
        }

        private void btnexport_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = "C:";
            saveFileDialog1.Title = "Export TimeSheet to Excel";
            saveFileDialog1.FileName = "";
            saveFileDialog1.Filter = "Excel Files 2003|*.xls|Excel Files 2007|*.xlsx";

            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            app.Visible = false;

            Microsoft.Office.Interop.Excel.Workbook wb = app.Workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
            Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)wb.ActiveSheet;
            app.Application.Worksheets.Add(Type.Missing); 
            if (saveFileDialog1.ShowDialog() != DialogResult.Cancel) 
            {
                //header
                for (int i = 0; i < dgtimesheet.Columns.Count; i++)
                {
                    ws.Cells[1, i + 1] = dgtimesheet.Columns[i].HeaderText;
                }
                //content
                for (int i = 0; i < dgtimesheet.Rows.Count; i++)
                {
                    if (dgtimesheet.Rows.Count > 2)
                    {
                        for (int j = 0; j < dgtimesheet.Columns.Count; j++)
                        {
                            ws.Cells[i + 2, j + 1] = dgtimesheet.Rows[i].Cells[j].ToString();
                        }
                    }
                }
                ws.Name = "TimeSheet data";

                wb.SaveCopyAs(saveFileDialog1.FileName.ToString());
                //wb.SaveAs(true);
                app.Quit();
            }
            
        }
        
    }
}
