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
    public partial class MoviesInformation : Form
    {
        OracleConnection conn = Singleton.getConnection();
        OracleCommand cmd = new OracleCommand();

        public MoviesInformation()
        {
            InitializeComponent();

            OracleDataAdapter da = new OracleDataAdapter();
            da.SelectCommand = new OracleCommand();
            DataTable dt = new DataTable();

            da.SelectCommand.Connection = conn;
            string SQLquery = "select MovieNumber from Movie";
            da.SelectCommand.CommandText = SQLquery;
            da.Fill(dt);
            chooseMovie_comboBox.DataSource = dt;
            chooseMovie_comboBox.DisplayMember = "MovieNumber";
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            conn.Close();
            Hide();
        }


        private void chooseMovie_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
      
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                int curItem = Convert.ToInt32(((DataRowView)chooseMovie_comboBox.SelectedValue)["MovieNumber"]);
     
                    try
                    {
                        income_textBox.Text = "";
                        seeIncome_checkBox.Checked = false;
                        OracleCommand cmd = new OracleCommand();
                        cmd.Connection = conn;
                        cmd.CommandText = "DATESFORMOVIE";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("Movie_Number", OracleType.Number);
                        cmd.Parameters["Movie_Number"].Value = curItem;
                        cmd.Parameters["Movie_Number"].Direction = ParameterDirection.Input;
                        cmd.Parameters.Add("ret", OracleType.VarChar, 500);
                        cmd.Parameters["ret"].Direction = ParameterDirection.ReturnValue;
                        cmd.ExecuteNonQuery();
                        string result = Convert.ToString(cmd.Parameters["ret"].Value);
                        if (result.Equals(""))
                        {
                            richTextBox1.Text = "There is no dates for this movie yet";
                        }
                        else
                        {
                            richTextBox1.Text = result;
                        }

                     
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERROR: " + ex.Message);
                    }
                
        }

        private void checkedChanged1(object sender, EventArgs e)
        {

            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            int curItem = Convert.ToInt32(((DataRowView)chooseMovie_comboBox.SelectedValue)["MovieNumber"]);

            if (seeIncome_checkBox.Checked == false)
            {
                income_textBox.Text = "";
            }
            else
            {
                try
                {
                    OracleCommand cmd2 = new OracleCommand();
                    cmd2.Connection = conn;
                    cmd2.CommandText = "INCOME_FOR_MOVIE";
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.Add("Movie_Number", OracleType.Number);
                    cmd2.Parameters["Movie_Number"].Value = curItem;
                    cmd2.Parameters["Movie_Number"].Direction = ParameterDirection.Input;
                    cmd2.Parameters.Add("income", OracleType.Number);
                    cmd2.Parameters["income"].Direction = ParameterDirection.ReturnValue;

                    cmd2.ExecuteNonQuery();
                    string result2 = Convert.ToString(cmd2.Parameters["income"].Value);

                    income_textBox.Text = result2;



                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex.Message);
                }
            }
                
        }
    }
}
