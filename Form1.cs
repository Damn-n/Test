using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        private string originalText;
        private Color originalTextColor;
        private Font originalTextFont;

        private string originalTextButton1, originalTextButton2, originalTextButton3;
        private Color originalTextColorButton;
        private Color originalBackColorButton;
        public Form1()

        {
            InitializeComponent();
            originalText = si.Text;
            originalTextColor = si.ForeColor;
            originalTextFont = si.Font;

          
            originalBackColorButton = txtbutton.ForeColor;
            originalBackColorButton = txtbutton.BackColor;

            originalTextButton1 = txtbutton.Text;
            originalTextButton2 = colorbutton.Text;
            originalTextButton3 = fontbutton.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ChangeTxtButton_Click(object sender, EventArgs e)
        {
            si.Text = "Malos dias";
            txtbutton.Text = "Listo";
            txtbutton.ForeColor = Color.AliceBlue;
            txtbutton.BackColor = Color.Green;
        }

        private void ColorBtn_Click(object sender, EventArgs e)
        {
            si.ForeColor = Color.DarkCyan;
            colorbutton.Text = "Listo";
            colorbutton.ForeColor = Color.AliceBlue;
            colorbutton.BackColor = Color.Green;
        }

        private void FrontBtn_Click(object sender, EventArgs e)
        {
            si.Font = new Font("Calisto", 10);
            fontbutton.Text = "Listo";
            fontbutton.ForeColor = Color.AliceBlue;
            fontbutton.BackColor = Color.Green;
        }

        private void NameTxt_Click(object sender, EventArgs e)
        {

        }

        private void Reset_Click(object sender, EventArgs e)
        {
            si.Text = originalText;
            si.ForeColor = originalTextColor;
            si.Font = originalTextFont;


            txtbutton.BackColor = originalBackColorButton;
            colorbutton.BackColor = originalBackColorButton;
            fontbutton.BackColor = originalBackColorButton;

            txtbutton.ForeColor = originalTextColor;
            colorbutton.ForeColor = originalTextColor;
            fontbutton.ForeColor = originalTextColor;

            txtbutton.Text = originalTextButton1;
            colorbutton.Text = originalTextButton2;
            fontbutton.Text = originalTextButton3;

            // si :v

           
        }
    }
}
