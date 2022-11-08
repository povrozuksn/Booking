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
    public partial class AdminRoomsForm : Form
    {
        public AdminRoomsForm()
        {
            InitializeComponent();

            List<string> hotels_list = MainForm.MySelect("SELECT Name, City, ID FROM hotels");

            comboBox1.Items.Clear();
            for(int i=0; i<hotels_list.Count; i+=3)
            {
                comboBox1.Items.Add(hotels_list[i]+ "," + hotels_list[i+1] + "," + hotels_list[i+2]);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] parts = comboBox1.Text.Split(new char[] { ',' });
            
            MainForm.MyUpdate("INSERT INTO rooms (Name, Price, Name_hotel, City, Hotel_id)" +
                              "VALUES('" + textBox1.Text + "', '" + textBox2.Text + "', '" + parts[0] + "', '" + parts[1] + "', '" + parts[2] + "')");

            MessageBox.Show("Сохранено");
            AdminRoomsForm_Load(sender, e);
            return;
        }

        private void AdminRoomsForm_Load(object sender, EventArgs e)
        {
            List<string> list = MainForm.MySelect("SELECT Name, Price, Name_hotel, City, ID, Hotel_id FROM rooms");

            panel1.Controls.Clear();
            int y = 10;
            for (int i = 0; i < list.Count; i += 6)
            {
                Label lbl0 = new Label();
                lbl0.Location = new Point(50, y);
                lbl0.Size = new Size(170, 30);
                lbl0.Font = new Font("Microsoft Sans Serif", 12);
                lbl0.Text = list[i];
                lbl0.Tag = list[i+4];
                panel1.Controls.Add(lbl0);

                Label lbl1 = new Label();
                lbl1.Location = new Point(225, y);
                lbl1.Size = new Size(50, 30);
                lbl1.Font = new Font("Microsoft Sans Serif", 12);
                lbl1.Text = list[i + 1];
                panel1.Controls.Add(lbl1);

                Label lbl2 = new Label();
                lbl2.Location = new Point(280, y);
                lbl2.Size = new Size(250, 30);
                lbl2.Font = new Font("Microsoft Sans Serif", 12);
                lbl2.Text = list[i + 2];
                panel1.Controls.Add(lbl2);

                Label lbl3 = new Label();
                lbl3.Location = new Point(535, y);
                lbl3.Size = new Size(200, 30);
                lbl3.Font = new Font("Microsoft Sans Serif", 12);
                lbl3.Text = list[i + 3];
                panel1.Controls.Add(lbl3);

                Button btn = new Button();
                btn.Location = new Point(740, y);
                btn.Size = new Size(100, 30);
                btn.Font = new Font("Microsoft Sans Serif", 12);
                btn.Click += new EventHandler(DeleteRoomClick);
                btn.Text = "Удалить";
                panel1.Controls.Add(btn);

                y += 35;
            }
        }

        private void DeleteRoomClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int y = btn.Location.Y;

            foreach (Control control in panel1.Controls)
            {
                if (control.Location == new Point(50, y))
                {
                    MainForm.MyUpdate("DELETE FROM rooms WHERE ID = '" + control.Tag + "'");
                    AdminRoomsForm_Load(sender, e);
                    return;
                }
            }
        }

        string adress = "";
        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                adress = openFileDialog1.FileName;
                pictureBox1.Load(adress);
                System.IO.File.Copy(adress, "../../Pictures/" + System.IO.Path.GetFileName(adress));
                adress = System.IO.Path.GetFileName(adress);
            }
        }
    }
}
