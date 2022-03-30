namespace WindowsFormsApp1
{
    partial class Winscreen
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
            this.Exitbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Exitbutton
            // 
            this.Exitbutton.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.exit;
            this.Exitbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Exitbutton.Location = new System.Drawing.Point(215, 177);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(120, 76);
            this.Exitbutton.TabIndex = 2;
            this.Exitbutton.UseVisualStyleBackColor = true;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // Winscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.winscreen;
            this.Controls.Add(this.Exitbutton);
            this.Name = "Winscreen";
            this.Size = new System.Drawing.Size(805, 312);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Exitbutton;
    }
}
