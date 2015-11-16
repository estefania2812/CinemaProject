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
    public partial class TicketsForReservation : Form
    {
        OracleConnection conn = Singleton.getConnection();
        OracleCommand cmd = new OracleCommand();

        public TicketsForReservation()
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
                resNum_comboBox.Items.Add(dataReader.GetInt32(0).ToString());
            }
            
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            conn.Close();
            Hide();
        }

        private void resNum_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
             
            try
            {
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                int resnum = Convert.ToInt32(resNum_comboBox.Text);

                cmd.CommandText = "select count(ReservationNumber) as TicketForReservation from Ticket where ReservationNumber= " + resnum;

                var reader = cmd.ExecuteReader();

                if (reader.HasRows == false)
                {
                    throw new Exception();
                }
                if (reader.Read())
                {

                    tickets_textBox.Text = reader[0].ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
            conn.Close();    
        }
        }
    }

