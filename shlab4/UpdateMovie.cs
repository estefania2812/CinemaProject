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
    public partial class UpdateMovie : Form
    {

        OracleConnection conn = Singleton.getConnection();
        OracleCommand cmd = new OracleCommand();

        public UpdateMovie()
        {
            InitializeComponent();
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            BindingSource bs2 = new BindingSource();
            bs2.DataSource = new List<String> { "", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
            rate_comboBox.DataSource = bs2;
            BindingSource bs3 = new BindingSource();
            bs3.DataSource = new List<String> { "", "Action", "Drama", "Romance", "Thriller", "Comedy" };
            genre_comboBox.DataSource = bs3;
            OracleDataAdapter da = new OracleDataAdapter();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select MovieNumber from Movie";
            OracleDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                movieNumber_comboBox.Items.Add(dataReader.GetInt32(0).ToString());
            }
            
        }

        private void confirm_button_Click(object sender, EventArgs e)
        {


            if (movieNumber_comboBox.Text == "" || genre_comboBox.Text == "" || title_textBox.Text == "" || actors_textBox.Text == "" || description_richTextBox.Text == "" || rate_comboBox.Text == null)
                MessageBox.Show("You must fill all the fields");
            else
            {
               
                try
                {
                    int MovieNumber = Convert.ToInt32(movieNumber_comboBox.Text);
                    string Genre = genre_comboBox.Text;
                    string Title = title_textBox.Text;
                    string Actors = actors_textBox.Text;
                    string Description = description_richTextBox.Text;
                    int Rate = Convert.ToInt32(rate_comboBox.SelectedValue);

                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update Movie set  Genre = &param1, Title = &param2, Actors = &param3, Description = &param4, Rate = &param5 where MovieNumber = &keyValue";
                    cmd.Parameters.AddWithValue("keyValue", MovieNumber);
                    cmd.Parameters.AddWithValue("Param1", Genre);
                    cmd.Parameters.AddWithValue("Param2", Title);
                    cmd.Parameters.AddWithValue("Param3", Actors);
                    cmd.Parameters.AddWithValue("Param4", Description);
                    cmd.Parameters.AddWithValue("Param5", Rate);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Movie updated successfully");
                }
                catch (Exception s)
                {
                    MessageBox.Show(s.Message);
                }
            }
        }



        private void exit_button2_Click(object sender, EventArgs e)
        {
            conn.Close();
            Hide();
        }

        private void movieNumber_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

                    int movienum = Convert.ToInt32(movieNumber_comboBox.Text);
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from Movie where MovieNumber= " + movienum;
                    

                    

                        var reader = cmd.ExecuteReader();
                        try
                        {
                            if (reader.HasRows == false)
                            {
                                throw new Exception();
                            }
                           while (reader.Read())
                            {

                               genre_comboBox.Text = reader[1].ToString();
                               title_textBox.Text = reader[2].ToString();
                               actors_textBox.Text = reader[4].ToString();
                               description_richTextBox.Text = reader[3].ToString();
                               rate_comboBox.Text = reader[5].ToString();

                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("ERROR: " + ex.Message);
                        }
                    
        }

    }
}

