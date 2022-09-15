using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Booking
{
    public partial class RoomForm : Form
    {
        public RoomForm(string HotelName, string RoomName)
        {
            InitializeComponent();

            Text = HotelName + ": " + RoomName;
            label1.Text = HotelName;
            label3.Text = RoomName;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Успешно!");
        }
    }
}
