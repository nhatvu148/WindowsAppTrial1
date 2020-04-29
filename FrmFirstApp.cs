using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstApp
{
    public partial class FrmFirstApp : Form
    {
        public FrmFirstApp()
        {
            InitializeComponent();
        }

        private void BtnApply_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello! " + TxtBox.Text);
        }

        private void FrmFirstApp_Load(object sender, EventArgs e)
        {

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            RBtnOne.Checked = true;
        }

        private void PicOne_Click(object sender, EventArgs e)
        {
            RBtnTwo.Checked = true;
        }

        private void RBtnOne_CheckedChanged(object sender, EventArgs e)
        {
            PicOne.Visible = true;
            PicTwo.Visible = false;
        }

        private void RBtnTwo_CheckedChanged(object sender, EventArgs e)
        {
            PicOne.Visible = false;
            PicTwo.Visible = true;
        }

        private void HsbNumber_Scroll(object sender, ScrollEventArgs e)
        {
            TxtBox.Text = HsbNumber.Value.ToString();
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void BtnMove_Click(object sender, EventArgs e)
        {
            FrmTwo x = new FrmTwo();
            
            //x.Show();
            //this.Height; this.Width;
            x.MyText = "Hello";
            //x.ShowDialog();
            if (x.ShowDialog() == DialogResult.Cancel)
            {
                MessageBox.Show(x.MyText);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            LblMyText.Text = Convert.ToString(e.KeyChar) + " " + Convert.ToString((int)e.KeyChar);
            TxtMyText.Text = "";
            //e.Handled = true; => KeyPress event has been handled and pressed key is ignored
        }

        private void FrmFirstApp_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Really quit?", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
