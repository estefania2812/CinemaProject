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
    public partial class DeleteClient : Form
    {
        OracleConnection conn = Singleton.getConnection();
        OracleCommand cmd = new OracleCommand();

        public DeleteClient()
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
                deleteClient_comboBox.Items.Add(dataReader.GetInt32(0).ToString());
            }
        
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            conn.Close();
            Hide();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {

            if (deleteClient_comboBox.Text == "")
                MessageBox.Show("You must enter a client to delete");
            else
            {
                int ClientId = Convert.ToInt32(deleteClient_comboBox.Text);

                cmd.Connection = conn;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "delete from Client where ClientId= " + ClientId;
                try
                {

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Client deleted successfully");

                }

                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex.Message);
                }
            }
        }
    }
}
