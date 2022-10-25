using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data.Common;

namespace Booking
{
    public partial class AdminHotelsForm : Form
    {
        public AdminHotelsForm()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        string adress = "";
        private void button1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                adress = openFileDialog1.FileName;
                pictureBox1.Load(adress);
                System.IO.File.Copy(adress, "../../Pictures/" + System.IO.Path.GetFileName(adress));
                adress = System.IO.Path.GetFileName(adress);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainForm.MyUpdate("INSERT INTO hotels (Name, City, Rating, Image, Adress)"+
                              "VALUES('"+ textBox1.Text +"', '"+ textBox2.Text + "', '"+ textBox3.Text + "', '"+ adress + "', '"+ textBox4.Text + "')");
            
            MessageBox.Show("Сохранено");
            AdminHotelsForm_Load(sender, e);
            return;
        }

        private void AdminHotelsForm_Load(object sender, EventArgs e)
        {
            List<string> list = MainForm.MySelect("SELECT Name, City, Rating, Image, Adress, ID FROM hotels");

            panel1.Controls.Clear();
            int y = 10;
            for (int i=0; i<list.Count; i+=6)
            {
                Label lbl0 = new Label();
                lbl0.Location = new Point(50, y);
                lbl0.Size = new Size(250, 30);
                lbl0.Font = new Font("Microsoft Sans Serif", 12);
                lbl0.Text = list[i];
                panel1.Controls.Add(lbl0);
                
                Label lbl1 = new Label();
                lbl1.Location = new Point(300, y);
                lbl1.Size = new Size(200, 30);
                lbl1.Font = new Font("Microsoft Sans Serif", 12);
                lbl1.Text = list[i+1];
                panel1.Controls.Add(lbl1);                

                Button btn = new Button();
                btn.Location = new Point(500, y);
                btn.Size = new Size(100, 30);
                btn.Font = new Font("Microsoft Sans Serif", 12);
                btn.Click += new EventHandler(DeleteHotelClick);
                btn.Text = "Удалить";
                panel1.Controls.Add(btn);

                y += 35;
            }
        }

        private void DeleteHotelClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int y = btn.Location.Y;

            foreach(Control control in panel1.Controls)
            {
                if(control.Location == new Point(50, y))
                {
                    MainForm.MyUpdate("DELETE FROM hotels WHERE Name = '" + control.Text + "'");                    
                    AdminHotelsForm_Load(sender, e);
                    return;
                }
            }
        }
    }
}
