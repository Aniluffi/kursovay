using System;
using System.IO;
using System.Windows.Forms;

namespace ScreenAdmin
{
    public partial class Balans : Form
    {
       ScreenUsesr screenUsesr;
        public Balans(ScreenUsesr a)
        {
            InitializeComponent();
            this.screenUsesr = a;
        }

        private void deposit_Click(object sender, EventArgs e)
        {
            try
            {
            if (-1 == Chek(textBoxDeposit.Text))
            {
               
                    this.chet.Text = Convert.ToString(Math.Round(Convert.ToDouble(textBoxDeposit.Text) + Convert.ToDouble(this.chet.Text), 2));
                    screenUsesr.Chet.Text = this.chet.Text;
                Save(new StreamWriter($@"{Directory.GetCurrentDirectory()}\txt\Balans.txt"));
                textBoxDeposit.Text = "0";
            }
            else if (0 == Chek(textBoxDeposit.Text))
            {
                MessageBox.Show("Вы ничего не ввели!");
            }
            else if (1 == Chek(textBoxDeposit.Text))
            {
                MessageBox.Show("Введите число!");
                textBoxDeposit.Text = "0";
            }
            }
            catch
            {
                MessageBox.Show("Слишком болльшая сумма для пополнения!");

            }
           
        }

        public int Chek(string txt)
        {
            if (String.Compare(txt,"") == 0) return 0;
                try
                {
                    double  a = Convert.ToDouble(txt) == 0 ? a = Convert.ToDouble("yg") : a = Convert.ToDouble(txt);   
                }
                catch (FormatException)
                {
                    return 1;
                }
                finally
                {

                }
            return -1;
        }

        private void withdraw_Click(object sender, EventArgs e)
        {
            try
            {
            if (-1 == Chek(textBoxWithdraw.Text))
            {
                if ( Convert.ToDouble(chet.Text) - Convert.ToDouble(textBoxWithdraw.Text) >= 0)
                {
              
                        this.chet.Text = Convert.ToString(Math.Round(Convert.ToDouble(this.chet.Text) - Convert.ToDouble(textBoxWithdraw.Text)));
                        screenUsesr.Chet.Text = this.chet.Text;
                    
                    
                Save(new StreamWriter($@"{Directory.GetCurrentDirectory()}\txt\Balans.txt"));

                    textBoxWithdraw.Text = "0";
                } else  MessageBox.Show("Недостаточно средств!");
               

            }
            else if (0 == Chek(textBoxWithdraw.Text))
            {
                MessageBox.Show("Вы ничего не ввели!");
            }
            else if (1 == Chek(textBoxWithdraw.Text))
            {
                MessageBox.Show("Введите число!");
                textBoxWithdraw.Text = "0";
            }
            }
            catch
            {
                MessageBox.Show("Слишком болльшая сумма для пополнения!");
            }

        }

        private void Balans_Load(object sender, EventArgs e)
        {
            this.chet.Text = screenUsesr.Chet.Text;
        }

        protected  void Save(StreamWriter z)
        {
            using (z)
            {
                z.WriteLine($"{chet.Text}");
            }

        }
    }
}
