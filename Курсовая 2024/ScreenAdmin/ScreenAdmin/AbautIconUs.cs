using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;


namespace ScreenAdmin
{
    public class AbautIconUs:AbautIcon
    {
        private System.Windows.Forms.Button Buy;

        private void InitializeComponent()
        {
            this.Buy = new System.Windows.Forms.Button();
            this.back1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addUnits
            // 
            this.addUnits.Location = new System.Drawing.Point(186, 415);
            this.addUnits.Visible = false;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(326, 415);
            this.back.Visible = false;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(46, 415);
            this.delete.Visible = false;
            // 
            // Buy
            // 
            this.Buy.Location = new System.Drawing.Point(454, 334);
            this.Buy.Name = "Buy";
            this.Buy.Size = new System.Drawing.Size(145, 30);
            this.Buy.TabIndex = 14;
            this.Buy.Text = "Купить";
            this.Buy.UseVisualStyleBackColor = true;
            this.Buy.Click += new System.EventHandler(this.Buy_Click);
            // 
            // back1
            // 
            this.back1.Location = new System.Drawing.Point(13, 13);
            this.back1.Name = "back1";
            this.back1.Size = new System.Drawing.Size(75, 23);
            this.back1.TabIndex = 15;
            this.back1.Text = "назад";
            this.back1.UseVisualStyleBackColor = true;
            this.back1.Click += new System.EventHandler(this.back_Click);
            // 
            // AbautIconUs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back1);
            this.Controls.Add(this.Buy);
            this.Name = "AbautIconUs";
            this.Controls.SetChildIndex(this.delete, 0);
            this.Controls.SetChildIndex(this.addUnits, 0);
            this.Controls.SetChildIndex(this.back, 0);
            this.Controls.SetChildIndex(this.Buy, 0);
            this.Controls.SetChildIndex(this.back1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        ScreenUsesr screenUsesr;
        private Button back1;
        Thread th;
        double balans;

        public double Balans { get => balans; set => balans = value; }

        public AbautIconUs(ScreenAdd a, ScreenUsesr z)
        {
            InitializeComponent();
            this.screenUsesr = z;

            this.pills = z.Pills.Checked;
            this.potion = z.Potion.Checked;
            this.powders = z.Powders.Checked;
            this.injections = z.Injections.Checked;
            this.allType = z.AllType.Checked;
            this.alphabetically = z.Alphabetically.Checked;
            this.asItIs = z.AsItIs.Checked;
            this.byManufacturer = z.ByManufacturer.Checked;
            this.greatestNumber = z.GreatestNumber.Checked;
            this.balans = Convert.ToDouble(z.Chet.Text);

            this.sc = a;
            this.Name1 = a.name1;
            this.producer1 = a.producer1;
            this.typeMedication1 = a.typeMedication1;
            this.yearProduction1 = a.yearProduction1;
            this.inStock1 = a.inStock1;
            this.coast1 = a.coast1;
            this.namePhoto = a.namePhoto;
        }
        
        private void Buy_Click(object sender, EventArgs e)
        {
            if (balans >= coast1 & inStock1 > 0)
            {
                this.inStock1--;
                InStock.Text = Convert.ToString(inStock1);
                balans -= coast1;
                Save(new StreamWriter($@"{Directory.GetCurrentDirectory()}\txt\\Balans.txt"));
            }
            else if (inStock1 <= 0) 
            {
                MessageBox.Show("Товар закончился!");
            }
            else MessageBox.Show("недостаточно средств!");
            
           

          
        }

        protected override void back_Click(object sender, EventArgs e)
        {
            sc = new ScreenAdd(Name1, producer1, typeMedication1, yearProduction1,inStock1,coast1, namePhoto);
            screenUsesr = new ScreenUsesr(sc, this);

            this.Close();
            th = new Thread(Open);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
           
        }
        private void Open()
        {
            Application.Run(screenUsesr);
        }
        protected void Save(StreamWriter z)
        {
            using (z)
            {
                z.WriteLine($"{balans}");
            }

        }
    }
}
