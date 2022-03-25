namespace WindowsFormsApp1
{
    partial class gameScreen
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
            this.components = new System.ComponentModel.Container();
            this.gameTImer = new System.Windows.Forms.Timer(this.components);
            this.fortnite = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.fortnite)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTImer
            // 
            this.gameTImer.Enabled = true;
            this.gameTImer.Interval = 10;
            this.gameTImer.Tick += new System.EventHandler(this.gameTImer_Tick);
            // 
            // fortnite
            // 
            this.fortnite.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.fortnitereals;
            this.fortnite.Location = new System.Drawing.Point(142, 354);
            this.fortnite.Name = "fortnite";
            this.fortnite.Size = new System.Drawing.Size(34, 22);
            this.fortnite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fortnite.TabIndex = 0;
            this.fortnite.TabStop = false;
            // 
            // gameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fortnite);
            this.DoubleBuffered = true;
            this.Name = "gameScreen";
            this.Size = new System.Drawing.Size(600, 600);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.gameScreen_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameScreen_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.gameScreen_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.fortnite)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer gameTImer;
        private System.Windows.Forms.PictureBox fortnite;
    }
}
