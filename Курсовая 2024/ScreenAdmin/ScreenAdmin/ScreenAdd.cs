using System;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace ScreenAdmin
{
    public partial class ScreenAdd : Form
    {

        public string name1;
        public string producer1;
        public string typeMedication1;
        public int yearProduction1;
        public int inStock1;
        public double coast1;
        public string namePhoto;

        bool pills;
        bool potion;
        bool powders;
        bool injections;
        bool allType;

        bool alphabetically;
        bool asItIs;
        bool byManufacturer;
        bool greatestNumber;
        public OpenFileDialog openFile;

        ScreenAdmin screenAdmin;
        Thread th;
        string nal;
        public bool Pills { get => pills; set => pills = value; }
        public bool Potion { get => potion; set => potion = value; }
        public bool Powders { get => powders; set => powders = value; }
        public bool Injections { get => injections; set => injections = value; }
        public bool AllType { get => allType; set => allType = value; }
        public bool Alphabetically { get => alphabetically; set => alphabetically = value; }
        public bool AsItIs { get => asItIs; set => asItIs = value; }
        public bool ByManufacturer { get => byManufacturer; set => byManufacturer = value; }
        public bool GreatestNumber { get => greatestNumber; set => greatestNumber = value; }
        public string Nal { get => nal; set => nal = value; }

        public ScreenAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            screenAdmin = new ScreenAdmin(this);

            this.Close();
            th = new Thread(Open);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

        }

        private void Open(object obj)
        {
            Application.Run(screenAdmin);
        }

        public ScreenAdd(ScreenAdmin z)
        {
            InitializeComponent();
            this.pills = z.Pills.Checked;
            this.potion = z.Potion.Checked;
            this.powders = z.Powders.Checked;
            this.injections = z.Injections.Checked;
            this.allType = z.AllType.Checked;

            this.byManufacturer = z.ByManufacturer.Checked;
            this.alphabetically = z.Alphabetically.Checked;
            this.asItIs = z.AsItIs.Checked;
            this.greatestNumber = z.GreatestNumber.Checked;
        }

        public ScreenAdd(string name, string producer, string typeMedication, int yearProduction, int inStock, double coast, string namePhoto)
        {
            this.name1 = name;
            this.producer1 = producer;
            this.typeMedication1 = typeMedication;
            this.yearProduction1 = yearProduction;
            this.inStock1 = inStock;
            this.coast1 = coast;
            this.namePhoto = namePhoto;
        }

        public void OpenAdmin()
        {
            this.Close();
            th = new Thread(Open);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        public int Chek()
        {
            double a = 0;
            char[] chek;
            string[] pols = new string[] { typeMedication.Text, yearProduction.Text, inStock.Text, coast.Text };
            string[] number = new string[] { yearProduction.Text, inStock.Text, coast.Text };
            for (int i = 0; i < pols.Length; i++)
            {
                try
                {
                    chek = pols[i].ToArray();

                    for (int z = 0; z < chek.Length; z++)
                    {
                        string el = Convert.ToString(chek[z]);
                        if (String.Compare(el, " ") == 0 || String.Compare(el, null) == 0) return 0;
                        
                       

                    }
                    if (i <= 2) a = Convert.ToDouble(number[i]) <= 0 ? a = Convert.ToDouble("") : a = Convert.ToDouble(number[i]);
                }
                catch (FormatException)
                {
                    return 1;
                }
               
            }

            if (Convert.ToInt32(yearProduction.Text)  > DateTime.Now.Year) return 2;
            return -1;
        }

        private void button3_Click(object sender, EventArgs e)

        {
            try{
                photo.Image.Save($@"{Directory.GetCurrentDirectory()}\Resources\{openFile.SafeFileName}");


                if (Chek() == 0)
                {
                    MessageBox.Show($"Вы незаполнили все поля \n или в них есть пробелы");
                }
                else if (Chek() == 1)
                {
                    MessageBox.Show($"В местах , где необходимо написать цифры\nнеизвестные символы или пробелы");
                } else if(Chek() == 2) MessageBox.Show($"Нельзя указать год, который не наступил");
                else if (before.Checked == true)
                {
                    screenAdmin = new ScreenAdmin(this, placeAdd(), textBoxBefore.Text);
                    OpenAdmin();
                }
                else if (after.Checked == true)
                {
                    screenAdmin = new ScreenAdmin(this, placeAdd(), textBoxAfter.Text);
                    OpenAdmin();
                }
                else
                {
                    screenAdmin = new ScreenAdmin(this, placeAdd(), "");
                    OpenAdmin();
                }
            }
            catch
            {
                MessageBox.Show("Вы не добавили фотографию");
            }
        }

        public string placeAdd()
        {
            if (start.Checked == true)
            {
                return start.Text;
            }
            else if (before.Checked == true)
            {
                textBoxBefore.Visible = true;
                return before.Text;
            }
            else if (after.Checked == true)
            {
                textBoxAfter.Visible = true;
                return after.Text;
            }
            return end.Text;
        }

        private void ScreenAdd_Load(object sender, EventArgs e)
        {
            end.Checked = true;
        }

        private void before_Click(object sender, EventArgs e)
        {
            placeAdd();
            if (after.Checked == false)
            {
                textBoxAfter.Text = "";
                textBoxAfter.Visible = false;
            }
            if (before.Checked == false)
            {
                textBoxBefore.Text = "";
                textBoxBefore.Visible = false;
            }
        }

        private void addPhoto_Click(object sender, EventArgs e)
        {
            openFile = new OpenFileDialog();
            openFile.Filter = "Image files(* JPG, * EMP, * .GIF, * .PNG) | * .JPG; *.EMP;*.GIF;*.PNG | All files(*.*) | *.*";
            if (openFile.ShowDialog() == DialogResult.OK)
                try
                {
                    this.photo.Image = new Bitmap(openFile.FileName);

                }

                catch
                {
                    MessageBox.Show("Фото неверного формата");
                }
          
        }
    }
}
