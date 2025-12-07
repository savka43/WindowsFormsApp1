namespace WindowsFormsApp1
{
    partial class login
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.driverButton = new System.Windows.Forms.Button();
            this.ownerButton = new System.Windows.Forms.Button();
            this.inspectorButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.ГИБДД2;
            this.pictureBox1.Location = new System.Drawing.Point(179, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(253, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Войти как";
            // 
            // driverButton
            // 
            this.driverButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.driverButton.Location = new System.Drawing.Point(162, 211);
            this.driverButton.Name = "driverButton";
            this.driverButton.Size = new System.Drawing.Size(273, 48);
            this.driverButton.TabIndex = 3;
            this.driverButton.Text = "Водитель";
            this.driverButton.UseVisualStyleBackColor = true;
            // 
            // ownerButton
            // 
            this.ownerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ownerButton.Location = new System.Drawing.Point(162, 282);
            this.ownerButton.Name = "ownerButton";
            this.ownerButton.Size = new System.Drawing.Size(273, 48);
            this.ownerButton.TabIndex = 4;
            this.ownerButton.Text = "Владелец";
            this.ownerButton.UseVisualStyleBackColor = true;
            // 
            // inspectorButton
            // 
            this.inspectorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inspectorButton.Location = new System.Drawing.Point(162, 350);
            this.inspectorButton.Name = "inspectorButton";
            this.inspectorButton.Size = new System.Drawing.Size(273, 48);
            this.inspectorButton.TabIndex = 5;
            this.inspectorButton.Text = "Инспектор";
            this.inspectorButton.UseVisualStyleBackColor = true;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(632, 478);
            this.Controls.Add(this.inspectorButton);
            this.Controls.Add(this.ownerButton);
            this.Controls.Add(this.driverButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "login";
            this.Text = "login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button driverButton;
        private System.Windows.Forms.Button ownerButton;
        private System.Windows.Forms.Button inspectorButton;
    }
}