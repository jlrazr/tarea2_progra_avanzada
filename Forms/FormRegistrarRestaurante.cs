namespace Tarea2
{
    public partial class FormRegistrarRestaurante : Form
    {
        private ManagerRestaurantes managerRest;
        public FormRegistrarRestaurante(ManagerRestaurantes managerRestaurantes)
        {
            InitializeComponent();
            this.managerRest = managerRestaurantes;
        }

        private void button_reg_restaurante_Click(object sender, EventArgs e)
        {
            string nombre = textBox_reg_rest_nombre.Text;
            string direccion = textBox_reg_rest_direccion.Text;
            bool activo = checkBox__reg_rest_activo.Checked;
            string telefono = textBox_reg_rest_telefono.Text;

            Restaurante nuevoRest = new(nombre, direccion, activo, telefono);

            // Registra el restaurante
            managerRest.Registrar(nuevoRest);
        }
    }
}