namespace proyecto_integrador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // ------------------------------------------------------------------
        // MÉTODO PRINCIPAL DE INICIO DE SESIÓN
        // Se ejecuta cuando el usuario hace clic en el botón 'button1' (Ingresar)
        // ------------------------------------------------------------------
        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Capturar los valores de los TextBoxes
            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;

            // 2. Lógica de validación (Usuario: admin, Contraseña: 1234)
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
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Limpia el campo de contraseña
                txtContrasena.Clear();

                // Mueve el cursor al campo de usuario para que reintente
                txtUsuario.Focus();
            }
        }

        // Puedes borrar todos estos métodos si están vacíos, 
        // ya que no contienen lógica de negocio importante.
        private void Form1_Load(object sender, EventArgs e)
        {
            // Este método se ejecuta al cargar el formulario
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            // Este método se ejecuta cada vez que el texto del usuario cambia
        }

        private void txtContrasena_TextChanged(object sender, EventArgs e)
        {
            // Este método se ejecuta cada vez que el texto de la contraseña cambia
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