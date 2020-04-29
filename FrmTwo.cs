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
    public partial class FrmTwo : Form
    {
        public FrmTwo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            int x;
            int y;
            int sum;

            x = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Enter x: ", "X",""));
            y = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Enter y: ", "Y", ""));
            sum = x + y;
            MessageBox.Show("The sum is: " + sum, "Result", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
        }

        private void BtnClickMe_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Hello There!", "Greetings", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (r == DialogResult.Yes)
            {
                MessageBox.Show("You chose Yes!");
            } else if (r == DialogResult.No)
            {
                MessageBox.Show("You chose No!");
            } else if (r == DialogResult.Cancel)
            {
                MessageBox.Show("You chose Cancel!");
            }
        }
    }
}
