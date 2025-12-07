namespace WindowsFormsApp1
{
    partial class TsInspector
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
            this.resetbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textboxnumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textboxVIN = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.insertCertificate = new System.Windows.Forms.TextBox();
            this.insertName = new System.Windows.Forms.TextBox();
            this.offense = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.allfineradiobutton = new System.Windows.Forms.RadioButton();
            this.unpaidradiobutton = new System.Windows.Forms.RadioButton();
            this.Paidradiobutton = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 501);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // resetbutton
            // 
            this.resetbutton.Location = new System.Drawing.Point(545, 96);
            this.resetbutton.Name = "resetbutton";
            this.resetbutton.Size = new System.Drawing.Size(75, 38);
            this.resetbutton.TabIndex = 3;
            this.resetbutton.Text = "Сброс";
            this.resetbutton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(456, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "ГосНомер";
            // 
            // textboxnumber
            // 
            this.textboxnumber.Location = new System.Drawing.Point(569, 25);
            this.textboxnumber.Name = "textboxnumber";
            this.textboxnumber.Size = new System.Drawing.Size(129, 20);
            this.textboxnumber.TabIndex = 6;
            this.textboxnumber.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Введите правонарушения";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textboxVIN
            // 
            this.textboxVIN.Location = new System.Drawing.Point(569, 66);
            this.textboxVIN.Name = "textboxVIN";
            this.textboxVIN.Size = new System.Drawing.Size(129, 20);
            this.textboxVIN.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(959, 341);
            this.dataGridView1.TabIndex = 10;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "ОТ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "ДО";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(639, 96);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(84, 38);
            this.SearchButton.TabIndex = 14;
            this.SearchButton.Text = "Поиск";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // insertCertificate
            // 
            this.insertCertificate.Location = new System.Drawing.Point(49, 117);
            this.insertCertificate.Multiline = true;
            this.insertCertificate.Name = "insertCertificate";
            this.insertCertificate.Size = new System.Drawing.Size(155, 20);
            this.insertCertificate.TabIndex = 15;
            this.insertCertificate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.insertCertificate.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // insertName
            // 
            this.insertName.Location = new System.Drawing.Point(241, 117);
            this.insertName.Multiline = true;
            this.insertName.Name = "insertName";
            this.insertName.Size = new System.Drawing.Size(181, 20);
            this.insertName.TabIndex = 16;
            this.insertName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // offense
            // 
            this.offense.FormattingEnabled = true;
            this.offense.Location = new System.Drawing.Point(189, 66);
            this.offense.Name = "offense";
            this.offense.Size = new System.Drawing.Size(233, 21);
            this.offense.TabIndex = 17;
            this.offense.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.allfineradiobutton);
            this.groupBox1.Controls.Add(this.unpaidradiobutton);
            this.groupBox1.Controls.Add(this.Paidradiobutton);
            this.groupBox1.Location = new System.Drawing.Point(758, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 125);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Статус";
            // 
            // allfineradiobutton
            // 
            this.allfineradiobutton.AutoSize = true;
            this.allfineradiobutton.Location = new System.Drawing.Point(80, 53);
            this.allfineradiobutton.Name = "allfineradiobutton";
            this.allfineradiobutton.Size = new System.Drawing.Size(88, 17);
            this.allfineradiobutton.TabIndex = 2;
            this.allfineradiobutton.TabStop = true;
            this.allfineradiobutton.Text = "Все штрафы";
            this.allfineradiobutton.UseVisualStyleBackColor = true;
            this.allfineradiobutton.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // unpaidradiobutton
            // 
            this.unpaidradiobutton.AutoSize = true;
            this.unpaidradiobutton.Location = new System.Drawing.Point(6, 84);
            this.unpaidradiobutton.Name = "unpaidradiobutton";
            this.unpaidradiobutton.Size = new System.Drawing.Size(83, 17);
            this.unpaidradiobutton.TabIndex = 1;
            this.unpaidradiobutton.TabStop = true;
            this.unpaidradiobutton.Text = "Не оплачен";
            this.unpaidradiobutton.UseVisualStyleBackColor = true;
            this.unpaidradiobutton.CheckedChanged += new System.EventHandler(this.unpaidradiobutton_CheckedChanged);
            // 
            // Paidradiobutton
            // 
            this.Paidradiobutton.AutoSize = true;
            this.Paidradiobutton.Location = new System.Drawing.Point(6, 53);
            this.Paidradiobutton.Name = "Paidradiobutton";
            this.Paidradiobutton.Size = new System.Drawing.Size(68, 17);
            this.Paidradiobutton.TabIndex = 0;
            this.Paidradiobutton.TabStop = true;
            this.Paidradiobutton.Text = "Оплачен";
            this.Paidradiobutton.UseVisualStyleBackColor = true;
            this.Paidradiobutton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Введите удостоверение";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(266, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Введите Фио Водителя";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(456, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Введите VIN авто";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(851, 501);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 42);
            this.button2.TabIndex = 22;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(74, 25);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowCheckBox = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(140, 20);
            this.dateTimePicker1.TabIndex = 23;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(250, 25);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowCheckBox = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(142, 20);
            this.dateTimePicker2.TabIndex = 24;
            // 
            // TsInspector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 571);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.offense);
            this.Controls.Add(this.insertName);
            this.Controls.Add(this.insertCertificate);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textboxVIN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textboxnumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.resetbutton);
            this.Controls.Add(this.button1);
            this.Name = "TsInspector";
            this.Text = "Транспортные средства";
            this.Load += new System.EventHandler(this.TsInspector_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button resetbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textboxnumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textboxVIN;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox insertName;
        private System.Windows.Forms.TextBox insertCertificate;
        private System.Windows.Forms.ComboBox offense;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton allfineradiobutton;
        private System.Windows.Forms.RadioButton unpaidradiobutton;
        private System.Windows.Forms.RadioButton Paidradiobutton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}