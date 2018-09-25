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
    public partial class TecnicoFind : Form
    {
        public TecnicoFind()
        {
            InitializeComponent();
        }
        conexion cn = new conexion();
       
        private void button4_Click(object sender, EventArgs e)
        {
            /*SqlDataReader reader = cn.getQuery("Select * From TECNICOS WHERE DNI="  + txt_dni.Text + ";");
            while (reader.Read())
            {
                String x = reader.GetInt32(0) + "";
                if (x == txt_dni.Text)
                {
                    MessageBox.Show("Se encontro el Tecnico ");
                }
                else
                {
                    MessageBox.Show("No se encontro el Tecnico! ");
                }
            }
            cn.desconectar();*/
        }

        private void TecnicoFind_Load(object sender, EventArgs e)
        {

        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            cn.cargarTabla(tabla,"SELECT * from Tecnicos_Aviones;");

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cn.cargarTabla(tabla, "Select * from TECNICOSXMODELOS AS TXM JOIN TECNICOS AS T ON TXM.DNI;");
        }
    }
}
