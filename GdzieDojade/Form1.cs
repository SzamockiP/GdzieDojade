using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GdzieDojade
{
    public partial class MainForm : Form
    {
        private SearchConnectionControl _searchConnectionControl;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gdzieDojadeDBDataSet.Connections' table. You can move, or remove it, as needed.
            this.connectionsTableAdapter.Fill(this.gdzieDojadeDBDataSet.Connections);

            // Create connection string
            string connectionString = Properties.Settings.Default.GdzieDojadeDBConnectionString;

            // Create search connection control
            _searchConnectionControl = new SearchConnectionControl(connectionString);

            // Add search connection control to main panel
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(_searchConnectionControl);

        }

        private void btnOpenSearchConnectionPanel_Click(object sender, EventArgs e)
        {
            // If search connection control is already in main panel, don't do anything
            if(pnlMain.Controls.Count > 0 && pnlMain.Controls[0] == _searchConnectionControl)
                return;

            // Put search connection control to main panel
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(_searchConnectionControl);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void connectionsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.connectionsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gdzieDojadeDBDataSet);

        }
    }
}
