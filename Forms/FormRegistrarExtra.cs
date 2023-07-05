namespace Tarea2.Forms
{
    public partial class FormRegistrarExtra : Form
    {
        private ManagerExtra managerExtra;
        private ManagerCategPlatos managerCategPlatos;
        public FormRegistrarExtra(ManagerExtra managerExtra, ManagerCategPlatos managerCategPlatos)
        {
            InitializeComponent();
            this.managerExtra = managerExtra;
            this.managerCategPlatos = managerCategPlatos;
        }

        private void button_reg_extras_Click(object sender, EventArgs e)
        {
            string descripcion = textBox_reg_extra_desc.Text;
            int idCateg = int.Parse(textBox_reg_extra_idCateg.Text);
            int precio = int.Parse(textBox_reg_extra_precio.Text);
            bool activa = checkBox_reg_extra_activa.Checked;

            CategoriaPlato categ = managerCategPlatos.GetPorId(idCateg);


            Extra nuevaExtra = new(descripcion, idCateg, activa, precio);

            // Registra el restaurante
            managerExtra.RegistrarExtra(nuevaExtra);
        }
    }
}
