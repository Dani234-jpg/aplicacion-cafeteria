namespace aplicacion_cafeteria
{
    partial class Contraseña
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
            panel1 = new Panel();
            button2 = new Button();
            textBox4 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label1 = new Label();
            linkLabel3 = new LinkLabel();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(linkLabel3);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(277, 47);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 386);
            panel1.TabIndex = 14;
            // 
            // button2
            // 
            button2.BackColor = Color.Tan;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(107, 353);
            button2.Name = "button2";
            button2.Size = new Size(130, 24);
            button2.TabIndex = 18;
            button2.Text = "Acceder";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.White;
            textBox4.Location = new Point(39, 319);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(254, 18);
            textBox4.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(40, 299);
            label2.Name = "label2";
            label2.Size = new Size(147, 17);
            label2.TabIndex = 16;
            label2.Text = "Confirmar Contraseña ";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.White;
            textBox3.Location = new Point(40, 268);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(254, 18);
            textBox3.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(39, 248);
            label1.Name = "label1";
            label1.Size = new Size(120, 17);
            label1.TabIndex = 14;
            label1.Text = "Contraseña Nueva";
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.Location = new Point(229, 335);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(0, 15);
            linkLabel3.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.log_cafe;
            pictureBox1.Location = new Point(107, 13);
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
            label4.Location = new Point(39, 147);
            label4.Name = "label4";
            label4.Size = new Size(121, 17);
            label4.TabIndex = 4;
            label4.Text = "Correo Electronico";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.Location = new Point(40, 167);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(254, 18);
            textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.Location = new Point(40, 218);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(254, 18);
            textBox1.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(39, 198);
            label5.Name = "label5";
            label5.Size = new Size(137, 17);
            label5.TabIndex = 6;
            label5.Text = "Contraseña existente";
            // 
            // button1
            // 
            button1.BackColor = Color.Tan;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(355, 406);
            button1.Name = "button1";
            button1.Size = new Size(189, 27);
            button1.TabIndex = 9;
            button1.Text = "Sign up";
            button1.UseVisualStyleBackColor = false;
            // 
            // Contraseña
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo2;
            ClientSize = new Size(884, 489);
            Controls.Add(panel1);
            Controls.Add(button1);
            Name = "Contraseña";
            Text = "Contraseña";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBox3;
        private Label label1;
        private Button button1;
        private LinkLabel linkLabel3;
        private PictureBox pictureBox1;
        private Label label4;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label5;
        private Button button2;
        private TextBox textBox4;
        private Label label2;
    }
}