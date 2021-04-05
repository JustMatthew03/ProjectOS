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

namespace Calculator
{
    public partial class Calculator : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Calculator()
        {
            InitializeComponent();
        }

        int count;

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void MinimiseButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Num0_Click(object sender, EventArgs e)
        {
            if (InputField.Text == "0")
            {
                return;
            }
            else
            {
                InputField.Text = InputField.Text + 0;
            }
        }

        private void Num1_Click(object sender, EventArgs e)
        {
            if (InputField.Text == "0")
            {
                InputField.Text = "1";
            }
            else
            {
                InputField.Text = InputField.Text + 1;
            }
        }

        private void Num2_Click(object sender, EventArgs e)
        {
            if (InputField.Text == "0")
            {
                InputField.Text = "2";
            }
            else
            {
                InputField.Text = InputField.Text + 2;
            }
        }

        private void Num3_Click(object sender, EventArgs e)
        {
            if (InputField.Text == "0")
            {
                InputField.Text = "3";
            }
            else
            {
                InputField.Text = InputField.Text + 3;
            }
        }

        private void Num4_Click(object sender, EventArgs e)
        {
            if (InputField.Text == "0")
            {
                InputField.Text = "4";
            }
            else
            {
                InputField.Text = InputField.Text + 4;
            }
        }

        private void Num5_Click(object sender, EventArgs e)
        {
            if (InputField.Text == "0")
            {
                InputField.Text = "5";
            }
            else
            {
                InputField.Text = InputField.Text + 5;
            }
        }

        private void Num6_Click(object sender, EventArgs e)
        {
            if (InputField.Text == "0")
            {
                InputField.Text = "6";
            }
            else
            {
                InputField.Text = InputField.Text + 6;
            }
        }

        private void Num7_Click(object sender, EventArgs e)
        {
            if (InputField.Text == "0")
            {
                InputField.Text = "7";
            }
            else
            {
                InputField.Text = InputField.Text + 7;
            }
        }

        private void Num8_Click(object sender, EventArgs e)
        {
            if (InputField.Text == "0")
            {
                InputField.Text = "8";
            }
            else
            {
                InputField.Text = InputField.Text + 8;
            }
        }

        private void Num9_Click(object sender, EventArgs e)
        {
            if (InputField.Text == "0")
            {
                InputField.Text = "9";
            }
            else
            {
                InputField.Text = InputField.Text + 9;
            }
        }

        private void Decimal_Click(object sender, EventArgs e)
        {
            bool decimalFound = false;
            string value = InputField.Text;
            foreach (char character in value)
            {
                if (character == '.')
                {
                    decimalFound = true;
                }
            }

            if (decimalFound == false)
            {
                InputField.Text = InputField.Text + ".";
            }
        }

        float ans;
        float num1;
        private void button2_Click(object sender, EventArgs e)
        {
            Calculate(count);
        }

        public void Calculate(int count)
        {
            switch (count)
            {
                case 1:
                    ans = num1 + float.Parse(InputField.Text);
                    InputField.Text = ans.ToString();
                    break;
                case 2:
                    ans = num1 - float.Parse(InputField.Text);
                    InputField.Text = ans.ToString();
                    break;
                case 3:
                    ans = num1 * float.Parse(InputField.Text);
                    InputField.Text = ans.ToString();
                    break;
                case 4:
                    if (num1 == 0 || float.Parse(InputField.Text) == 0)
                    {
                        InputField.Text = "Math Error.";
                        break;
                    }
                    else
                    {
                        ans = num1 / float.Parse(InputField.Text);
                        InputField.Text = ans.ToString();
                        break;
                    }
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (InputField.Text != null)
            {
                num1 = float.Parse(InputField.Text);
                InputField.Clear();
                InputField.Focus();
                count = 1;
            }
        }

        private void Subtract_Click(object sender, EventArgs e)
        {
            if (InputField.Text != null)
            {
                num1 = float.Parse(InputField.Text);
                InputField.Clear();
                InputField.Focus();
                count = 2;
            }
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            if (InputField.Text != null)
            {
                num1 = float.Parse(InputField.Text);
                InputField.Clear();
                InputField.Focus();
                count = 3;
            }
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            if (InputField.Text != null)
            {
                num1 = float.Parse(InputField.Text);
                InputField.Clear();
                InputField.Focus();
                count = 4;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InputField.Text = "0";
        }
    }
}
