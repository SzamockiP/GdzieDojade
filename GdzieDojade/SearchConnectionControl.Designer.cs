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
            this.clbTransportType = new System.Windows.Forms.CheckedListBox();
            this.cbxSearchType = new System.Windows.Forms.ComboBox();
            this.cbxSource = new System.Windows.Forms.ComboBox();
            this.cbxDestination = new System.Windows.Forms.ComboBox();
            this.pnlSearchData.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearchConnection
            // 
            this.btnSearchConnection.Location = new System.Drawing.Point(378, 52);
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
            this.pnlSearchData.Controls.Add(this.cbxDestination);
            this.pnlSearchData.Controls.Add(this.cbxSource);
            this.pnlSearchData.Controls.Add(this.cbxSearchType);
            this.pnlSearchData.Controls.Add(this.clbTransportType);
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
            // clbTransportType
            // 
            this.clbTransportType.FormattingEnabled = true;
            this.clbTransportType.Items.AddRange(new object[] {
            "Autobus",
            "Pociąg",
            "Samolot"});
            this.clbTransportType.Location = new System.Drawing.Point(536, 26);
            this.clbTransportType.Name = "clbTransportType";
            this.clbTransportType.Size = new System.Drawing.Size(120, 49);
            this.clbTransportType.TabIndex = 15;
            // 
            // cbxSearchType
            // 
            this.cbxSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSearchType.FormattingEnabled = true;
            this.cbxSearchType.Items.AddRange(new object[] {
            "Najszybsze",
            "Najtańsze",
            "Najkrótsze"});
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
            // SearchConnectionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlSearchData);
            this.Name = "SearchConnectionControl";
            this.Size = new System.Drawing.Size(681, 571);
            this.Load += new System.EventHandler(this.SearchConnectionControl_Load);
            this.pnlSearchData.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSearchConnection;
        private System.Windows.Forms.Panel pnlSearchData;
        private System.Windows.Forms.ComboBox cbxSearchType;
        private System.Windows.Forms.CheckedListBox clbTransportType;
        private System.Windows.Forms.DateTimePicker dtpDepartureTime;
        private System.Windows.Forms.ComboBox cbxDestination;
        private System.Windows.Forms.ComboBox cbxSource;
    }
}
