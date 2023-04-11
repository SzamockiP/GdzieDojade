namespace GdzieDojade
{
    partial class ConnectionNotFoundDisplay
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
            this.lblConnectionNotFound = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblConnectionNotFound
            // 
            this.lblConnectionNotFound.AutoSize = true;
            this.lblConnectionNotFound.Location = new System.Drawing.Point(268, 218);
            this.lblConnectionNotFound.Name = "lblConnectionNotFound";
            this.lblConnectionNotFound.Size = new System.Drawing.Size(132, 13);
            this.lblConnectionNotFound.TabIndex = 0;
            this.lblConnectionNotFound.Text = "Nie znaleziono połączenia";
            // 
            // ConnectionNotFoundDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblConnectionNotFound);
            this.Name = "ConnectionNotFoundDisplay";
            this.Size = new System.Drawing.Size(681, 471);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConnectionNotFound;
    }
}
