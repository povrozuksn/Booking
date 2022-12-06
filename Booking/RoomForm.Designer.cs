
namespace Booking
{
    partial class RoomForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomForm));
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.QuantityTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.InfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // InfoPanel
            // 
            this.InfoPanel.Controls.Add(this.label4);
            this.InfoPanel.Controls.Add(this.label3);
            this.InfoPanel.Controls.Add(this.label2);
            this.InfoPanel.Controls.Add(this.label1);
            this.InfoPanel.Controls.Add(this.pictureBox1);
            this.InfoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.InfoPanel.Location = new System.Drawing.Point(0, 0);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(1033, 300);
            this.InfoPanel.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(474, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(473, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(323, 36);
            this.label3.TabIndex = 7;
            this.label3.Text = "Одноместный номер";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(474, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Адрес:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(473, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Гостиница \"Москва\"";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(422, 273);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(650, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(244, 78);
            this.button1.TabIndex = 2;
            this.button1.Text = "Забронировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Location = new System.Drawing.Point(410, 385);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(212, 30);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker2.Location = new System.Drawing.Point(410, 433);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(212, 30);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(256, 390);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Дата заезда";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(253, 438);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Дата выезда";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(256, 333);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "Цена";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(531, 333);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 25);
            this.label8.TabIndex = 10;
            this.label8.Text = "Количество";
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Enabled = false;
            this.PriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceTextBox.Location = new System.Drawing.Point(335, 333);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.ReadOnly = true;
            this.PriceTextBox.Size = new System.Drawing.Size(113, 30);
            this.PriceTextBox.TabIndex = 11;
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.Enabled = false;
            this.QuantityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuantityTextBox.Location = new System.Drawing.Point(660, 333);
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.ReadOnly = true;
            this.QuantityTextBox.Size = new System.Drawing.Size(107, 30);
            this.QuantityTextBox.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(454, 333);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 25);
            this.label9.TabIndex = 13;
            this.label9.Text = "руб.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(773, 333);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 25);
            this.label10.TabIndex = 14;
            this.label10.Text = "шт.";
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButton.Location = new System.Drawing.Point(826, 333);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(135, 30);
            this.SaveButton.TabIndex = 15;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Visible = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 500);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.QuantityTextBox);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.InfoPanel);
            this.Name = "RoomForm";
            this.Text = "RoomForm";
            this.Load += new System.EventHandler(this.RoomForm_Load);
            this.InfoPanel.ResumeLayout(false);
            this.InfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.TextBox QuantityTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button SaveButton;
    }
}