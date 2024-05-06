namespace LoginApplication
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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            checkBox1 = new CheckBox();
            label3 = new Label();
            textBox3 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(403, 300);
            button1.Name = "button1";
            button1.Size = new Size(94, 40);
            button1.TabIndex = 0;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(552, 300);
            button2.Name = "button2";
            button2.Size = new Size(94, 40);
            button2.TabIndex = 1;
            button2.Text = "Cancle";
            button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(403, 78);
            label1.Name = "label1";
            label1.Size = new Size(92, 23);
            label1.TabIndex = 2;
            label1.Text = "UserName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(403, 133);
            label2.Name = "label2";
            label2.Size = new Size(85, 23);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.ForeColor = Color.Red;
            linkLabel1.LinkColor = Color.Red;
            linkLabel1.Location = new Point(467, 390);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(156, 23);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forgot Password ?";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(128, 255, 255);
            pictureBox1.Image = Properties.Resources.login_image;
            pictureBox1.Location = new Point(78, 74);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(210, 204);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(521, 74);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 30);
            textBox1.TabIndex = 6;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(521, 133);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(125, 30);
            textBox2.TabIndex = 7;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox1.ForeColor = Color.FromArgb(0, 192, 0);
            checkBox1.Location = new Point(500, 176);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(157, 27);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Show password";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(410, 236);
            label3.Name = "label3";
            label3.Size = new Size(54, 23);
            label3.TabIndex = 9;
            label3.Text = "Email";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(521, 229);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 30);
            textBox3.TabIndex = 10;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(checkBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(linkLabel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private CheckBox checkBox1;
        private Label label3;
        private TextBox textBox3;
    }
}
