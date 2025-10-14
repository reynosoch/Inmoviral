namespace proyecto_integrador
{
    partial class FormRegistro
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
            textBox1 = new TextBox();
            label3 = new Label();
            button4 = new Button();
            checkBox = new CheckBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            txtContrasena = new TextBox();
            txtUsuario = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Coral;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(695, 333);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(420, 27);
            textBox1.TabIndex = 33;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(695, 310);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 32;
            label3.Text = "contraseña";
            // 
            // button4
            // 
            button4.ForeColor = SystemColors.ControlText;
            button4.Location = new Point(691, 574);
            button4.Name = "button4";
            button4.Size = new Size(260, 55);
            button4.TabIndex = 31;
            button4.Text = "Register";
            button4.UseVisualStyleBackColor = true;
            // 
            // checkBox
            // 
            checkBox.AutoSize = true;
            checkBox.Location = new Point(691, 505);
            checkBox.Name = "checkBox";
            checkBox.Size = new Size(385, 24);
            checkBox.TabIndex = 30;
            checkBox.Text = "Acepto todos los términos y la política de privacidad.";
            checkBox.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Captura_de_pantalla_2025_10_09_110406;
            pictureBox2.Location = new Point(-1, -3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(501, 728);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 29;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Snow;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = Properties.Resources.Diseño_sin_título__1_;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(637, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(522, 154);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // txtContrasena
            // 
            txtContrasena.BackColor = Color.Coral;
            txtContrasena.BorderStyle = BorderStyle.None;
            txtContrasena.Cursor = Cursors.IBeam;
            txtContrasena.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtContrasena.Location = new Point(695, 400);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(420, 27);
            txtContrasena.TabIndex = 27;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.Coral;
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Cursor = Cursors.IBeam;
            txtUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(695, 240);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(420, 27);
            txtUsuario.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(691, 377);
            label2.Name = "label2";
            label2.Size = new Size(151, 20);
            label2.TabIndex = 25;
            label2.Text = "Confirmar contraseña";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(695, 206);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 24;
            label1.Text = "usuario";
            // 
            // FormRegistro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1657, 695);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(button4);
            Controls.Add(checkBox);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(txtContrasena);
            Controls.Add(txtUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormRegistro";
            Text = "FormRegistro";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label3;
        private Button button4;
        private CheckBox checkBox;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private TextBox txtContrasena;
        private TextBox txtUsuario;
        private Label label2;
        private Label label1;
    }
}