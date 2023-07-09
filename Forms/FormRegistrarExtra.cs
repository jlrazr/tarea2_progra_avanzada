using System;
using Tarea2.Forms;
using Tarea2;

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
            int idCateg;
            int precio;
            bool activa = checkBox_reg_extra_activa.Checked;
            CategoriaPlato categ;


            //Validación de los datos
            if (textBox_reg_extra_desc.Text == null || textBox_reg_extra_desc.Text == "")
            {
                var mensaje = new FormMensaje("Error: Verifique la descripción de la extra");
                mensaje.ShowDialog();
            }
            else if (textBox_reg_extra_idCateg.Text == null || textBox_reg_extra_idCateg.Text == "")
            {
                var mensaje = new FormMensaje("Error: Verifique el ID de la categoría");
                mensaje.ShowDialog();
            }
            else if (textBox_reg_extra_precio.Text == null || textBox_reg_extra_precio.Text == "")
            {
                var mensaje = new FormMensaje("Error: Verifique el precio de la extra");
                mensaje.ShowDialog();
            }
            else
            {
                var validaCateg = managerCategPlatos.GetPorId(int.Parse(textBox_reg_extra_idCateg.Text));

                if (validaCateg == null)
                {
                    var mensaje = new FormMensaje("Error: El ID ingresado no corresponde a ninguna categoría");
                    mensaje.ShowDialog();
                }
                else
                {
                    precio = int.Parse(textBox_reg_extra_precio.Text);
                    idCateg = int.Parse(textBox_reg_extra_idCateg.Text);
                    categ = managerCategPlatos.GetPorId(idCateg);

                    try
                    {
                        Extra nuevaExtra = new(descripcion, categ, activa, precio);

                        // Registra la extra
                        managerExtra.RegistrarExtra(nuevaExtra);

                        var mensaje = new FormMensaje("La extra " + descripcion + " ha sido añadida");
                        mensaje.ShowDialog();

                        textBox_reg_extra_desc.Text = "";
                        textBox_reg_extra_precio.Text = "";
                        textBox_reg_extra_idCateg.Text = "";
                        checkBox_reg_extra_activa.Checked = false;
                    }
                    catch (Exception ex)
                    {
                        var mensaje = new FormMensaje("Error: " + ex);
                        mensaje.ShowDialog();
                    }
                }

            }
        }
    }
}
