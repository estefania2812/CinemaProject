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
    public partial class Movies : Form
    {
        OracleConnection conn = Singleton.getConnection();
        OracleCommand cmd = new OracleCommand();

        public Movies()
        {
            InitializeComponent();
        }

        private void updateMovie_button_Click(object sender, EventArgs e)
        {
            UpdateMovie update_movie = new UpdateMovie();
            update_movie.Show();
        }

        private void AddMovie_button_Click(object sender, EventArgs e)
        {
            AddMovie add_movie = new AddMovie();
            add_movie.Show();
        }

        private void DeleteMovie_button_Click(object sender, EventArgs e)
        {
            DeleteMovie delete_movie = new DeleteMovie();
            delete_movie.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Close();
            Hide();

        }

        private void Types_button_Click(object sender, EventArgs e)
        {
            MovieTypes movie_types = new MovieTypes();
            movie_types.Show();
        }

        private void Info_button_Click(object sender, EventArgs e)
        {
            MoviesInformation movies_info = new MoviesInformation();
            movies_info.Show();
        }

        private void see_button_Click(object sender, EventArgs e)
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
         
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Title from Movie m join Screen s on m.movienumber=s.movienumber " +
                                         "where s.reservedseats=(select max(reservedSeats) from Screen)";
            var reader = cmd.ExecuteReader();
            try
            {
                if (reader.HasRows == false)
                {
                    throw new Exception();
                }
                if (reader.Read())
                {

                    textBox1.Text = reader[0].ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
              
        }
    }
}