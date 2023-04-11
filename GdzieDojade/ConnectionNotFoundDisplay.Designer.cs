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
            this.lblConnectionNotFound.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblConnectionNotFound.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnectionNotFound.Location = new System.Drawing.Point(0, 0);
            this.lblConnectionNotFound.Name = "lblConnectionNotFound";
            this.lblConnectionNotFound.Size = new System.Drawing.Size(681, 471);
            this.lblConnectionNotFound.TabIndex = 0;
            this.lblConnectionNotFound.Text = "Nie znaleziono połączenia";
            this.lblConnectionNotFound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConnectionNotFoundDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblConnectionNotFound);
            this.Name = "ConnectionNotFoundDisplay";
            this.Size = new System.Drawing.Size(681, 471);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblConnectionNotFound;
    }
}
