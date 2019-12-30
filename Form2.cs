using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mp3_player
{
    public partial class Form2 : Form
    {
        Form1 f1;
        public Form2(Form1 frm1)
        {
            InitializeComponent();
            this.f1 = frm1;
        }

       

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure ?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Form3 f3 = new Form3();
                f3.ShowDialog();
                f1.comboBox1.Items.Add(textBox1.Text);
                    this.Close();
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
