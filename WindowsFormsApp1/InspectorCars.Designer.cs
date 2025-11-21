namespace WindowsFormsApp1
{
    partial class InspectorCars
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
            this.carBrand = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.modelCar = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.carColor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.carPlate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateRegistration = new System.Windows.Forms.DateTimePicker();
            this.resetButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // carBrand
            // 
            this.carBrand.FormattingEnabled = true;
            this.carBrand.Location = new System.Drawing.Point(132, 27);
            this.carBrand.Name = "carBrand";
            this.carBrand.Size = new System.Drawing.Size(121, 21);
            this.carBrand.TabIndex = 0;
            this.carBrand.SelectedIndexChanged += new System.EventHandler(this.carBrand_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(53, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Марка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(53, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Модель";
            // 
            // modelCar
            // 
            this.modelCar.FormattingEnabled = true;
            this.modelCar.Location = new System.Drawing.Point(132, 72);
            this.modelCar.Name = "modelCar";
            this.modelCar.Size = new System.Drawing.Size(121, 21);
            this.modelCar.TabIndex = 2;
            this.modelCar.SelectedIndexChanged += new System.EventHandler(this.modelCar_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(283, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Цвет";
            // 
            // carColor
            // 
            this.carColor.FormattingEnabled = true;
            this.carColor.Location = new System.Drawing.Point(377, 26);
            this.carColor.Name = "carColor";
            this.carColor.Size = new System.Drawing.Size(121, 21);
            this.carColor.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(283, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "ГосНомер";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // carPlate
            // 
            this.carPlate.Location = new System.Drawing.Point(377, 70);
            this.carPlate.Name = "carPlate";
            this.carPlate.Size = new System.Drawing.Size(121, 20);
            this.carPlate.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(515, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Год Выпуска";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(515, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Дата учета";
            // 
            // dateRegistration
            // 
            this.dateRegistration.Location = new System.Drawing.Point(626, 69);
            this.dateRegistration.Name = "dateRegistration";
            this.dateRegistration.ShowCheckBox = true;
            this.dateRegistration.Size = new System.Drawing.Size(298, 20);
            this.dateRegistration.TabIndex = 13;
            this.dateRegistration.ValueChanged += new System.EventHandler(this.dateRegistration_ValueChanged);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(987, 23);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 14;
            this.resetButton.Text = "Сброс";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(987, 68);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 15;
            this.searchButton.Text = "Поиск";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(35, 609);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Назад";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(177, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(723, 454);
            this.dataGridView1.TabIndex = 17;
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(651, 27);
            this.startDate.Name = "startDate";
            this.startDate.ShowCheckBox = true;
            this.startDate.Size = new System.Drawing.Size(141, 20);
            this.startDate.TabIndex = 18;
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(827, 28);
            this.endDate.Name = "endDate";
            this.endDate.ShowCheckBox = true;
            this.endDate.Size = new System.Drawing.Size(141, 20);
            this.endDate.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(623, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "От";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(798, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "До";
            // 
            // InspectorCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 658);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.dateRegistration);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.carPlate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.carColor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.modelCar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.carBrand);
            this.Name = "InspectorCars";
            this.Text = "Транспортные средства";
            this.Load += new System.EventHandler(this.InspectorCars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox carBrand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox modelCar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox carColor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox carPlate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateRegistration;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}