using System;
using System.Windows.Forms;

namespace ScreenAdmin
{
    public partial class AddUnits : Form
    {
        AbautIcon a;
        public AddUnits()
        {
            InitializeComponent();
        }
        public AddUnits(AbautIcon owner)
        {
            InitializeComponent();
            a = owner;
        }
        private void done_Click(object sender, EventArgs e)
        {
           if (0< Convert.ToInt32(textBox1.Text))
            {
                try
                {
                    int chek = Convert.ToInt32(textBox1.Text);
                    a.InStock.Text = textBox1.Text;
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Не является числом");
                }
            }
            else MessageBox.Show("Колличество товара не может быть отрицательным");

        }
    }
}
