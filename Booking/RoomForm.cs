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
        public RoomForm(string HotelName, string RoomName, int Rating)
        {
            InitializeComponent();

            Text = HotelName + ": " + RoomName;
            label1.Text = HotelName;
            label3.Text = RoomName;

            if(RoomName == "Одноместный номер")
            {
                pictureBox1.Load("../../Pictures/1seat.jpg");
            }

            if (RoomName == "Двухместный номер")
            {
                pictureBox1.Load("../../Pictures/2seat.jpg");
            }

            int x = 480;
            for (int i = 0; i < Rating; i++)
            {
                PictureBox box = new PictureBox();
                box.Load("../../Pictures/star.jpg");
                box.Location = new Point(x, 70);
                box.Size = new Size(50, 50);
                box.SizeMode = PictureBoxSizeMode.Zoom;
                InfoPanel.Controls.Add(box);

                x += 55;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Успешно!");
        }

        private void RoomForm_Load(object sender, EventArgs e)
        {

        }
    }
}
