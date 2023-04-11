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
            this.btnSearchConnection = new System.Windows.Forms.Button();
            this.pnlSearchData = new System.Windows.Forms.Panel();
            this.dtpDepartureTime = new System.Windows.Forms.DateTimePicker();
            this.clbTransportTypes = new System.Windows.Forms.CheckedListBox();
            this.cbxSearchType = new System.Windows.Forms.ComboBox();
            this.cbxSource = new System.Windows.Forms.ComboBox();
            this.cbxDestination = new System.Windows.Forms.ComboBox();
            this.pnlConnectionResponse = new System.Windows.Forms.Panel();
            this.pnlConnectionControl = new System.Windows.Forms.Panel();
            this.btnBookConnection = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSummaryDepartureTime = new System.Windows.Forms.Label();
            this.lblSummaryArrivalTime = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSummaryPrice = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.pnlSearchData.SuspendLayout();
            this.pnlConnectionControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearchConnection
            // 
            this.btnSearchConnection.Location = new System.Drawing.Point(382, 17);
            this.btnSearchConnection.Name = "btnSearchConnection";
            this.btnSearchConnection.Size = new System.Drawing.Size(75, 23);
            this.btnSearchConnection.TabIndex = 12;
            this.btnSearchConnection.Text = "Wyszukaj";
            this.btnSearchConnection.UseVisualStyleBackColor = true;
            this.btnSearchConnection.Click += new System.EventHandler(this.btnSearchConnection_Click);
            // 
            // pnlSearchData
            // 
            this.pnlSearchData.BackColor = System.Drawing.Color.LightYellow;
            this.pnlSearchData.Controls.Add(this.btnChange);
            this.pnlSearchData.Controls.Add(this.cbxDestination);
            this.pnlSearchData.Controls.Add(this.cbxSource);
            this.pnlSearchData.Controls.Add(this.cbxSearchType);
            this.pnlSearchData.Controls.Add(this.clbTransportTypes);
            this.pnlSearchData.Controls.Add(this.btnSearchConnection);
            this.pnlSearchData.Controls.Add(this.dtpDepartureTime);
            this.pnlSearchData.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearchData.Location = new System.Drawing.Point(0, 0);
            this.pnlSearchData.Name = "pnlSearchData";
            this.pnlSearchData.Size = new System.Drawing.Size(681, 100);
            this.pnlSearchData.TabIndex = 15;
            // 
            // dtpDepartureTime
            // 
            this.dtpDepartureTime.Location = new System.Drawing.Point(176, 16);
            this.dtpDepartureTime.Name = "dtpDepartureTime";
            this.dtpDepartureTime.Size = new System.Drawing.Size(200, 20);
            this.dtpDepartureTime.TabIndex = 0;
            // 
            // clbTransportTypes
            // 
            this.clbTransportTypes.FormattingEnabled = true;
            this.clbTransportTypes.Location = new System.Drawing.Point(463, 17);
            this.clbTransportTypes.Name = "clbTransportTypes";
            this.clbTransportTypes.Size = new System.Drawing.Size(120, 49);
            this.clbTransportTypes.TabIndex = 15;
            // 
            // cbxSearchType
            // 
            this.cbxSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSearchType.FormattingEnabled = true;
            this.cbxSearchType.Location = new System.Drawing.Point(176, 42);
            this.cbxSearchType.Name = "cbxSearchType";
            this.cbxSearchType.Size = new System.Drawing.Size(121, 21);
            this.cbxSearchType.TabIndex = 16;
            // 
            // cbxSource
            // 
            this.cbxSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSource.FormattingEnabled = true;
            this.cbxSource.Location = new System.Drawing.Point(23, 15);
            this.cbxSource.Name = "cbxSource";
            this.cbxSource.Size = new System.Drawing.Size(121, 21);
            this.cbxSource.TabIndex = 17;
            // 
            // cbxDestination
            // 
            this.cbxDestination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDestination.FormattingEnabled = true;
            this.cbxDestination.Location = new System.Drawing.Point(23, 43);
            this.cbxDestination.Name = "cbxDestination";
            this.cbxDestination.Size = new System.Drawing.Size(121, 21);
            this.cbxDestination.TabIndex = 18;
            // 
            // pnlConnectionResponse
            // 
            this.pnlConnectionResponse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlConnectionResponse.Location = new System.Drawing.Point(0, 100);
            this.pnlConnectionResponse.Name = "pnlConnectionResponse";
            this.pnlConnectionResponse.Size = new System.Drawing.Size(681, 471);
            this.pnlConnectionResponse.TabIndex = 16;
            // 
            // pnlConnectionControl
            // 
            this.pnlConnectionControl.Controls.Add(this.lblSummaryPrice);
            this.pnlConnectionControl.Controls.Add(this.label5);
            this.pnlConnectionControl.Controls.Add(this.lblSummaryArrivalTime);
            this.pnlConnectionControl.Controls.Add(this.lblSummaryDepartureTime);
            this.pnlConnectionControl.Controls.Add(this.label2);
            this.pnlConnectionControl.Controls.Add(this.label1);
            this.pnlConnectionControl.Controls.Add(this.btnBookConnection);
            this.pnlConnectionControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlConnectionControl.Location = new System.Drawing.Point(0, 471);
            this.pnlConnectionControl.Name = "pnlConnectionControl";
            this.pnlConnectionControl.Size = new System.Drawing.Size(681, 100);
            this.pnlConnectionControl.TabIndex = 0;
            // 
            // btnBookConnection
            // 
            this.btnBookConnection.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookConnection.Location = new System.Drawing.Point(12, 25);
            this.btnBookConnection.Name = "btnBookConnection";
            this.btnBookConnection.Size = new System.Drawing.Size(105, 49);
            this.btnBookConnection.TabIndex = 0;
            this.btnBookConnection.Text = "Kup";
            this.btnBookConnection.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wyjazd:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(171, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Przyjazd:";
            // 
            // lblSummaryDepartureTime
            // 
            this.lblSummaryDepartureTime.AutoSize = true;
            this.lblSummaryDepartureTime.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummaryDepartureTime.Location = new System.Drawing.Point(267, 54);
            this.lblSummaryDepartureTime.Name = "lblSummaryDepartureTime";
            this.lblSummaryDepartureTime.Size = new System.Drawing.Size(68, 30);
            this.lblSummaryDepartureTime.TabIndex = 3;
            this.lblSummaryDepartureTime.Text = "label3";
            // 
            // lblSummaryArrivalTime
            // 
            this.lblSummaryArrivalTime.AutoSize = true;
            this.lblSummaryArrivalTime.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummaryArrivalTime.Location = new System.Drawing.Point(267, 15);
            this.lblSummaryArrivalTime.Name = "lblSummaryArrivalTime";
            this.lblSummaryArrivalTime.Size = new System.Drawing.Size(68, 30);
            this.lblSummaryArrivalTime.TabIndex = 4;
            this.lblSummaryArrivalTime.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(505, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 30);
            this.label5.TabIndex = 5;
            this.label5.Text = "Cena:";
            // 
            // lblSummaryPrice
            // 
            this.lblSummaryPrice.AutoSize = true;
            this.lblSummaryPrice.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummaryPrice.Location = new System.Drawing.Point(571, 54);
            this.lblSummaryPrice.Name = "lblSummaryPrice";
            this.lblSummaryPrice.Size = new System.Drawing.Size(68, 30);
            this.lblSummaryPrice.TabIndex = 6;
            this.lblSummaryPrice.Text = "label6";
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(23, 71);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(121, 23);
            this.btnChange.TabIndex = 19;
            this.btnChange.Text = "Zamień";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // SearchConnectionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlConnectionControl);
            this.Controls.Add(this.pnlConnectionResponse);
            this.Controls.Add(this.pnlSearchData);
            this.Name = "SearchConnectionControl";
            this.Size = new System.Drawing.Size(681, 571);
            this.Load += new System.EventHandler(this.SearchConnectionControl_Load);
            this.pnlSearchData.ResumeLayout(false);
            this.pnlConnectionControl.ResumeLayout(false);
            this.pnlConnectionControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSearchConnection;
        private System.Windows.Forms.Panel pnlSearchData;
        private System.Windows.Forms.ComboBox cbxSearchType;
        private System.Windows.Forms.CheckedListBox clbTransportTypes;
        private System.Windows.Forms.DateTimePicker dtpDepartureTime;
        private System.Windows.Forms.ComboBox cbxDestination;
        private System.Windows.Forms.ComboBox cbxSource;
        private System.Windows.Forms.Panel pnlConnectionResponse;
        private System.Windows.Forms.Panel pnlConnectionControl;
        private System.Windows.Forms.Button btnBookConnection;
        private System.Windows.Forms.Label lblSummaryPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSummaryArrivalTime;
        private System.Windows.Forms.Label lblSummaryDepartureTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChange;
    }
}
