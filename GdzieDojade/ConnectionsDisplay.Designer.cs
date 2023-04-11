namespace GdzieDojade
{
    partial class ConnectionsDisplay
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
            this.flpConnections = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpConnections
            // 
            this.flpConnections.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpConnections.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpConnections.Location = new System.Drawing.Point(0, 0);
            this.flpConnections.Name = "flpConnections";
            this.flpConnections.Size = new System.Drawing.Size(681, 471);
            this.flpConnections.TabIndex = 0;
            // 
            // ConnectionsDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flpConnections);
            this.Name = "ConnectionsDisplay";
            this.Size = new System.Drawing.Size(681, 471);
            this.Load += new System.EventHandler(this.ConnectionsDisplay_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpConnections;
    }
}
