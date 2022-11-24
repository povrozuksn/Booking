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
        public static int Rating;
        string id = "";

        public RoomForm(string hotel_id, string room_id)
        {
            InitializeComponent();
            id = room_id;

            List<string> otel = MainForm.MySelect("SELECT Name, City, Rating, Image, Adress, ID FROM hotels WHERE ID = '" + hotel_id + "'");
            List<string> room = MainForm.MySelect("SELECT Name, Price, Image, ID FROM rooms WHERE ID = '" + room_id + "'");

            Text = otel[0] + ": " + room[0];
            label1.Text = otel[0];
            label3.Text = room[0];
            label4.Text = otel[4];
            Rating = Convert.ToInt32(otel[2]);

            try
            {
                pictureBox1.Load("../../Pictures/" + room[2]);
            }
            catch (Exception) { };

            
            

            int x = 360;
            for (int i = 0; i < Rating; i++)
            {
                PictureBox box = new PictureBox();
                box.Load("../../Pictures/star.png");
                box.Location = new Point(x, 50);
                box.Size = new Size(50, 50);
                box.SizeMode = PictureBoxSizeMode.Zoom;
                InfoPanel.Controls.Add(box);

                x += 55;
            }

        }       

        private void button1_Click(object sender, EventArgs e)
        {
            if(MainForm.Login == "")
            {
                MessageBox.Show("Вы не авторизованы");
                return;
            }
            
            MainForm.MyUpdate("INSERT INTO booking(user, datefrom, dateto, room_id) VALUES(" +
                "'" + MainForm.Login + "'," +
                "'" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "'," +
                "'" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "'," +
                id + ")");
            MessageBox.Show("Успешно!");
        }

        private void RoomForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
