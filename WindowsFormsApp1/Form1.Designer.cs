namespace WindowsFormsApp1
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.inspectorButton = new System.Windows.Forms.Button();
            this.driverButton = new System.Windows.Forms.Button();
            this.ownerButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.ГИБДД2;
            this.pictureBox1.Location = new System.Drawing.Point(75, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // inspectorButton
            // 
            this.inspectorButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.inspectorButton.Location = new System.Drawing.Point(62, 409);
            this.inspectorButton.Name = "inspectorButton";
            this.inspectorButton.Size = new System.Drawing.Size(258, 36);
            this.inspectorButton.TabIndex = 7;
            this.inspectorButton.Text = "Инспектор";
            this.inspectorButton.UseVisualStyleBackColor = false;
            this.inspectorButton.Click += new System.EventHandler(this.inspectorButton_Click);
            // 
            // driverButton
            // 
            this.driverButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.driverButton.Location = new System.Drawing.Point(62, 283);
            this.driverButton.Name = "driverButton";
            this.driverButton.Size = new System.Drawing.Size(258, 36);
            this.driverButton.TabIndex = 8;
            this.driverButton.Text = "Водитель";
            this.driverButton.UseVisualStyleBackColor = false;
            this.driverButton.Click += new System.EventHandler(this.driverButton_Click);
            // 
            // ownerButton
            // 
            this.ownerButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ownerButton.Location = new System.Drawing.Point(62, 348);
            this.ownerButton.Name = "ownerButton";
            this.ownerButton.Size = new System.Drawing.Size(258, 36);
            this.ownerButton.TabIndex = 9;
            this.ownerButton.Text = "Владелец";
            this.ownerButton.UseVisualStyleBackColor = false;
            this.ownerButton.Click += new System.EventHandler(this.ownerButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(145, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Войти как";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 574);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ownerButton);
            this.Controls.Add(this.driverButton);
            this.Controls.Add(this.inspectorButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button inspectorButton;
        private System.Windows.Forms.Button driverButton;
        private System.Windows.Forms.Button ownerButton;
        private System.Windows.Forms.Label label1;
    }
}

