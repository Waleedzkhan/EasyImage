using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace ImageComparison
{
    public partial class FreeHand : Form
    {
        Graphics Graphic;//this class contains methods for drawing shapes and other stuff such as drawLine etc
        Pen myPen = new Pen(Color.Black,1);
        Point ep = new Point(0,0);
        Point sp = new Point(0,0);
        int k = 0;
        
        public FreeHand()
        {
            InitializeComponent();
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            
            sp = e.Location;
            if(e.Button==MouseButtons.Left){
                k = 1;
            }
          
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if(k==1){
            ep = e.Location;
            Graphic = this.CreateGraphics();
            Graphic.DrawLine(myPen, sp, ep);
            }
            sp = ep;
            
          
        }

       

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            k = 0;
        }

        private void red_Click(object sender, EventArgs e)
        {
            myPen.Color = red.BackColor;
            pictureBox1.BackColor = red.BackColor;
        }

        private void green_Click(object sender, EventArgs e)
        {
            myPen.Color = green.BackColor;
            pictureBox1.BackColor = green.BackColor;
        }

        private void yellow_Click(object sender, EventArgs e)
        {
            myPen.Color = yellow.BackColor;
            pictureBox1.BackColor = yellow.BackColor;
        }

        private void blue_Click(object sender, EventArgs e)
        {
            myPen.Color = blue.BackColor;
            pictureBox1.BackColor = blue.BackColor;
        }

        private void white_Click(object sender, EventArgs e)
        {
            myPen.Color = white.BackColor;
            pictureBox1.BackColor = white.BackColor;
        }

        private void black_Click(object sender, EventArgs e)
        {
            myPen.Color = black.BackColor;
            pictureBox1.BackColor = black.BackColor;
        }

        private void orange_Click(object sender, EventArgs e)
        {
            myPen.Color = orange.BackColor;
            pictureBox1.BackColor = orange.BackColor;
        }

        private void pink_Click(object sender, EventArgs e)
        {
            myPen.Color = pink.BackColor;
            pictureBox1.BackColor = pink.BackColor;
        }

        private void purple_Click(object sender, EventArgs e)
        {
            myPen.Color = purple.BackColor;
            pictureBox1.BackColor = purple.BackColor;
        }

        private void maroon_Click(object sender, EventArgs e)
        {
            myPen.Color = maroon.BackColor;
            pictureBox1.BackColor = maroon.BackColor;
        }

        private void brown_Click(object sender, EventArgs e)
        {
            myPen.Color = brown.BackColor;
            pictureBox1.BackColor = brown.BackColor;
        }

        private void rubber_Click(object sender, EventArgs e)
        {
            myPen.Color = cyan.BackColor;
            pictureBox1.BackColor = cyan.BackColor;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Image = ImageComparison.Properties.Resources.cross2;
            this.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        
        

        private void pictureBox2_MouseLeave_1(object sender, EventArgs e)
        {
            pictureBox2.Image = ImageComparison.Properties.Resources.cross;
            this.Cursor = System.Windows.Forms.Cursors.Cross;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
     

      
    }
}
