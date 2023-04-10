namespace GdzieDojade
{
    partial class SearchConnectionControl
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
            this.numSourceId = new System.Windows.Forms.NumericUpDown();
            this.lblReturn = new System.Windows.Forms.Label();
            this.numDestinationId = new System.Windows.Forms.NumericUpDown();
            this.lblSource = new System.Windows.Forms.Label();
            this.lblDestination = new System.Windows.Forms.Label();
            this.btnSearchConnection = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numSourceId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDestinationId)).BeginInit();
            this.SuspendLayout();
            // 
            // numSourceId
            // 
            this.numSourceId.Location = new System.Drawing.Point(44, 46);
            this.numSourceId.Name = "numSourceId";
            this.numSourceId.Size = new System.Drawing.Size(120, 20);
            this.numSourceId.TabIndex = 13;
            // 
            // lblReturn
            // 
            this.lblReturn.AutoSize = true;
            this.lblReturn.Location = new System.Drawing.Point(41, 104);
            this.lblReturn.Name = "lblReturn";
            this.lblReturn.Size = new System.Drawing.Size(64, 13);
            this.lblReturn.TabIndex = 9;
            this.lblReturn.Text = "Połączenie:";
            // 
            // numDestinationId
            // 
            this.numDestinationId.Location = new System.Drawing.Point(44, 68);
            this.numDestinationId.Name = "numDestinationId";
            this.numDestinationId.Size = new System.Drawing.Size(120, 20);
            this.numDestinationId.TabIndex = 14;
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(170, 48);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(14, 13);
            this.lblSource.TabIndex = 10;
            this.lblSource.Text = "Z";
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Location = new System.Drawing.Point(170, 70);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(21, 13);
            this.lblDestination.TabIndex = 11;
            this.lblDestination.Text = "Do";
            // 
            // btnSearchConnection
            // 
            this.btnSearchConnection.Location = new System.Drawing.Point(44, 121);
            this.btnSearchConnection.Name = "btnSearchConnection";
            this.btnSearchConnection.Size = new System.Drawing.Size(75, 23);
            this.btnSearchConnection.TabIndex = 12;
            this.btnSearchConnection.Text = "Wyszukaj";
            this.btnSearchConnection.UseVisualStyleBackColor = true;
            this.btnSearchConnection.Click += new System.EventHandler(this.btnSearchConnection_Click);
            // 
            // SearchConnectionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.numSourceId);
            this.Controls.Add(this.lblReturn);
            this.Controls.Add(this.numDestinationId);
            this.Controls.Add(this.lblSource);
            this.Controls.Add(this.lblDestination);
            this.Controls.Add(this.btnSearchConnection);
            this.Name = "SearchConnectionControl";
            this.Size = new System.Drawing.Size(802, 516);
            this.Load += new System.EventHandler(this.SearchConnectionControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSourceId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDestinationId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numSourceId;
        private System.Windows.Forms.Label lblReturn;
        private System.Windows.Forms.NumericUpDown numDestinationId;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Button btnSearchConnection;
    }
}
