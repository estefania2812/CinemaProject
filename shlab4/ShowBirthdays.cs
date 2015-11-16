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
    public partial class ShowBirthdays : Form
    {
        OracleConnection conn = Singleton.getConnection();
        OracleCommand cmd = new OracleCommand();

        public ShowBirthdays()
        {
            InitializeComponent();
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            
            BindingSource bs2 = new BindingSource();
            bs2.DataSource = new List<String> { "", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12" };
            months_comboBox.DataSource = bs2;
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            conn.Close();
            Hide();
        }

        private void months_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (months_comboBox.Text.Equals(""))
            {
                birthdays_dataGridView.DataSource = null;
            }
            else
            {
                try
                {
                    int curItem = Convert.ToInt32(months_comboBox.Text);
                    OracleDataAdapter da = new OracleDataAdapter();
                    da.SelectCommand = new OracleCommand();
                    DataTable dt = new DataTable();

                    da.SelectCommand.Connection = conn;
                    da.SelectCommand.CommandText = "select ClientId, LName, FName, BirthDate, Email from Client where extract(month from BirthDate)= " + curItem +
                                                    "order by extract(day from BirthDate) Asc";
                    da.Fill(dt);
                    birthdays_dataGridView.DataSource = dt;
                }
                catch (Exception s)
                {
                    
                   MessageBox.Show(s.Message);
                }
            }
        }
    }
}
