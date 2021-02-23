
namespace Assignment1.Sections
{
    partial class Login
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.labelChooseImages = new System.Windows.Forms.Label();
            this.pictureBoxPlay = new System.Windows.Forms.PictureBox();
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.speaker = new Assignment1.Speaker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speaker)).BeginInit();
            this.SuspendLayout();
            // 
            // labelChooseImages
            // 
            this.labelChooseImages.BackColor = System.Drawing.Color.Transparent;
            this.labelChooseImages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelChooseImages.Font = new System.Drawing.Font("Century", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChooseImages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(238)))));
            this.labelChooseImages.Location = new System.Drawing.Point(195, 80);
            this.labelChooseImages.Name = "labelChooseImages";
            this.labelChooseImages.Size = new System.Drawing.Size(811, 57);
            this.labelChooseImages.TabIndex = 2;
            this.labelChooseImages.Text = "Type your name";
            this.labelChooseImages.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxPlay
            // 
            this.pictureBoxPlay.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxPlay.Image = global::Assignment1.Properties.Resources.button_square_play;
            this.pictureBoxPlay.Location = new System.Drawing.Point(455, 280);
            this.pictureBoxPlay.Name = "pictureBoxPlay";
            this.pictureBoxPlay.Size = new System.Drawing.Size(291, 110);
            this.pictureBoxPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPlay.TabIndex = 3;
            this.pictureBoxPlay.TabStop = false;
            this.pictureBoxPlay.Click += new System.EventHandler(this.pictureBoxPlay_Click);
            this.pictureBoxPlay.MouseEnter += new System.EventHandler(this.pictureBoxPlay_MouseEnter);
            this.pictureBoxPlay.MouseLeave += new System.EventHandler(this.pictureBoxPlay_MouseLeave);
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxBack.Image = global::Assignment1.Properties.Resources.button_square_back;
            this.pictureBoxBack.Location = new System.Drawing.Point(455, 413);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(291, 110);
            this.pictureBoxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBack.TabIndex = 4;
            this.pictureBoxBack.TabStop = false;
            this.pictureBoxBack.Click += new System.EventHandler(this.pictureBoxBack_Click);
            this.pictureBoxBack.MouseEnter += new System.EventHandler(this.pictureBoxBack_MouseEnter);
            this.pictureBoxBack.MouseLeave += new System.EventHandler(this.pictureBoxBack_MouseLeave);
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(400, 164);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(400, 44);
            this.textBoxName.TabIndex = 5;
            // 
            // speaker
            // 
            this.speaker.BackColor = System.Drawing.Color.Transparent;
            this.speaker.Image = ((System.Drawing.Image)(resources.GetObject("speaker.Image")));
            this.speaker.Location = new System.Drawing.Point(1152, 8);
            this.speaker.Margin = new System.Windows.Forms.Padding(8);
            this.speaker.Name = "speaker";
            this.speaker.Size = new System.Drawing.Size(40, 40);
            this.speaker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.speaker.TabIndex = 18;
            this.speaker.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Assignment1.Properties.Resources.University_of_Piraeus_Banner;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.speaker);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.pictureBoxBack);
            this.Controls.Add(this.pictureBoxPlay);
            this.Controls.Add(this.labelChooseImages);
            this.DoubleBuffered = true;
            this.Name = "Login";
            this.Size = new System.Drawing.Size(1200, 800);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speaker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelChooseImages;
        private System.Windows.Forms.PictureBox pictureBoxPlay;
        private System.Windows.Forms.PictureBox pictureBoxBack;
        private System.Windows.Forms.TextBox textBoxName;
        private Speaker speaker;
    }
}
