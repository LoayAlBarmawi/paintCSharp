using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        Graphics g;
        int x = -1;
        int y = -1;
        bool moving = false;
        Pen pen;
       
        public Form1()
        { 
            InitializeComponent();
           
            g = canvas.CreateGraphics();
            pen = new Pen(Color.Black, 5);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            textBox1.Text = "5";
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
           
            PictureBox p = (PictureBox)sender;
            pen.Color = p.BackColor;
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            PictureBox p = (PictureBox)sender;
            pen.Color = p.BackColor;
        }

        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            moving = true;
            x = e.X;
            y = e.Y;
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (moving && x != -1 && y != -1)
            {
                g.DrawLine(pen, new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;
            }
        }

        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
            x = -1;
            y = -1;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            pen.Color = p.BackColor;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
          
            PictureBox p = (PictureBox)sender;
            pen.Color = p.BackColor;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
           
            PictureBox p = (PictureBox)sender;
            pen.Color = p.BackColor;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            pen.Color = p.BackColor;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            
            PictureBox p = (PictureBox)sender;
            pen.Color = p.BackColor;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
           
            PictureBox p = (PictureBox)sender;
            pen.Color = p.BackColor;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
           
            PictureBox p = (PictureBox)sender;
            pen.Color = p.BackColor;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            
            PictureBox p = (PictureBox)sender;
            pen.Color = p.BackColor;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
           
            PictureBox p = (PictureBox)sender;
            pen.Color = p.BackColor;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
           
            PictureBox p = (PictureBox)sender;
            pen.Color = p.BackColor;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            pen.Width = Convert.ToInt32(textBox1.Text);
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            
            PictureBox p = (PictureBox)sender;
            pen.Color = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            canvas.Refresh();
        }


    }
}
