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
            this.drawPickleRick = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // drawPickleRick
            // 
            this.drawPickleRick.BackColor = System.Drawing.Color.Transparent;
            this.drawPickleRick.FlatAppearance.BorderColor = System.Drawing.Color.LightCyan;
            this.drawPickleRick.FlatAppearance.BorderSize = 4;
            this.drawPickleRick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drawPickleRick.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawPickleRick.ForeColor = System.Drawing.Color.DodgerBlue;
            this.drawPickleRick.Location = new System.Drawing.Point(79, 239);
            this.drawPickleRick.Name = "drawPickleRick";
            this.drawPickleRick.Size = new System.Drawing.Size(320, 70);
            this.drawPickleRick.TabIndex = 0;
            this.drawPickleRick.Text = "Draw Pickle Rick";
            this.drawPickleRick.UseVisualStyleBackColor = false;
            this.drawPickleRick.Click += new System.EventHandler(this.drawPickleRick_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PickleRick.Properties.Resources.thumb_1920_633262;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(464, 321);
            this.Controls.Add(this.drawPickleRick);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Pickle Rick";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button drawPickleRick;
    }
}

