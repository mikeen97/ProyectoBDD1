using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_V_2
{
    public partial class AvionDelete : Form
    {
        public AvionDelete()
        {
            InitializeComponent();
        }

        conexion cn = new conexion();

        private void button1_Click(object sender, EventArgs e)
        {
            String numRegistro = txt_numRegistroAvion.Text;

            cn.ExecuteQuery("EXECUTE DELETE_AVION " + txt_numRegistroAvion.Text +";");
        }

    }
}

