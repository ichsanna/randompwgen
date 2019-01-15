namespace Random_Password_Generator
{
    partial class Form1
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
            ((System.ComponentModel.ISupportInitialize)(this.trackbar_pwlength)).BeginInit();
            this.SuspendLayout();
            // 
            // button_generate
            // 
            this.button_generate.Location = new System.Drawing.Point(496, 38);
            this.button_generate.Name = "button_generate";
            this.button_generate.Size = new System.Drawing.Size(90, 48);
            this.button_generate.TabIndex = 0;
            this.button_generate.Text = "Generate";
            this.button_generate.UseVisualStyleBackColor = true;
            this.button_generate.Click += new System.EventHandler(this.button_generate_Click);
            // 
            // label_pwlength
            // 
            this.label_pwlength.AutoSize = true;
            this.label_pwlength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_pwlength.Location = new System.Drawing.Point(148, 182);
            this.label_pwlength.Name = "label_pwlength";
            this.label_pwlength.Size = new System.Drawing.Size(23, 25);
            this.label_pwlength.TabIndex = 8;
            this.label_pwlength.Text = "8";
            // 
            // label_length
            // 
            this.label_length.AutoSize = true;
            this.label_length.Location = new System.Drawing.Point(12, 189);
            this.label_length.Name = "label_length";
            this.label_length.Size = new System.Drawing.Size(121, 17);
            this.label_length.TabIndex = 6;
            this.label_length.Text = "Password Length:";
            // 
            // checkbox_uppercase
            // 
            this.checkbox_uppercase.Location = new System.Drawing.Point(186, 120);
            this.checkbox_uppercase.Name = "checkbox_uppercase";
            this.checkbox_uppercase.Size = new System.Drawing.Size(148, 21);
            this.checkbox_uppercase.TabIndex = 4;
            this.checkbox_uppercase.Text = "Uppercase Letters";
            this.checkbox_uppercase.UseVisualStyleBackColor = true;
            this.checkbox_uppercase.CheckedChanged += new System.EventHandler(this.checkbox_uppercase_CheckedChanged);
            // 
            // checkbox_symbol
            // 
            this.checkbox_symbol.Location = new System.Drawing.Point(505, 120);
            this.checkbox_symbol.Name = "checkbox_symbol";
            this.checkbox_symbol.Size = new System.Drawing.Size(98, 21);
            this.checkbox_symbol.TabIndex = 2;
            this.checkbox_symbol.Text = "Symbols";
            this.checkbox_symbol.UseVisualStyleBackColor = true;
            this.checkbox_symbol.CheckedChanged += new System.EventHandler(this.checkbox_symbol_CheckedChanged);
            // 
            // checkbox_number
            // 
            this.checkbox_number.Checked = true;
            this.checkbox_number.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkbox_number.Location = new System.Drawing.Point(366, 120);
            this.checkbox_number.Name = "checkbox_number";
            this.checkbox_number.Size = new System.Drawing.Size(98, 21);
            this.checkbox_number.TabIndex = 1;
            this.checkbox_number.Text = "Numbers";
            this.checkbox_number.UseVisualStyleBackColor = true;
            this.checkbox_number.CheckedChanged += new System.EventHandler(this.checkbox_number_CheckedChanged);
            // 
            // checkbox_lowercase
            // 
            this.checkbox_lowercase.Checked = true;
            this.checkbox_lowercase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkbox_lowercase.Location = new System.Drawing.Point(12, 120);
            this.checkbox_lowercase.Name = "checkbox_lowercase";
            this.checkbox_lowercase.Size = new System.Drawing.Size(146, 21);
            this.checkbox_lowercase.TabIndex = 0;
            this.checkbox_lowercase.Text = "Lowercase Letters";
            this.checkbox_lowercase.UseVisualStyleBackColor = true;
            this.checkbox_lowercase.CheckedChanged += new System.EventHandler(this.checkbox_lowercase_CheckedChanged);
            // 
            // trackbar_pwlength
            // 
            this.trackbar_pwlength.Location = new System.Drawing.Point(186, 182);
            this.trackbar_pwlength.Maximum = 44;
            this.trackbar_pwlength.Name = "trackbar_pwlength";
            this.trackbar_pwlength.Size = new System.Drawing.Size(470, 56);
            this.trackbar_pwlength.TabIndex = 7;
            this.trackbar_pwlength.Value = 2;
            this.trackbar_pwlength.Scroll += new System.EventHandler(this.trackbar_pwlength_Scroll);
            // 
            // textbox_password
            // 
            this.textbox_password.DetectUrls = false;
            this.textbox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textbox_password.Location = new System.Drawing.Point(12, 44);
            this.textbox_password.Multiline = false;
            this.textbox_password.Name = "textbox_password";
            this.textbox_password.ReadOnly = true;
            this.textbox_password.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.textbox_password.Size = new System.Drawing.Size(478, 36);
            this.textbox_password.TabIndex = 1;
            this.textbox_password.Text = "";
            this.textbox_password.WordWrap = false;
            // 
            // button_copy
            // 
            this.button_copy.Location = new System.Drawing.Point(592, 38);
            this.button_copy.Name = "button_copy";
            this.button_copy.Size = new System.Drawing.Size(78, 48);
            this.button_copy.TabIndex = 9;
            this.button_copy.Text = "Copy";
            this.button_copy.UseVisualStyleBackColor = true;
            this.button_copy.Click += new System.EventHandler(this.button_copy_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(682, 253);
            this.Controls.Add(this.button_copy);
            this.Controls.Add(this.label_pwlength);
            this.Controls.Add(this.label_length);
            this.Controls.Add(this.textbox_password);
            this.Controls.Add(this.checkbox_uppercase);
            this.Controls.Add(this.trackbar_pwlength);
            this.Controls.Add(this.checkbox_lowercase);
            this.Controls.Add(this.button_generate);
            this.Controls.Add(this.checkbox_number);
            this.Controls.Add(this.checkbox_symbol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Random Password Generator";
            ((System.ComponentModel.ISupportInitialize)(this.trackbar_pwlength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

