namespace WindowsFormsApp1
{
    partial class NewOwner
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
            this.FIO = new System.Windows.Forms.TextBox();
            this.Birthdate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.Passport = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(195, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавление владельца";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(138, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ФИО: ";
            // 
            // FIO
            // 
            this.FIO.Location = new System.Drawing.Point(199, 122);
            this.FIO.Name = "FIO";
            this.FIO.Size = new System.Drawing.Size(200, 20);
            this.FIO.TabIndex = 2;
            this.FIO.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Birthdate
            // 
            this.Birthdate.Location = new System.Drawing.Point(199, 159);
            this.Birthdate.Name = "Birthdate";
            this.Birthdate.ShowCheckBox = true;
            this.Birthdate.Size = new System.Drawing.Size(200, 20);
            this.Birthdate.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(57, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Дата рождения: ";
            // 
            // Passport
            // 
            this.Passport.Location = new System.Drawing.Point(199, 205);
            this.Passport.Name = "Passport";
            this.Passport.Size = new System.Drawing.Size(200, 20);
            this.Passport.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(115, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Паспорт:";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(252, 262);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // NewOwner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 338);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.Passport);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Birthdate);
            this.Controls.Add(this.FIO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewOwner";
            this.Text = "Новый Владелц";
            this.Load += new System.EventHandler(this.NewOwner_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FIO;
        private System.Windows.Forms.DateTimePicker Birthdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Passport;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addButton;
    }
}