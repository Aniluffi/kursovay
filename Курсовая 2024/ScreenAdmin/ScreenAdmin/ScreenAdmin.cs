using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Security.Cryptography;


namespace ScreenAdmin
{
    public partial class ScreenAdmin : Form
    {

        protected Thread th;
        public static LinkedList<ScreenAdd> iconList = new LinkedList<ScreenAdd>();

        public static LinkedList<ScreenAdd> iconPills;
        public static LinkedList<ScreenAdd> iconPotion;
        public static LinkedList<ScreenAdd> iconInjections;
        public static LinkedList<ScreenAdd> iconPowders;
        public static LinkedList<ScreenAdd> All;

        public static LinkedList<ScreenAdd> sortAlphabetically;
        public static LinkedList<ScreenAdd> sortAsItIs;
        public static LinkedList<ScreenAdd> sortGreatestNumber;
        public static LinkedList<ScreenAdd> sortByManufacturer;

        public static LinkedList<ScreenAdd> sort;

        ScreenAdd iconDannie;

        static int power;
        protected int y;

        private LinkedList<ScreenAdd> SortAlhabet(bool alphabetically, bool asItIs, bool greatestNumber, bool byManufacturer)
        {

            LinkedList<ScreenAdd> a = iconList;

            if (alphabetically == true)
            {
                a = new LinkedList<ScreenAdd>(a.OrderBy(x => x.name1));
            }

            else if (greatestNumber == true)
            {
                LinkedList<ScreenAdd> z = new LinkedList<ScreenAdd>();
                a = new LinkedList<ScreenAdd>(a.OrderBy(x => x.inStock1));
                for (int i = 0; i < a.Count; i++)
                {
                    
                    z.AddFirst(a.ElementAt(i));
                }
                a = z;
            }

            else if (byManufacturer == true)
            {
                a = new LinkedList<ScreenAdd>(a.OrderBy(x => x.producer1));
            }
            return a;
        }

        private static LinkedList<ScreenAdd> Filter(LinkedList<ScreenAdd> a, string type)
        {
            LinkedList<ScreenAdd> iconType = new LinkedList<ScreenAdd>();

            for (int i = 0; i < a.Count; i++)
            {

                if (type == a.ElementAt(i).typeMedication1) iconType.AddLast(a.ElementAt(i));

            }
            return iconType;
        }

        public ScreenAdmin()
        {
            InitializeComponent();
        }


        public ScreenAdmin(ScreenAdd owner, string placeAdd, string beforeAfter)
        {
            InitializeComponent();

            iconDannie = new ScreenAdd(owner.name.Text, owner.producer.Text, owner.typeMedication.Text, Convert.ToInt32(owner.yearProduction.Text)
                , Convert.ToInt32(owner.inStock.Text), Convert.ToDouble(owner.coast.Text),owner.openFile.SafeFileName);

            if (placeAdd == "После")
            {
                iconList.AddAfter(AddBeforeAfter(owner.name.Text, iconList, beforeAfter), iconDannie);
            }
            else if (placeAdd == "Перед")
            {

                iconList.AddBefore(AddBeforeAfter(owner.name.Text, iconList, beforeAfter), iconDannie);
            }
            else if (placeAdd == "Начало")
            {
                iconList.AddFirst(iconDannie);
            }
            else if (placeAdd == "Конец")
            {
                iconList.AddLast(iconDannie);

            }

            Save(new StreamWriter($@"{Directory.GetCurrentDirectory()}\txt\Add.txt"));

            this.pills.Checked = owner.Pills;
            this.potion.Checked = owner.Potion;
            this.powders.Checked = owner.Powders;
            this.injections.Checked = owner.Injections;
            this.allType.Checked = owner.AllType;

            this.alphabetically.Checked = owner.Alphabetically;
            this.asItIs.Checked = owner.AsItIs;
            this.byManufacturer.Checked = owner.ByManufacturer;
            this.greatestNumber.Checked = owner.GreatestNumber;
        }

        private LinkedListNode<ScreenAdd> AddBeforeAfter(string name, LinkedList<ScreenAdd> a, string el)
        {
            LinkedListNode<ScreenAdd> n;
            for (int i = 0; i < a.Count; i++)
            {
                if (a.ElementAt(i).name1 == el) return n = a.Find(a.ElementAt(i));
            }
            return null;
        }

        public ScreenAdmin(string name, AbautIcon owner)
        {
            InitializeComponent();
            iconList.Remove(Delete(iconList, name));
          
            Save(new StreamWriter($@"{Directory.GetCurrentDirectory()}\txt\Add.txt"));
        
            this.pills.Checked = owner.Pills;
            this.potion.Checked = owner.Potion;
            this.powders.Checked = owner.Powders;
            this.injections.Checked = owner.Injections;
            this.allType.Checked = owner.AllType;

            this.alphabetically.Checked = owner.Alphabetically;
            this.asItIs.Checked = owner.AsItIs;
            this.byManufacturer.Checked = owner.ByManufacturer;
            this.greatestNumber.Checked = owner.GreatestNumber;
        }

        public ScreenAdmin(ScreenAdd a, AbautIcon owner)
        {
            InitializeComponent();
            this.pills.Checked = owner.Pills;
            this.potion.Checked = owner.Potion;
            this.powders.Checked = owner.Powders;
            this.injections.Checked = owner.Injections;
            this.allType.Checked = owner.AllType;

            this.alphabetically.Checked = owner.Alphabetically;
            this.asItIs.Checked = owner.AsItIs;
            this.byManufacturer.Checked = owner.ByManufacturer;
            this.greatestNumber.Checked = owner.GreatestNumber;

            for (int i = 0; i < iconList.Count; i++)
            {
                if (iconList.ElementAt(i).name1 == a.name1)
                {
                    iconList.ElementAt(i).inStock1 = a.inStock1;
                    Save(new StreamWriter($@"{Directory.GetCurrentDirectory()}\txt\Add.txt"));
                }
            }
            
        }

        public ScreenAdmin(ScreenAdmin owner)
        {
            InitializeComponent();
            this.pills.Checked = owner.Pills.Checked;
            this.potion.Checked = owner.Potion.Checked;
            this.powders.Checked = owner.Powders.Checked;
            this.injections.Checked = owner.Injections.Checked;
            this.allType.Checked = owner.AllType.Checked;

            this.alphabetically.Checked = owner.Alphabetically.Checked;
            this.asItIs.Checked = owner.AsItIs.Checked;
            this.byManufacturer.Checked = owner.ByManufacturer.Checked;
            this.greatestNumber.Checked = owner.GreatestNumber.Checked;
        }

        public ScreenAdmin(ScreenAdd owner)
        {
            InitializeComponent();
            this.pills.Checked = owner.Pills;
            this.potion.Checked = owner.Potion;
            this.powders.Checked = owner.Powders;
            this.injections.Checked = owner.Injections;
            this.allType.Checked = owner.AllType;

            this.alphabetically.Checked = owner.Alphabetically;
            this.asItIs.Checked = owner.AsItIs;
            this.byManufacturer.Checked = owner.ByManufacturer;
            this.greatestNumber.Checked = owner.GreatestNumber;
        }

        protected ScreenAdd Delete(LinkedList<ScreenAdd> a, string name)
        {
            for (int i = 0; i < a.Count; i++)
            {

                if (a.ElementAt(i).name1 == name)
                {
                    return a.ElementAt(i);
                }
            }
            return null;
        } 
        
        public void Form1_Load(object sender, EventArgs e)
        {
            this.main.Padding = new Padding(30);

            this.sideBar.Size = new Size(0, 0);

            ScreenAdmin_SizeChanged(this, EventArgs.Empty);

            LinkedList<ScreenAdd> f = new LinkedList<ScreenAdd>();

            using (StreamReader sr = new StreamReader($@"{Directory.GetCurrentDirectory()}\txt\Add.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        f.AddLast(SplAdd(line));
                    }
                }

            iconList = f;

            sort = SortAlhabet(alphabetically.Checked, asItIs.Checked, greatestNumber.Checked, byManufacturer.Checked);

            int x = 50;

            int z = 150;

            if (this.pills.Checked == true)
            {
                iconPills = Filter(sort, "Таблетки");

                for (int i = 0; i < iconPills.Count; i++)
                {
                    CreateIcon(iconPills.ElementAt(i), x, 50);
                    x += z;
                }
            }
            else if (powders.Checked == true)
            {
                iconPowders = Filter(sort, "Порошки");

                for (int i = 0; i < iconPowders.Count; i++)
                {
                    CreateIcon(iconPowders.ElementAt(i), x, 50);
                    x += z;
                }
            }
            else if (allType.Checked == true)
            {
                All = sort;

                for (int i = 0; i < All.Count; i++)
                {
                    CreateIcon(All.ElementAt(i), x, 50);
                    x += z;
                }
            }
            else if (injections.Checked == true)
            {

                iconInjections = Filter(sort, "Уколы");
                for (int i = 0; i < iconInjections.Count; i++)
                {
                    CreateIcon(iconInjections.ElementAt(i), x, 50);
                    x += z;
                }
            }
            else if (potion.Checked == true)
            {
                iconPotion = Filter(iconList, "Микстура");
                for (int i = 0; i < iconPotion.Count; i++)
                {
                    CreateIcon(iconPotion.ElementAt(i), x, 50);
                    x += z;
                }
            }

            this.main.Controls.Add(this.planX);
            
        }


        private void ScreenAdmin_SizeChanged(object sender, EventArgs e)
        {

            header.Location = new Point((head.Width - header.Width) / 2, (head.Height - header.Height) / 2);
            this.conteiner.Size = new Size(this.Width, this.Height);



            this.sideBar.Location = new Point(0, 0);
            main.Location = new Point(0, this.conteiner.Height - (this.conteiner.Height - this.head.Height));
            main.Size = new Size(conteiner.Width, this.conteiner.Height - head.Height -39);
            if (power == 1) sideBar.Size = new Size(250, this.Height);

            burger.Location = new Point(head.Width - 75, (head.Height - burger.Height) / 2);
            this.conteiner.Location = new Point((this.Width - this.conteiner.Width - 15) / 2, 0);

            this.planX.Size = new Size(main.Width - 100,50);

            Width768();
            Width425X768();


            void Width425X768()
            {
                if (this.conteiner.Width <= 768 & this.conteiner.Width >= 425)
                {
                    burger.Visible = true;

                }
            }

            void Width768()
            {
                if (this.conteiner.Width > 768)
                {
                  
                    burger.Visible = false;
                    int onePesentWidth = this.conteiner.Width / 100;
                    int onePesentHeight = this.conteiner.Height / 100;

                    this.sideBar.Size = new Size(onePesentWidth * 25, this.conteiner.Height);
                    this.sideBar.Location = new Point(0, this.conteiner.Height - (this.conteiner.Height - this.head.Height));

                    this.main.Size = new Size(this.conteiner.Width - this.sideBar.Width, this.conteiner.Height - head.Height);
                    this.main.Location = new Point(this.conteiner.Width - main.Width, this.conteiner.Height - main.Height);
                    this.planX.Size = new Size(main.Width - 100, 70);
                }
            }
        }

        private void burger_Click(object sender, EventArgs e)
        {
            if (power == 0)
            {
                this.sideBar.Location = new Point(0, 0);
                sideBar.Size = new Size(250, this.Height);

                sideBar.BringToFront();
                power++;
            }
            else
            {
                sideBar.Size = new Size(0, 0);
                sideBar.SendToBack();
                power--;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ScreenAdd screenAdd = new ScreenAdd();

            screenAdd.Show();

            this.Close();
            th = new Thread(Open);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

            void Open(object obj)
            {
                Application.Run(new ScreenAdd(this));
            }
        }

        protected virtual void CreateIcon(ScreenAdd a, int x, int y)
        {
            icon = new Panel();
            this.nalLabel = new Label();
            this.photo = new PictureBox();

            this.icon.SuspendLayout();
            this.main.Controls.Add(this.icon);
            this.icon.Size = new Size(100, 150);
            this.icon.BackColor = Color.FromArgb(220, 164, 164);
            this.icon.Location = new Point(x, 0);

            this.icon.Controls.Add(this.photo);
            photo.Size = new Size(80,60);
            photo.Location = new Point(10,10);
            photo.BackColor = Color.Aqua;
            photo.SizeMode = PictureBoxSizeMode.Zoom;
            photo.Image = new Bitmap($@"{Directory.GetCurrentDirectory()}\Resources\{a.namePhoto}");

            nameIcon = new Label();

            this.icon.Controls.Add(this.nameIcon);
            this.nameIcon.Location = new Point(0, 75);
            this.nameIcon.Width = 100;
            this.nameIcon.TextAlign = ContentAlignment.MiddleCenter;
            nameIcon.Text = a.name1;


            nalLabel.Text = a.inStock1 > 0 ? "Есть в наличии" : "Нет в наличии";
            this.icon.Controls.Add(this.nalLabel);
            nalLabel.Location = new Point(5, 100);

            if (nalLabel.Text == "Нет в наличии")
            {
                this.nalLabel.ForeColor = Color.Red;
                this.icon.BackColor = Color.Beige;
            }
            else
            {

                this.nalLabel.ForeColor = Color.Green;
                this.icon.BackColor = Color.FromArgb(220, 164, 164);
            }

            double coast = a.coast1;
            this.coast = new Label();
            this.coast.Text = $"Цена: {coast}";
            this.coast.Location = new Point(5, 125);
            this.icon.Controls.Add(this.coast);

            icon.Click += new System.EventHandler(Icon_Click);
            nameIcon.Click += new System.EventHandler(Icon_Click);
            this.coast.Click += new System.EventHandler(Icon_Click);
            this.nalLabel.Click += new System.EventHandler(Icon_Click);
            photo.Click += new EventHandler(Icon_Click);
            void Icon_Click(object sender, EventArgs e)
            {
                AbautIcon abautIcon = new AbautIcon(a, this);

                this.Close();
                th = new Thread(Open);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
                void Open(object obj)
                {
                    Application.Run(abautIcon);
                }
            }
        }

        protected void ButtonSort_Click(object sender, EventArgs e)
        {
            this.main.Controls.Clear();
            Form1_Load(this, EventArgs.Empty);
        }

       

        protected virtual void Search(object sender, EventArgs e)
        {
            this.y = 0;
            this.searchElement.Controls.Clear();


            LinkedList<ScreenAdd> list = new LinkedList<ScreenAdd>();
            string searchIcon = searchBox.Text;


            for (int i = 0; i < iconList.Count; i++)//обновляет провереямые элементы
            {
                int start = 0;
                int end = searchIcon.Length;
                string iconName = "";
                Char[] el = iconList.ElementAt(i).name1.ToCharArray();
                if (searchBox.Text == "") break;
                for (int s = 0; s < el.Length - searchIcon.Length + 1; s++)//проверяет на соответствие
                {
                    for (int z = start; z < end; z++)
                    {
                        iconName = iconName + Convert.ToString(el[z]);
                    }

                    if (String.Compare(iconName.ToLower(), searchIcon.ToLower()) == 0)
                    {

                        list.AddLast(iconList.ElementAt(i));

                        break;
                    }

                    start++;
                    end++;
                    iconName = "";

                }


            }

            list.AddLast(new ScreenAdd());
            for (int i = 0; i < list.Count; i++)
            {

                this.searchElement.Size = new Size(116, this.y);
                CreateIconSearch(list.ElementAt(i), this.y);

                this.y = y + 20;
            }

            void CreateIconSearch(ScreenAdd a, int y)
            {

                iconSearch = new Panel();

                this.iconSearch.SuspendLayout();
                this.searchElement.Controls.Add(this.iconSearch);
                this.iconSearch.Size = new Size(116, 20);
                this.iconSearch.BackColor = Color.Aqua;
                this.iconSearch.Location = new Point(0, y);

                nameIcon = new Label();

                this.iconSearch.Controls.Add(this.nameIcon);
                this.nameIcon.Location = new Point(0, 0);
                nameIcon.Text = a.name1;



                iconSearch.Click += new System.EventHandler(Icon_Click);
                nameIcon.Click += new System.EventHandler(Icon_Click);

                void Icon_Click(object s, EventArgs w)
                {
                    AbautIcon abautIcon = new AbautIcon(a, this);

                    this.Close();
                    th = new Thread(Open);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                    void Open(object obj)
                    {
                        Application.Run(abautIcon);
                    }
                }
            }
        }


        protected void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(Open);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

            void Open(object obj)
            {
                Application.Run(new ScreenUsesr());
            }
        }

        protected virtual void Save(StreamWriter z)
        {
            using ( z)
            {

                foreach (ScreenAdd el in iconList)
                {
                    z.WriteLine($"{el.name1};{el.producer1};{el.typeMedication1};{el.yearProduction1};{el.inStock1};{el.coast1};{el.namePhoto}");
                }
            }
        }
       
          protected virtual  ScreenAdd SplAdd(string spl)
            {
                string[] e = spl.Split(Convert.ToChar(";"));
                return new ScreenAdd(e[0], e[1], e[2], Convert.ToInt32(e[3]), Convert.ToInt32(e[4]), Convert.ToDouble(e[5]), e[6]);
            }

       
    }
}

