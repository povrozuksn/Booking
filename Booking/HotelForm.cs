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
    public partial class HotelForm : Form
    {
        public HotelForm(string HotelName)
        {
            InitializeComponent();

            Text = HotelName;
            label1.Text = HotelName;

            if(HotelName == "Гостиница \"Москва\"")
            {  
                pictureBox1.Load("../../Pictures/Moskow.jpg");
            }
            else if (HotelName == "Гостиница \"Венец\"")
            {
                pictureBox1.Load("../../Pictures/Venec.jpg");
            }
            else if (HotelName == "Гостиница \"Минск\"")
            {
                pictureBox1.Load("../../Pictures/Minsk.jpg");
            }

        }

        private void HotelForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            RoomForm rf = new RoomForm();
            rf.Show();
        }
    }
}
