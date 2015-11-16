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
    public partial class Screens : Form
    {
        public Screens()
        {
            InitializeComponent();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            AddScreen add_screen = new AddScreen();
            add_screen.Show();
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            updateScreenGrid update_screen_grid = new updateScreenGrid();
            update_screen_grid.Show();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            DeleteScreen delete_screen = new DeleteScreen();
            delete_screen.Show();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddSeats add_seats = new AddSeats();
            add_seats.Show();
        }
    }
}
