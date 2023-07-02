namespace Tarea2
{
    partial class FormRegistrarRestaurante
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            checkBox__reg_rest_activo = new CheckBox();
            textBox_reg_rest_nombre = new TextBox();
            label_reg_rest_nombre = new Label();
            label_reg_rest_direccion = new Label();
            textBox_reg_rest_direccion = new TextBox();
            label_reg_rest_telefono = new Label();
            textBox_reg_rest_telefono = new TextBox();
            button_reg_restaurante = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 17);
            label1.Name = "label1";
            label1.Size = new Size(178, 25);
            label1.TabIndex = 0;
            label1.Text = "Registrar Restaurante";
            // 
            // checkBox__reg_rest_activo
            // 
            checkBox__reg_rest_activo.AutoSize = true;
            checkBox__reg_rest_activo.Location = new Point(24, 294);
            checkBox__reg_rest_activo.Name = "checkBox__reg_rest_activo";
            checkBox__reg_rest_activo.Size = new Size(249, 29);
            checkBox__reg_rest_activo.TabIndex = 1;
            checkBox__reg_rest_activo.Text = "¿Está el restaurante activo?";
            checkBox__reg_rest_activo.UseVisualStyleBackColor = true;
            // 
            // textBox_reg_rest_nombre
            // 
            textBox_reg_rest_nombre.Location = new Point(24, 110);
            textBox_reg_rest_nombre.Name = "textBox_reg_rest_nombre";
            textBox_reg_rest_nombre.Size = new Size(352, 31);
            textBox_reg_rest_nombre.TabIndex = 2;
            // 
            // label_reg_rest_nombre
            // 
            label_reg_rest_nombre.AutoSize = true;
            label_reg_rest_nombre.Location = new Point(24, 82);
            label_reg_rest_nombre.Name = "label_reg_rest_nombre";
            label_reg_rest_nombre.Size = new Size(78, 25);
            label_reg_rest_nombre.TabIndex = 3;
            label_reg_rest_nombre.Text = "Nombre";
            // 
            // label_reg_rest_direccion
            // 
            label_reg_rest_direccion.AutoSize = true;
            label_reg_rest_direccion.Location = new Point(24, 187);
            label_reg_rest_direccion.Name = "label_reg_rest_direccion";
            label_reg_rest_direccion.Size = new Size(85, 25);
            label_reg_rest_direccion.TabIndex = 5;
            label_reg_rest_direccion.Text = "Dirección";
            // 
            // textBox_reg_rest_direccion
            // 
            textBox_reg_rest_direccion.Location = new Point(24, 215);
            textBox_reg_rest_direccion.Name = "textBox_reg_rest_direccion";
            textBox_reg_rest_direccion.Size = new Size(352, 31);
            textBox_reg_rest_direccion.TabIndex = 4;
            // 
            // label_reg_rest_telefono
            // 
            label_reg_rest_telefono.AutoSize = true;
            label_reg_rest_telefono.Location = new Point(24, 361);
            label_reg_rest_telefono.Name = "label_reg_rest_telefono";
            label_reg_rest_telefono.Size = new Size(79, 25);
            label_reg_rest_telefono.TabIndex = 7;
            label_reg_rest_telefono.Text = "Teléfono";
            // 
            // textBox_reg_rest_telefono
            // 
            textBox_reg_rest_telefono.Location = new Point(24, 389);
            textBox_reg_rest_telefono.Name = "textBox_reg_rest_telefono";
            textBox_reg_rest_telefono.Size = new Size(352, 31);
            textBox_reg_rest_telefono.TabIndex = 6;
            // 
            // button_reg_restaurante
            // 
            button_reg_restaurante.Location = new Point(24, 464);
            button_reg_restaurante.Name = "button_reg_restaurante";
            button_reg_restaurante.Size = new Size(352, 58);
            button_reg_restaurante.TabIndex = 8;
            button_reg_restaurante.Text = "Registrar nuevo restaurante";
            button_reg_restaurante.UseVisualStyleBackColor = true;
            // 
            // FormRegistrarRestaurante
            // 
            ClientSize = new Size(1204, 942);
            Controls.Add(button_reg_restaurante);
            Controls.Add(label_reg_rest_telefono);
            Controls.Add(textBox_reg_rest_telefono);
            Controls.Add(label_reg_rest_direccion);
            Controls.Add(textBox_reg_rest_direccion);
            Controls.Add(label_reg_rest_nombre);
            Controls.Add(textBox_reg_rest_nombre);
            Controls.Add(checkBox__reg_rest_activo);
            Controls.Add(label1);
            Name = "FormRegistrarRestaurante";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private Label label1;
        private CheckBox checkBox__reg_rest_activo;
        private TextBox textBox_reg_rest_nombre;
        private Label label_reg_rest_nombre;
        private Label label_reg_rest_direccion;
        private TextBox textBox_reg_rest_direccion;
        private Label label_reg_rest_telefono;
        private TextBox textBox_reg_rest_telefono;
        private Button button_reg_restaurante;
    }
}