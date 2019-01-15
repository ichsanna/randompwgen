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
    public partial class Form1 : Form
    {
        bool genlowercase = true;
        bool genuppercase = false;
        bool gennumber = true;
        bool gensymbol = false;
        int passwordlength = 8;
        char[] lowercase = new char[26] {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};
        char[] uppercase = new char[26] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        char[] number = new char[10] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        char[] symbol = new char[31] { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '_', '=', '+', '`', '~', '[', ']', '{', '}', ';', '"', ':', ',', '.', '/', '<', '>', '?' ,'|', '"' };
        public Form1()
        {
            InitializeComponent();
            textbox_password.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void button_generate_Click(object sender, EventArgs e)
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
                password[i] = randompasswd[rand.Next(0, method+1)];
            }
            string output = new string(password);
            textbox_password.Text = output;
        }

        private void checkbox_lowercase_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_lowercase.Checked == true) genlowercase = true;
            else genlowercase = false;
        }

        private void checkbox_uppercase_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_uppercase.Checked == true) genuppercase = true;
            else genuppercase = false;
        }

        private void checkbox_number_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_number.Checked == true) gennumber = true;
            else gennumber = false;
        }

        private void checkbox_symbol_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_symbol.Checked == true) gensymbol = true;
            else gensymbol = false;
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
    }
}
