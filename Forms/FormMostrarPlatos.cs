﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea2.Managers;

namespace Tarea2.Forms
{
    public partial class FormMostrarPlatos : Form
    {
        private ManagerPlatos managerPlatos;
        public FormMostrarPlatos(ManagerPlatos managerPlatos)
        {
            this.managerPlatos = managerPlatos;
            InitializeComponent();
            this.Shown += new System.EventHandler(this.FormMostrarPlatos_Shown);
        }

        private void FormMostrarPlatos_Shown(object sender, EventArgs e)
        {
            dataGridView_consul_platos.DataSource = managerPlatos.GetTodos().Where(x => x != null).ToList();
        }
    }
}
