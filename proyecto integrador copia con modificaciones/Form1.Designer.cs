namespace proyecto_integrador
{
    partial class Form1
    {

        private System.ComponentModel.IContainer components = null;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            txtUsuario = new TextBox();
            txtContrasena = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            checkBox = new CheckBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(818, 686);
            button1.Name = "button1";
            button1.Size = new Size(260, 55);
            button1.TabIndex = 0;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(828, 332);
            label1.Name = "label1";
            label1.Size = new Size(129, 46);
            label1.TabIndex = 1;
            label1.Text = "usuario";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(828, 428);
            label2.Name = "label2";
            label2.Size = new Size(184, 46);
            label2.TabIndex = 2;
            label2.Text = "contraseña";
            label2.Click += label2_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.Coral;
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Cursor = Cursors.IBeam;
            txtUsuario.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(828, 381);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(420, 27);
            txtUsuario.TabIndex = 1;
            txtUsuario.TextChanged += txtUsuario_TextChanged_1;
            // 
            // txtContrasena
            // 
            txtContrasena.BackColor = Color.Coral;
            txtContrasena.BorderStyle = BorderStyle.None;
            txtContrasena.Cursor = Cursors.IBeam;
            txtContrasena.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtContrasena.Location = new Point(828, 477);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.PasswordChar = '*';
            txtContrasena.Size = new Size(420, 27);
            txtContrasena.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Snow;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = Properties.Resources.Diseño_sin_título__1_;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(733, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(656, 275);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Captura_de_pantalla_2025_10_09_110406;
            pictureBox2.Location = new Point(0, -3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(470, 776);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // checkBox
            // 
            checkBox.AutoSize = true;
            checkBox.Location = new Point(806, 632);
            checkBox.Name = "checkBox";
            checkBox.Size = new Size(385, 24);
            checkBox.TabIndex = 7;
            checkBox.Text = "Acepto todos los términos y la política de privacidad.";
            checkBox.UseVisualStyleBackColor = true;
            checkBox.CheckedChanged += checkBox_CheckedChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 0);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(806, 562);
            button2.Name = "button2";
            button2.Size = new Size(240, 54);
            button2.TabIndex = 8;
            button2.Text = "Continuar con Google";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Blue;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(1078, 562);
            button3.Name = "button3";
            button3.Size = new Size(281, 54);
            button3.TabIndex = 9;
            button3.Text = "Continuar con Facebook";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.ForeColor = SystemColors.ControlText;
            button4.Location = new Point(1099, 686);
            button4.Name = "button4";
            button4.Size = new Size(260, 55);
            button4.TabIndex = 10;
            button4.Text = "Register";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(1804, 772);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(checkBox);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(txtContrasena);
            Controls.Add(txtUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox txtUsuario;
        private TextBox txtContrasena;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private CheckBox checkBox;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
