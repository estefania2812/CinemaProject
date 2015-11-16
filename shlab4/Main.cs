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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

      

        private void tablesView_button_Click(object sender, EventArgs e)
        {
            tablesView tables_view = new tablesView ();
            tables_view.Show();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void Movies_button_Click(object sender, EventArgs e)
        {
            Movies movies = new Movies();
            movies.Show();
        }

        private void rooms_button_Click(object sender, EventArgs e)
        {
            Rooms rooms = new Rooms();
            rooms.Show();
        }

        private void clients_button_Click(object sender, EventArgs e)
        {
            Clients clients = new Clients();
            clients.Show();
        }

        private void tickets_button_Click(object sender, EventArgs e)
        {
            Tickets tickets = new Tickets();
            tickets.Show();
        }

        private void reservation_button_Click(object sender, EventArgs e)
        {
            Reservations reservations = new Reservations();
            reservations.Show();
        }

        private void screens_button_Click(object sender, EventArgs e)
        {
            Screens screens = new Screens();
            screens.Show();
        }
    }
}
