namespace WindowsFormsApp1
{
    partial class NewCar
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
            this.passportOwner = new System.Windows.Forms.TextBox();
            this.carBrand = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.carModel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.carColor = new System.Windows.Forms.Label();
            this.dateRegistration = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.addAuto = new System.Windows.Forms.Button();
            this.carPlate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.carYear = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(213, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавить ТС";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(25, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Паспорт владельца";
            // 
            // passportOwner
            // 
            this.passportOwner.Location = new System.Drawing.Point(217, 117);
            this.passportOwner.Name = "passportOwner";
            this.passportOwner.Size = new System.Drawing.Size(217, 20);
            this.passportOwner.TabIndex = 2;
            // 
            // carBrand
            // 
            this.carBrand.Location = new System.Drawing.Point(217, 157);
            this.carBrand.Name = "carBrand";
            this.carBrand.Size = new System.Drawing.Size(217, 20);
            this.carBrand.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(25, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Марка";
            // 
            // carModel
            // 
            this.carModel.Location = new System.Drawing.Point(217, 200);
            this.carModel.Name = "carModel";
            this.carModel.Size = new System.Drawing.Size(217, 20);
            this.carModel.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(25, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Модель";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(25, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Год выпуска";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(217, 297);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(217, 20);
            this.textBox4.TabIndex = 11;
            // 
            // carColor
            // 
            this.carColor.AutoSize = true;
            this.carColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.carColor.Location = new System.Drawing.Point(25, 297);
            this.carColor.Name = "carColor";
            this.carColor.Size = new System.Drawing.Size(48, 20);
            this.carColor.TabIndex = 10;
            this.carColor.Text = "Цвет";
            // 
            // dateRegistration
            // 
            this.dateRegistration.Location = new System.Drawing.Point(217, 368);
            this.dateRegistration.Name = "dateRegistration";
            this.dateRegistration.Size = new System.Drawing.Size(217, 20);
            this.dateRegistration.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(25, 368);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Дата постановки";
            // 
            // addAuto
            // 
            this.addAuto.Location = new System.Drawing.Point(187, 416);
            this.addAuto.Name = "addAuto";
            this.addAuto.Size = new System.Drawing.Size(112, 42);
            this.addAuto.TabIndex = 14;
            this.addAuto.Text = "ДобавитьТС";
            this.addAuto.UseVisualStyleBackColor = true;
            // 
            // carPlate
            // 
            this.carPlate.Location = new System.Drawing.Point(217, 333);
            this.carPlate.Name = "carPlate";
            this.carPlate.Size = new System.Drawing.Size(217, 20);
            this.carPlate.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(25, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "ГосНомер";
            // 
            // carYear
            // 
            this.carYear.Location = new System.Drawing.Point(217, 250);
            this.carYear.Name = "carYear";
            this.carYear.Size = new System.Drawing.Size(217, 20);
            this.carYear.TabIndex = 17;
            // 
            // NewCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 513);
            this.Controls.Add(this.carYear);
            this.Controls.Add(this.carPlate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.addAuto);
            this.Controls.Add(this.dateRegistration);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.carColor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.carModel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.carBrand);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passportOwner);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewCar";
            this.Text = "NewCar";
            this.Load += new System.EventHandler(this.NewCar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passportOwner;
        private System.Windows.Forms.TextBox carBrand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox carModel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label carColor;
        private System.Windows.Forms.DateTimePicker dateRegistration;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button addAuto;
        private System.Windows.Forms.TextBox carPlate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox carYear;
    }
}