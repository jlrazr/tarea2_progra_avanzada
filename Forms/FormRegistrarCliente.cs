namespace Tarea2.Forms
{
    public partial class FormRegistrarCliente : Form
    {
        private ManagerClientes managerClientes;
        public FormRegistrarCliente(ManagerClientes managerClientes)
        {
            InitializeComponent();
            this.managerClientes = managerClientes;
        }
    }
}
