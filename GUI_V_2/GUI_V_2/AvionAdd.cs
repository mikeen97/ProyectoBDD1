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
    public partial class AvionAdd : Form
    {
        conexion cn = new conexion();
        public AvionAdd()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cn.ExecuteQuery("EXECUTE INSERT_AVION " + txtRegistro.Text+ "," + cbNumRegistroAviones.Text + ";");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlDataReader reader= cn.getQuery("Select num_modelo from MODELOS_NUM;");
            while (cbNumRegistroAviones.Items.Count>0)
            {
                cbNumRegistroAviones.Items.Remove(0);
            }
            while (reader.Read())
            {
                cbNumRegistroAviones.Items.Add((int)reader.GetInt32(0));

            }
           

            cn.desconectar();
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            cn.ExecuteQuery("EXECUTE UPDATE_AVION "+ txtRegistro.Text + "," + cbNumRegistroAviones.Text + ";");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlDataReader reader = cn.getQuery("Select * From AVIONES WHERE NUM_REGISTRO=" + txtRegistro.Text + ";");
            while (reader.Read())
            {
                txtRegistro.Text = reader.GetInt32(0) + "";
                cbNumRegistroAviones.Text = reader.GetInt32(1) + "";

            }
            cn.desconectar();
        }
    }
}
