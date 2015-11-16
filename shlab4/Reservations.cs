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
    public partial class Reservations : Form
    {
        public Reservations()
        {
            InitializeComponent();
        }

        private void deleteReservation_button_Click(object sender, EventArgs e)
        {
            DeleteReservation delete_res = new DeleteReservation();
            delete_res.Show();
        }

        private void addReservation_button_Click(object sender, EventArgs e)
        {
           AddReservation add_res = new AddReservation();
            add_res.Show();
        }

        private void TicketsForRes_button_Click(object sender, EventArgs e)
        {
            TicketsForReservation tickets_for_res = new TicketsForReservation();
            tickets_for_res.Show();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
