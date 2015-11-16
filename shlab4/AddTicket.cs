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
    public partial class AddTicket : Form
    {
        OracleConnection conn = Singleton.getConnection();
        OracleCommand cmd = new OracleCommand();
        OracleCommand cmd2 = new OracleCommand();

        public AddTicket()
        {
            InitializeComponent();
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            OracleDataAdapter da = new OracleDataAdapter();
            da.SelectCommand = new OracleCommand();
            DataTable dt = new DataTable();
            da.SelectCommand.Connection = conn;
            string SQLquery = "select ReservationNumber from Reservation";
            da.SelectCommand.CommandText = SQLquery;
            da.Fill(dt);
            resNum_comboBox.DataSource = dt;
            resNum_comboBox.DisplayMember = "ReservationNumber";

            OracleDataAdapter da2 = new OracleDataAdapter();
            da2.SelectCommand = new OracleCommand();
            DataTable dt2 = new DataTable();

            da2.SelectCommand.Connection = conn;
            SQLquery = "select screendate, roomnumber from Screen";
            da2.SelectCommand.CommandText = SQLquery;
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;

        }

        private void add_button_Click(object sender, EventArgs e)
        {
            if (ticketNumber_textBox.Text == "" || seat_textBox.Text == "" || resNum_comboBox.Text == "")
                MessageBox.Show("You must fill all the fields");

            else
            {
                if (Convert.ToInt32(seat_textBox.Text) > 127)
                    MessageBox.Show("There are only 127 seats");
                else
                {
                    try
                    {
                        int yCoord = dataGridView1.CurrentCellAddress.Y;

                        DateTime date = (DateTime)dataGridView1.Rows[yCoord].Cells[0].Value;
                        int room = Convert.ToInt32(dataGridView1.Rows[yCoord].Cells[1].Value);
                        int seat = Convert.ToInt32(seat_textBox.Text);
                        cmd2.Connection = conn;
                        cmd2.CommandType = CommandType.Text;
                        cmd2.CommandText = "select ticketNumber from TICKET where screendate= TO_DATE('" + date + "','MM/DD/YYYY hh:mi:ss AM') and roomnumber = " +
                                      room + "and seat= " + seat;

                        var reader = cmd2.ExecuteReader();
                       
                            if (reader.HasRows == true)
                            {
                                MessageBox.Show("This seat is already saved in this screen");
                            }
                            else
                            {
                                cmd.Connection = conn;
                                cmd.CommandType = CommandType.StoredProcedure;

                                int ticket = Convert.ToInt32(ticketNumber_textBox.Text);

                                int res_num = Convert.ToInt32(((DataRowView)resNum_comboBox.SelectedValue)["ReservationNumber"]);


                                cmd.CommandText = "insert into Ticket values (" + ticket + "," + seat +
                                             "," + "(TO_DATE('" + date + "','MM/DD/YYYY hh:mi:ss AM'))" + "," + room + "," + res_num + ")";

                               
                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show("Ticket added successfully");
                                
                            }
                           }
                    catch (Exception s)
                    {
                        MessageBox.Show(s.Message);
                    }
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
