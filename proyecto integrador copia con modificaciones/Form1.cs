namespace proyecto_integrador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // ------------------------------------------------------------------
        // M�TODO PRINCIPAL DE INICIO DE SESI�N
        // Se ejecuta cuando el usuario hace clic en el bot�n 'button1' (Ingresar)
        // ------------------------------------------------------------------
        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Capturar los valores de los TextBoxes
            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;

            // 2. L�gica de validaci�n (Usuario: admin, Contrase�a: 1234)
            if (usuario == "admin" && contrasena == "1234")
            {
                // LOGIN EXITOSO

                // Crea una nueva instancia del formulario principal
                FormPrincipal principal = new FormPrincipal();

                // Muestra la nueva ventana
                principal.Show();

                // Cierra el formulario de login actual, liberando recursos
                this.Close();
            }
            else
            {
                // LOGIN FALLIDO

                // Muestra un mensaje de error
                MessageBox.Show("Usuario o contrase�a incorrectos.", "Error de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Limpia el campo de contrase�a
                txtContrasena.Clear();

                // Mueve el cursor al campo de usuario para que reintente
                txtUsuario.Focus();
            }
        }

        // Puedes borrar todos estos m�todos si est�n vac�os, 
        // ya que no contienen l�gica de negocio importante.
        private void Form1_Load(object sender, EventArgs e)
        {
            // Este m�todo se ejecuta al cargar el formulario
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            // Este m�todo se ejecuta cada vez que el texto del usuario cambia
        }

        private void txtContrasena_TextChanged(object sender, EventArgs e)
        {
            // Este m�todo se ejecuta cada vez que el texto de la contrase�a cambia
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
          
            // Oculta el formulario actual (el de login)
            this.Hide();

            // Crea una instancia del formulario de registro
            FormRegistro formRegistro = new FormRegistro();

            // Muestra el formulario de registro
            formRegistro.Show();
        }
    }
}