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
    public partial class UpdateTicket : Form
    {
        OracleConnection conn = Singleton.getConnection();
        OracleCommand cmd = new OracleCommand();
        OracleCommand cmd2 = new OracleCommand();

        public UpdateTicket()
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
                ticketNum_comboBox.Items.Add(dataReader.GetInt32(0).ToString());
            }


            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select ReservationNumber from Reservation";
            OracleDataReader dataReader2 = cmd.ExecuteReader();
            while (dataReader2.Read())
            {
                resNum_comboBox.Items.Add(dataReader2.GetInt32(0).ToString());
            }
            
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            conn.Close();
            Hide();
        }

        private void ticketNum_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            int TicketNum = Convert.ToInt32(ticketNum_comboBox.Text);
        
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Ticket where TicketNumber= " + TicketNum;

            var reader = cmd.ExecuteReader();
            try
            {
                if (reader.HasRows == false)
                {
                    throw new Exception();
                }
                while (reader.Read())
                {

                    seat_textBox.Text = reader[1].ToString();
                    date_label.Text = reader[2].ToString();
                    room_label.Text = reader[3].ToString();
                    resNum_comboBox.Text = reader[4].ToString();

                   

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void update_button_Click(object sender, EventArgs e)
        {

            if (seat_textBox.Text == "" || resNum_comboBox.Text == "" || ticketNum_comboBox.Text == "")
                MessageBox.Show("You must fill all the fields");
           
            else
            {
                if (Convert.ToInt32(seat_textBox.Text) > 127)
                    MessageBox.Show("There are only 127 seats");
                else
                {
                    
                    try
                    {
                        DateTime date = DateTime.Parse(date_label.Text);

                        int TicketNum = Convert.ToInt32(ticketNum_comboBox.Text);
                        int ResNum = Convert.ToInt32(resNum_comboBox.Text);
                        int seat = Convert.ToInt32(seat_textBox.Text);
                        int room = Convert.ToInt32(room_label.Text);
                        cmd2.Connection = conn;
                        cmd2.CommandType = CommandType.Text;
                        cmd2.CommandText = "select ticketNumber from TICKET where screendate= TO_DATE('" + date + "'" + ", 'MM/DD/YYYY HH:MI:SS AM') and roomnumber = "
                            + room + "and seat = " + seat + "and ticketnumber != " + TicketNum;
                        var reader = cmd2.ExecuteReader();

                        if (reader.HasRows == true)
                        {
                            MessageBox.Show("This seat is already saved in this screen");
                        }
                        else
                        {
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "update Ticket set seat = &param1, ReservationNumber = &param2 where TicketNumber = &keyValue";
                            cmd.Parameters.AddWithValue("keyValue", TicketNum);
                            cmd.Parameters.AddWithValue("Param1", seat);
                            cmd.Parameters.AddWithValue("Param2", ResNum);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Ticket updated successfully");        
                        }

                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("ERROR: " + ex.Message);
                    }

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            OracleDataAdapter da = new OracleDataAdapter();
            da.SelectCommand = new OracleCommand();
            DataTable dt = new DataTable();

            da.SelectCommand.Connection = conn;
            string SQLquery = "select screendate, roomnumber from Screen";
            da.SelectCommand.CommandText = SQLquery;
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int yCoord = dataGridView1.CurrentCellAddress.Y;
            string date = Convert.ToString(dataGridView1.Rows[yCoord].Cells[0].Value);
            string room = Convert.ToString(dataGridView1.Rows[yCoord].Cells[1].Value);
            date_label.Text = date;
            room_label.Text = room;

        }
    }
}
