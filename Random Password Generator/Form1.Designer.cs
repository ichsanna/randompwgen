namespace Random_Password_Generator
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button_generate = new System.Windows.Forms.Button();
            this.label_pwlength = new System.Windows.Forms.Label();
            this.label_length = new System.Windows.Forms.Label();
            this.checkbox_uppercase = new System.Windows.Forms.CheckBox();
            this.checkbox_symbol = new System.Windows.Forms.CheckBox();
            this.checkbox_number = new System.Windows.Forms.CheckBox();
            this.checkbox_lowercase = new System.Windows.Forms.CheckBox();
            this.trackbar_pwlength = new System.Windows.Forms.TrackBar();
            this.textbox_password = new System.Windows.Forms.RichTextBox();
            this.button_copy = new System.Windows.Forms.Button();
            this.panel_header = new System.Windows.Forms.Panel();
            this.label_randompwgen = new System.Windows.Forms.Label();
            this.button_minimize = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.panel_options = new System.Windows.Forms.Panel();
            this.button_decreasepwlength = new System.Windows.Forms.Button();
            this.button_increasepwlength = new System.Windows.Forms.Button();
            this.panel_passwordstrength2 = new System.Windows.Forms.Panel();
            this.label_passwordstrength = new System.Windows.Forms.Label();
            this.panel_passwordstrength = new System.Windows.Forms.Panel();
            this.timer_checkstrength = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trackbar_pwlength)).BeginInit();
            this.panel_header.SuspendLayout();
            this.panel_options.SuspendLayout();
            this.panel_passwordstrength2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_generate
            // 
            this.button_generate.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_generate.FlatAppearance.BorderSize = 0;
            this.button_generate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_generate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.3F);
            this.button_generate.ForeColor = System.Drawing.Color.White;
            this.button_generate.Location = new System.Drawing.Point(501, 66);
            this.button_generate.Name = "button_generate";
            this.button_generate.Size = new System.Drawing.Size(102, 48);
            this.button_generate.TabIndex = 0;
            this.button_generate.Text = "Generate";
            this.button_generate.UseVisualStyleBackColor = false;
            this.button_generate.Click += new System.EventHandler(this.button_generate_Click);
            // 
            // label_pwlength
            // 
            this.label_pwlength.AutoSize = true;
            this.label_pwlength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_pwlength.ForeColor = System.Drawing.Color.Black;
            this.label_pwlength.Location = new System.Drawing.Point(254, 56);
            this.label_pwlength.Name = "label_pwlength";
            this.label_pwlength.Size = new System.Drawing.Size(23, 25);
            this.label_pwlength.TabIndex = 8;
            this.label_pwlength.Text = "6";
            this.label_pwlength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_length
            // 
            this.label_length.AutoSize = true;
            this.label_length.ForeColor = System.Drawing.Color.Black;
            this.label_length.Location = new System.Drawing.Point(442, 35);
            this.label_length.Name = "label_length";
            this.label_length.Size = new System.Drawing.Size(117, 17);
            this.label_length.TabIndex = 6;
            this.label_length.Text = "Password Length";
            // 
            // checkbox_uppercase
            // 
            this.checkbox_uppercase.ForeColor = System.Drawing.Color.Black;
            this.checkbox_uppercase.Location = new System.Drawing.Point(13, 82);
            this.checkbox_uppercase.Name = "checkbox_uppercase";
            this.checkbox_uppercase.Size = new System.Drawing.Size(148, 21);
            this.checkbox_uppercase.TabIndex = 4;
            this.checkbox_uppercase.Text = "Uppercase Letters";
            this.checkbox_uppercase.UseVisualStyleBackColor = true;
            this.checkbox_uppercase.CheckedChanged += new System.EventHandler(this.checkbox_uppercase_CheckedChanged);
            // 
            // checkbox_symbol
            // 
            this.checkbox_symbol.ForeColor = System.Drawing.Color.Black;
            this.checkbox_symbol.Location = new System.Drawing.Point(13, 136);
            this.checkbox_symbol.Name = "checkbox_symbol";
            this.checkbox_symbol.Size = new System.Drawing.Size(98, 21);
            this.checkbox_symbol.TabIndex = 2;
            this.checkbox_symbol.Text = "Symbols";
            this.checkbox_symbol.UseVisualStyleBackColor = true;
            this.checkbox_symbol.CheckedChanged += new System.EventHandler(this.checkbox_symbol_CheckedChanged);
            // 
            // checkbox_number
            // 
            this.checkbox_number.ForeColor = System.Drawing.Color.Black;
            this.checkbox_number.Location = new System.Drawing.Point(13, 109);
            this.checkbox_number.Name = "checkbox_number";
            this.checkbox_number.Size = new System.Drawing.Size(98, 21);
            this.checkbox_number.TabIndex = 1;
            this.checkbox_number.Text = "Numbers";
            this.checkbox_number.UseVisualStyleBackColor = true;
            this.checkbox_number.CheckedChanged += new System.EventHandler(this.checkbox_number_CheckedChanged);
            // 
            // checkbox_lowercase
            // 
            this.checkbox_lowercase.ForeColor = System.Drawing.Color.Black;
            this.checkbox_lowercase.Location = new System.Drawing.Point(13, 55);
            this.checkbox_lowercase.Name = "checkbox_lowercase";
            this.checkbox_lowercase.Size = new System.Drawing.Size(146, 21);
            this.checkbox_lowercase.TabIndex = 0;
            this.checkbox_lowercase.Text = "Lowercase Letters";
            this.checkbox_lowercase.UseVisualStyleBackColor = true;
            this.checkbox_lowercase.CheckedChanged += new System.EventHandler(this.checkbox_lowercase_CheckedChanged);
            // 
            // trackbar_pwlength
            // 
            this.trackbar_pwlength.Location = new System.Drawing.Point(364, 55);
            this.trackbar_pwlength.Maximum = 44;
            this.trackbar_pwlength.Name = "trackbar_pwlength";
            this.trackbar_pwlength.Size = new System.Drawing.Size(311, 56);
            this.trackbar_pwlength.TabIndex = 7;
            this.trackbar_pwlength.Scroll += new System.EventHandler(this.trackbar_pwlength_Scroll);
            // 
            // textbox_password
            // 
            this.textbox_password.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textbox_password.DetectUrls = false;
            this.textbox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textbox_password.Location = new System.Drawing.Point(12, 72);
            this.textbox_password.Multiline = false;
            this.textbox_password.Name = "textbox_password";
            this.textbox_password.ReadOnly = true;
            this.textbox_password.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.textbox_password.Size = new System.Drawing.Size(483, 36);
            this.textbox_password.TabIndex = 1;
            this.textbox_password.Text = "";
            this.textbox_password.WordWrap = false;
            // 
            // button_copy
            // 
            this.button_copy.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_copy.FlatAppearance.BorderSize = 0;
            this.button_copy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_copy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.3F);
            this.button_copy.ForeColor = System.Drawing.Color.White;
            this.button_copy.Location = new System.Drawing.Point(609, 66);
            this.button_copy.Name = "button_copy";
            this.button_copy.Size = new System.Drawing.Size(78, 48);
            this.button_copy.TabIndex = 9;
            this.button_copy.Text = "Copy";
            this.button_copy.UseVisualStyleBackColor = false;
            this.button_copy.Click += new System.EventHandler(this.button_copy_Click);
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel_header.Controls.Add(this.label_randompwgen);
            this.panel_header.Controls.Add(this.button_minimize);
            this.panel_header.Controls.Add(this.button_close);
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(702, 50);
            this.panel_header.TabIndex = 11;
            this.panel_header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_header_MouseDown);
            // 
            // label_randompwgen
            // 
            this.label_randompwgen.AutoSize = true;
            this.label_randompwgen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label_randompwgen.ForeColor = System.Drawing.Color.White;
            this.label_randompwgen.Location = new System.Drawing.Point(12, 8);
            this.label_randompwgen.Name = "label_randompwgen";
            this.label_randompwgen.Size = new System.Drawing.Size(372, 31);
            this.label_randompwgen.TabIndex = 12;
            this.label_randompwgen.Text = "Random Password Generator";
            this.label_randompwgen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_header_MouseDown);
            // 
            // button_minimize
            // 
            this.button_minimize.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_minimize.FlatAppearance.BorderSize = 0;
            this.button_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.button_minimize.ForeColor = System.Drawing.Color.White;
            this.button_minimize.Location = new System.Drawing.Point(613, 0);
            this.button_minimize.Name = "button_minimize";
            this.button_minimize.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.button_minimize.Size = new System.Drawing.Size(45, 45);
            this.button_minimize.TabIndex = 14;
            this.button_minimize.Text = "_";
            this.button_minimize.UseVisualStyleBackColor = false;
            this.button_minimize.Click += new System.EventHandler(this.button_minimize_Click);
            this.button_minimize.MouseEnter += new System.EventHandler(this.button_minimize_MouseEnter);
            this.button_minimize.MouseLeave += new System.EventHandler(this.button_minimize_MouseLeave);
            // 
            // button_close
            // 
            this.button_close.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_close.FlatAppearance.BorderSize = 0;
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button_close.ForeColor = System.Drawing.Color.White;
            this.button_close.Location = new System.Drawing.Point(657, 0);
            this.button_close.Name = "button_close";
            this.button_close.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.button_close.Size = new System.Drawing.Size(45, 45);
            this.button_close.TabIndex = 13;
            this.button_close.Text = "X";
            this.button_close.UseVisualStyleBackColor = false;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            this.button_close.MouseEnter += new System.EventHandler(this.button_close_MouseEnter);
            this.button_close.MouseLeave += new System.EventHandler(this.button_close_MouseLeave);
            // 
            // panel_options
            // 
            this.panel_options.BackColor = System.Drawing.Color.White;
            this.panel_options.Controls.Add(this.button_decreasepwlength);
            this.panel_options.Controls.Add(this.button_increasepwlength);
            this.panel_options.Controls.Add(this.panel_passwordstrength2);
            this.panel_options.Controls.Add(this.panel_passwordstrength);
            this.panel_options.Controls.Add(this.checkbox_lowercase);
            this.panel_options.Controls.Add(this.trackbar_pwlength);
            this.panel_options.Controls.Add(this.label_length);
            this.panel_options.Controls.Add(this.checkbox_uppercase);
            this.panel_options.Controls.Add(this.checkbox_symbol);
            this.panel_options.Controls.Add(this.checkbox_number);
            this.panel_options.Controls.Add(this.label_pwlength);
            this.panel_options.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_options.Location = new System.Drawing.Point(12, 138);
            this.panel_options.Name = "panel_options";
            this.panel_options.Size = new System.Drawing.Size(680, 200);
            this.panel_options.TabIndex = 12;
            // 
            // button_decreasepwlength
            // 
            this.button_decreasepwlength.BackColor = System.Drawing.Color.Transparent;
            this.button_decreasepwlength.FlatAppearance.BorderSize = 0;
            this.button_decreasepwlength.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_decreasepwlength.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button_decreasepwlength.ForeColor = System.Drawing.Color.Black;
            this.button_decreasepwlength.Location = new System.Drawing.Point(287, 53);
            this.button_decreasepwlength.Margin = new System.Windows.Forms.Padding(0);
            this.button_decreasepwlength.Name = "button_decreasepwlength";
            this.button_decreasepwlength.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.button_decreasepwlength.Size = new System.Drawing.Size(30, 30);
            this.button_decreasepwlength.TabIndex = 16;
            this.button_decreasepwlength.Text = "-";
            this.button_decreasepwlength.UseVisualStyleBackColor = false;
            // 
            // button_increasepwlength
            // 
            this.button_increasepwlength.BackColor = System.Drawing.Color.Transparent;
            this.button_increasepwlength.FlatAppearance.BorderSize = 0;
            this.button_increasepwlength.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_increasepwlength.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button_increasepwlength.ForeColor = System.Drawing.Color.Black;
            this.button_increasepwlength.Location = new System.Drawing.Point(328, 53);
            this.button_increasepwlength.Name = "button_increasepwlength";
            this.button_increasepwlength.Padding = new System.Windows.Forms.Padding(3, 0, 0, 6);
            this.button_increasepwlength.Size = new System.Drawing.Size(30, 30);
            this.button_increasepwlength.TabIndex = 15;
            this.button_increasepwlength.Text = "+";
            this.button_increasepwlength.UseVisualStyleBackColor = false;
            // 
            // panel_passwordstrength2
            // 
            this.panel_passwordstrength2.BackColor = System.Drawing.Color.Gold;
            this.panel_passwordstrength2.Controls.Add(this.label_passwordstrength);
            this.panel_passwordstrength2.Location = new System.Drawing.Point(0, 3);
            this.panel_passwordstrength2.Name = "panel_passwordstrength2";
            this.panel_passwordstrength2.Size = new System.Drawing.Size(111, 29);
            this.panel_passwordstrength2.TabIndex = 10;
            // 
            // label_passwordstrength
            // 
            this.label_passwordstrength.AutoSize = true;
            this.label_passwordstrength.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label_passwordstrength.ForeColor = System.Drawing.Color.White;
            this.label_passwordstrength.Location = new System.Drawing.Point(14, 4);
            this.label_passwordstrength.Name = "label_passwordstrength";
            this.label_passwordstrength.Size = new System.Drawing.Size(83, 20);
            this.label_passwordstrength.TabIndex = 11;
            this.label_passwordstrength.Text = "MEDIUM";
            this.label_passwordstrength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_passwordstrength
            // 
            this.panel_passwordstrength.BackColor = System.Drawing.Color.Gold;
            this.panel_passwordstrength.Location = new System.Drawing.Point(0, 0);
            this.panel_passwordstrength.Name = "panel_passwordstrength";
            this.panel_passwordstrength.Size = new System.Drawing.Size(680, 10);
            this.panel_passwordstrength.TabIndex = 9;
            // 
            // timer_checkstrength
            // 
            this.timer_checkstrength.Interval = 1;
            this.timer_checkstrength.Tick += new System.EventHandler(this.timer_checkstrength_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(700, 350);
            this.Controls.Add(this.panel_header);
            this.Controls.Add(this.button_copy);
            this.Controls.Add(this.textbox_password);
            this.Controls.Add(this.button_generate);
            this.Controls.Add(this.panel_options);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "Random Password Generator";
            ((System.ComponentModel.ISupportInitialize)(this.trackbar_pwlength)).EndInit();
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            this.panel_options.ResumeLayout(false);
            this.panel_options.PerformLayout();
            this.panel_passwordstrength2.ResumeLayout(false);
            this.panel_passwordstrength2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_generate;
        private System.Windows.Forms.CheckBox checkbox_symbol;
        private System.Windows.Forms.CheckBox checkbox_number;
        private System.Windows.Forms.CheckBox checkbox_lowercase;
        private System.Windows.Forms.RichTextBox textbox_password;
        private System.Windows.Forms.CheckBox checkbox_uppercase;
        private System.Windows.Forms.TrackBar trackbar_pwlength;
        private System.Windows.Forms.Label label_length;
        private System.Windows.Forms.Label label_pwlength;
        private System.Windows.Forms.Button button_copy;
        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Label label_randompwgen;
        private System.Windows.Forms.Button button_minimize;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Panel panel_options;
        private System.Windows.Forms.Panel panel_passwordstrength2;
        private System.Windows.Forms.Panel panel_passwordstrength;
        private System.Windows.Forms.Label label_passwordstrength;
        private System.Windows.Forms.Timer timer_checkstrength;
        private System.Windows.Forms.Button button_decreasepwlength;
        private System.Windows.Forms.Button button_increasepwlength;
    }
}

