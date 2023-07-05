namespace Tarea2.Forms
{
    public partial class FormRegistrarCategPlato : Form
    {
        private ManagerCategPlatos managerCategPlatos;
        public FormRegistrarCategPlato(ManagerCategPlatos managerCategorias)
        {
            InitializeComponent();
            this.managerCategPlatos = managerCategorias;
        }

        private void button_reg_cat_plato_Click(object sender, EventArgs e)
        {
            string descripcion = textBox_reg_cat_descripcion.Text;
            bool activo = checkBox_reg_cat_activa.Checked;

            CategoriaPlato nuevaCategoria = new(descripcion, activo);

            // Registra la categoría
            managerCategPlatos.Registrar(nuevaCategoria);
        }
    }
}