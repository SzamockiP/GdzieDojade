namespace GdzieDojade
{
    partial class ConnectionPanel
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
            this.lblSource = new System.Windows.Forms.Label();
            this.lblDestination = new System.Windows.Forms.Label();
            this.lblDistance = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDepartureTime = new System.Windows.Forms.Label();
            this.lblArrivalTime = new System.Windows.Forms.Label();
            this.lblTransportType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(31, 29);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(35, 13);
            this.lblSource.TabIndex = 0;
            this.lblSource.Text = "label1";
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Location = new System.Drawing.Point(109, 29);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(35, 13);
            this.lblDestination.TabIndex = 1;
            this.lblDestination.Text = "label2";
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Location = new System.Drawing.Point(179, 29);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(35, 13);
            this.lblDistance.TabIndex = 2;
            this.lblDistance.Text = "label3";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(243, 29);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(35, 13);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "label4";
            // 
            // lblDepartureTime
            // 
            this.lblDepartureTime.AutoSize = true;
            this.lblDepartureTime.Location = new System.Drawing.Point(322, 29);
            this.lblDepartureTime.Name = "lblDepartureTime";
            this.lblDepartureTime.Size = new System.Drawing.Size(35, 13);
            this.lblDepartureTime.TabIndex = 4;
            this.lblDepartureTime.Text = "label5";
            // 
            // lblArrivalTime
            // 
            this.lblArrivalTime.AutoSize = true;
            this.lblArrivalTime.Location = new System.Drawing.Point(399, 29);
            this.lblArrivalTime.Name = "lblArrivalTime";
            this.lblArrivalTime.Size = new System.Drawing.Size(35, 13);
            this.lblArrivalTime.TabIndex = 5;
            this.lblArrivalTime.Text = "label6";
            // 
            // lblTransportType
            // 
            this.lblTransportType.AutoSize = true;
            this.lblTransportType.Location = new System.Drawing.Point(475, 29);
            this.lblTransportType.Name = "lblTransportType";
            this.lblTransportType.Size = new System.Drawing.Size(35, 13);
            this.lblTransportType.TabIndex = 6;
            this.lblTransportType.Text = "label7";
            // 
            // ConnectionPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTransportType);
            this.Controls.Add(this.lblArrivalTime);
            this.Controls.Add(this.lblDepartureTime);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.lblDestination);
            this.Controls.Add(this.lblSource);
            this.Name = "ConnectionPanel";
            this.Size = new System.Drawing.Size(681, 106);
            this.Load += new System.EventHandler(this.ConnectionPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblDepartureTime;
        private System.Windows.Forms.Label lblArrivalTime;
        private System.Windows.Forms.Label lblTransportType;
    }
}
