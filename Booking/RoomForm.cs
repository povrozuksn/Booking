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
        int qty = 0;
        int price;

        public RoomForm(string hotel_id, string room_id)
        {
            InitializeComponent();
            id = room_id;

            List<string> otel = SQLClass.Select("SELECT Name, City, Rating, Image, Adress, ID FROM hotels WHERE ID = '" + hotel_id + "'");
            List<string> room = SQLClass.Select("SELECT Name, Price, Image, ID, quantity FROM rooms WHERE ID = '" + room_id + "'");

            Text = otel[0] + ": " + room[0];
            qty = Convert.ToInt32(room[4]);
            price = Convert.ToInt32(room[1]);
            label1.Text = otel[0];
            label3.Text = room[0];
            label4.Text = otel[4];
            Rating = Convert.ToInt32(otel[2]);

            PriceTextBox.Text = price.ToString();
            QuantityTextBox.Text = qty.ToString();

            PriceTextBox.Enabled = MainForm.isAdmin;
            QuantityTextBox.Enabled = MainForm.isAdmin;
            PriceTextBox.ReadOnly = !MainForm.isAdmin;
            QuantityTextBox.ReadOnly = !MainForm.isAdmin;
            SaveButton.Visible = MainForm.isAdmin;

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
            #region Проверка ошибок
            if (MainForm.Login == "")
            {
                MessageBox.Show("Вы не авторизованы");
                return;
            }
            
            DateTime dt = dateTimePicker1.Value;
            while(dt <= dateTimePicker2.Value.AddDays(0.5))
            {
                List<string> existBooking = SQLClass.Select("SELECT COUNT(*) FROM booking " +
                    "WHERE datefrom <= '" + dt.ToString("yyyy-MM-dd") + "'" +
                    "AND dateto >= '" + dt.ToString("yyyy-MM-dd") + "'");
                if(Convert.ToInt32(existBooking[0]) >= qty)
                {
                    MessageBox.Show("На эти даты мест нет, Выберите другие даты");
                    return;
                }

                dt = dt.AddDays(1);
            }
            #endregion

            SQLClass.Update("INSERT INTO booking(user, datefrom, dateto, room_id) VALUES(" +
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

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SQLClass.Update("UPDATE rooms SET Price='" + PriceTextBox.Text + "' , quantity='" + QuantityTextBox.Text + "' WHERE ID ='" + id + "'");
            MessageBox.Show("Сохранено");
        }
    }
}
