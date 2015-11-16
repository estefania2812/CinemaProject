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
    public partial class updateScreenGrid : Form
    {
        OracleConnection conn = Singleton.getConnection();
        OracleCommand cmd = new OracleCommand();

        public updateScreenGrid()
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
            screen_dataGridView.DataSource = dt;
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            conn.Close();
            Hide();
        }

        private void screen_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int yCoord = screen_dataGridView.CurrentCellAddress.Y;
            DateTime date = (DateTime)screen_dataGridView.Rows[yCoord].Cells[0].Value;
            int room = Convert.ToInt32(screen_dataGridView.Rows[yCoord].Cells[1].Value);
            int movieNum = Convert.ToInt32(screen_dataGridView.Rows[yCoord].Cells[2].Value);
            int seats = Convert.ToInt32(screen_dataGridView.Rows[yCoord].Cells[3].Value);
            UpdateScreen update_screen = new UpdateScreen(date, room, movieNum, seats);
            update_screen.Show();
        }
    }
}
