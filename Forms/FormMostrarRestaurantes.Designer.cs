namespace Tarea2.Forms
{
    partial class FormMostrarRestaurantes
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
            dataGridView_consul_restaruantes = new DataGridView();
            button_mostrar_rest = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_consul_restaruantes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(192, 25);
            label1.TabIndex = 0;
            label1.Text = "Consultar Restaurantes";
            // 
            // dataGridView_consul_restaruantes
            // 
            dataGridView_consul_restaruantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_consul_restaruantes.Location = new Point(12, 57);
            dataGridView_consul_restaruantes.Name = "dataGridView_consul_restaruantes";
            dataGridView_consul_restaruantes.RowHeadersWidth = 62;
            dataGridView_consul_restaruantes.RowTemplate.Height = 33;
            dataGridView_consul_restaruantes.Size = new Size(789, 526);
            dataGridView_consul_restaruantes.TabIndex = 1;
            // 
            // button_mostrar_rest
            // 
            button_mostrar_rest.Location = new Point(12, 843);
            button_mostrar_rest.Name = "button_mostrar_rest";
            button_mostrar_rest.Size = new Size(232, 63);
            button_mostrar_rest.TabIndex = 2;
            button_mostrar_rest.Text = "Mostrar";
            button_mostrar_rest.UseVisualStyleBackColor = true;
            // 
            // FormMostrarRestaurantes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(818, 965);
            Controls.Add(button_mostrar_rest);
            Controls.Add(dataGridView_consul_restaruantes);
            Controls.Add(label1);
            Name = "FormMostrarRestaurantes";
            Text = "Consultar Restaurantes";
            ((System.ComponentModel.ISupportInitialize)dataGridView_consul_restaruantes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView_consul_restaruantes;
        private Button button_mostrar_rest;
    }
}