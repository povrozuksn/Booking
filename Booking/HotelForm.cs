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
        public static string Hotel_Name;
        public static int Rating;
        public static int hotelid;

        public HotelForm(string hotel_id)
        {
            InitializeComponent();
            RoomsPanel.Controls.Clear();
            List<string> otel = SQLClass.Select("SELECT Name, City, Rating, Image, Adress, ID FROM hotels WHERE ID = '" + hotel_id + "'");

            Text = otel[0];
            label1.Text = otel[0];
            Hotel_Name = otel[0];
            Rating = Convert.ToInt32(otel[2]);
            hotelid = Convert.ToInt32(hotel_id);
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

            //Звезды
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
            //Номера
            List<string> rooms = SQLClass.Select("SELECT Name, Price, Image, ID, quantity FROM rooms WHERE Hotel_id = '" + hotel_id + "'");
            x = 40;
            for (int i = 0; i < rooms.Count; i += 5)
            {

                Label lbl = new Label();
                lbl.Location = new Point(x, 10);
                lbl.Size = new Size(250, 30);
                lbl.Font = new Font("Microsoft Sans Serif", 12);
                lbl.Text = rooms[i];
                lbl.Tag = rooms[i + 3];
                lbl.Click += new EventHandler(label3_Click);
                RoomsPanel.Controls.Add(lbl);

                PictureBox pb = new PictureBox();
                pb = new PictureBox();
                try
                {
                    pb.Load("../../Pictures/" + rooms[i + 2]);
                }
                catch (Exception) { }
                pb.Location = new Point(x, 30);
                pb.Size = new Size(250, 180);
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pb.Tag = rooms[i + 3];
                pb.Click += new EventHandler(pictureBox6_Click);
                RoomsPanel.Controls.Add(pb);
                
                Label lb = new Label();
                lb.Location = new Point(x, 210);
                lb.Size = new Size(100, 40);
                lb.Font = new Font("Microsoft Sans Serif", 12);
                lb.Text = rooms[i + 1] + " руб.";
                lb.Tag = rooms[i + 3];
                RoomsPanel.Controls.Add(lb);
                
                x += 260;
            }
        }

        private void HotelForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            RoomForm rf = new RoomForm(hotelid.ToString(), pb.Tag.ToString());
            rf.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            RoomForm rf = new RoomForm(hotelid.ToString(), lbl.Tag.ToString());
            rf.Show();
        }

        private void OpinionButton_Click(object sender, EventArgs e)
        {
            SQLClass.Update("INSERT INTO rating (User, Hotel_id, Rate, Comments)" +
                              "VALUES('" + MainForm.Login + "', '" + hotelid + "', '" + numericUpDown1.Value.ToString() + "', '" + textBox1.Text + "')");

            MessageBox.Show("Спасибо");
        }
    }
}
