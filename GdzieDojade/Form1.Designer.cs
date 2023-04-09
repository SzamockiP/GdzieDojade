namespace GdzieDojade
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblReturn = new System.Windows.Forms.Label();
            this.lblSource = new System.Windows.Forms.Label();
            this.lblDestination = new System.Windows.Forms.Label();
            this.btnSearchConnection = new System.Windows.Forms.Button();
            this.numSourceId = new System.Windows.Forms.NumericUpDown();
            this.numDestinationId = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numSourceId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDestinationId)).BeginInit();
            this.SuspendLayout();
            // 
            // lblReturn
            // 
            this.lblReturn.AutoSize = true;
            this.lblReturn.Location = new System.Drawing.Point(13, 68);
            this.lblReturn.Name = "lblReturn";
            this.lblReturn.Size = new System.Drawing.Size(64, 13);
            this.lblReturn.TabIndex = 3;
            this.lblReturn.Text = "Połączenie:";
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(142, 12);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(14, 13);
            this.lblSource.TabIndex = 4;
            this.lblSource.Text = "Z";
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Location = new System.Drawing.Point(142, 34);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(21, 13);
            this.lblDestination.TabIndex = 5;
            this.lblDestination.Text = "Do";
            // 
            // btnSearchConnection
            // 
            this.btnSearchConnection.Location = new System.Drawing.Point(16, 85);
            this.btnSearchConnection.Name = "btnSearchConnection";
            this.btnSearchConnection.Size = new System.Drawing.Size(75, 23);
            this.btnSearchConnection.TabIndex = 6;
            this.btnSearchConnection.Text = "Wyszukaj";
            this.btnSearchConnection.UseVisualStyleBackColor = true;
            this.btnSearchConnection.Click += new System.EventHandler(this.btnSearchConnection_Click);
            // 
            // numSourceId
            // 
            this.numSourceId.Location = new System.Drawing.Point(16, 10);
            this.numSourceId.Name = "numSourceId";
            this.numSourceId.Size = new System.Drawing.Size(120, 20);
            this.numSourceId.TabIndex = 7;
            // 
            // numDestinationId
            // 
            this.numDestinationId.Location = new System.Drawing.Point(16, 32);
            this.numDestinationId.Name = "numDestinationId";
            this.numDestinationId.Size = new System.Drawing.Size(120, 20);
            this.numDestinationId.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numDestinationId);
            this.Controls.Add(this.numSourceId);
            this.Controls.Add(this.btnSearchConnection);
            this.Controls.Add(this.lblDestination);
            this.Controls.Add(this.lblSource);
            this.Controls.Add(this.lblReturn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSourceId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDestinationId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblReturn;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Button btnSearchConnection;
        private System.Windows.Forms.NumericUpDown numSourceId;
        private System.Windows.Forms.NumericUpDown numDestinationId;
    }
}

