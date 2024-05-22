using System.Drawing;
using System.Windows.Forms;

namespace ScreenAdmin
{
    partial class ScreenAdmin
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.icon = new System.Windows.Forms.Panel();
            this.sideBar = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.searchElement = new System.Windows.Forms.Panel();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.Exit = new System.Windows.Forms.Button();
            this.sortirovka = new System.Windows.Forms.Button();
            this.addNew = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.alphabetically = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.asItIs = new System.Windows.Forms.RadioButton();
            this.greatestNumber = new System.Windows.Forms.RadioButton();
            this.byManufacturer = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pills = new System.Windows.Forms.RadioButton();
            this.potion = new System.Windows.Forms.RadioButton();
            this.injections = new System.Windows.Forms.RadioButton();
            this.powders = new System.Windows.Forms.RadioButton();
            this.allType = new System.Windows.Forms.RadioButton();
            this.head = new System.Windows.Forms.Panel();
            this.burger = new System.Windows.Forms.Panel();
            this.header = new System.Windows.Forms.Label();
            this.conteiner = new System.Windows.Forms.Panel();
            this.main = new System.Windows.Forms.FlowLayoutPanel();
            this.planX = new System.Windows.Forms.Panel();
            this.sideBar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.head.SuspendLayout();
            this.conteiner.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(186, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // icon
            // 
            this.icon.Location = new System.Drawing.Point(0, 0);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(200, 100);
            this.icon.TabIndex = 0;
            // 
            // sideBar
            // 
            this.sideBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sideBar.AutoScroll = true;
            this.sideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.sideBar.Controls.Add(this.label4);
            this.sideBar.Controls.Add(this.searchElement);
            this.sideBar.Controls.Add(this.searchBox);
            this.sideBar.Controls.Add(this.Exit);
            this.sideBar.Controls.Add(this.sortirovka);
            this.sideBar.Controls.Add(this.addNew);
            this.sideBar.Controls.Add(this.panel2);
            this.sideBar.Controls.Add(this.panel1);
            this.sideBar.Location = new System.Drawing.Point(0, 100);
            this.sideBar.Margin = new System.Windows.Forms.Padding(0);
            this.sideBar.Name = "sideBar";
            this.sideBar.Size = new System.Drawing.Size(183, 606);
            this.sideBar.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Поиск:";
            // 
            // searchElement
            // 
            this.searchElement.BackColor = System.Drawing.Color.White;
            this.searchElement.Location = new System.Drawing.Point(30, 47);
            this.searchElement.Name = "searchElement";
            this.searchElement.Size = new System.Drawing.Size(116, 0);
            this.searchElement.TabIndex = 21;
            // 
            // searchBox
            // 
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBox.Location = new System.Drawing.Point(30, 29);
            this.searchBox.Margin = new System.Windows.Forms.Padding(0);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(116, 20);
            this.searchBox.TabIndex = 20;
            this.searchBox.TextChanged += new System.EventHandler(this.Search);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(39, 461);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(116, 23);
            this.Exit.TabIndex = 18;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // sortirovka
            // 
            this.sortirovka.Location = new System.Drawing.Point(39, 390);
            this.sortirovka.Name = "sortirovka";
            this.sortirovka.Size = new System.Drawing.Size(116, 23);
            this.sortirovka.TabIndex = 17;
            this.sortirovka.Text = "Отсортировать";
            this.sortirovka.UseVisualStyleBackColor = true;
            this.sortirovka.Click += new System.EventHandler(this.ButtonSort_Click);
            // 
            // addNew
            // 
            this.addNew.Location = new System.Drawing.Point(39, 419);
            this.addNew.Name = "addNew";
            this.addNew.Size = new System.Drawing.Size(116, 36);
            this.addNew.TabIndex = 16;
            this.addNew.Text = "Добавить новое лекарство";
            this.addNew.UseVisualStyleBackColor = true;
            this.addNew.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.alphabetically);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.asItIs);
            this.panel2.Controls.Add(this.greatestNumber);
            this.panel2.Controls.Add(this.byManufacturer);
            this.panel2.Location = new System.Drawing.Point(30, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(116, 144);
            this.panel2.TabIndex = 0;
            // 
            // alphabetically
            // 
            this.alphabetically.AutoSize = true;
            this.alphabetically.Location = new System.Drawing.Point(4, 16);
            this.alphabetically.Name = "alphabetically";
            this.alphabetically.Size = new System.Drawing.Size(74, 17);
            this.alphabetically.TabIndex = 12;
            this.alphabetically.Text = "Алфавиту";
            this.alphabetically.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Сортировка по:";
            // 
            // asItIs
            // 
            this.asItIs.AutoSize = true;
            this.asItIs.Checked = true;
            this.asItIs.Location = new System.Drawing.Point(4, 39);
            this.asItIs.Name = "asItIs";
            this.asItIs.Size = new System.Drawing.Size(44, 17);
            this.asItIs.TabIndex = 9;
            this.asItIs.TabStop = true;
            this.asItIs.Text = "Все";
            this.asItIs.UseVisualStyleBackColor = true;
            // 
            // greatestNumber
            // 
            this.greatestNumber.Location = new System.Drawing.Point(3, 62);
            this.greatestNumber.Name = "greatestNumber";
            this.greatestNumber.Size = new System.Drawing.Size(104, 44);
            this.greatestNumber.TabIndex = 10;
            this.greatestNumber.Text = "наибольшему колличеству\r\n экземпляров";
            this.greatestNumber.UseVisualStyleBackColor = true;
            // 
            // byManufacturer
            // 
            this.byManufacturer.Location = new System.Drawing.Point(4, 112);
            this.byManufacturer.Name = "byManufacturer";
            this.byManufacturer.Size = new System.Drawing.Size(107, 31);
            this.byManufacturer.TabIndex = 11;
            this.byManufacturer.Text = "Производителю";
            this.byManufacturer.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pills);
            this.panel1.Controls.Add(this.potion);
            this.panel1.Controls.Add(this.injections);
            this.panel1.Controls.Add(this.powders);
            this.panel1.Controls.Add(this.allType);
            this.panel1.Location = new System.Drawing.Point(30, 222);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(116, 154);
            this.panel1.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Виды:";
            // 
            // pills
            // 
            this.pills.AutoSize = true;
            this.pills.Location = new System.Drawing.Point(15, 38);
            this.pills.Name = "pills";
            this.pills.Size = new System.Drawing.Size(73, 17);
            this.pills.TabIndex = 8;
            this.pills.Text = "Таблетки";
            this.pills.UseVisualStyleBackColor = true;
            // 
            // potion
            // 
            this.potion.AutoSize = true;
            this.potion.Location = new System.Drawing.Point(15, 61);
            this.potion.Name = "potion";
            this.potion.Size = new System.Drawing.Size(74, 17);
            this.potion.TabIndex = 4;
            this.potion.Text = "Микстура";
            this.potion.UseVisualStyleBackColor = true;
            // 
            // injections
            // 
            this.injections.AutoSize = true;
            this.injections.Location = new System.Drawing.Point(15, 84);
            this.injections.Name = "injections";
            this.injections.Size = new System.Drawing.Size(59, 17);
            this.injections.TabIndex = 5;
            this.injections.Text = "Уколы";
            this.injections.UseVisualStyleBackColor = true;
            // 
            // powders
            // 
            this.powders.AutoSize = true;
            this.powders.Location = new System.Drawing.Point(15, 107);
            this.powders.Name = "powders";
            this.powders.Size = new System.Drawing.Size(71, 17);
            this.powders.TabIndex = 6;
            this.powders.Text = "Порошки";
            this.powders.UseVisualStyleBackColor = true;
            // 
            // allType
            // 
            this.allType.AutoSize = true;
            this.allType.Checked = true;
            this.allType.Location = new System.Drawing.Point(15, 130);
            this.allType.Name = "allType";
            this.allType.Size = new System.Drawing.Size(44, 17);
            this.allType.TabIndex = 7;
            this.allType.TabStop = true;
            this.allType.Text = "Все";
            this.allType.UseVisualStyleBackColor = true;
            // 
            // head
            // 
            this.head.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.head.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(164)))), ((int)(((byte)(164)))));
            this.head.Controls.Add(this.burger);
            this.head.Controls.Add(this.header);
            this.head.Location = new System.Drawing.Point(0, 0);
            this.head.Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.head.Name = "head";
            this.head.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.head.Size = new System.Drawing.Size(805, 100);
            this.head.TabIndex = 1;
            // 
            // burger
            // 
            this.burger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.burger.Cursor = System.Windows.Forms.Cursors.Hand;
            this.burger.Location = new System.Drawing.Point(689, 25);
            this.burger.Margin = new System.Windows.Forms.Padding(0);
            this.burger.Name = "burger";
            this.burger.Size = new System.Drawing.Size(50, 50);
            this.burger.TabIndex = 0;
            this.burger.Click += new System.EventHandler(this.burger_Click);
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.Location = new System.Drawing.Point(254, 34);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(279, 33);
            this.header.TabIndex = 1;
            this.header.Text = "Аптечная база данных";
            this.header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // conteiner
            // 
            this.conteiner.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.conteiner.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.conteiner.Controls.Add(this.main);
            this.conteiner.Controls.Add(this.head);
            this.conteiner.Controls.Add(this.sideBar);
            this.conteiner.Location = new System.Drawing.Point(332, 1);
            this.conteiner.MaximumSize = new System.Drawing.Size(1140, 0);
            this.conteiner.MinimumSize = new System.Drawing.Size(425, 500);
            this.conteiner.Name = "conteiner";
            this.conteiner.Size = new System.Drawing.Size(805, 500);
            this.conteiner.TabIndex = 0;
            // 
            // main
            // 
            this.main.AutoScroll = true;
            this.main.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.main.Location = new System.Drawing.Point(186, 100);
            this.main.Margin = new System.Windows.Forms.Padding(3, 0, 3, 160);
            this.main.MinimumSize = new System.Drawing.Size(425, 200);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(619, 606);
            this.main.TabIndex = 0;
            // 
            // planX
            // 
            this.planX.Location = new System.Drawing.Point(0, 0);
            this.planX.Name = "planX";
            this.planX.Size = new System.Drawing.Size(200, 100);
            this.planX.TabIndex = 0;
            // 
            // ScreenAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1433, 708);
            this.Controls.Add(this.conteiner);
            this.MinimumSize = new System.Drawing.Size(425, 500);
            this.Name = "ScreenAdmin";
            this.Text = "Form1";
            this.AutoSizeChanged += new System.EventHandler(this.Form1_Load);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.ScreenAdmin_SizeChanged);
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

        #endregion

        protected System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel icon;
        protected System.Windows.Forms.Label nameIcon;
        private Panel iconSearch;
        protected Label nalLabel;
        protected Label coast;
        protected Panel sideBar;
        private Panel searchElement;
        protected TextBox searchBox;
        protected Button Exit;
        protected Button sortirovka;
        protected Button addNew;
        protected Panel panel2;
        protected RadioButton alphabetically;
        protected Label label2;
        protected RadioButton asItIs;
        protected RadioButton greatestNumber;
        protected RadioButton byManufacturer;
        protected Panel panel1;
        protected Label label3;
        protected RadioButton pills;
        protected RadioButton potion;
        protected RadioButton injections;
        protected RadioButton powders;
        protected RadioButton allType;
        protected Panel head;
        protected Panel burger;
        protected Label header;
        protected Panel conteiner;
        protected FlowLayoutPanel main;
        protected PictureBox photo;
        protected Panel planX;
        private Label label4;

        public RadioButton Alphabetically { get => alphabetically; set => alphabetically = value; }
        public RadioButton ByManufacturer { get => byManufacturer; set => byManufacturer = value; }
        public RadioButton GreatestNumber { get => greatestNumber; set => greatestNumber = value; }
        public RadioButton AsItIs { get => asItIs; set => asItIs = value; }
        public RadioButton Pills { get => pills; set => pills = value; }
        public RadioButton AllType { get => allType; set => allType = value; }
        public RadioButton Powders { get => powders; set => powders = value; }
        public RadioButton Injections { get => injections; set => injections = value; }
        public RadioButton Potion { get => potion; set => potion = value; }
        public Panel SearchElement { get => searchElement; set => searchElement = value; }
        public Panel IconSearch { get => iconSearch; set => iconSearch = value; }
    }
}

