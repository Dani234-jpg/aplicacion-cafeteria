namespace aplicacion_cafeteria
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
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            textBox2 = new TextBox();
            linkLabel1 = new LinkLabel();
            button1 = new Button();
            label6 = new Label();
            linkLabel3 = new LinkLabel();
            panel1 = new Panel();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.log_cafe;
            pictureBox1.Location = new Point(173, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(109, 145);
            label4.Name = "label4";
            label4.Size = new Size(85, 17);
            label4.TabIndex = 4;
            label4.Text = "Email adress";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(109, 197);
            label5.Name = "label5";
            label5.Size = new Size(66, 17);
            label5.TabIndex = 6;
            label5.Text = "password";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(109, 165);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(254, 18);
            textBox2.TabIndex = 7;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(270, 238);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(93, 15);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "forgot password";
            // 
            // button1
            // 
            button1.BackColor = Color.BurlyWood;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(131, 271);
            button1.Name = "button1";
            button1.Size = new Size(189, 27);
            button1.TabIndex = 9;
            button1.Text = "Sign up";
            button1.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(131, 301);
            label6.Name = "label6";
            label6.Size = new Size(167, 17);
            label6.TabIndex = 10;
            label6.Text = "You don't have an account?";
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.Location = new Point(292, 303);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(47, 15);
            linkLabel3.TabIndex = 12;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Sign up\r\n";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Tan;
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(linkLabel3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(342, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(449, 386);
            panel1.TabIndex = 13;
            panel1.Paint += panel1_Paint;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(109, 217);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(254, 18);
            textBox1.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(205, 178, 138);
            BackgroundImage = Properties.Resources.cafe1;
            ClientSize = new Size(1024, 472);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label4;
        private Label label5;
        private TextBox textBox2;
        private LinkLabel linkLabel1;
        private Button button1;
        private Label label6;
        private LinkLabel linkLabel3;
        private Panel panel1;
        private TextBox textBox1;
    }
}
