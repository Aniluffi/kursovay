using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace ScreenAdmin
{
    public class ScreenUsesr:ScreenAdmin
    {
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPassword;
        private Button linkChet;
        private Label label5;
        private Label chet;
        private Button button1;
        private Panel searchElementUs;
        private Button SignIn;
       
     

        private void InitializeComponent()
        {
            this.password = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.SignIn = new System.Windows.Forms.Button();
            this.linkChet = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.chet = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.searchElementUs = new System.Windows.Forms.Panel();
            this.sideBar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.head.SuspendLayout();
            this.conteiner.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideBar
            // 
            this.sideBar.Controls.Add(this.searchElementUs);
            this.sideBar.Controls.Add(this.linkChet);
            this.sideBar.Controls.Add(this.SignIn);
            this.sideBar.Controls.Add(this.labelLogin);
            this.sideBar.Controls.Add(this.labelPassword);
            this.sideBar.Controls.Add(this.login);
            this.sideBar.Controls.Add(this.password);
            this.sideBar.MinimumSize = new System.Drawing.Size(250, 0);
            this.sideBar.Size = new System.Drawing.Size(275, 789);
            this.sideBar.Controls.SetChildIndex(this.searchBox, 0);
            this.sideBar.Controls.SetChildIndex(this.password, 0);
            this.sideBar.Controls.SetChildIndex(this.login, 0);
            this.sideBar.Controls.SetChildIndex(this.labelPassword, 0);
            this.sideBar.Controls.SetChildIndex(this.labelLogin, 0);
            this.sideBar.Controls.SetChildIndex(this.SignIn, 0);
            this.sideBar.Controls.SetChildIndex(this.panel1, 0);
            this.sideBar.Controls.SetChildIndex(this.panel2, 0);
            this.sideBar.Controls.SetChildIndex(this.addNew, 0);
            this.sideBar.Controls.SetChildIndex(this.sortirovka, 0);
            this.sideBar.Controls.SetChildIndex(this.Exit, 0);
            this.sideBar.Controls.SetChildIndex(this.linkChet, 0);
            this.sideBar.Controls.SetChildIndex(this.searchElementUs, 0);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(30, 30);
            this.searchBox.TextChanged += new System.EventHandler(this.Search);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(18, 641);
            this.Exit.Size = new System.Drawing.Size(182, 32);
            this.Exit.Text = "Вход";
            this.Exit.Visible = false;
            // 
            // sortirovka
            // 
            this.sortirovka.Location = new System.Drawing.Point(38, 382);
            // 
            // addNew
            // 
            this.addNew.Location = new System.Drawing.Point(18, 637);
            this.addNew.Size = new System.Drawing.Size(182, 36);
            this.addNew.Visible = false;
            // 
            // head
            // 
            this.head.Controls.Add(this.label5);
            this.head.Controls.Add(this.chet);
            this.head.Controls.Add(this.button1);
            this.head.Size = new System.Drawing.Size(1140, 100);
            this.head.Controls.SetChildIndex(this.header, 0);
            this.head.Controls.SetChildIndex(this.burger, 0);
            this.head.Controls.SetChildIndex(this.button1, 0);
            this.head.Controls.SetChildIndex(this.chet, 0);
            this.head.Controls.SetChildIndex(this.label5, 0);
            // 
            // burger
            // 
            this.burger.Location = new System.Drawing.Point(1065, 25);
            // 
            // header
            // 
            this.header.Location = new System.Drawing.Point(430, 33);
            // 
            // conteiner
            // 
            this.conteiner.Location = new System.Drawing.Point(147, 0);
            this.conteiner.Size = new System.Drawing.Size(1140, 789);
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password.Location = new System.Drawing.Point(38, 534);
            this.password.Name = "password";
            this.password.PasswordChar = 'x';
            this.password.Size = new System.Drawing.Size(143, 30);
            this.password.TabIndex = 21;
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login.Location = new System.Drawing.Point(38, 485);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(143, 30);
            this.login.TabIndex = 22;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(38, 518);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(48, 13);
            this.labelPassword.TabIndex = 23;
            this.labelPassword.Text = "Пароль:";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(35, 469);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(41, 13);
            this.labelLogin.TabIndex = 24;
            this.labelLogin.Tag = "";
            this.labelLogin.Text = "Логин:";
            // 
            // SignIn
            // 
            this.SignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SignIn.Location = new System.Drawing.Point(37, 570);
            this.SignIn.Name = "SignIn";
            this.SignIn.Size = new System.Drawing.Size(144, 37);
            this.SignIn.TabIndex = 26;
            this.SignIn.Text = "Вход";
            this.SignIn.UseVisualStyleBackColor = true;
            this.SignIn.Click += new System.EventHandler(this.SignIn_Click);
            // 
            // linkChet
            // 
            this.linkChet.Location = new System.Drawing.Point(38, 422);
            this.linkChet.Name = "linkChet";
            this.linkChet.Size = new System.Drawing.Size(116, 23);
            this.linkChet.TabIndex = 28;
            this.linkChet.Text = "Счет";
            this.linkChet.UseVisualStyleBackColor = true;
            this.linkChet.Click += new System.EventHandler(this.chet_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(50, 77);
            this.label5.Margin = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Баланс:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chet
            // 
            this.chet.BackColor = System.Drawing.Color.White;
            this.chet.Location = new System.Drawing.Point(100, 77);
            this.chet.Margin = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.chet.Name = "chet";
            this.chet.Size = new System.Drawing.Size(100, 23);
            this.chet.TabIndex = 6;
            this.chet.Text = "0";
            this.chet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(200, 75);
            this.button1.Margin = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 5;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.chet_Click);
            // 
            // searchElementUs
            // 
            this.searchElementUs.Location = new System.Drawing.Point(30, 53);
            this.searchElementUs.Name = "searchElementUs";
            this.searchElementUs.Size = new System.Drawing.Size(116, 10);
            this.searchElementUs.TabIndex = 1;
            // 
            // ScreenUsesr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.ClientSize = new System.Drawing.Size(1433, 750);
            this.Name = "ScreenUsesr";
            this.Text = "Form";
            this.Load += new System.EventHandler(this.BalansRead);
            this.sideBar.ResumeLayout(false);
            this.sideBar.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.head.ResumeLayout(false);
            this.head.PerformLayout();
            this.conteiner.ResumeLayout(false);
            this.ResumeLayout(false);

        } 
        ScreenAdmin a;

        public Label Chet { get => chet; set => chet = value; }

        public ScreenUsesr()
        {
            InitializeComponent();
        }
       
        public ScreenUsesr(AbautIconUs owner)
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
            this.chet.Text = Convert.ToString(owner.Balans);

            //iconList.Remove(Delete(iconList, owner.Name1));
        }

        public ScreenUsesr(ScreenAdd a, AbautIconUs owner)
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
            this.chet.Text = Convert.ToString(owner.Balans);
            for (int i = 0; i < iconList.Count; i++)
            {
                if (iconList.ElementAt(i).name1 == a.name1)
                {
                    iconList.ElementAt(i).inStock1 = a.inStock1;
                       Save(new StreamWriter($@"{Directory.GetCurrentDirectory()}\txt\Add.txt"));
                }
            }
            
        }

        protected override void CreateIcon(ScreenAdd a, int x, int y)
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
            photo.Size = new Size(80, 60);
            photo.Location = new Point(10, 10);
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
                AbautIconUs abautIcon = new AbautIconUs(a, this);

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
        protected override void Search(object sender, EventArgs e)
        {
            this.y = 0;
            this.searchElementUs.Controls.Clear();


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

                this.searchElementUs.Size = new Size(116, this.y);
                CreateIconSearch(list.ElementAt(i), this.y);

                this.y = y + 20;
            }

            void CreateIconSearch(ScreenAdd a, int y)
            {

                IconSearch = new Panel();

                this.IconSearch.SuspendLayout();
                this.searchElementUs.Controls.Add(this.IconSearch);
                this.IconSearch.Size = new Size(116, 20);
                this.IconSearch.BackColor = Color.Aqua;
                this.IconSearch.Location = new Point(0, y);

                nameIcon = new Label();

                this.IconSearch.Controls.Add(this.nameIcon);
                this.nameIcon.Location = new Point(0, 0);
                nameIcon.Text = a.name1;


                IconSearch.Click += new System.EventHandler(Icon_Click);
                nameIcon.Click += new System.EventHandler(Icon_Click);

                void Icon_Click(object s, EventArgs w)
                {
                    AbautIconUs abautIconUs = new AbautIconUs(a, this);

                    this.Close();
                    th = new Thread(Open);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                    void Open(object obj)
                    {
                        Application.Run(abautIconUs);
                    }
                }
            }
        }
        private void SignIn_Click(object sender, EventArgs e)
        {
           a = new ScreenAdmin();

            if (String.Compare(password.Text, "215") == 0 & String.Compare(login.Text, "TTIiP") == 0)
            {
                this.Close();
                th = new Thread(Open);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();

                void Open(object obj)
                {
                    Application.Run(a);
                }
            }
            else if(String.Compare(password.Text, "") == 0 || String.Compare(login.Text, "") == 0) MessageBox.Show($"Введите пароль и логин!");
            else MessageBox.Show($"Пароль или логин неправильные!");
        }
        
        

        private void chet_Click(object sender, EventArgs e)
        {
            Balans balans = new Balans(this);
            Save(new StreamWriter($@"{Directory.GetCurrentDirectory()}\txt\Balans.txt"));
            balans.ShowDialog();
        }

        private void BalansRead(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader($@"{Directory.GetCurrentDirectory()}\txt\Balans.txt"))
            {
                chet.Text = sr.ReadLine();
             
            }
        }

      
    }
}
