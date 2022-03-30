namespace WindowsFormsApp1
{
    partial class gamoverscreen
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
            this.playagain = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playagain
            // 
            this.playagain.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.replay;
            this.playagain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.playagain.Location = new System.Drawing.Point(156, 172);
            this.playagain.Name = "playagain";
            this.playagain.Size = new System.Drawing.Size(212, 72);
            this.playagain.TabIndex = 3;
            this.playagain.UseVisualStyleBackColor = true;
            this.playagain.Click += new System.EventHandler(this.playagain_Click);
            // 
            // exit
            // 
            this.exit.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.exit;
            this.exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exit.Location = new System.Drawing.Point(156, 305);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(212, 79);
            this.exit.TabIndex = 2;
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // gamoverscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.playagain);
            this.Controls.Add(this.exit);
            this.Name = "gamoverscreen";
            this.Size = new System.Drawing.Size(600, 600);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button playagain;
    }
}
