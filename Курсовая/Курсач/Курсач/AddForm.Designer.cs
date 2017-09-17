namespace Курсач
{
    partial class AddForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm));
            this.add = new System.Windows.Forms.GroupBox();
            this.name = new System.Windows.Forms.TextBox();
            this.RAM = new System.Windows.Forms.TextBox();
            this.Capacity = new System.Windows.Forms.TextBox();
            this.monSize = new System.Windows.Forms.TextBox();
            this.processor = new System.Windows.Forms.TextBox();
            this.battery = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.availabilityChB1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.add.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.Controls.Add(this.name);
            this.add.Controls.Add(this.RAM);
            this.add.Controls.Add(this.Capacity);
            this.add.Controls.Add(this.monSize);
            this.add.Controls.Add(this.processor);
            this.add.Controls.Add(this.battery);
            this.add.Controls.Add(this.price);
            this.add.Location = new System.Drawing.Point(122, 22);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(117, 310);
            this.add.TabIndex = 0;
            this.add.TabStop = false;
            // 
            // name
            // 
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name.Location = new System.Drawing.Point(6, 19);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 20);
            this.name.TabIndex = 1;
            // 
            // RAM
            // 
            this.RAM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RAM.Location = new System.Drawing.Point(6, 65);
            this.RAM.Name = "RAM";
            this.RAM.Size = new System.Drawing.Size(100, 20);
            this.RAM.TabIndex = 2;
            // 
            // Capacity
            // 
            this.Capacity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Capacity.Location = new System.Drawing.Point(6, 106);
            this.Capacity.Name = "Capacity";
            this.Capacity.Size = new System.Drawing.Size(100, 20);
            this.Capacity.TabIndex = 3;
            // 
            // monSize
            // 
            this.monSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.monSize.Location = new System.Drawing.Point(6, 147);
            this.monSize.Name = "monSize";
            this.monSize.Size = new System.Drawing.Size(100, 20);
            this.monSize.TabIndex = 4;
            // 
            // processor
            // 
            this.processor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.processor.Location = new System.Drawing.Point(6, 191);
            this.processor.Name = "processor";
            this.processor.Size = new System.Drawing.Size(100, 20);
            this.processor.TabIndex = 5;
            // 
            // battery
            // 
            this.battery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.battery.Location = new System.Drawing.Point(6, 235);
            this.battery.Name = "battery";
            this.battery.Size = new System.Drawing.Size(100, 20);
            this.battery.TabIndex = 6;
            // 
            // price
            // 
            this.price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.price.Location = new System.Drawing.Point(6, 278);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(100, 20);
            this.price.TabIndex = 7;
            // 
            // addButton
            // 
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Location = new System.Drawing.Point(82, 400);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(11, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Название ноутбука";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Location = new System.Drawing.Point(42, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "RAM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Location = new System.Drawing.Point(23, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Объем HDD";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Location = new System.Drawing.Point(14, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Диагональ экрана";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Location = new System.Drawing.Point(29, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Батарея";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Location = new System.Drawing.Point(40, 303);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Цена";
            // 
            // availabilityChB1
            // 
            this.availabilityChB1.AutoSize = true;
            this.availabilityChB1.Checked = true;
            this.availabilityChB1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.availabilityChB1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.availabilityChB1.Location = new System.Drawing.Point(100, 357);
            this.availabilityChB1.Name = "availabilityChB1";
            this.availabilityChB1.Size = new System.Drawing.Size(66, 17);
            this.availabilityChB1.TabIndex = 8;
            this.availabilityChB1.Text = "Наличие";
            this.availabilityChB1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Location = new System.Drawing.Point(29, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Процессор";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(Курсач.Product);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(260, 435);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.availabilityChB1);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddForm";
            this.Text = "Добавить ноутбук";
            this.add.ResumeLayout(false);
            this.add.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox add;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox RAM;
        private System.Windows.Forms.TextBox Capacity;
        private System.Windows.Forms.TextBox monSize;
        private System.Windows.Forms.TextBox processor;
        private System.Windows.Forms.TextBox battery;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox availabilityChB1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource productBindingSource;
    }
}