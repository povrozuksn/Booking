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
        public static int id;

        public HotelForm(string hotel_name)
        {
            InitializeComponent();

            List<string> otel = MainForm.MySelect("SELECT Name, City, Rating, Image, Adress, ID FROM hotels WHERE Name = '" + hotel_name + "'");

            Text = otel[0];
            label1.Text = otel[0];
            Hotel_Name = otel[0];
            Rating = Convert.ToInt32(otel[2]);
            id = Convert.ToInt32(otel[5]);
            try
            {
                pictureBox1.Load("../../Pictures/" + otel[3]);
            }
            catch (Exception) { };
            label5.Text = otel[4];

            if (MainForm.Login != "")
            {
                OpinionPanel.Visible = true;
            }
            else
            {
                OpinionPanel.Visible = false;
            }

            int x = 360;
            for(int i=0; i<Rating; i++)
            {
                PictureBox box = new PictureBox();
                box.Load("../../Pictures/star.png");
                box.Location = new Point(x, 5);
                box.Size = new Size(40, 40);
                box.SizeMode = PictureBoxSizeMode.Zoom;
                panel1.Controls.Add(box);

                x += 43;
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

        private void OpinionButton_Click(object sender, EventArgs e)
        {            
            MainForm.MyUpdate("INSERT INTO rating (User, Hotel_id, Rate, Comments)" +
                              "VALUES('" + MainForm.Login + "', '" + id + "', '" + numericUpDown1.Value.ToString() + "', '" + textBox1.Text + "')");

            MessageBox.Show("Спасибо");
        }
    }
}
