using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace ScreenAdmin
{
    public partial class AbautIcon : Form
    {
        ScreenAdmin screenAdmin;
        Thread th;

        private string name1;
        protected string producer1;
        protected string typeMedication1;
        protected int yearProduction1;
        protected int inStock1;
        protected double coast1;
        protected string namePhoto;

        protected ScreenAdd sc;
        AddUnits addUnit;
        ScreenAdmin owner;

       protected bool pills;
        protected bool potion;
        protected bool powders;
        protected bool injections;
        protected bool allType;

        protected bool alphabetically;
        protected bool asItIs;
        protected bool byManufacturer;
        protected bool greatestNumber;

        public int InStock1 
        { 
            get => inStock1; 
            set 
            {
                if (value < 0) inStock1 = 0;
                    else inStock1 = value;
            }
        }

       public bool Pills { get => pills; set => pills = value; }
        public bool Potion { get => potion; set => potion = value; }
        public bool Powders { get => powders; set => powders = value; }
        public bool Injections { get => injections; set => injections = value; }
        public bool AllType { get => allType; set => allType = value; }
        public bool Alphabetically { get => alphabetically; set => alphabetically = value; }
        public bool AsItIs { get => asItIs; set => asItIs = value; }
        public bool ByManufacturer { get => byManufacturer; set => byManufacturer = value; }
        public bool GreatestNumber { get => greatestNumber; set => greatestNumber = value; }
        public string Name1 { get => name1; set => name1 = value; }
        public string NamePhoto { get => namePhoto; set => namePhoto = value; }

        public AbautIcon()
        {
            InitializeComponent();
        }
      
        public AbautIcon(ScreenAdd a,ScreenAdmin z)
        {
            InitializeComponent();
            this.owner = z;

            this.pills = z.Pills.Checked;
            this.potion = z.Potion.Checked;
            this.powders = z.Powders.Checked;
            this.injections = z.Injections.Checked;
            this.allType = z.AllType.Checked;
            this.alphabetically = z.Alphabetically.Checked;
            this.asItIs = z.AsItIs.Checked;
            this.byManufacturer = z.ByManufacturer.Checked;
            this.greatestNumber = z.GreatestNumber.Checked;

            this.sc = a;
            this.name1 = a.name1;
            this.producer1 = a.producer1;
            this.typeMedication1 = a.typeMedication1;
            this.yearProduction1 = a.yearProduction1;
            this.inStock1 = a.inStock1;
            this.coast1 = a.coast1;
            this.namePhoto = a.namePhoto;
        }


        protected virtual void back_Click(object sender, EventArgs e)
        {
            sc = new ScreenAdd(name1, producer1, typeMedication1, yearProduction1,Convert.ToInt32(inStock.Text),coast1,namePhoto);
            screenAdmin = new ScreenAdmin(sc,this);
           
            this.Close();
            th = new Thread(Open);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        protected virtual void Open()
        {
            Application.Run(screenAdmin);
        }
        protected void AbautIcon_Load(object sender, EventArgs e)
        {
            name.Text = name1;
            manufacturer.Text = producer1;
            typeMedicine.Text = typeMedication1;
            productionYear.Text = Convert.ToString(yearProduction1);
            inStock.Text = Convert.ToString(this.inStock1);
            coast.Text = Convert.ToString(coast1);
            photo.Image = new Bitmap($@"{Directory.GetCurrentDirectory()}\Resources\{namePhoto}");
        }

        private void delete_Click(object sender, EventArgs e)
        {
            screenAdmin = new ScreenAdmin(name1,this);


            this.Close();
        
            th = new Thread(Open);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
         
        }

        private void addUnits_Click(object sender, EventArgs e)
        {
            new AddUnits(this).ShowDialog();
        }
    }
}
