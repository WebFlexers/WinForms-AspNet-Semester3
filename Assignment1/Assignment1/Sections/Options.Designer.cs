
namespace Assignment1.Sections
{
    partial class Options
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            this.labelChooseImages = new System.Windows.Forms.Label();
            this.pictureBoxBrowse = new System.Windows.Forms.PictureBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.labelSound = new System.Windows.Forms.Label();
            this.checkBoxEffects = new System.Windows.Forms.CheckBox();
            this.checkBoxMusic = new System.Windows.Forms.CheckBox();
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            this.labelPath = new System.Windows.Forms.Label();
            this.speaker = new Assignment1.Speaker();
            this.pictureBoxResetPath = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBrowse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speaker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResetPath)).BeginInit();
            this.SuspendLayout();
            // 
            // labelChooseImages
            // 
            this.labelChooseImages.Font = new System.Drawing.Font("Century", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChooseImages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(238)))));
            this.labelChooseImages.Location = new System.Drawing.Point(195, 28);
            this.labelChooseImages.Name = "labelChooseImages";
            this.labelChooseImages.Size = new System.Drawing.Size(811, 57);
            this.labelChooseImages.TabIndex = 1;
            this.labelChooseImages.Text = "Import your own picture directory";
            this.labelChooseImages.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxBrowse
            // 
            this.pictureBoxBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxBrowse.Image = global::Assignment1.Properties.Resources.button_square_browse;
            this.pictureBoxBrowse.Location = new System.Drawing.Point(495, 137);
            this.pictureBoxBrowse.Name = "pictureBoxBrowse";
            this.pictureBoxBrowse.Size = new System.Drawing.Size(211, 81);
            this.pictureBoxBrowse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBrowse.TabIndex = 2;
            this.pictureBoxBrowse.TabStop = false;
            this.pictureBoxBrowse.Click += new System.EventHandler(this.pictureBoxBrowse_Click);
            this.pictureBoxBrowse.MouseEnter += new System.EventHandler(this.pictureBoxBrowse_MouseEnter);
            this.pictureBoxBrowse.MouseLeave += new System.EventHandler(this.pictureBoxBrowse_MouseLeave);
            // 
            // labelSound
            // 
            this.labelSound.Font = new System.Drawing.Font("Century", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSound.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(238)))));
            this.labelSound.Location = new System.Drawing.Point(515, 361);
            this.labelSound.Name = "labelSound";
            this.labelSound.Size = new System.Drawing.Size(170, 57);
            this.labelSound.TabIndex = 3;
            this.labelSound.Text = "Sound";
            this.labelSound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBoxEffects
            // 
            this.checkBoxEffects.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBoxEffects.Checked = true;
            this.checkBoxEffects.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEffects.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEffects.ForeColor = System.Drawing.Color.Black;
            this.checkBoxEffects.Location = new System.Drawing.Point(383, 459);
            this.checkBoxEffects.Name = "checkBoxEffects";
            this.checkBoxEffects.Size = new System.Drawing.Size(226, 55);
            this.checkBoxEffects.TabIndex = 4;
            this.checkBoxEffects.Text = "Sound Effects";
            this.checkBoxEffects.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxEffects.UseVisualStyleBackColor = true;
            this.checkBoxEffects.Click += new System.EventHandler(this.checkBoxEffects_Click);
            // 
            // checkBoxMusic
            // 
            this.checkBoxMusic.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBoxMusic.Checked = true;
            this.checkBoxMusic.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMusic.ForeColor = System.Drawing.Color.Black;
            this.checkBoxMusic.Location = new System.Drawing.Point(643, 459);
            this.checkBoxMusic.Name = "checkBoxMusic";
            this.checkBoxMusic.Size = new System.Drawing.Size(113, 55);
            this.checkBoxMusic.TabIndex = 5;
            this.checkBoxMusic.Text = "Music";
            this.checkBoxMusic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxMusic.UseVisualStyleBackColor = true;
            this.checkBoxMusic.Click += new System.EventHandler(this.checkBoxMusic_Click);
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxBack.Image = global::Assignment1.Properties.Resources.button_square_back;
            this.pictureBoxBack.Location = new System.Drawing.Point(466, 594);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(268, 103);
            this.pictureBoxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBack.TabIndex = 6;
            this.pictureBoxBack.TabStop = false;
            this.pictureBoxBack.Click += new System.EventHandler(this.pictureBoxBack_Click);
            this.pictureBoxBack.MouseEnter += new System.EventHandler(this.pictureBoxBack_MouseEnter);
            this.pictureBoxBack.MouseLeave += new System.EventHandler(this.pictureBoxBack_MouseLeave);
            // 
            // labelPath
            // 
            this.labelPath.AutoEllipsis = true;
            this.labelPath.Font = new System.Drawing.Font("Century", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPath.ForeColor = System.Drawing.Color.Black;
            this.labelPath.Location = new System.Drawing.Point(51, 94);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(1099, 40);
            this.labelPath.TabIndex = 7;
            this.labelPath.Text = "Sample Text";
            this.labelPath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // speaker
            // 
            this.speaker.Image = ((System.Drawing.Image)(resources.GetObject("speaker.Image")));
            this.speaker.Location = new System.Drawing.Point(1152, 8);
            this.speaker.Margin = new System.Windows.Forms.Padding(8);
            this.speaker.Name = "speaker";
            this.speaker.Size = new System.Drawing.Size(40, 40);
            this.speaker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.speaker.TabIndex = 0;
            this.speaker.TabStop = false;
            // 
            // pictureBoxResetPath
            // 
            this.pictureBoxResetPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxResetPath.Image = global::Assignment1.Properties.Resources.button_square_reset;
            this.pictureBoxResetPath.Location = new System.Drawing.Point(495, 224);
            this.pictureBoxResetPath.Name = "pictureBoxResetPath";
            this.pictureBoxResetPath.Size = new System.Drawing.Size(211, 81);
            this.pictureBoxResetPath.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxResetPath.TabIndex = 8;
            this.pictureBoxResetPath.TabStop = false;
            this.pictureBoxResetPath.Click += new System.EventHandler(this.pictureBoxResetPath_Click);
            this.pictureBoxResetPath.MouseEnter += new System.EventHandler(this.pictureBoxResetPath_MouseEnter);
            this.pictureBoxResetPath.MouseLeave += new System.EventHandler(this.pictureBoxResetPath_MouseLeave);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::Assignment1.Properties.Resources.University_of_Piraeus_Banner;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.pictureBoxResetPath);
            this.Controls.Add(this.labelPath);
            this.Controls.Add(this.pictureBoxBack);
            this.Controls.Add(this.checkBoxMusic);
            this.Controls.Add(this.checkBoxEffects);
            this.Controls.Add(this.labelSound);
            this.Controls.Add(this.pictureBoxBrowse);
            this.Controls.Add(this.labelChooseImages);
            this.Controls.Add(this.speaker);
            this.DoubleBuffered = true;
            this.Name = "Options";
            this.Size = new System.Drawing.Size(1200, 800);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBrowse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speaker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResetPath)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Speaker speaker;
        private System.Windows.Forms.Label labelChooseImages;
        private System.Windows.Forms.PictureBox pictureBoxBrowse;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Label labelSound;
        private System.Windows.Forms.CheckBox checkBoxEffects;
        private System.Windows.Forms.CheckBox checkBoxMusic;
        private System.Windows.Forms.PictureBox pictureBoxBack;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.PictureBox pictureBoxResetPath;
    }
}
