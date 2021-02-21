
namespace Assignment1
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.timerFadeOnExit = new System.Windows.Forms.Timer(this.components);
            this.panelMenu = new Assignment1.DoubleBufferPanel();
            this.speaker = new Assignment1.Speaker();
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.pictureBoxOptions = new System.Windows.Forms.PictureBox();
            this.pictureBoxPlay = new System.Windows.Forms.PictureBox();
            this.game = new Assignment1.Sections.Game();
            this.options = new Assignment1.Sections.Options();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speaker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlay)).BeginInit();
            this.SuspendLayout();
            // 
            // timerFadeOnExit
            // 
            this.timerFadeOnExit.Interval = 1;
            this.timerFadeOnExit.Tick += new System.EventHandler(this.timerFadeOnExit_Tick);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Transparent;
            this.panelMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMenu.Controls.Add(this.speaker);
            this.panelMenu.Controls.Add(this.pictureBoxExit);
            this.panelMenu.Controls.Add(this.pictureBoxOptions);
            this.panelMenu.Controls.Add(this.pictureBoxPlay);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1200, 800);
            this.panelMenu.TabIndex = 3;
            // 
            // speaker
            // 
            this.speaker.Image = ((System.Drawing.Image)(resources.GetObject("speaker.Image")));
            this.speaker.Location = new System.Drawing.Point(1152, 8);
            this.speaker.Margin = new System.Windows.Forms.Padding(8);
            this.speaker.Name = "speaker";
            this.speaker.Size = new System.Drawing.Size(40, 40);
            this.speaker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.speaker.TabIndex = 3;
            this.speaker.TabStop = false;
            // 
            // pictureBoxExit
            // 
            this.pictureBoxExit.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxExit.Image = global::Assignment1.Properties.Resources.button_square_exit;
            this.pictureBoxExit.Location = new System.Drawing.Point(426, 446);
            this.pictureBoxExit.Name = "pictureBoxExit";
            this.pictureBoxExit.Size = new System.Drawing.Size(348, 138);
            this.pictureBoxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxExit.TabIndex = 2;
            this.pictureBoxExit.TabStop = false;
            this.pictureBoxExit.Click += new System.EventHandler(this.pictureBoxExit_Click);
            this.pictureBoxExit.MouseEnter += new System.EventHandler(this.pictureBoxExit_MouseEnter);
            this.pictureBoxExit.MouseLeave += new System.EventHandler(this.pictureBoxExit_MouseLeave);
            // 
            // pictureBoxOptions
            // 
            this.pictureBoxOptions.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxOptions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxOptions.Image = global::Assignment1.Properties.Resources.button_square_options;
            this.pictureBoxOptions.Location = new System.Drawing.Point(426, 281);
            this.pictureBoxOptions.Name = "pictureBoxOptions";
            this.pictureBoxOptions.Size = new System.Drawing.Size(348, 138);
            this.pictureBoxOptions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxOptions.TabIndex = 1;
            this.pictureBoxOptions.TabStop = false;
            this.pictureBoxOptions.Click += new System.EventHandler(this.pictureBoxOptions_Click);
            this.pictureBoxOptions.MouseEnter += new System.EventHandler(this.pictureBoxOptions_MouseEnter);
            this.pictureBoxOptions.MouseLeave += new System.EventHandler(this.pictureBoxOptions_MouseLeave);
            // 
            // pictureBoxPlay
            // 
            this.pictureBoxPlay.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxPlay.Image = global::Assignment1.Properties.Resources.button_square_play;
            this.pictureBoxPlay.Location = new System.Drawing.Point(426, 116);
            this.pictureBoxPlay.Name = "pictureBoxPlay";
            this.pictureBoxPlay.Size = new System.Drawing.Size(348, 138);
            this.pictureBoxPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPlay.TabIndex = 0;
            this.pictureBoxPlay.TabStop = false;
            this.pictureBoxPlay.Click += new System.EventHandler(this.pictureBoxPlay_Click);
            this.pictureBoxPlay.MouseEnter += new System.EventHandler(this.pictureBoxPlay_MouseEnter);
            this.pictureBoxPlay.MouseLeave += new System.EventHandler(this.pictureBoxPlay_MouseLeave);
            // 
            // game
            // 
            this.game.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("game.BackgroundImage")));
            this.game.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.game.Location = new System.Drawing.Point(0, 0);
            this.game.Name = "game";
            this.game.Size = new System.Drawing.Size(1200, 800);
            this.game.TabIndex = 4;
            // 
            // options
            // 
            this.options.BackColor = System.Drawing.Color.Transparent;
            this.options.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("options.BackgroundImage")));
            this.options.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.options.Dock = System.Windows.Forms.DockStyle.Fill;
            this.options.Location = new System.Drawing.Point(0, 0);
            this.options.Name = "options";
            this.options.Size = new System.Drawing.Size(1200, 800);
            this.options.TabIndex = 4;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Assignment1.Properties.Resources.University_of_Piraeus_Banner;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.game);
            this.Controls.Add(this.options);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResizeEnd += new System.EventHandler(this.FormMain_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.FormMain_SizeChanged);
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.speaker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPlay;
        private System.Windows.Forms.PictureBox pictureBoxOptions;
        private System.Windows.Forms.PictureBox pictureBoxExit;
        private DoubleBufferPanel panelMenu;
        private Speaker speaker;
        private Sections.Options options;
        private Sections.Game game;
        private System.Windows.Forms.Timer timerFadeOnExit;
    }
}

