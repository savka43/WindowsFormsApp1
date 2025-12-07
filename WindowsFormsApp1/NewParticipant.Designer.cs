namespace WindowsFormsApp1
{
    partial class NewParticipant
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
            this.nameFIO = new System.Windows.Forms.TextBox();
            this.DriverLicense = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.carPlate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numberOfProtocol = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.guiltiness = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.damage = new System.Windows.Forms.ComboBox();
            this.addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(164, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(232, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Добавить учатсника ДТП";
            // 
            // nameFIO
            // 
            this.nameFIO.Location = new System.Drawing.Point(236, 91);
            this.nameFIO.Name = "nameFIO";
            this.nameFIO.Size = new System.Drawing.Size(217, 20);
            this.nameFIO.TabIndex = 2;
            // 
            // DriverLicense
            // 
            this.DriverLicense.Location = new System.Drawing.Point(236, 126);
            this.DriverLicense.Name = "DriverLicense";
            this.DriverLicense.Size = new System.Drawing.Size(217, 20);
            this.DriverLicense.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(181, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "ВУ:";
            // 
            // carPlate
            // 
            this.carPlate.Location = new System.Drawing.Point(236, 168);
            this.carPlate.Name = "carPlate";
            this.carPlate.Size = new System.Drawing.Size(217, 20);
            this.carPlate.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(86, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Номер машины:";
            // 
            // numberOfProtocol
            // 
            this.numberOfProtocol.Location = new System.Drawing.Point(236, 205);
            this.numberOfProtocol.Name = "numberOfProtocol";
            this.numberOfProtocol.Size = new System.Drawing.Size(217, 20);
            this.numberOfProtocol.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(39, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Номер проткола ДТП:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(111, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Виновность:";
            // 
            // guiltiness
            // 
            this.guiltiness.FormattingEnabled = true;
            this.guiltiness.Location = new System.Drawing.Point(236, 280);
            this.guiltiness.Name = "guiltiness";
            this.guiltiness.Size = new System.Drawing.Size(217, 21);
            this.guiltiness.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(27, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(188, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Степень Повреждений:";
            // 
            // damage
            // 
            this.damage.AllowDrop = true;
            this.damage.FormattingEnabled = true;
            this.damage.Location = new System.Drawing.Point(236, 240);
            this.damage.Name = "damage";
            this.damage.Size = new System.Drawing.Size(217, 21);
            this.damage.TabIndex = 13;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(287, 330);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 14;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // NewParticipant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 450);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.damage);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.guiltiness);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numberOfProtocol);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.carPlate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DriverLicense);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameFIO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewParticipant";
            this.Text = "NewParticipant";
            this.Load += new System.EventHandler(this.NewParticipant_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameFIO;
        private System.Windows.Forms.TextBox DriverLicense;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox carPlate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox numberOfProtocol;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox guiltiness;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox damage;
        private System.Windows.Forms.Button addButton;
    }
}