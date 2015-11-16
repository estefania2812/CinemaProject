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
    public partial class AddClient : Form
    {
        OracleConnection conn = Singleton.getConnection();
        OracleCommand cmd = new OracleCommand();

        public AddClient()
        {
            InitializeComponent();
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            conn.Close();
            Hide();
        }

        private void add_button_Click(object sender, EventArgs e)
        {

            if (Id_textBox.Text == "" || LName_textBox.Text == "" || FName_textBox.Text == "" || Phone_textBox.Text == "" || email_textBox.Text == "")
                MessageBox.Show("You must fill all the fields");
            else
            {
                if ((int)DateTime.Now.Year - (int)birthdate_dateTimePicker.Value.Year > 120 || (int)DateTime.Now.Year - (int)birthdate_dateTimePicker.Value.Year < 13)
                    MessageBox.Show("Client age is not valid");
                else
                {


                    try
                    {
                        int n;
                        if (int.TryParse(LName_textBox.Text, out n) == true || int.TryParse(FName_textBox.Text, out n) == true || int.TryParse(email_textBox.Text, out n) == true || int.TryParse(Phone_textBox.Text, out n) == false)
                            MessageBox.Show("There is some incorrect format");
                        else
                        {
                            cmd.Connection = conn;
                            cmd.CommandType = CommandType.StoredProcedure;
                            int clientId = Convert.ToInt32(Id_textBox.Text);
                            birthdate_dateTimePicker.Format = DateTimePickerFormat.Custom;
                            birthdate_dateTimePicker.CustomFormat = "dd/MM/yyyy";
                            int day = (int)birthdate_dateTimePicker.Value.Day;
                            int month = (int)birthdate_dateTimePicker.Value.Month;
                            int year = (int)birthdate_dateTimePicker.Value.Year;
                            string date = day + "/" + month + "/" + year;
                            int phone = Convert.ToInt32(Phone_textBox.Text);

                            cmd.CommandText = "insert into Client values (" + clientId + "," + "'" + this.LName_textBox.Text + "'" +
                                 "," + "'" + this.FName_textBox.Text + "'" + "," + phone + "," + "(TO_DATE('" + date + "','DD/MM/YYYY'))"
                                  + "," + "'" + email_textBox.Text + "')";
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Client added successfully");

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
}
