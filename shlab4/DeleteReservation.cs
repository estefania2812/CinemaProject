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
    public partial class DeleteReservation : Form
    {
        OracleConnection conn = Singleton.getConnection();
        OracleCommand cmd = new OracleCommand();

        public DeleteReservation()
        {
            InitializeComponent();
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select ReservationNumber from Reservation";
            OracleDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                Res_comboBox.Items.Add(dataReader.GetInt32(0).ToString());
            }
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void deleteRes_button_Click(object sender, EventArgs e)
        {
            if (Res_comboBox.Text == "")
                MessageBox.Show("You must enter a reservation to delete");
            else
            {
                cmd.Connection = conn;
                int ResNum = Convert.ToInt32(Res_comboBox.Text);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "delete from Reservation where ReservationNumber= " + ResNum;

                try
                {

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Reservation deleted successfully");
                }

                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex.Message);
                }
            }
        }

     
    }
}
