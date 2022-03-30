namespace WindowsFormsApp1
{
    partial class Menuscreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menuscreen));
            this.Exitbutton = new System.Windows.Forms.Button();
            this.playbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Exitbutton
            // 
            this.Exitbutton.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.exit;
            this.Exitbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Exitbutton.Location = new System.Drawing.Point(216, 333);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(122, 52);
            this.Exitbutton.TabIndex = 1;
            this.Exitbutton.UseVisualStyleBackColor = true;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // playbutton
            // 
            this.playbutton.BackColor = System.Drawing.Color.Transparent;
            this.playbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("playbutton.BackgroundImage")));
            this.playbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playbutton.Location = new System.Drawing.Point(216, 203);
            this.playbutton.Name = "playbutton";
            this.playbutton.Size = new System.Drawing.Size(122, 59);
            this.playbutton.TabIndex = 2;
            this.playbutton.UseVisualStyleBackColor = false;
            this.playbutton.Click += new System.EventHandler(this.playbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(3, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(610, 55);
            this.label1.TabIndex = 3;
            this.label1.Text = "THE IMPOSSIBLE GAME ";
            // 
            // Menuscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.ninja;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playbutton);
            this.Controls.Add(this.Exitbutton);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Menuscreen";
            this.Size = new System.Drawing.Size(616, 575);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exitbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button playbutton;
    }
}
