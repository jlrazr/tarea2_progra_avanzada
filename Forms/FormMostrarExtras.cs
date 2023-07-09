﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea2.Forms
{
    public partial class FormMostrarExtras : Form
    {
        private ManagerExtra managerExtra;
        public FormMostrarExtras(ManagerExtra managerExtra)
        {
            this.managerExtra = managerExtra;
            InitializeComponent();
            this.Shown += new System.EventHandler(this.FormMostrarExtra_Shown);
        }

        private void FormMostrarExtra_Shown(object sender, EventArgs e)
        {
            dataGridView_consul_extras.DataSource = managerExtra.GetTodos().Where(x => x != null).ToList();
        }
    }
}