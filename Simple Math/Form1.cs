using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Simple_Math
{
    public partial class Form1 : Form
    {
        int inputNumber;

        public Point mouseLocation;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
         (
              int nLeftRect,
              int nTopRect,
              int nRightRect,
              int nBottomRect,
              int nWidthEllipse,
             int nHeightEllipse

          );

        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.White;
            closeButton.BackColor = Color.Red;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.BackColor = Color.FromArgb(45, 45, 48);
            closeButton.ForeColor = Color.FromArgb(105, 105, 105);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mCurrentPos = Control.MousePosition;
                mCurrentPos.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mCurrentPos;
            }
        }

        void ExpandNum(string number)
        {
            string expandedNot = "";
            string finalNotation = "";
            int numLength = number.Length - 1;
            for (int j = 0; j <= number.Length; j++)
            {
                if (j < number.Length - 1)
                {
                    if (number[j] != '0')
                    {
                        expandedNot = addZero(number[j], numLength);
                        finalNotation += $"{expandedNot} + ";
                        numLength--;
                    }
                    else
                    {
                        numLength--;
                        continue;
                    }
                }
                else if (j == number.Length - 1)
                {
                    if (number[j] != '0')
                    {
                        finalNotation += $"{number[number.Length - 1]}";
                    }
                    else
                    {
                        finalNotation = finalNotation.Remove(finalNotation.LastIndexOf('+') - 1);
                        continue;
                    }
                }

            }

            outputTextbox.Text = finalNotation;
        }

        string addZero(Char character, int length)
        {
            string numWithZeros = Char.ToString(character);
            for (int i = 1; i <= length; i++)
            {
                numWithZeros += "0";
            }

            return numWithZeros;
        }

        private void processButton_Click(object sender, EventArgs e)
        {
            if (inputTextbox.Text != "")
            {
                if (int.TryParse(inputTextbox.Text, out inputNumber))
                {
                    ExpandNum(inputTextbox.Text);
                }
                else
                {
                    MessageBox.Show("Enter Only Numeric Values");
                }
            }
            else
            {
                MessageBox.Show("Enter The Number(s) Please");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            inputTextbox.Clear();
            outputTextbox.Clear();
        }
    }
}
