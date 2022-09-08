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
        public MainForm()
        {
            InitializeComponent();
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
            HotelForm hf = new HotelForm();
            hf.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            HotelForm hf = new HotelForm();
            hf.ShowDialog();
        }
    }
}
