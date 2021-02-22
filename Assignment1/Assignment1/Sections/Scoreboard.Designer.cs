
namespace Assignment1.Sections
{
    partial class Scoreboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Scoreboard));
            this.labelDisplayUsername = new System.Windows.Forms.Label();
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.champion = new Assignment1.Champion();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDisplayUsername
            // 
            this.labelDisplayUsername.BackColor = System.Drawing.Color.Transparent;
            this.labelDisplayUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelDisplayUsername.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDisplayUsername.ForeColor = System.Drawing.Color.DarkRed;
            this.labelDisplayUsername.Location = new System.Drawing.Point(-6, 15);
            this.labelDisplayUsername.Name = "labelDisplayUsername";
            this.labelDisplayUsername.Size = new System.Drawing.Size(1200, 40);
            this.labelDisplayUsername.TabIndex = 16;
            this.labelDisplayUsername.Text = "Champion";
            this.labelDisplayUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDisplayUsername.Visible = false;
            // 
            // pictureBoxExit
            // 
            this.pictureBoxExit.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxExit.Image = global::Assignment1.Properties.Resources.button_square_exit;
            this.pictureBoxExit.Location = new System.Drawing.Point(459, 699);
            this.pictureBoxExit.Name = "pictureBoxExit";
            this.pictureBoxExit.Size = new System.Drawing.Size(282, 98);
            this.pictureBoxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxExit.TabIndex = 17;
            this.pictureBoxExit.TabStop = false;
            this.pictureBoxExit.Click += new System.EventHandler(this.pictureBoxExit_Click);
            this.pictureBoxExit.MouseEnter += new System.EventHandler(this.pictureBoxExit_MouseEnter);
            this.pictureBoxExit.MouseLeave += new System.EventHandler(this.pictureBoxExit_MouseLeave);
            // 
            // champion
            // 
            this.champion.BackColor = System.Drawing.Color.Transparent;
            this.champion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("champion.BackgroundImage")));
            this.champion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.champion.Location = new System.Drawing.Point(393, 55);
            this.champion.Name = "champion";
            this.champion.Padding = new System.Windows.Forms.Padding(45);
            this.champion.Size = new System.Drawing.Size(406, 335);
            this.champion.TabIndex = 0;
            this.champion.Visible = false;
            // 
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.Color.Transparent;
            this.buttonNext.FlatAppearance.BorderSize = 0;
            this.buttonNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(86)))), ((int)(((byte)(54)))));
            this.buttonNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(86)))), ((int)(((byte)(54)))));
            this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNext.Font = new System.Drawing.Font("Marlett", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonNext.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonNext.Location = new System.Drawing.Point(1118, 525);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(45, 45);
            this.buttonNext.TabIndex = 22;
            this.buttonNext.Text = "4";
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Visible = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.BackColor = System.Drawing.Color.Transparent;
            this.buttonPrev.FlatAppearance.BorderSize = 0;
            this.buttonPrev.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(86)))), ((int)(((byte)(54)))));
            this.buttonPrev.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(86)))), ((int)(((byte)(54)))));
            this.buttonPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrev.Font = new System.Drawing.Font("Marlett", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonPrev.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonPrev.Location = new System.Drawing.Point(35, 525);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(45, 45);
            this.buttonPrev.TabIndex = 23;
            this.buttonPrev.Text = "3";
            this.buttonPrev.UseVisualStyleBackColor = false;
            this.buttonPrev.Visible = false;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // Scoreboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Assignment1.Properties.Resources.amphitheater;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.pictureBoxExit);
            this.Controls.Add(this.labelDisplayUsername);
            this.Controls.Add(this.champion);
            this.DoubleBuffered = true;
            this.Name = "Scoreboard";
            this.Size = new System.Drawing.Size(1200, 800);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Champion champion;
        private System.Windows.Forms.Label labelDisplayUsername;
        private System.Windows.Forms.PictureBox pictureBoxExit;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrev;
    }
}
