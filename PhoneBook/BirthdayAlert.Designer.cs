﻿namespace PhoneBook
{
    partial class BirthdayAlert
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BirthdayAlert));
            this.pictureBirthdayCake = new System.Windows.Forms.PictureBox();
            this.greetings = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBirthdayCake)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBirthdayCake
            // 
            this.pictureBirthdayCake.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBirthdayCake.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBirthdayCake.Location = new System.Drawing.Point(142, 56);
            this.pictureBirthdayCake.Name = "pictureBirthdayCake";
            this.pictureBirthdayCake.Size = new System.Drawing.Size(103, 128);
            this.pictureBirthdayCake.TabIndex = 0;
            this.pictureBirthdayCake.TabStop = false;
            // 
            // greetings
            // 
            this.greetings.AutoSize = true;
            this.greetings.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.greetings.ForeColor = System.Drawing.Color.SteelBlue;
            this.greetings.Location = new System.Drawing.Point(104, 187);
            this.greetings.Name = "greetings";
            this.greetings.Size = new System.Drawing.Size(174, 28);
            this.greetings.TabIndex = 1;
            this.greetings.Text = " has birthday today!";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NameLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.NameLabel.Location = new System.Drawing.Point(137, 9);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(119, 28);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Alicja Kropka";
            // 
            // BirthdayAlert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(414, 224);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.greetings);
            this.Controls.Add(this.pictureBirthdayCake);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BirthdayAlert";
            this.Text = "Birthday Alert!";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBirthdayCake)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBirthdayCake;
        private System.Windows.Forms.Label greetings;
        private System.Windows.Forms.Label NameLabel;
    }
}