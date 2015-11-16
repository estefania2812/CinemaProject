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
    public partial class UpdateClient : Form
    {
        OracleConnection conn = Singleton.getConnection();
        OracleCommand cmd = new OracleCommand();

        public UpdateClient()
        {
            InitializeComponent();
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select ClientId from Client";
            OracleDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
               id_comboBox.Items.Add(dataReader.GetInt32(0).ToString());
            }
            
        }

        private void update_button_Click(object sender, EventArgs e)
        {

            if (id_comboBox.Text == "" || LName_textBox.Text == "" || FName_textBox.Text == "" || Phone_textBox.Text == "" || email_textBox.Text == "")
                MessageBox.Show("You must fill all the fields");
            else
            {
                if ((int)DateTime.Now.Year - (int)birthdate_dateTimePicker.Value.Year > 120 || (int)DateTime.Now.Year - (int)birthdate_dateTimePicker.Value.Year < 13)
                    MessageBox.Show("Client age is not valid");
                else
                {
                    try 
                    {
                    int ClientId = Convert.ToInt32(id_comboBox.Text);
                   
                    string LName = LName_textBox.Text;
                    string FName = FName_textBox.Text;
                    string Phone = Phone_textBox.Text;
                    string Email = email_textBox.Text;
                    birthdate_dateTimePicker.Format = DateTimePickerFormat.Custom;
                    birthdate_dateTimePicker.CustomFormat = "MM/dd/yyyy";

                    DateTime date = birthdate_dateTimePicker.Value;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update Client set LName = &param1, FName = &param2, Phone = &param3, BirthDate = &param4, Email = &param5 where ClientId = &keyValue";
                    cmd.Parameters.AddWithValue("keyValue", ClientId);
                    cmd.Parameters.AddWithValue("Param1", LName);
                    cmd.Parameters.AddWithValue("Param2", FName);
                    cmd.Parameters.AddWithValue("Param3", Phone);
                    cmd.Parameters.AddWithValue("Param4", date);
                    cmd.Parameters.AddWithValue("Param5", Email);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Client updated successfully");
                    
                    }
                    catch (Exception s)
                    {
                        MessageBox.Show(s.Message);
                    }
                }
            }
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            conn.Close();
            Hide();
        }

        private void id_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

                    int ClientId = Convert.ToInt32(id_comboBox.Text);
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from Client where ClientId= " + ClientId;
                    

                    

                        var reader = cmd.ExecuteReader();
                        try
                        {
                            if (reader.HasRows == false)
                            {
                                throw new Exception();
                            }
                           while (reader.Read())
                            {

                               LName_textBox.Text = reader[1].ToString();
                               FName_textBox.Text = reader[2].ToString();
                               Phone_textBox.Text = reader[3].ToString();
                               birthdate_dateTimePicker.Value = (DateTime)reader[4];
                               
                               email_textBox.Text = reader[5].ToString();
                                
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("ERROR: " + ex.Message);
                        }
                    
        }
        }
    }

