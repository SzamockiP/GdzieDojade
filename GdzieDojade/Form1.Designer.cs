namespace GdzieDojade
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.pnlNavBar = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpenSearchConnectionPanel = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.gdzieDojadeDBDataSet = new GdzieDojade.GdzieDojadeDBDataSet();
            this.connectionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.connectionsTableAdapter = new GdzieDojade.GdzieDojadeDBDataSetTableAdapters.ConnectionsTableAdapter();
            this.tableAdapterManager = new GdzieDojade.GdzieDojadeDBDataSetTableAdapters.TableAdapterManager();
            this.pnlNavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdzieDojadeDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlNavBar
            // 
            this.pnlNavBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
            this.pnlNavBar.Controls.Add(this.btnClose);
            this.pnlNavBar.Controls.Add(this.btnOpenSearchConnectionPanel);
            this.pnlNavBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlNavBar.Location = new System.Drawing.Point(681, 0);
            this.pnlNavBar.Name = "pnlNavBar";
            this.pnlNavBar.Size = new System.Drawing.Size(223, 571);
            this.pnlNavBar.TabIndex = 9;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClose.Location = new System.Drawing.Point(0, 531);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(223, 40);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Zamknij";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // btnOpenSearchConnectionPanel
            // 
            this.btnOpenSearchConnectionPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnOpenSearchConnectionPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOpenSearchConnectionPanel.FlatAppearance.BorderSize = 0;
            this.btnOpenSearchConnectionPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenSearchConnectionPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenSearchConnectionPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOpenSearchConnectionPanel.Location = new System.Drawing.Point(0, 0);
            this.btnOpenSearchConnectionPanel.Name = "btnOpenSearchConnectionPanel";
            this.btnOpenSearchConnectionPanel.Size = new System.Drawing.Size(223, 40);
            this.btnOpenSearchConnectionPanel.TabIndex = 0;
            this.btnOpenSearchConnectionPanel.Text = "Wyszukiwarka Połączeń";
            this.btnOpenSearchConnectionPanel.UseVisualStyleBackColor = false;
            this.btnOpenSearchConnectionPanel.Click += new System.EventHandler(this.btnOpenSearchConnectionPanel_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(681, 571);
            this.pnlMain.TabIndex = 10;
            // 
            // gdzieDojadeDBDataSet
            // 
            this.gdzieDojadeDBDataSet.DataSetName = "GdzieDojadeDBDataSet";
            this.gdzieDojadeDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // connectionsBindingSource
            // 
            this.connectionsBindingSource.DataMember = "Connections";
            this.connectionsBindingSource.DataSource = this.gdzieDojadeDBDataSet;
            // 
            // connectionsTableAdapter
            // 
            this.connectionsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ConnectionsTableAdapter = this.connectionsTableAdapter;
            this.tableAdapterManager.UpdateOrder = GdzieDojade.GdzieDojadeDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 571);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlNavBar);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(920, 610);
            this.MinimumSize = new System.Drawing.Size(920, 610);
            this.Name = "MainForm";
            this.Text = "GdzieDojade";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlNavBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdzieDojadeDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlNavBar;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnOpenSearchConnectionPanel;
        private System.Windows.Forms.Button btnClose;
        private GdzieDojadeDBDataSet gdzieDojadeDBDataSet;
        private System.Windows.Forms.BindingSource connectionsBindingSource;
        private GdzieDojadeDBDataSetTableAdapters.ConnectionsTableAdapter connectionsTableAdapter;
        private GdzieDojadeDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}

