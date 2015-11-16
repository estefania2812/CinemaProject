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
    public partial class UpdateScreen : Form
    {
        OracleConnection conn = Singleton.getConnection();
        OracleCommand cmd = new OracleCommand();

        public UpdateScreen(DateTime date, int room, int movieNum, int seats)
        {
            InitializeComponent();
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

            movieNum_comboBox.Text = movieNum.ToString();
            seats_textBox.Text = seats.ToString();
            room_label.Text = room.ToString();
            label.Text = Convert.ToString(date);
  
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select MovieNumber from Movie";
            OracleDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                movieNum_comboBox.Items.Add(dataReader.GetInt32(0).ToString());
            }
          
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            
            if (seats_textBox.Text == "" || movieNum_comboBox.Text == "" )
                MessageBox.Show("You must fill all the fields");

            else
            {
                if (Convert.ToInt32(seats_textBox.Text) > 127)
                    MessageBox.Show("Error: There are only 127 seats");

                else
                {
                    try
                    {

                        DateTime ScreenDate = DateTime.Parse(label.Text);
                        int room = Convert.ToInt32(room_label.Text);
                        int MovieNum = Convert.ToInt32(movieNum_comboBox.Text);
                        int seats = Convert.ToInt32(seats_textBox.Text);

                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "update Screen set MovieNumber = &param1, ReservedSeats = &param2 where ScreenDate = &keyValue1 and roomNumber = &keyValue2";
                        cmd.Parameters.AddWithValue("keyValue1", ScreenDate);
                        cmd.Parameters.AddWithValue("keyValue2", room);
                        cmd.Parameters.AddWithValue("Param1", MovieNum);
                        cmd.Parameters.AddWithValue("Param2", seats);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Screen updated successfully");
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
