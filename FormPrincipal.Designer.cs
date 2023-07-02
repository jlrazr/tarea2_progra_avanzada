namespace Tarea2
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label_titulo = new Label();
            button_menu_reg_restaurante = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            SuspendLayout();
            // 
            // label_titulo
            // 
            label_titulo.AutoSize = true;
            label_titulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label_titulo.Location = new Point(20, 18);
            label_titulo.Name = "label_titulo";
            label_titulo.Size = new Size(171, 38);
            label_titulo.TabIndex = 0;
            label_titulo.Text = "REST-UNED";
            // 
            // button_menu_reg_restaurante
            // 
            button_menu_reg_restaurante.Location = new Point(20, 71);
            button_menu_reg_restaurante.Name = "button_menu_reg_restaurante";
            button_menu_reg_restaurante.Size = new Size(302, 50);
            button_menu_reg_restaurante.TabIndex = 1;
            button_menu_reg_restaurante.Text = "Registrar Restaurante";
            button_menu_reg_restaurante.UseVisualStyleBackColor = true;
            button_menu_reg_restaurante.Click += button_menu_reg_restaurante_Click;
            // 
            // button2
            // 
            button2.Location = new Point(20, 139);
            button2.Name = "button2";
            button2.Size = new Size(302, 50);
            button2.TabIndex = 2;
            button2.Text = "Registrar Categoría Plato";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(20, 278);
            button3.Name = "button3";
            button3.Size = new Size(302, 50);
            button3.TabIndex = 4;
            button3.Text = "Registrar Cliente";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(20, 210);
            button4.Name = "button4";
            button4.Size = new Size(302, 50);
            button4.TabIndex = 3;
            button4.Text = "Registrar Plato";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(20, 556);
            button5.Name = "button5";
            button5.Size = new Size(302, 50);
            button5.TabIndex = 8;
            button5.Text = "Consultar Categorías de Platos";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(20, 488);
            button6.Name = "button6";
            button6.Size = new Size(302, 50);
            button6.TabIndex = 7;
            button6.Text = "Consultar Restaurantes";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(20, 417);
            button7.Name = "button7";
            button7.Size = new Size(302, 50);
            button7.TabIndex = 6;
            button7.Text = "Registrar Extras";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(20, 349);
            button8.Name = "button8";
            button8.Size = new Size(302, 50);
            button8.TabIndex = 5;
            button8.Text = "Registrar Platos por Restaurante";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(20, 836);
            button9.Name = "button9";
            button9.Size = new Size(302, 50);
            button9.TabIndex = 12;
            button9.Text = "Consultar Extras";
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(20, 768);
            button10.Name = "button10";
            button10.Size = new Size(302, 50);
            button10.TabIndex = 11;
            button10.Text = "Consultar Platos por Restaurante";
            button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.Location = new Point(20, 697);
            button11.Name = "button11";
            button11.Size = new Size(302, 50);
            button11.TabIndex = 10;
            button11.Text = "Consultar Clientes";
            button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            button12.Location = new Point(20, 629);
            button12.Name = "button12";
            button12.Size = new Size(302, 50);
            button12.TabIndex = 9;
            button12.Text = "Consultar Platos";
            button12.UseVisualStyleBackColor = true;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1895, 1096);
            Controls.Add(button9);
            Controls.Add(button10);
            Controls.Add(button11);
            Controls.Add(button12);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button_menu_reg_restaurante);
            Controls.Add(label_titulo);
            Name = "FormPrincipal";
            Text = "REST-UNED";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_titulo;
        private Button button_menu_reg_restaurante;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
    }
}