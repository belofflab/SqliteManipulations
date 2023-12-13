namespace SqliteManipulations
{
    partial class MainForm
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
            this.dataGridViewPersons = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonDeletePerson = new System.Windows.Forms.Button();
            this.buttonFillData = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.фИОToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискПоФамилииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискПоИмениToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ктоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ктоЖиветНаУлицеПушкинаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ктоНеЗанимаетсяТяжелойАтлетикойToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ктоРодилсяСегодняToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.уКогоНомерДомаМеньше50ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.уКогоНомерДомаМеньше50ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.уКогоНомерКвартирыМеньше12ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.уКогоНетХоббиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ктоРодилсяВXГодуToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersons)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewPersons
            // 
            this.dataGridViewPersons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersons.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewPersons.Location = new System.Drawing.Point(0, 28);
            this.dataGridViewPersons.Name = "dataGridViewPersons";
            this.dataGridViewPersons.RowHeadersWidth = 51;
            this.dataGridViewPersons.RowTemplate.Height = 24;
            this.dataGridViewPersons.Size = new System.Drawing.Size(1279, 448);
            this.dataGridViewPersons.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 482);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 53);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(200, 482);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 53);
            this.button2.TabIndex = 2;
            this.button2.Text = "Изменить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonDeletePerson
            // 
            this.buttonDeletePerson.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeletePerson.Location = new System.Drawing.Point(388, 482);
            this.buttonDeletePerson.Name = "buttonDeletePerson";
            this.buttonDeletePerson.Size = new System.Drawing.Size(182, 53);
            this.buttonDeletePerson.TabIndex = 3;
            this.buttonDeletePerson.Text = "Удалить";
            this.buttonDeletePerson.UseVisualStyleBackColor = true;
            this.buttonDeletePerson.Click += new System.EventHandler(this.buttonDeletePerson_Click);
            // 
            // buttonFillData
            // 
            this.buttonFillData.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFillData.Location = new System.Drawing.Point(956, 482);
            this.buttonFillData.Name = "buttonFillData";
            this.buttonFillData.Size = new System.Drawing.Size(296, 53);
            this.buttonFillData.TabIndex = 4;
            this.buttonFillData.Text = "Наполнить данными";
            this.buttonFillData.UseVisualStyleBackColor = true;
            this.buttonFillData.Click += new System.EventHandler(this.buttonFillData_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.фИОToolStripMenuItem,
            this.ктоToolStripMenuItem,
            this.уКогоНомерДомаМеньше50ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1279, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // фИОToolStripMenuItem
            // 
            this.фИОToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поискПоФамилииToolStripMenuItem,
            this.поискПоИмениToolStripMenuItem});
            this.фИОToolStripMenuItem.Name = "фИОToolStripMenuItem";
            this.фИОToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.фИОToolStripMenuItem.Text = "ФИО";
            // 
            // поискПоФамилииToolStripMenuItem
            // 
            this.поискПоФамилииToolStripMenuItem.Name = "поискПоФамилииToolStripMenuItem";
            this.поискПоФамилииToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.поискПоФамилииToolStripMenuItem.Text = "Поиск по фамилии";
            this.поискПоФамилииToolStripMenuItem.Click += new System.EventHandler(this.поискПоФамилииToolStripMenuItem_Click);
            // 
            // поискПоИмениToolStripMenuItem
            // 
            this.поискПоИмениToolStripMenuItem.Name = "поискПоИмениToolStripMenuItem";
            this.поискПоИмениToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.поискПоИмениToolStripMenuItem.Text = "Поиск по имени";
            this.поискПоИмениToolStripMenuItem.Click += new System.EventHandler(this.поискПоИмениToolStripMenuItem_Click);
            // 
            // ктоToolStripMenuItem
            // 
            this.ктоToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ктоЖиветНаУлицеПушкинаToolStripMenuItem,
            this.ктоНеЗанимаетсяТяжелойАтлетикойToolStripMenuItem,
            this.ктоРодилсяСегодняToolStripMenuItem1,
            this.ктоРодилсяВXГодуToolStripMenuItem1});
            this.ктоToolStripMenuItem.Name = "ктоToolStripMenuItem";
            this.ктоToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.ктоToolStripMenuItem.Text = "Кто?";
            // 
            // ктоЖиветНаУлицеПушкинаToolStripMenuItem
            // 
            this.ктоЖиветНаУлицеПушкинаToolStripMenuItem.Name = "ктоЖиветНаУлицеПушкинаToolStripMenuItem";
            this.ктоЖиветНаУлицеПушкинаToolStripMenuItem.Size = new System.Drawing.Size(370, 26);
            this.ктоЖиветНаУлицеПушкинаToolStripMenuItem.Text = "Кто живет на улице Пушкина? ";
            this.ктоЖиветНаУлицеПушкинаToolStripMenuItem.Click += new System.EventHandler(this.ктоЖиветНаУлицеПушкинаToolStripMenuItem_Click);
            // 
            // ктоНеЗанимаетсяТяжелойАтлетикойToolStripMenuItem
            // 
            this.ктоНеЗанимаетсяТяжелойАтлетикойToolStripMenuItem.Name = "ктоНеЗанимаетсяТяжелойАтлетикойToolStripMenuItem";
            this.ктоНеЗанимаетсяТяжелойАтлетикойToolStripMenuItem.Size = new System.Drawing.Size(370, 26);
            this.ктоНеЗанимаетсяТяжелойАтлетикойToolStripMenuItem.Text = "Кто не занимается тяжелой атлетикой? ";
            this.ктоНеЗанимаетсяТяжелойАтлетикойToolStripMenuItem.Click += new System.EventHandler(this.ктоНеЗанимаетсяТяжелойАтлетикойToolStripMenuItem_Click);
            // 
            // ктоРодилсяСегодняToolStripMenuItem1
            // 
            this.ктоРодилсяСегодняToolStripMenuItem1.Name = "ктоРодилсяСегодняToolStripMenuItem1";
            this.ктоРодилсяСегодняToolStripMenuItem1.Size = new System.Drawing.Size(370, 26);
            this.ктоРодилсяСегодняToolStripMenuItem1.Text = "Кто родился сегодня? ";
            this.ктоРодилсяСегодняToolStripMenuItem1.Click += new System.EventHandler(this.ктоРодилсяСегодняToolStripMenuItem1_Click);
            // 
            // уКогоНомерДомаМеньше50ToolStripMenuItem
            // 
            this.уКогоНомерДомаМеньше50ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.уКогоНомерДомаМеньше50ToolStripMenuItem1,
            this.уКогоНомерКвартирыМеньше12ToolStripMenuItem,
            this.уКогоНетХоббиToolStripMenuItem});
            this.уКогоНомерДомаМеньше50ToolStripMenuItem.Name = "уКогоНомерДомаМеньше50ToolStripMenuItem";
            this.уКогоНомерДомаМеньше50ToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.уКогоНомерДомаМеньше50ToolStripMenuItem.Text = "У кого?";
            // 
            // уКогоНомерДомаМеньше50ToolStripMenuItem1
            // 
            this.уКогоНомерДомаМеньше50ToolStripMenuItem1.Name = "уКогоНомерДомаМеньше50ToolStripMenuItem1";
            this.уКогоНомерДомаМеньше50ToolStripMenuItem1.Size = new System.Drawing.Size(412, 26);
            this.уКогоНомерДомаМеньше50ToolStripMenuItem1.Text = "У кого номер дома меньше 50?  ";
            this.уКогоНомерДомаМеньше50ToolStripMenuItem1.Click += new System.EventHandler(this.уКогоНомерДомаМеньше50ToolStripMenuItem1_Click);
            // 
            // уКогоНомерКвартирыМеньше12ToolStripMenuItem
            // 
            this.уКогоНомерКвартирыМеньше12ToolStripMenuItem.Name = "уКогоНомерКвартирыМеньше12ToolStripMenuItem";
            this.уКогоНомерКвартирыМеньше12ToolStripMenuItem.Size = new System.Drawing.Size(341, 26);
            this.уКогоНомерКвартирыМеньше12ToolStripMenuItem.Text = "У кого номер квартиры меньше 12 ";
            this.уКогоНомерКвартирыМеньше12ToolStripMenuItem.Click += new System.EventHandler(this.уКогоНомерКвартирыМеньше12ToolStripMenuItem_Click);
            // 
            // уКогоНетХоббиToolStripMenuItem
            // 
            this.уКогоНетХоббиToolStripMenuItem.Name = "уКогоНетХоббиToolStripMenuItem";
            this.уКогоНетХоббиToolStripMenuItem.Size = new System.Drawing.Size(341, 26);
            this.уКогоНетХоббиToolStripMenuItem.Text = "У кого нет хобби. ";
            this.уКогоНетХоббиToolStripMenuItem.Click += new System.EventHandler(this.уКогоНетХоббиToolStripMenuItem_Click);
            // 
            // ктоРодилсяВXГодуToolStripMenuItem1
            // 
            this.ктоРодилсяВXГодуToolStripMenuItem1.Name = "ктоРодилсяВXГодуToolStripMenuItem1";
            this.ктоРодилсяВXГодуToolStripMenuItem1.Size = new System.Drawing.Size(370, 26);
            this.ктоРодилсяВXГодуToolStripMenuItem1.Text = "Кто родился в X году?";
            this.ктоРодилсяВXГодуToolStripMenuItem1.Click += new System.EventHandler(this.ктоРодилсяВXГодуToolStripMenuItem1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 588);
            this.Controls.Add(this.buttonFillData);
            this.Controls.Add(this.buttonDeletePerson);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewPersons);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Бдшчка";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersons)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPersons;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonDeletePerson;
        private System.Windows.Forms.Button buttonFillData;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem фИОToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискПоФамилииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискПоИмениToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ктоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ктоЖиветНаУлицеПушкинаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ктоНеЗанимаетсяТяжелойАтлетикойToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ктоРодилсяСегодняToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ктоРодилсяВXГодуToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem уКогоНомерДомаМеньше50ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem уКогоНомерДомаМеньше50ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem уКогоНомерКвартирыМеньше12ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem уКогоНетХоббиToolStripMenuItem;
    }
}

