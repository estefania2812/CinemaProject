using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shlab4
{
    public partial class Clients : Form
    {
        public Clients()
        {
            InitializeComponent();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            UpdateClient update_client = new UpdateClient();
            update_client.Show();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            AddClient add_client = new AddClient();
            add_client.Show();
        }

        private void birthday_button_Click(object sender, EventArgs e)
        {
            ShowBirthdays show_birthdays = new ShowBirthdays();
            show_birthdays.Show();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            DeleteClient delete_client = new DeleteClient();
            delete_client.Show();
        }
    }
}
