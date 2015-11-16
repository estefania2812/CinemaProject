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
    public partial class Tickets : Form
    {
        public Tickets()
        {
            InitializeComponent();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            AddTicket add_ticket = new AddTicket();
            add_ticket.Show();
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            UpdateTicket update_ticket = new UpdateTicket();
            update_ticket.Show();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            DeleteTicket delete_ticket = new DeleteTicket();
            delete_ticket.Show();
        }
    }
}
