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
    public partial class AddMovie : Form
    {
        OracleConnection conn = Singleton.getConnection();
        OracleCommand cmd = new OracleCommand();

        public AddMovie()
        {
            InitializeComponent();
            BindingSource bs2 = new BindingSource();
            bs2.DataSource = new List<String> { "", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
            Rate_comboBox.DataSource = bs2;
            BindingSource bs3 = new BindingSource();
            bs3.DataSource = new List<String> { "", "Action", "Drama", "Romance", "Thriller", "Comedy" };
            Genre_comboBox.DataSource = bs3;

            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }


        }

        private void AddMovie_button_Click(object sender, EventArgs e)
        {

            if (MovieNumber_textBox.Text == "" || Genre_comboBox.Text == "" || Title_textBox.Text == "" || Actors_textBox.Text == "" || Description_richTextBox.Text == "" || Rate_comboBox.Text == null)
                MessageBox.Show("You must fill all the fields");
            else
            {

                 try
                   {
                       cmd.Connection = conn;
                       cmd.CommandType = CommandType.StoredProcedure;
                       int movienum = Convert.ToInt32(MovieNumber_textBox.Text);
                       int rate = Convert.ToInt32(Rate_comboBox.Text);
                       cmd.CommandText = "insert into Movie values (" + movienum + "," + "'" + this.Genre_comboBox.Text + "'" +
                            "," + "'" + this.Title_textBox.Text + "'" + "," + "'" + this.Description_richTextBox.Text + "'" + "," + "'" + this.Actors_textBox.Text +
                            "'" + "," + rate + ")";
                       cmd.ExecuteNonQuery();
                       MessageBox.Show("Movie added successfully");
                    
                   }

                 catch (Exception s)
                   {
                    MessageBox.Show(s.Message);
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
