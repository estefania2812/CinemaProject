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
    public partial class AddScreen : Form
    {
        OracleConnection conn = Singleton.getConnection();
        OracleCommand cmd = new OracleCommand();
        OracleCommand cmd2 = new OracleCommand();

        public AddScreen()
        {
            InitializeComponent();
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select MovieNumber from Movie";
            OracleDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                movieNum_comboBox.Items.Add(dataReader.GetInt32(0).ToString());
            }
            BindingSource bs = new BindingSource();
            bs.DataSource = new List<String> { "", "11:00:00 AM", "01:00:00 PM", "03:00:00 PM", "05:00:00 PM", "07:00:00 PM", "09:00:00 PM", "11:00:00 PM" };
            Hour_comboBox.DataSource = bs;
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            if (movieNum_comboBox.Text == "" || room_textBox.Text == "" || seats_textBox.Text == "" || Hour_comboBox.Text == "")
                MessageBox.Show("You must fill all the fields");

            
            if (seats_textBox.Text != "")
            {
                if (Convert.ToInt32(seats_textBox.Text) > 127)
                    MessageBox.Show("Error: There are only 127 seats");
                else
                {
                    if (DateTime.Now.AddDays(-1) > dateTimePicker.Value)

                        MessageBox.Show("The date for the screen you want to add is not valid");


                    else
                    {
                        try
                        {

                            cmd.Connection = conn;
                            cmd.CommandType = CommandType.StoredProcedure;

                            int seats = Convert.ToInt32(seats_textBox.Text);
                            int room = Convert.ToInt32(room_textBox.Text);
                            int movieNum = Convert.ToInt32(movieNum_comboBox.Text);
                            dateTimePicker.Format = DateTimePickerFormat.Custom;
                            dateTimePicker.CustomFormat = "DD/MM/YYYY";
                            int day = (int)dateTimePicker.Value.Day;
                            int month = (int)dateTimePicker.Value.Month;
                            int year = (int)dateTimePicker.Value.Year;


                            string date = day + "/" + month + "/" + year + " " + Hour_comboBox.Text;

                            cmd2.Connection = conn;
                            cmd2.CommandType = CommandType.Text;
                            cmd2.CommandText = "select screendate, roomnumber from screen where screendate= TO_DATE('" + date + "'" + ", 'DD/MM/YYYY HH:MI:SS AM') and roomnumber = "
                                              + room;
                            var reader = cmd2.ExecuteReader();

                            if (reader.HasRows == true)
                            {
                                MessageBox.Show("This screen is busy already");
                            }

                            else
                            {
                                cmd.CommandText = "insert into Screen values (TO_DATE('" + date + "',' DD/MM/YYYY hh:mi:ss AM')" + "," + room + "," + movieNum + "," + seats + ")";
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Screen added successfully");

                            }
                        }

                        catch (Exception s)
                        {
                            MessageBox.Show(s.Message);
                        }


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
