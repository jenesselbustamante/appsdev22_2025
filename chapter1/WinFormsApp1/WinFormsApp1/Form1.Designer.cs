namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            firstName = new TextBox();
            label2 = new Label();
            lastName = new TextBox();
            Login = new Button();
            linkLabel1 = new LinkLabel();
            checkBox = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(221, 72);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            // 
            // firstName
            // 
            firstName.Location = new Point(172, 101);
            firstName.Name = "firstName";
            firstName.Size = new Size(174, 23);
            firstName.TabIndex = 1;
            firstName.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(223, 155);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 2;
            label2.Text = "Last Name";
            // 
            // lastName
            // 
            lastName.Location = new Point(172, 173);
            lastName.Name = "lastName";
            lastName.Size = new Size(174, 23);
            lastName.TabIndex = 3;
            // 
            // Login
            // 
            Login.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Login.Location = new Point(213, 202);
            Login.Name = "Login";
            Login.Size = new Size(75, 34);
            Login.TabIndex = 4;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = true;
            Login.Click += Login_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(248, 259);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(98, 15);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "forgot password?";
            // 
            // checkBox
            // 
            checkBox.AutoSize = true;
            checkBox.Location = new Point(138, 259);
            checkBox.Name = "checkBox";
            checkBox.Size = new Size(104, 19);
            checkBox.TabIndex = 6;
            checkBox.Text = "Remember Me";
            checkBox.UseVisualStyleBackColor = true;
            checkBox.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 371);
            Controls.Add(checkBox);
            Controls.Add(linkLabel1);
            Controls.Add(Login);
            Controls.Add(lastName);
            Controls.Add(label2);
            Controls.Add(firstName);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox firstName;
        private Label label2;
        private TextBox lastName;
        private Button Login;
        private LinkLabel linkLabel1;
        private CheckBox checkBox;
    }
}
