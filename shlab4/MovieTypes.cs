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
    public partial class MovieTypes : Form
    {
        OracleConnection conn = Singleton.getConnection();
        OracleCommand cmd = new OracleCommand();

        public MovieTypes()
        {
            InitializeComponent();
            BindingSource bs3 = new BindingSource();
            bs3.DataSource = new List<String> { "", "Action", "Drama", "Romance", "Thriller", "Comedy" };
            genre_comboBox.DataSource = bs3;
            
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            conn.Close();
            Hide();
        }

        public void GetDataByQueryString(string strQueryString)
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            OracleDataAdapter da = new OracleDataAdapter();
            da.SelectCommand = new OracleCommand();
            DataTable dt = new DataTable();

            da.SelectCommand.Connection = conn;
            da.SelectCommand.CommandText = strQueryString;
            da.Fill(dt);
            movieTypes_dataGridView.DataSource = dt;
            
        }

        private void genre_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = genre_comboBox.SelectedItem.ToString();
            string SQLquery = "select Title, Movie.Description, Actors, rate, ScreenDate from Movie natural join Screen where Genre= '" + curItem +
                "' order by rate desc,ScreenDate";
            GetDataByQueryString(SQLquery);
            
        }
    }
}
