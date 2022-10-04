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
    public struct Hotel
    {
        public string Name;
        public string City;
        public int Rating;
        public string Picture_Adress;
        public PictureBox pb;
        public Label lbl;

        public Hotel(string _Name, string _City, int _Rating, string _Adress)
        {
            Name = _Name;
            City = _City;
            Rating = _Rating;
            Picture_Adress = _Adress;
            pb = new PictureBox();
            try
            {
                pb.Load("../../Pictures/" + _Adress);
            }
            catch (Exception) { }

            lbl = new Label();
        }
    }


    public partial class HotelForm : Form
    {
        public static string Hotel_Name;
        public static int Rating;

        public HotelForm(Hotel hotel)
        {
            InitializeComponent();

            Text = hotel.Name;
            label1.Text = hotel.Name;
            Hotel_Name = hotel.Name;
            Rating = hotel.Rating;
            pictureBox1.Image = hotel.pb.Image;

            int x = 360;
            for(int i=0; i<hotel.Rating; i++)
            {
                PictureBox box = new PictureBox();
                box.Load("../../Pictures/star.jpg");
                box.Location = new Point(x, 60);
                box.Size = new Size(50, 50);
                box.SizeMode = PictureBoxSizeMode.Zoom;
                panel1.Controls.Add(box);

                x += 55;
            }
        }

        private void HotelForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            RoomForm rf = new RoomForm(Hotel_Name, pb.Tag.ToString(), Rating);
            rf.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            RoomForm rf = new RoomForm(Hotel_Name, lbl.Text, Rating);
            rf.Show();
        }
    }
}
