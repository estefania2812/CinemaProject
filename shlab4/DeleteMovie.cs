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
    public partial class DeleteMovie : Form

    {
        OracleConnection conn = Singleton.getConnection();
        OracleCommand cmd = new OracleCommand();
        
        
        
        public DeleteMovie()
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
                  MovieToDelete_comboBox.Items.Add(dataReader.GetInt32(0).ToString());
              }
            
        }

      

        private void back_button_Click(object sender, EventArgs e)
        {
            conn.Close();
            Hide();
            
        }

        private void DeleteMovie_button_Click(object sender, EventArgs e)
        {
            if (MovieToDelete_comboBox.Text == "")
                MessageBox.Show("You must enter a movie to delete");
            else
            {
                cmd.Connection = conn;
                int movienum = Convert.ToInt32(MovieToDelete_comboBox.Text);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "delete from Movie where MovieNumber= " + movienum;

                try
                {

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Movie deleted successfully");

                }

                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex.Message);
                }
            }
        }

    

       
    }
}
