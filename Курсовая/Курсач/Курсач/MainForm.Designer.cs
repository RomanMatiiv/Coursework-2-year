namespace Курсач
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтрацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьЗаписьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.путьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.путьКПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.путьКСохраненномуФайлуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.всяИнформацтяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.laptopID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.laptopName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availability = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.RAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonotorSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Processor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BatteryCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FilterButton = new System.Windows.Forms.Button();
            this.Filter = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.availBox = new System.Windows.Forms.CheckBox();
            this.priceBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.processorBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.displayBox = new System.Windows.Forms.ComboBox();
            this.ramBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.hddBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.Filter.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.manualToolStripMenuItem,
            this.добавитьToolStripMenuItem,
            this.фильтрацияToolStripMenuItem,
            this.удалитьЗаписьToolStripMenuItem,
            this.путьToolStripMenuItem,
            this.редактироватьToolStripMenuItem,
            this.всяИнформацтяToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(918, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            // 
            // manualToolStripMenuItem
            // 
            this.manualToolStripMenuItem.Name = "manualToolStripMenuItem";
            this.manualToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.manualToolStripMenuItem.Text = "Manual";
            this.manualToolStripMenuItem.Click += new System.EventHandler(this.manualToolStripMenuItem_Click);
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // фильтрацияToolStripMenuItem
            // 
            this.фильтрацияToolStripMenuItem.Name = "фильтрацияToolStripMenuItem";
            this.фильтрацияToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.фильтрацияToolStripMenuItem.Text = "Фильтрация";
            this.фильтрацияToolStripMenuItem.Click += new System.EventHandler(this.фильтрацияToolStripMenuItem_Click);
            // 
            // удалитьЗаписьToolStripMenuItem
            // 
            this.удалитьЗаписьToolStripMenuItem.Name = "удалитьЗаписьToolStripMenuItem";
            this.удалитьЗаписьToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.удалитьЗаписьToolStripMenuItem.Text = "Удалить запись";
            this.удалитьЗаписьToolStripMenuItem.Click += new System.EventHandler(this.удалитьЗаписьToolStripMenuItem_Click);
            // 
            // путьToolStripMenuItem
            // 
            this.путьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.путьКПрограммеToolStripMenuItem,
            this.путьКСохраненномуФайлуToolStripMenuItem});
            this.путьToolStripMenuItem.Name = "путьToolStripMenuItem";
            this.путьToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.путьToolStripMenuItem.Text = "Путь";
            // 
            // путьКПрограммеToolStripMenuItem
            // 
            this.путьКПрограммеToolStripMenuItem.Name = "путьКПрограммеToolStripMenuItem";
            this.путьКПрограммеToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.путьКПрограммеToolStripMenuItem.Text = "Путь к программе";
            this.путьКПрограммеToolStripMenuItem.Click += new System.EventHandler(this.путьКПрограммеToolStripMenuItem_Click);
            // 
            // путьКСохраненномуФайлуToolStripMenuItem
            // 
            this.путьКСохраненномуФайлуToolStripMenuItem.Name = "путьКСохраненномуФайлуToolStripMenuItem";
            this.путьКСохраненномуФайлуToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.путьКСохраненномуФайлуToolStripMenuItem.Text = "Путь к сохраненному файлу";
            this.путьКСохраненномуФайлуToolStripMenuItem.Click += new System.EventHandler(this.путьКСохраненномуФайлуToolStripMenuItem_Click);
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            this.редактироватьToolStripMenuItem.Click += new System.EventHandler(this.редактироватьToolStripMenuItem_Click);
            // 
            // всяИнформацтяToolStripMenuItem
            // 
            this.всяИнформацтяToolStripMenuItem.Name = "всяИнформацтяToolStripMenuItem";
            this.всяИнформацтяToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.всяИнформацтяToolStripMenuItem.Text = "Вся информация";
            this.всяИнформацтяToolStripMenuItem.Click += new System.EventHandler(this.всяИнформацтяToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.AutoGenerateColumns = false;
            this.DGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.laptopID,
            this.laptopName,
            this.Price,
            this.availability,
            this.RAM,
            this.Capacity,
            this.MonotorSize,
            this.Processor,
            this.BatteryCapacity});
            this.DGV.DataSource = this.productBindingSource;
            this.DGV.Location = new System.Drawing.Point(12, 36);
            this.DGV.Name = "DGV";
            this.DGV.Size = new System.Drawing.Size(461, 150);
            this.DGV.TabIndex = 1;
            // 
            // laptopID
            // 
            this.laptopID.DataPropertyName = "LaptopID";
            this.laptopID.HeaderText = "ID ноутбука";
            this.laptopID.Name = "laptopID";
            this.laptopID.ReadOnly = true;
            // 
            // laptopName
            // 
            this.laptopName.DataPropertyName = "LaptopName";
            this.laptopName.HeaderText = "Название";
            this.laptopName.Name = "laptopName";
            this.laptopName.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Цена";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // availability
            // 
            this.availability.DataPropertyName = "Availability";
            this.availability.HeaderText = "Наличие";
            this.availability.Name = "availability";
            this.availability.ReadOnly = true;
            // 
            // RAM
            // 
            this.RAM.DataPropertyName = "RAM";
            this.RAM.HeaderText = "RAM";
            this.RAM.Name = "RAM";
            this.RAM.ReadOnly = true;
            this.RAM.Visible = false;
            // 
            // Capacity
            // 
            this.Capacity.DataPropertyName = "Capacity";
            this.Capacity.HeaderText = "Capacity";
            this.Capacity.Name = "Capacity";
            this.Capacity.ReadOnly = true;
            this.Capacity.Visible = false;
            // 
            // MonotorSize
            // 
            this.MonotorSize.DataPropertyName = "MonotorSize";
            this.MonotorSize.HeaderText = "MonotorSize";
            this.MonotorSize.Name = "MonotorSize";
            this.MonotorSize.ReadOnly = true;
            this.MonotorSize.Visible = false;
            // 
            // Processor
            // 
            this.Processor.DataPropertyName = "Processor";
            this.Processor.HeaderText = "Processor";
            this.Processor.Name = "Processor";
            this.Processor.ReadOnly = true;
            this.Processor.Visible = false;
            // 
            // BatteryCapacity
            // 
            this.BatteryCapacity.DataPropertyName = "BatteryCapacity";
            this.BatteryCapacity.HeaderText = "BatteryCapacity";
            this.BatteryCapacity.Name = "BatteryCapacity";
            this.BatteryCapacity.ReadOnly = true;
            this.BatteryCapacity.Visible = false;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(Курсач.Product);
            // 
            // FilterButton
            // 
            this.FilterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilterButton.Location = new System.Drawing.Point(182, 229);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(103, 23);
            this.FilterButton.TabIndex = 6;
            this.FilterButton.Text = "Отфильтровать";
            this.FilterButton.UseVisualStyleBackColor = true;
            this.FilterButton.Click += new System.EventHandler(this.Filter_Click);
            // 
            // Filter
            // 
            this.Filter.Controls.Add(this.label8);
            this.Filter.Controls.Add(this.IDBox);
            this.Filter.Controls.Add(this.nameBox);
            this.Filter.Controls.Add(this.label7);
            this.Filter.Controls.Add(this.label6);
            this.Filter.Controls.Add(this.availBox);
            this.Filter.Controls.Add(this.priceBox);
            this.Filter.Controls.Add(this.label5);
            this.Filter.Controls.Add(this.processorBox);
            this.Filter.Controls.Add(this.label4);
            this.Filter.Controls.Add(this.displayBox);
            this.Filter.Controls.Add(this.ramBox);
            this.Filter.Controls.Add(this.label3);
            this.Filter.Controls.Add(this.hddBox);
            this.Filter.Controls.Add(this.label2);
            this.Filter.Controls.Add(this.label1);
            this.Filter.Controls.Add(this.FilterButton);
            this.Filter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Filter.Location = new System.Drawing.Point(479, 36);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(425, 259);
            this.Filter.TabIndex = 5;
            this.Filter.TabStop = false;
            this.Filter.Text = "Фильтрация";
            this.Filter.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(201, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Только в наличае";
            // 
            // IDBox
            // 
            this.IDBox.BackColor = System.Drawing.Color.White;
            this.IDBox.Location = new System.Drawing.Point(190, 164);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(121, 20);
            this.IDBox.TabIndex = 18;
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.Color.White;
            this.nameBox.Location = new System.Drawing.Point(279, 119);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(121, 20);
            this.nameBox.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(155, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Location = new System.Drawing.Point(201, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Название";
            // 
            // availBox
            // 
            this.availBox.AutoSize = true;
            this.availBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.availBox.Location = new System.Drawing.Point(182, 206);
            this.availBox.Name = "availBox";
            this.availBox.Size = new System.Drawing.Size(12, 11);
            this.availBox.TabIndex = 5;
            this.availBox.UseVisualStyleBackColor = true;
            // 
            // priceBox
            // 
            this.priceBox.BackColor = System.Drawing.Color.White;
            this.priceBox.FormattingEnabled = true;
            this.priceBox.Items.AddRange(new object[] {
            "10000",
            "15000",
            "20000",
            "25000",
            "35000",
            "50000",
            "70000",
            "100000"});
            this.priceBox.Location = new System.Drawing.Point(52, 28);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(121, 21);
            this.priceBox.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Location = new System.Drawing.Point(6, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Цена<";
            // 
            // processorBox
            // 
            this.processorBox.BackColor = System.Drawing.Color.White;
            this.processorBox.FormattingEnabled = true;
            this.processorBox.Items.AddRange(new object[] {
            "intel core i-3",
            "intel core i-5"});
            this.processorBox.Location = new System.Drawing.Point(279, 72);
            this.processorBox.Name = "processorBox";
            this.processorBox.Size = new System.Drawing.Size(121, 21);
            this.processorBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Location = new System.Drawing.Point(195, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Процессор";
            // 
            // displayBox
            // 
            this.displayBox.BackColor = System.Drawing.Color.White;
            this.displayBox.FormattingEnabled = true;
            this.displayBox.Items.AddRange(new object[] {
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.displayBox.Location = new System.Drawing.Point(279, 28);
            this.displayBox.Name = "displayBox";
            this.displayBox.Size = new System.Drawing.Size(121, 21);
            this.displayBox.TabIndex = 3;
            // 
            // ramBox
            // 
            this.ramBox.BackColor = System.Drawing.Color.White;
            this.ramBox.FormattingEnabled = true;
            this.ramBox.Items.AddRange(new object[] {
            "2",
            "4",
            "8",
            "16",
            "32",
            "64"});
            this.ramBox.Location = new System.Drawing.Point(52, 119);
            this.ramBox.Name = "ramBox";
            this.ramBox.Size = new System.Drawing.Size(121, 21);
            this.ramBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Location = new System.Drawing.Point(192, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Диагональ >";
            // 
            // hddBox
            // 
            this.hddBox.BackColor = System.Drawing.Color.White;
            this.hddBox.FormattingEnabled = true;
            this.hddBox.Items.AddRange(new object[] {
            "64",
            "128",
            "256",
            "512",
            "1024",
            "2048"});
            this.hddBox.Location = new System.Drawing.Point(52, 72);
            this.hddBox.Name = "hddBox";
            this.hddBox.Size = new System.Drawing.Size(121, 21);
            this.hddBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(6, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "HDD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(6, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "RAM";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(918, 300);
            this.Controls.Add(this.Filter);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Список ноутбуков";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.Filter.ResumeLayout(false);
            this.Filter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manualToolStripMenuItem;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.Button FilterButton;
        private System.Windows.Forms.GroupBox Filter;
        private System.Windows.Forms.ComboBox ramBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox hddBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox displayBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem фильтрацияToolStripMenuItem;
        private System.Windows.Forms.CheckBox availBox;
        private System.Windows.Forms.ComboBox priceBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox processorBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem удалитьЗаписьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem путьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem всяИнформацтяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem путьКПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem путьКСохраненномуФайлуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn laptopID;
        private System.Windows.Forms.DataGridViewTextBoxColumn laptopName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewCheckBoxColumn availability;
        private System.Windows.Forms.DataGridViewTextBoxColumn RAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonotorSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn Processor;
        private System.Windows.Forms.DataGridViewTextBoxColumn BatteryCapacity;
        private System.Windows.Forms.Label label8;
    }
}

