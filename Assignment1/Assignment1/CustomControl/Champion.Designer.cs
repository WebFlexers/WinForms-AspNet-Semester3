
namespace Assignment1
{
    partial class Champion
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
            this.panelContents = new System.Windows.Forms.Panel();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelDisplayTime = new System.Windows.Forms.Label();
            this.labelTries = new System.Windows.Forms.Label();
            this.labelDisplayTries = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelDisplayUsername = new System.Windows.Forms.Label();
            this.panelContents.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContents
            // 
            this.panelContents.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelContents.BackgroundImage = global::Assignment1.Properties.Resources.escape_menu_background;
            this.panelContents.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelContents.Controls.Add(this.labelTime);
            this.panelContents.Controls.Add(this.labelDisplayTime);
            this.panelContents.Controls.Add(this.labelTries);
            this.panelContents.Controls.Add(this.labelDisplayTries);
            this.panelContents.Controls.Add(this.labelUsername);
            this.panelContents.Controls.Add(this.labelDisplayUsername);
            this.panelContents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContents.Location = new System.Drawing.Point(45, 39);
            this.panelContents.Name = "panelContents";
            this.panelContents.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.panelContents.Size = new System.Drawing.Size(310, 232);
            this.panelContents.TabIndex = 0;
            // 
            // labelTime
            // 
            this.labelTime.AutoEllipsis = true;
            this.labelTime.BackColor = System.Drawing.Color.Transparent;
            this.labelTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTime.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.White;
            this.labelTime.Location = new System.Drawing.Point(0, 183);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(310, 32);
            this.labelTime.TabIndex = 20;
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDisplayTime
            // 
            this.labelDisplayTime.BackColor = System.Drawing.Color.Transparent;
            this.labelDisplayTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelDisplayTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelDisplayTime.Font = new System.Drawing.Font("Century", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDisplayTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(205)))));
            this.labelDisplayTime.Location = new System.Drawing.Point(0, 150);
            this.labelDisplayTime.Name = "labelDisplayTime";
            this.labelDisplayTime.Size = new System.Drawing.Size(310, 33);
            this.labelDisplayTime.TabIndex = 19;
            this.labelDisplayTime.Text = "Finish Time";
            this.labelDisplayTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTries
            // 
            this.labelTries.AutoEllipsis = true;
            this.labelTries.BackColor = System.Drawing.Color.Transparent;
            this.labelTries.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTries.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTries.ForeColor = System.Drawing.Color.White;
            this.labelTries.Location = new System.Drawing.Point(0, 118);
            this.labelTries.Name = "labelTries";
            this.labelTries.Size = new System.Drawing.Size(310, 32);
            this.labelTries.TabIndex = 18;
            this.labelTries.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDisplayTries
            // 
            this.labelDisplayTries.BackColor = System.Drawing.Color.Transparent;
            this.labelDisplayTries.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelDisplayTries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelDisplayTries.Font = new System.Drawing.Font("Century", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDisplayTries.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(205)))));
            this.labelDisplayTries.Location = new System.Drawing.Point(0, 85);
            this.labelDisplayTries.Name = "labelDisplayTries";
            this.labelDisplayTries.Size = new System.Drawing.Size(310, 33);
            this.labelDisplayTries.TabIndex = 17;
            this.labelDisplayTries.Text = "Attempts";
            this.labelDisplayTries.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoEllipsis = true;
            this.labelUsername.BackColor = System.Drawing.Color.Transparent;
            this.labelUsername.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelUsername.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.White;
            this.labelUsername.Location = new System.Drawing.Point(0, 53);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(310, 32);
            this.labelUsername.TabIndex = 16;
            this.labelUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDisplayUsername
            // 
            this.labelDisplayUsername.BackColor = System.Drawing.Color.Transparent;
            this.labelDisplayUsername.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelDisplayUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelDisplayUsername.Font = new System.Drawing.Font("Century", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDisplayUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(205)))));
            this.labelDisplayUsername.Location = new System.Drawing.Point(0, 20);
            this.labelDisplayUsername.Name = "labelDisplayUsername";
            this.labelDisplayUsername.Size = new System.Drawing.Size(310, 33);
            this.labelDisplayUsername.TabIndex = 15;
            this.labelDisplayUsername.Text = "Username";
            this.labelDisplayUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Champion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::Assignment1.Properties.Resources.champion_frame1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panelContents);
            this.DoubleBuffered = true;
            this.Name = "Champion";
            this.Padding = new System.Windows.Forms.Padding(45, 39, 45, 39);
            this.Size = new System.Drawing.Size(400, 310);
            this.panelContents.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContents;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelDisplayTime;
        private System.Windows.Forms.Label labelTries;
        private System.Windows.Forms.Label labelDisplayTries;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelDisplayUsername;
    }
}
