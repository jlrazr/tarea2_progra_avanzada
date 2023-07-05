﻿namespace Tarea2
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
            button_reg_catPlatos = new Button();
            button_reg_cliente = new Button();
            button_reg_plato = new Button();
            button_consul_categ = new Button();
            button_consul_rest = new Button();
            button_reg_extras = new Button();
            button_reg_platoRest = new Button();
            button_consul_extras = new Button();
            button_consul_platoRest = new Button();
            button_consul_clientes = new Button();
            button_consul_platos = new Button();
            SuspendLayout();
            // 
            // label_titulo
            // 
            label_titulo.AutoSize = true;
            label_titulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label_titulo.Location = new Point(183, 16);
            label_titulo.Name = "label_titulo";
            label_titulo.Size = new Size(171, 38);
            label_titulo.TabIndex = 0;
            label_titulo.Text = "REST-UNED";
            // 
            // button_menu_reg_restaurante
            // 
            button_menu_reg_restaurante.Location = new Point(20, 71);
            button_menu_reg_restaurante.Name = "button_menu_reg_restaurante";
            button_menu_reg_restaurante.Size = new Size(475, 50);
            button_menu_reg_restaurante.TabIndex = 1;
            button_menu_reg_restaurante.Text = "Registrar Restaurante";
            button_menu_reg_restaurante.UseVisualStyleBackColor = true;
            button_menu_reg_restaurante.Click += button_menu_reg_restaurante_Click;
            // 
            // button_reg_catPlatos
            // 
            button_reg_catPlatos.Location = new Point(20, 139);
            button_reg_catPlatos.Name = "button_reg_catPlatos";
            button_reg_catPlatos.Size = new Size(475, 50);
            button_reg_catPlatos.TabIndex = 2;
            button_reg_catPlatos.Text = "Registrar Categoría Plato";
            button_reg_catPlatos.UseVisualStyleBackColor = true;
            button_reg_catPlatos.Click += button_reg_catPlatos_Click;
            // 
            // button_reg_cliente
            // 
            button_reg_cliente.Location = new Point(20, 278);
            button_reg_cliente.Name = "button_reg_cliente";
            button_reg_cliente.Size = new Size(475, 50);
            button_reg_cliente.TabIndex = 4;
            button_reg_cliente.Text = "Registrar Cliente";
            button_reg_cliente.UseVisualStyleBackColor = true;
            button_reg_cliente.Click += button_reg_cliente_Click;
            // 
            // button_reg_plato
            // 
            button_reg_plato.Location = new Point(20, 210);
            button_reg_plato.Name = "button_reg_plato";
            button_reg_plato.Size = new Size(475, 50);
            button_reg_plato.TabIndex = 3;
            button_reg_plato.Text = "Registrar Plato";
            button_reg_plato.UseVisualStyleBackColor = true;
            button_reg_plato.Click += button_reg_plato_Click;
            // 
            // button_consul_categ
            // 
            button_consul_categ.Location = new Point(20, 616);
            button_consul_categ.Name = "button_consul_categ";
            button_consul_categ.Size = new Size(475, 50);
            button_consul_categ.TabIndex = 8;
            button_consul_categ.Text = "Consultar Categorías de Platos";
            button_consul_categ.UseVisualStyleBackColor = true;
            // 
            // button_consul_rest
            // 
            button_consul_rest.Location = new Point(20, 548);
            button_consul_rest.Name = "button_consul_rest";
            button_consul_rest.Size = new Size(475, 50);
            button_consul_rest.TabIndex = 7;
            button_consul_rest.Text = "Consultar Restaurantes";
            button_consul_rest.UseVisualStyleBackColor = true;
            // 
            // button_reg_extras
            // 
            button_reg_extras.Location = new Point(20, 417);
            button_reg_extras.Name = "button_reg_extras";
            button_reg_extras.Size = new Size(475, 50);
            button_reg_extras.TabIndex = 6;
            button_reg_extras.Text = "Registrar Extras";
            button_reg_extras.UseVisualStyleBackColor = true;
            // 
            // button_reg_platoRest
            // 
            button_reg_platoRest.Location = new Point(20, 349);
            button_reg_platoRest.Name = "button_reg_platoRest";
            button_reg_platoRest.Size = new Size(475, 50);
            button_reg_platoRest.TabIndex = 5;
            button_reg_platoRest.Text = "Registrar Platos por Restaurante";
            button_reg_platoRest.UseVisualStyleBackColor = true;
            button_reg_platoRest.Click += button_reg_platoRest_Click;
            // 
            // button_consul_extras
            // 
            button_consul_extras.Location = new Point(20, 896);
            button_consul_extras.Name = "button_consul_extras";
            button_consul_extras.Size = new Size(475, 50);
            button_consul_extras.TabIndex = 12;
            button_consul_extras.Text = "Consultar Extras";
            button_consul_extras.UseVisualStyleBackColor = true;
            // 
            // button_consul_platoRest
            // 
            button_consul_platoRest.Location = new Point(20, 828);
            button_consul_platoRest.Name = "button_consul_platoRest";
            button_consul_platoRest.Size = new Size(475, 50);
            button_consul_platoRest.TabIndex = 11;
            button_consul_platoRest.Text = "Consultar Platos por Restaurante";
            button_consul_platoRest.UseVisualStyleBackColor = true;
            // 
            // button_consul_clientes
            // 
            button_consul_clientes.Location = new Point(20, 757);
            button_consul_clientes.Name = "button_consul_clientes";
            button_consul_clientes.Size = new Size(475, 50);
            button_consul_clientes.TabIndex = 10;
            button_consul_clientes.Text = "Consultar Clientes";
            button_consul_clientes.UseVisualStyleBackColor = true;
            // 
            // button_consul_platos
            // 
            button_consul_platos.Location = new Point(20, 689);
            button_consul_platos.Name = "button_consul_platos";
            button_consul_platos.Size = new Size(475, 50);
            button_consul_platos.TabIndex = 9;
            button_consul_platos.Text = "Consultar Platos";
            button_consul_platos.UseVisualStyleBackColor = true;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(507, 981);
            Controls.Add(button_consul_extras);
            Controls.Add(button_consul_platoRest);
            Controls.Add(button_consul_clientes);
            Controls.Add(button_consul_platos);
            Controls.Add(button_consul_categ);
            Controls.Add(button_consul_rest);
            Controls.Add(button_reg_extras);
            Controls.Add(button_reg_platoRest);
            Controls.Add(button_reg_cliente);
            Controls.Add(button_reg_plato);
            Controls.Add(button_reg_catPlatos);
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
        private Button button_reg_catPlatos;
        private Button button_reg_cliente;
        private Button button_reg_plato;
        private Button button_consul_categ;
        private Button button_consul_rest;
        private Button button_reg_extras;
        private Button button_reg_platoRest;
        private Button button_consul_extras;
        private Button button_consul_platoRest;
        private Button button_consul_clientes;
        private Button button_consul_platos;
    }
}