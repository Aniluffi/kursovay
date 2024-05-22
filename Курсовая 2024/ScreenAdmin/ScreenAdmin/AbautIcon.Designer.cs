using System.Windows.Forms;

namespace ScreenAdmin
{
    partial class AbautIcon
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.addUnits = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.manufacturer = new System.Windows.Forms.Label();
            this.typeMedicine = new System.Windows.Forms.Label();
            this.productionYear = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.inStock = new System.Windows.Forms.Label();
            this.coast = new System.Windows.Forms.Label();
            this.k = new System.Windows.Forms.Label();
            this.photo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.photo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Производитель:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Тип лекарства:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Год производства:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "В наличии:";
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(557, 266);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(134, 23);
            this.delete.TabIndex = 5;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // addUnits
            // 
            this.addUnits.Location = new System.Drawing.Point(557, 314);
            this.addUnits.Name = "addUnits";
            this.addUnits.Size = new System.Drawing.Size(134, 23);
            this.addUnits.TabIndex = 6;
            this.addUnits.Text = "добавить товар";
            this.addUnits.UseVisualStyleBackColor = true;
            this.addUnits.Click += new System.EventHandler(this.addUnits_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(125, 239);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(41, 13);
            this.name.TabIndex = 7;
            this.name.Text = "texttext";
            // 
            // manufacturer
            // 
            this.manufacturer.AutoSize = true;
            this.manufacturer.Location = new System.Drawing.Point(154, 266);
            this.manufacturer.Name = "manufacturer";
            this.manufacturer.Size = new System.Drawing.Size(41, 13);
            this.manufacturer.TabIndex = 8;
            this.manufacturer.Text = "texttext";
            // 
            // typeMedicine
            // 
            this.typeMedicine.AutoSize = true;
            this.typeMedicine.Location = new System.Drawing.Point(150, 289);
            this.typeMedicine.Name = "typeMedicine";
            this.typeMedicine.Size = new System.Drawing.Size(41, 13);
            this.typeMedicine.TabIndex = 9;
            this.typeMedicine.Text = "texttext";
            // 
            // productionYear
            // 
            this.productionYear.AutoSize = true;
            this.productionYear.Location = new System.Drawing.Point(167, 314);
            this.productionYear.Name = "productionYear";
            this.productionYear.Size = new System.Drawing.Size(41, 13);
            this.productionYear.TabIndex = 10;
            this.productionYear.Text = "texttext";
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(12, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 12;
            this.back.Text = "назад";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // inStock
            // 
            this.inStock.AutoSize = true;
            this.inStock.Location = new System.Drawing.Point(126, 341);
            this.inStock.Name = "inStock";
            this.inStock.Size = new System.Drawing.Size(35, 13);
            this.inStock.TabIndex = 13;
            this.inStock.Text = "label6";
            // 
            // coast
            // 
            this.coast.AutoSize = true;
            this.coast.Location = new System.Drawing.Point(101, 363);
            this.coast.Name = "coast";
            this.coast.Size = new System.Drawing.Size(35, 13);
            this.coast.TabIndex = 15;
            this.coast.Text = "label6";
            // 
            // k
            // 
            this.k.AutoSize = true;
            this.k.Location = new System.Drawing.Point(59, 363);
            this.k.Name = "k";
            this.k.Size = new System.Drawing.Size(36, 13);
            this.k.TabIndex = 14;
            this.k.Text = "Цена:";
            // 
            // photo
            // 
            this.photo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.photo.Location = new System.Drawing.Point(245, 12);
            this.photo.Name = "photo";
            this.photo.Size = new System.Drawing.Size(256, 193);
            this.photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.photo.TabIndex = 16;
            this.photo.TabStop = false;
            // 
            // AbautIcon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.photo);
            this.Controls.Add(this.coast);
            this.Controls.Add(this.k);
            this.Controls.Add(this.inStock);
            this.Controls.Add(this.back);
            this.Controls.Add(this.productionYear);
            this.Controls.Add(this.typeMedicine);
            this.Controls.Add(this.manufacturer);
            this.Controls.Add(this.name);
            this.Controls.Add(this.addUnits);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AbautIcon";
            this.Text = "AbautIcon";
            this.Load += new System.EventHandler(this.AbautIcon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.photo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        protected System.Windows.Forms.Button addUnits;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label manufacturer;
        private System.Windows.Forms.Label typeMedicine;
        private System.Windows.Forms.Label productionYear;
        protected System.Windows.Forms.Button back;
        protected Button delete;
        private Label inStock;
        protected Label coast;
        private Label k;
        protected PictureBox photo;

        public Label InStock { get => inStock; set => inStock = value; }
        
    }
}