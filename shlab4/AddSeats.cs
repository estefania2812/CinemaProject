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
    public partial class AddSeats : Form
    {

        OracleConnection conn = Singleton.getConnection();
        OracleCommand cmd = new OracleCommand();

        public AddSeats()
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
            string SQLquery = "select * from Screen order by screendate asc";
            da.SelectCommand.CommandText = SQLquery;
            da.Fill(dt);
            dataGridView.DataSource = dt;
        }

        private void commit_button_Click(object sender, EventArgs e)
        {
            try
            {
                int yCoord = dataGridView.CurrentCellAddress.Y;
                DateTime date = (DateTime)dataGridView.Rows[yCoord].Cells[0].Value;
                int room = Convert.ToInt32(dataGridView.Rows[yCoord].Cells[1].Value);
                int movieNum = Convert.ToInt32(dataGridView.Rows[yCoord].Cells[2].Value);


                int seatsToAdd = Convert.ToInt32(seats_textBox.Text);

                OracleCommand cmd2 = new OracleCommand();
                cmd2.Connection = conn;
                cmd2.CommandText = "UPDATESEATS";
                cmd2.CommandType = System.Data.CommandType.StoredProcedure;
                cmd2.Parameters.Add("mydate", OracleType.DateTime);
                cmd2.Parameters["mydate"].Value = date;
                cmd2.Parameters["mydate"].Direction = System.Data.ParameterDirection.Input;
                cmd2.Parameters.Add("seatsToAdd", OracleType.Number);
                cmd2.Parameters["seatsToAdd"].Value = seatsToAdd;
                cmd2.Parameters["seatsToAdd"].Direction = System.Data.ParameterDirection.Input;
                cmd2.Parameters.Add("myroom", OracleType.Number);
                cmd2.Parameters["myroom"].Value = room;
                cmd2.Parameters["myroom"].Direction = System.Data.ParameterDirection.Input;
                cmd2.Parameters.Add("mymovie", OracleType.Number);
                cmd2.Parameters["mymovie"].Value = movieNum;
                cmd2.Parameters["mymovie"].Direction = System.Data.ParameterDirection.Input;

                cmd2.ExecuteNonQuery();

                OracleDataAdapter da2 = new OracleDataAdapter();
                da2.SelectCommand = new OracleCommand();
                DataTable dt2 = new DataTable();

                da2.SelectCommand.Connection = conn;
                da2.SelectCommand.CommandText = "select * from Screen order by screendate asc";
                da2.Fill(dt2);
                dataGridView.DataSource = dt2;
                int seats = Convert.ToInt32(dataGridView.Rows[yCoord].Cells[3].Value);
                if (seats + seatsToAdd > 127)

                    MessageBox.Show("Yo can't add so many seats to this screen");
                else

                MessageBox.Show("You have added " + seatsToAdd + " seats to the screen at " + date + " in room " + room);
            }
            catch (Exception s)
            {
                   MessageBox.Show(s.Message);
            }
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            conn.Close();
            Hide();
        }
    }
}
