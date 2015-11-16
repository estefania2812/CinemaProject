using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shlab4
{
    public partial class Rooms : Form
    {
        OracleConnection conn = Singleton.getConnection();
        OracleCommand cmd = new OracleCommand();

        public Rooms()
        {
            InitializeComponent();
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            conn.Close();
            Hide();
        }

        private void commit_button_Click(object sender, EventArgs e)
        {
            
 
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            try
            {
                int increase1 = Convert.ToInt32(increase1_textBox.Text);
                int increase2 = Convert.ToInt32(increase2_textBox.Text);
                OracleCommand cmd2 = new OracleCommand();
                cmd2.Connection = conn;
                cmd2.CommandText = "UPDATEROOMPRICE";
                cmd2.CommandType = System.Data.CommandType.StoredProcedure;
                cmd2.Parameters.Add("increase1", OracleType.Number);
                cmd2.Parameters["increase1"].Value = increase1;
                cmd2.Parameters["increase1"].Direction = System.Data.ParameterDirection.Input;
                cmd2.Parameters.Add("increase2", OracleType.Number);
                cmd2.Parameters["increase2"].Value = increase2;
                cmd2.Parameters["increase2"].Direction = System.Data.ParameterDirection.Input;

                cmd2.ExecuteNonQuery();

                OracleDataAdapter da2 = new OracleDataAdapter();
                da2.SelectCommand = new OracleCommand();
                DataTable dt2 = new DataTable();

                da2.SelectCommand.Connection = conn;
                da2.SelectCommand.CommandText = "select * from Room";
                da2.Fill(dt2);
                room_dataGridView.DataSource = dt2;
               

            }

            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void rooms_button_Click(object sender, EventArgs e)
        {
            
            OracleDataAdapter da = new OracleDataAdapter();
            da.SelectCommand = new OracleCommand();
            DataTable dt = new DataTable();

            da.SelectCommand.Connection = conn;
            da.SelectCommand.CommandText = "select * from Room";
            da.Fill(dt);
            room_dataGridView.DataSource = dt;
        }
    }
}
