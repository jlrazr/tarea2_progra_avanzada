namespace Tarea2.Forms
{
    public partial class FormRegistrarPlato : Form
    {
        private ManagerPlatos managerPlatos;
        private ManagerCategPlatos managerCategPlatos;
        public FormRegistrarPlato(ManagerPlatos managePlatos, ManagerCategPlatos managerCategPlatos)
        {
            InitializeComponent();
            this.managerPlatos = managePlatos;
            this.managerCategPlatos = managerCategPlatos;
        }

        private void button_reg_plato_Click(object sender, EventArgs e)
        {
            string nombre = textBox_reg_plato_nombre.Text;
            int precio = int.Parse(textBox_reg_plato_precio.Text);
            int idCateg = int.Parse(textBox_reg_plato_idCateg.Text);

            CategoriaPlato categ = managerCategPlatos.GetPorId(idCateg);


            Plato nuevoPlato = new(nombre, precio, categ);

            // Registra el restaurante
            managerPlatos.Registrar(nuevoPlato);
        }
    }
}
