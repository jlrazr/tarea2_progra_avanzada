using System.ComponentModel;

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

        private void button_reg_cliente_Click(object sender, EventArgs e)
        {
            string nombre = textBox_reg_cliente_nombre.Text;
            string primApellido = textBox_reg_cliente_apellido1.Text;
            string segApellido = textBox_reg_cliente_apellido2.Text;
            DateTime fechaNacim = dateTimePicker_reg_cliente_dob.Value;
            char genero;

            if (radioButton_reg_cliente_m.Checked)
            {
                genero = 'm';
            }
            else
            {
                genero = 'f';
            };

            Cliente nuevoCliente = new(nombre, primApellido, segApellido, fechaNacim, genero);

            // Registra el restaurante
            managerClientes.Registrar(nuevoCliente);
        }
    }
}
