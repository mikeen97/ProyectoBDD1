﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_V_2
{
    public partial class TecnicoDelete : Form
    {
        public TecnicoDelete()
        {
            InitializeComponent();
        }

        conexion cn = new conexion();
        private void button4_Click(object sender, EventArgs e)
        {
            cn.ExecuteQuery("EXECUTE DELETE_EMPLEADO " + txt_dni.Text + ";");
        }
    }
}
