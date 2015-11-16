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
    public partial class tablesView : Form
    {

        public OracleConnection conn = Singleton.getConnection();
        OracleCommand cmd = new OracleCommand();
        
        
        public tablesView()
        {
            InitializeComponent();
            BindingSource bs = new BindingSource();
            bs.DataSource = new List<String> { "", "Movies", "Clients", "Tickets", "Screens", "Reservations", "Rooms" };
            comboBox1.DataSource = bs;
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
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
            dataGridView.DataSource = dt;
            conn.Close();
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string curItem = comboBox1.SelectedItem.ToString();

            if (curItem.Equals("Movies"))
            {
                string SQLquery = "select * from Movie";
                GetDataByQueryString(SQLquery);
            }

            else if (curItem.Equals("Clients"))
            {
                string SQLquery = "select * from Client";
                GetDataByQueryString(SQLquery);
            }

            else if (curItem.Equals("Reservations"))
            {
                string SQLquery = "select * from Reservation";
                GetDataByQueryString(SQLquery);
            }

            else if (curItem.Equals("Tickets"))
            {
                string SQLquery = "select * from Ticket";
                GetDataByQueryString(SQLquery);
            }

            else if (curItem.Equals("Screens"))
            {
                string SQLquery = "select * from Screen order by screendate asc";
                GetDataByQueryString(SQLquery);
            }

            else if (curItem.Equals("Rooms"))
            {
                string SQLquery = "select * from Room";
                GetDataByQueryString(SQLquery);
            }
             if (curItem.Equals(""))
            {
                dataGridView.DataSource = null;
            }
        }



        private void exit_button2_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
