namespace Tarea2.Forms
{
    partial class FormRegistrarPlatoRestaurante
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            comboBox_reg_platoRest_lista = new ComboBox();
            dataGridView_reg_platoRrest = new DataGridView();
            label3 = new Label();
            button_reg_platoRest = new Button();
            dataGridView_consul_platosRest = new DataGridView();
            button_consul_platosRest = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView_reg_platoRrest).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_consul_platosRest).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(279, 25);
            label1.TabIndex = 0;
            label1.Text = "Registrar Platos para Restaurantes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 55);
            label2.Name = "label2";
            label2.Size = new Size(210, 25);
            label2.TabIndex = 1;
            label2.Text = "Restaurantes Disponibles";
            // 
            // comboBox_reg_platoRest_lista
            // 
            comboBox_reg_platoRest_lista.FormattingEnabled = true;
            comboBox_reg_platoRest_lista.Location = new Point(12, 102);
            comboBox_reg_platoRest_lista.Name = "comboBox_reg_platoRest_lista";
            comboBox_reg_platoRest_lista.Size = new Size(704, 33);
            comboBox_reg_platoRest_lista.TabIndex = 2;
            // 
            // dataGridView_reg_platoRrest
            // 
            dataGridView_reg_platoRrest.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_reg_platoRrest.Location = new Point(12, 187);
            dataGridView_reg_platoRrest.Name = "dataGridView_reg_platoRrest";
            dataGridView_reg_platoRrest.RowHeadersWidth = 62;
            dataGridView_reg_platoRrest.RowTemplate.Height = 33;
            dataGridView_reg_platoRrest.Size = new Size(704, 255);
            dataGridView_reg_platoRrest.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 159);
            label3.Name = "label3";
            label3.Size = new Size(156, 25);
            label3.TabIndex = 4;
            label3.Text = "Platos disponibles";
            // 
            // button_reg_platoRest
            // 
            button_reg_platoRest.Location = new Point(408, 448);
            button_reg_platoRest.Name = "button_reg_platoRest";
            button_reg_platoRest.Size = new Size(308, 56);
            button_reg_platoRest.TabIndex = 5;
            button_reg_platoRest.Text = "Registrar Plato en Restaurante";
            button_reg_platoRest.UseVisualStyleBackColor = true;
            button_reg_platoRest.Click += button_reg_platoRest_Click;
            // 
            // dataGridView_consul_platosRest
            // 
            dataGridView_consul_platosRest.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_consul_platosRest.Location = new Point(12, 670);
            dataGridView_consul_platosRest.Name = "dataGridView_consul_platosRest";
            dataGridView_consul_platosRest.RowHeadersWidth = 62;
            dataGridView_consul_platosRest.RowTemplate.Height = 33;
            dataGridView_consul_platosRest.Size = new Size(704, 264);
            dataGridView_consul_platosRest.TabIndex = 6;
            // 
            // button_consul_platosRest
            // 
            button_consul_platosRest.Location = new Point(12, 611);
            button_consul_platosRest.Name = "button_consul_platosRest";
            button_consul_platosRest.Size = new Size(308, 53);
            button_consul_platosRest.TabIndex = 7;
            button_consul_platosRest.Text = "Mostrar platos registrados";
            button_consul_platosRest.UseVisualStyleBackColor = true;
            button_consul_platosRest.Click += button_consul_platosRest_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 583);
            label4.Name = "label4";
            label4.Size = new Size(382, 25);
            label4.TabIndex = 8;
            label4.Text = "Platos Registrados al Restaurante Seleccionado";
            // 
            // FormRegistrarPlatoRestaurante
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(728, 946);
            Controls.Add(label4);
            Controls.Add(button_consul_platosRest);
            Controls.Add(dataGridView_consul_platosRest);
            Controls.Add(button_reg_platoRest);
            Controls.Add(label3);
            Controls.Add(dataGridView_reg_platoRrest);
            Controls.Add(comboBox_reg_platoRest_lista);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormRegistrarPlatoRestaurante";
            Text = "Registrar Platos para Restaurantes";
            ((System.ComponentModel.ISupportInitialize)dataGridView_reg_platoRrest).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_consul_platosRest).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboBox_reg_platoRest_lista;
        private DataGridView dataGridView_reg_platoRrest;
        private Label label3;
        private Button button_reg_platoRest;
        private DataGridView dataGridView_consul_platosRest;
        private Button button_consul_platosRest;
        private Label label4;
    }
}