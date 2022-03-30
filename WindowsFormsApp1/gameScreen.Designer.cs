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
            this.help = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameTImer
            // 
            this.gameTImer.Enabled = true;
            this.gameTImer.Interval = 20;
            this.gameTImer.Tick += new System.EventHandler(this.gameTImer_Tick);
            // 
            // help
            // 
            this.help.AutoSize = true;
            this.help.BackColor = System.Drawing.Color.Transparent;
            this.help.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.help.Location = new System.Drawing.Point(669, 451);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(197, 29);
            this.help.TabIndex = 0;
            this.help.Text = "YOU GOT THIS";
            this.help.Visible = false;
            this.help.Click += new System.EventHandler(this.label1_Click);
            // 
            // gameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.defualt;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.help);
            this.DoubleBuffered = true;
            this.Name = "gameScreen";
            this.Size = new System.Drawing.Size(1023, 600);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.gameScreen_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameScreen_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.gameScreen_PreviewKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gameTImer;
        private System.Windows.Forms.Label help;
    }
}
