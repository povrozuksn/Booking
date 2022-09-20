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
    public partial class MainForm : Form
    {
        public static List<Hotel> hotels = new List<Hotel>();

        public MainForm()
        {
            InitializeComponent();

            string[] lines = System.IO.File.ReadAllLines("Гостиницы.txt");

            foreach(string line in lines)
            {
                string[] parts = line.Split(new string[] { ", " }, StringSplitOptions.None);
                Hotel hotel = new Hotel(parts[0], parts[1], Convert.ToInt32(parts[2]), parts[3]);
                hotels.Add(hotel);
            }

            int x = 40;
            foreach(Hotel hotel in hotels)
            {
                hotel.pb.Location = new Point(x, 30);
                hotel.pb.Size = new Size(200, 180);
                hotel.pb.Image = hotel.pb.Image;
                hotel.pb.SizeMode = PictureBoxSizeMode.Zoom;
                hotel.pb.Tag = hotel.Name;
                hotel.pb.Click += new EventHandler(pictureBox1_Click);
                HoletsPanel.Controls.Add(hotel.pb);

                x += 220;
            }
        }


        private void FilrtButton_Click(object sender, EventArgs e)
        {
            if(FiltrPanel.Size.Height < 50)
            {
                FiltrPanel.Size = new Size(FiltrPanel.Size.Width, 145);
            }
            else
            {
                FiltrPanel.Size = new Size(FiltrPanel.Size.Width, FilrtButton.Size.Height);
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            HotelForm hf = new HotelForm(pb.Tag.ToString());
            hf.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            HotelForm hf = new HotelForm(lb.Text);
            hf.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
