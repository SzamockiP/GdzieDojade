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

        private void Form1_Load(object sender, EventArgs e)
        {
            // Create connection string
            string connectionString = "Data Source=.;Initial Catalog=Connections;Integrated Security=True";

            // Create search connection control
            _searchConnectionControl = new SearchConnectionControl(connectionString);

            // Add search connection control to main panel
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(_searchConnectionControl);

        }
    }
}
