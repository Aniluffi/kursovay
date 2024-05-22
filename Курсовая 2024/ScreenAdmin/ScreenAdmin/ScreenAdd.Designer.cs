namespace ScreenAdmin
{
    partial class ScreenAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.d = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.producer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.yearProduction = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.inStock = new System.Windows.Forms.TextBox();
            this.lb = new System.Windows.Forms.Label();
            this.coast = new System.Windows.Forms.TextBox();
            this.start = new System.Windows.Forms.RadioButton();
            this.before = new System.Windows.Forms.RadioButton();
            this.end = new System.Windows.Forms.RadioButton();
            this.after = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.textBoxAfter = new System.Windows.Forms.TextBox();
            this.textBoxBefore = new System.Windows.Forms.TextBox();
            this.typeMedication = new System.Windows.Forms.ComboBox();
            this.photo = new System.Windows.Forms.PictureBox();
            this.addPhoto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.photo)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "< назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(55, 89);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 20);
            this.name.TabIndex = 1;
            // 
            // d
            // 
            this.d.AutoSize = true;
            this.d.Location = new System.Drawing.Point(52, 73);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(60, 13);
            this.d.TabIndex = 2;
            this.d.Text = "Название:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Производитель:";
            // 
            // producer
            // 
            this.producer.Location = new System.Drawing.Point(55, 153);
            this.producer.Name = "producer";
            this.producer.Size = new System.Drawing.Size(100, 20);
            this.producer.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Тип лекарства:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(334, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Год производства:";
            // 
            // yearProduction
            // 
            this.yearProduction.Location = new System.Drawing.Point(337, 89);
            this.yearProduction.Name = "yearProduction";
            this.yearProduction.Size = new System.Drawing.Size(100, 20);
            this.yearProduction.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(334, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "В наличии:";
            // 
            // inStock
            // 
            this.inStock.Location = new System.Drawing.Point(337, 153);
            this.inStock.Name = "inStock";
            this.inStock.Size = new System.Drawing.Size(100, 20);
            this.inStock.TabIndex = 9;
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(334, 196);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(36, 13);
            this.lb.TabIndex = 12;
            this.lb.Text = "Цена:";
            // 
            // coast
            // 
            this.coast.Location = new System.Drawing.Point(337, 212);
            this.coast.Name = "coast";
            this.coast.Size = new System.Drawing.Size(100, 20);
            this.coast.TabIndex = 11;
            // 
            // start
            // 
            this.start.AutoSize = true;
            this.start.Location = new System.Drawing.Point(55, 292);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(62, 17);
            this.start.TabIndex = 13;
            this.start.TabStop = true;
            this.start.Text = "Начало";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.before_Click);
            // 
            // before
            // 
            this.before.AutoSize = true;
            this.before.Location = new System.Drawing.Point(318, 292);
            this.before.Name = "before";
            this.before.Size = new System.Drawing.Size(57, 17);
            this.before.TabIndex = 14;
            this.before.TabStop = true;
            this.before.Text = "Перед";
            this.before.UseVisualStyleBackColor = true;
            this.before.Click += new System.EventHandler(this.before_Click);
            // 
            // end
            // 
            this.end.AutoSize = true;
            this.end.Location = new System.Drawing.Point(184, 292);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(56, 17);
            this.end.TabIndex = 15;
            this.end.TabStop = true;
            this.end.Text = "Конец";
            this.end.UseVisualStyleBackColor = true;
            this.end.Click += new System.EventHandler(this.before_Click);
            // 
            // after
            // 
            this.after.AutoSize = true;
            this.after.Location = new System.Drawing.Point(464, 292);
            this.after.Name = "after";
            this.after.Size = new System.Drawing.Size(57, 17);
            this.after.TabIndex = 16;
            this.after.TabStop = true;
            this.after.Text = "После";
            this.after.UseVisualStyleBackColor = true;
            this.after.Click += new System.EventHandler(this.before_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(346, 381);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "Создать";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBoxAfter
            // 
            this.textBoxAfter.Location = new System.Drawing.Point(443, 315);
            this.textBoxAfter.Name = "textBoxAfter";
            this.textBoxAfter.Size = new System.Drawing.Size(100, 20);
            this.textBoxAfter.TabIndex = 19;
            this.textBoxAfter.Visible = false;
            // 
            // textBoxBefore
            // 
            this.textBoxBefore.Location = new System.Drawing.Point(295, 315);
            this.textBoxBefore.Name = "textBoxBefore";
            this.textBoxBefore.Size = new System.Drawing.Size(100, 20);
            this.textBoxBefore.TabIndex = 20;
            this.textBoxBefore.Visible = false;
            // 
            // typeMedication
            // 
            this.typeMedication.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.typeMedication.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeMedication.FormattingEnabled = true;
            this.typeMedication.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.typeMedication.Items.AddRange(new object[] {
            "Таблетки",
            "Микстура",
            "Уколы",
            "Порошки"});
            this.typeMedication.Location = new System.Drawing.Point(55, 211);
            this.typeMedication.Name = "typeMedication";
            this.typeMedication.Size = new System.Drawing.Size(100, 21);
            this.typeMedication.TabIndex = 21;
            // 
            // photo
            // 
            this.photo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.photo.Location = new System.Drawing.Point(534, 127);
            this.photo.Name = "photo";
            this.photo.Size = new System.Drawing.Size(105, 105);
            this.photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.photo.TabIndex = 22;
            this.photo.TabStop = false;
            // 
            // addPhoto
            // 
            this.addPhoto.Location = new System.Drawing.Point(534, 89);
            this.addPhoto.Name = "addPhoto";
            this.addPhoto.Size = new System.Drawing.Size(105, 20);
            this.addPhoto.TabIndex = 23;
            this.addPhoto.Text = "Загрузить фото";
            this.addPhoto.UseVisualStyleBackColor = true;
            this.addPhoto.Click += new System.EventHandler(this.addPhoto_Click);
            // 
            // ScreenAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addPhoto);
            this.Controls.Add(this.photo);
            this.Controls.Add(this.typeMedication);
            this.Controls.Add(this.textBoxBefore);
            this.Controls.Add(this.textBoxAfter);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.after);
            this.Controls.Add(this.end);
            this.Controls.Add(this.before);
            this.Controls.Add(this.start);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.coast);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.inStock);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.yearProduction);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.producer);
            this.Controls.Add(this.d);
            this.Controls.Add(this.name);
            this.Controls.Add(this.button1);
            this.Name = "ScreenAdd";
            this.Text = "ScreenAdd";
            this.Load += new System.EventHandler(this.ScreenAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.photo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label d;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox producer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox yearProduction;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox inStock;
        private System.Windows.Forms.Label lb;
        public System.Windows.Forms.TextBox coast;
        private System.Windows.Forms.RadioButton start;
        private System.Windows.Forms.RadioButton before;
        private System.Windows.Forms.RadioButton end;
        private System.Windows.Forms.RadioButton after;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBoxAfter;
        private System.Windows.Forms.TextBox textBoxBefore;
        public System.Windows.Forms.ComboBox typeMedication;
        private System.Windows.Forms.PictureBox photo;
        private System.Windows.Forms.Button addPhoto;
    }
}