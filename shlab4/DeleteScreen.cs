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
    public partial class DeleteScreen : Form
    {
        OracleConnection conn = Singleton.getConnection();
        OracleCommand cmd = new OracleCommand();

        public DeleteScreen()
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

        private void delete_button_Click(object sender, EventArgs e)
        {

            cmd.Connection = conn;
            int yCoord = screen_dataGridView.CurrentCellAddress.Y;
            
            DateTime date = (DateTime)screen_dataGridView.Rows[yCoord].Cells[0].Value;
            int room = Convert.ToInt32(screen_dataGridView.Rows[yCoord].Cells[1].Value);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "delete from Screen where ScreenDate= TO_DATE('" + date + "'" + ", 'MM/DD/YYYY HH:MI:SS AM') and roomnumber = " + room;
      
            try
            {

                cmd.ExecuteNonQuery();
                screen_dataGridView.Rows.Remove(screen_dataGridView.Rows[yCoord]);
                MessageBox.Show("Screen deleted successfully");

            }

            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            conn.Close();
            Hide();
        }
    }
}
