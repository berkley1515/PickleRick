namespace PickleRick
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.musicPlayer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // musicPlayer
            // 
            this.musicPlayer.BackColor = System.Drawing.Color.Transparent;
            this.musicPlayer.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.musicPlayer.FlatAppearance.BorderSize = 3;
            this.musicPlayer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.musicPlayer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.musicPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.musicPlayer.Font = new System.Drawing.Font("Imprint MT Shadow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.musicPlayer.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.musicPlayer.Location = new System.Drawing.Point(101, 247);
            this.musicPlayer.Name = "musicPlayer";
            this.musicPlayer.Size = new System.Drawing.Size(266, 62);
            this.musicPlayer.TabIndex = 0;
            this.musicPlayer.Text = "Music Player";
            this.musicPlayer.UseVisualStyleBackColor = false;
            this.musicPlayer.Click += new System.EventHandler(this.drawPickleRick_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PickleRick.Properties.Resources.thumb_1920_6332621;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(464, 321);
            this.Controls.Add(this.musicPlayer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Pickle Rick";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button musicPlayer;
    }
}

