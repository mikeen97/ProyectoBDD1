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
    public partial class ControladorAereoFind : Form
    {
        public ControladorAereoFind()
        {
            InitializeComponent();
        }
        conexion cn = new conexion();
        private void button4_Click(object sender, EventArgs e)
        {
            SqlDataReader reader = cn.getQuery("Select * From CONTROLADOR_EU WHERE DNI=" + txt_dni.Text + ";");
            while (reader.Read())
            {
                String x = reader.GetInt32(0) + "";
                if (x == txt_dni.Text)
                {
                    MessageBox.Show("Se encontro el CONTROLADOR AEREO ");
                }
                else
                {
                    MessageBox.Show("No se encontro el CONTROLADOR AEREO! ");
                }
            }
            cn.desconectar();
        }
    }
}
