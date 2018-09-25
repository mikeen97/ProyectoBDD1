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
    public partial class AvionFind : Form
    {
        public AvionFind()
        {
            InitializeComponent();
        }
        conexion cn = new conexion();
        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataReader reader = cn.getQuery("Select * From AVIONES WHERE NUM_REGISTRO=" + txtRegistro.Text + ";");
            while (reader.Read())
            {
                String x = reader.GetInt32(0) + "";
                if (x==txtRegistro.Text)
                {
                    MessageBox.Show("Se encontro el Avion! ");
                }
                else
                {
                    MessageBox.Show("No se encontro el Avion! ");
                }
            }
            cn.desconectar();
        }
        
    }
}
