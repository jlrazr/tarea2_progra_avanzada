﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea2;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tarea2.Forms
{
    public partial class FormRegistrarPlatoRestaurante : Form
    {
        private ManagerPlatos managerPlatos;
        private ManagerRestaurantePlatos managerRestaurantePlatos;
        private ManagerRestaurantes managerRestaurantes;
        public FormRegistrarPlatoRestaurante(ManagerPlatos managerPlatos, ManagerRestaurantePlatos managerRestaurantePlatos, ManagerRestaurantes managerRestaurantes)
        {
            this.managerPlatos = managerPlatos;
            this.managerRestaurantePlatos = managerRestaurantePlatos;
            this.managerRestaurantes = managerRestaurantes;
            InitializeComponent();
            this.Shown += new System.EventHandler(this.FormRegistrarPlatoRestaurante_Shown);
        }

        private void FormRegistrarPlatoRestaurante_Shown(object sender, EventArgs e)
        {
            comboBox_reg_platoRest_lista.DataSource = managerRestaurantes.GetTodos().Where(x => x != null && x.Activo == true).ToList();
            dataGridView_reg_platoRrest.DataSource = managerPlatos.GetTodos().Where(x => x != null).ToList();
            comboBox_reg_platoRest_lista.DropDownStyle = ComboBoxStyle.DropDownList;


        }

        private void button_reg_platoRest_Click(object sender, EventArgs e)
        {
            if (comboBox_reg_platoRest_lista.SelectedItem != null && comboBox_reg_platoRest_lista.SelectedItem is Restaurante restauranteSeleccionado)
            {
                int idRestSeleccionado = restauranteSeleccionado.Id;

                var mensaje = new FormMensaje("El restaurante seleccionado tiene el ID:  " + idRestSeleccionado);
                mensaje.ShowDialog();
            }

            foreach (DataGridViewRow row in dataGridView_reg_platoRrest.SelectedRows)
            {
                if (row.DataBoundItem is Plato platoSeleccionado)
                {
                    int idPlatoSeleccionado = platoSeleccionado.Id;
                    var mensaje = new FormMensaje("El plato seleccionado tiene el ID:  " + idPlatoSeleccionado);
                    mensaje.ShowDialog();
                }
            }
        }
    }
}


