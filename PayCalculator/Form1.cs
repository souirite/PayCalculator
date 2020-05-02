using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayCalculator
{
    public partial class Form1 : Form
    {
        //Field
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activateForm;

        //Constructor
        public Form1()
        {
            InitializeComponent();
            random = new Random();
        }
        //Methods
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
               index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnsender)
        {
            if (btnsender != null)
            {
                if (currentButton != (Button)btnsender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnsender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    paneltitle.BackColor = color;
                    panellogo.BackColor = ThemeColor.ChangeColorBrightness(color,-0.3);
                }
            }
        }
        private void DisableButton()
        { 
            foreach(Control previousBtn in panelside.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51,51,76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
         private void OpenChildForm(Form childForm, object btnsender)
        {
            if(activateForm != null)
            {
                activateForm.Close();
            }
            ActivateButton(btnsender);
            activateForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.paneldesktop.Controls.Add(childForm);
            this.paneldesktop.Tag= childForm;
            childForm.BringToFront();
            childForm.Show();
            lbltitle.Text = childForm.Text;
        }
        private void btnhome_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btntimesheet_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormTimeSheet(), sender);
        }

        private void btnpay_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnholidays_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btntravel_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }
    }
}
