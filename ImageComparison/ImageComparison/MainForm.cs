using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ImageComparison
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        

        

        private void compareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fr = new Form1();
            fr.ShowDialog();
        }

        private void grayScaleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form fr = new GScale();
            fr.ShowDialog();
        }

        private void cropToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fr = new Crop();
            fr.ShowDialog();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void freeHandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fr = new FreeHand();
            fr.ShowDialog();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("EasyImage by Waleed khan Contact@ netprodigy@hotmail.com for assistance ");
        }

        
    }
}
