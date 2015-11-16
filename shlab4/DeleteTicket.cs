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
    public partial class DeleteTicket : Form
    {
        OracleConnection conn = Singleton.getConnection();
        OracleCommand cmd = new OracleCommand();

        public DeleteTicket()
        {
            InitializeComponent();
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select TicketNumber from Ticket";
            OracleDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                TicketToDelete_comboBox.Items.Add(dataReader.GetInt32(0).ToString());
            }
        }

        private void DeleteTicket_button_Click(object sender, EventArgs e)
        {

            if (TicketToDelete_comboBox.Text == "")
                MessageBox.Show("You must enter a ticket to delete");
            else
            {
                cmd.Connection = conn;
                int TicketNum = Convert.ToInt32(TicketToDelete_comboBox.Text);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "delete from Ticket where TicketNumber= " + TicketNum;

                try
                {

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ticket deleted successfully");

                }

                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex.Message);
                }
            }
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            conn.Close();
            Hide();
        }
    }
}
