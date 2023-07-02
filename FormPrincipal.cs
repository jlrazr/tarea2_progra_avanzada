namespace Tarea2
{
    public partial class FormPrincipal : Form
    {
        private ManagerRestaurantes managerRest = new();
        private ManagerPlatos managerPlatos = new();
        private ManagerCategPlatos managerCategPlatos = new();
        private ManagerClientes managerClientes = new();
        private ManagerRestaurantePlatos managerRestPlatos = new();
        private ManagerExtra managerExtra = new();
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void button_menu_reg_restaurante_Click(object sender, EventArgs e)
        {
            var form = new FormRegistrarRestaurante(managerRest);
            form.ShowDialog();
        }
    }
}