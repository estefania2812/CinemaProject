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
    public partial class AddReservation : Form
    {
        OracleConnection conn = Singleton.getConnection();
        OracleCommand cmd = new OracleCommand();

        public AddReservation()
        {
            InitializeComponent();
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select ClientId from Client";
            OracleDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    clientId_comboBox.Items.Add(dataReader.GetInt32(0).ToString());
                }
    
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            conn.Close();
            Hide();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            if (resNum_textBox.Text == "" || clientId_comboBox.Text == "" )
                MessageBox.Show("You must fill all the fields");
            else
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
            
                try
                {
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    int resnum = Convert.ToInt32(resNum_textBox.Text);
                    int clientid = Convert.ToInt32(clientId_comboBox.Text);
                    cmd.CommandText = "insert into Reservation values (" + resnum + "," + clientid + ")";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Reservation added successfully");

                }

                catch (Exception s)
                {
                    MessageBox.Show(s.Message);
                }
            }
        }
    }
}
