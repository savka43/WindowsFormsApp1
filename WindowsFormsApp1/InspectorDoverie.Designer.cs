namespace WindowsFormsApp1
{
    partial class InspectorDoverie
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
            this.DriverFIO = new System.Windows.Forms.TextBox();
            this.OwnerFIO = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.CarBrand = new System.Windows.Forms.ComboBox();
            this.CarModel = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Backbutton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.stateOfDoverie = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(37, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО Водителя:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DriverFIO
            // 
            this.DriverFIO.Location = new System.Drawing.Point(191, 38);
            this.DriverFIO.Name = "DriverFIO";
            this.DriverFIO.Size = new System.Drawing.Size(139, 20);
            this.DriverFIO.TabIndex = 1;
            this.DriverFIO.TextChanged += new System.EventHandler(this.DriverFIO_TextChanged_1);
            // 
            // OwnerFIO
            // 
            this.OwnerFIO.Location = new System.Drawing.Point(191, 75);
            this.OwnerFIO.Name = "OwnerFIO";
            this.OwnerFIO.Size = new System.Drawing.Size(139, 20);
            this.OwnerFIO.TabIndex = 3;
            this.OwnerFIO.TextChanged += new System.EventHandler(this.OwnerFIO_TextChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(27, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "ФИО Владельца:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(357, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Дата:";
            // 
            // dateStart
            // 
            this.dateStart.Location = new System.Drawing.Point(442, 38);
            this.dateStart.Name = "dateStart";
            this.dateStart.ShowCheckBox = true;
            this.dateStart.Size = new System.Drawing.Size(152, 20);
            this.dateStart.TabIndex = 5;
            this.dateStart.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(406, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "От";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(605, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "До";
            // 
            // dateEnd
            // 
            this.dateEnd.Location = new System.Drawing.Point(641, 38);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.ShowCheckBox = true;
            this.dateEnd.Size = new System.Drawing.Size(152, 20);
            this.dateEnd.TabIndex = 7;
            this.dateEnd.ValueChanged += new System.EventHandler(this.dateEnd_ValueChanged_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(348, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Марка:";
            // 
            // CarBrand
            // 
            this.CarBrand.FormattingEnabled = true;
            this.CarBrand.Location = new System.Drawing.Point(415, 73);
            this.CarBrand.Name = "CarBrand";
            this.CarBrand.Size = new System.Drawing.Size(130, 21);
            this.CarBrand.TabIndex = 10;
            this.CarBrand.SelectedIndexChanged += new System.EventHandler(this.CarBrand_SelectedIndexChanged_1);
            // 
            // CarModel
            // 
            this.CarModel.FormattingEnabled = true;
            this.CarModel.Location = new System.Drawing.Point(632, 75);
            this.CarModel.Name = "CarModel";
            this.CarModel.Size = new System.Drawing.Size(161, 21);
            this.CarModel.TabIndex = 12;
            this.CarModel.SelectedIndexChanged += new System.EventHandler(this.CarModel_SelectedIndexChanged_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(565, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Марка:";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(992, 40);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 13;
            this.SearchButton.Text = "Поиск";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click_1);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(992, 76);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 14;
            this.ResetButton.Text = "Сброс";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1026, 424);
            this.dataGridView1.TabIndex = 15;
            // 
            // Backbutton
            // 
            this.Backbutton.Location = new System.Drawing.Point(41, 566);
            this.Backbutton.Name = "Backbutton";
            this.Backbutton.Size = new System.Drawing.Size(75, 23);
            this.Backbutton.TabIndex = 16;
            this.Backbutton.Text = "Назад";
            this.Backbutton.UseVisualStyleBackColor = true;
            this.Backbutton.Click += new System.EventHandler(this.Backbutton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(869, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Статус:";
            // 
            // stateOfDoverie
            // 
            this.stateOfDoverie.FormattingEnabled = true;
            this.stateOfDoverie.Location = new System.Drawing.Point(841, 54);
            this.stateOfDoverie.Name = "stateOfDoverie";
            this.stateOfDoverie.Size = new System.Drawing.Size(121, 21);
            this.stateOfDoverie.TabIndex = 18;
            this.stateOfDoverie.SelectedIndexChanged += new System.EventHandler(this.stateOfDoverie_SelectedIndexChanged_1);
            // 
            // InspectorDoverie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 601);
            this.Controls.Add(this.stateOfDoverie);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Backbutton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.CarModel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CarBrand);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OwnerFIO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DriverFIO);
            this.Controls.Add(this.label1);
            this.Name = "InspectorDoverie";
            this.Text = "InspectorDoverie";
            this.Load += new System.EventHandler(this.InspectorDoverie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DriverFIO;
        private System.Windows.Forms.TextBox OwnerFIO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CarBrand;
        private System.Windows.Forms.ComboBox CarModel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Backbutton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox stateOfDoverie;
    }
}