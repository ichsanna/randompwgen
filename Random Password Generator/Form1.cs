using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_Password_Generator
{
    public partial class Main : Form
    {
        bool genlowercase;
        bool genuppercase;
        bool gennumber;
        bool gensymbol;
        int passwordlength;
        char[] lowercase = new char[26] {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};
        char[] uppercase = new char[26] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        char[] number = new char[10] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        char[] symbol = new char[31] { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '_', '=', '+', '`', '~', '[', ']', '{', '}', ';', '"', ':', ',', '.', '/', '<', '>', '?' ,'|', '"' };
        public Main()
        {
            InitializeComponent();
            textbox_password.SelectionAlignment = HorizontalAlignment.Center;
            timer_checkstrength.Start();
            checkbox_lowercase.Checked = true;
            checkbox_number.Checked = true;
            trackbar_pwlength.Value = 4;
            passwordlength = trackbar_pwlength.Value+6;
            genlowercase = checkbox_lowercase.Checked;
            genuppercase = checkbox_uppercase.Checked;
            gennumber = checkbox_number.Checked;
            gensymbol = checkbox_symbol.Checked;
            label_pwlength.Text = passwordlength.ToString();
            generatepassword();
        }

        private void generatepassword()
        {
            Random rand = new Random();
            char[] randompasswd = new char[4];
            char[] password = new char[passwordlength];
            int method;
            for (int i = 0; i < passwordlength; i++)
            {
                method = -1;
                if (genlowercase)
                {
                    method++;
                    randompasswd[method] = lowercase[rand.Next(0, lowercase.Length)];
                }
                if (genuppercase)
                {
                    method++;
                    randompasswd[method] = uppercase[rand.Next(0, uppercase.Length)];
                }
                if (gennumber)
                {
                    method++;
                    randompasswd[method] = number[rand.Next(0, number.Length)];
                }
                if (gensymbol)
                {
                    method++;
                    randompasswd[method] = symbol[rand.Next(0, symbol.Length)];
                }
                password[i] = randompasswd[rand.Next(0, method + 1)];
            }
            string output = new string(password);
            textbox_password.Text = output;
        }
        private void button_generate_Click(object sender, EventArgs e)
        {
            generatepassword();
        }

        private void checkbox_lowercase_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_lowercase.Checked)
            {
                genlowercase = true;
            }
            else
            {
                genlowercase = false;
            }
        }

        private void checkbox_uppercase_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_uppercase.Checked)
            {
                genuppercase = true;
            }
            else
            {
                genuppercase = false;
            }
        }

        private void checkbox_number_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_number.Checked)
            {
                gennumber = true;
            }
            else
            {
                gennumber = false;
            }
        }

        private void checkbox_symbol_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_symbol.Checked)
            {
                gensymbol = true;
            }
            else
            {
                gensymbol = false;
            }
        }

        private void trackbar_pwlength_Scroll(object sender, EventArgs e)
        {
            passwordlength = trackbar_pwlength.Value + 6;
            label_pwlength.Text = passwordlength.ToString();
        }

        private void button_copy_Click(object sender, EventArgs e)
        {
               Clipboard.SetText(textbox_password.Text);
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void panel_header_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void button_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button_close_MouseEnter(object sender, EventArgs e)
        {
            button_close.BackColor = Color.Crimson;
        }

        private void button_close_MouseLeave(object sender, EventArgs e)
        {
            button_close.BackColor = Color.DodgerBlue;
        }

        private void button_minimize_MouseEnter(object sender, EventArgs e)
        {
            button_minimize.BackColor = Color.LightSkyBlue;
        }

        private void button_minimize_MouseLeave(object sender, EventArgs e)
        {
            button_minimize.BackColor = Color.DodgerBlue;
        }
        private void timer_checkstrength_Tick(object sender, EventArgs e)
        {
            int strength = 0;
            string strengthdisplay = "";
            if (genlowercase) strength+=3;
            if (genuppercase) strength+=3;
            if (gennumber) strength+=3;
            if (gensymbol) strength+=3;
            strength += trackbar_pwlength.Value;
            if (!genlowercase && !genuppercase && !gennumber && !gensymbol)
            {
                strengthdisplay = ".....";
                panel_passwordstrength.BackColor = Color.Black;
                panel_passwordstrength2.BackColor = Color.Black;
                button_generate.Enabled = false;
                button_generate.BackColor = Color.DarkGray;
            }
            else if (strength < 8)
            {
                strengthdisplay = "WEAK";
                panel_passwordstrength.BackColor = Color.Crimson;
                panel_passwordstrength2.BackColor = Color.Crimson;
                button_generate.Enabled = true;
            }
            else if (strength >= 8 && strength < 17)
            {
                strengthdisplay = "MEDIUM";
                panel_passwordstrength.BackColor = Color.Gold;
                panel_passwordstrength2.BackColor = Color.Gold;
                button_generate.Enabled = true;
            }
            else
            {
                strengthdisplay = "STRONG";
                panel_passwordstrength.BackColor = Color.LimeGreen;
                panel_passwordstrength2.BackColor = Color.LimeGreen;
                button_generate.Enabled = true;
            }
            label_passwordstrength.Text = strengthdisplay;
            if (button_generate.Enabled) button_generate.BackColor = Color.DodgerBlue;
        }

        
    }
}
