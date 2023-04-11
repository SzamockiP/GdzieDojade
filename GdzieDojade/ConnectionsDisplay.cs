using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GdzieDojade
{
    internal partial class ConnectionsDisplay : UserControl
    {
        private List<Connection> _path = new List<Connection>();
        private Dictionary<int, string> _cities = new Dictionary<int, string>();
        private Dictionary<int, string> _transportTypes = new Dictionary<int, string>();

        internal ConnectionsDisplay(
            List<Connection> path,
            Dictionary<int, string> cities,
            Dictionary< int, string> transportTypes
        )
        {
            InitializeComponent();
            _path = path;
            _cities = cities;
            _transportTypes = transportTypes;
        }

        private void ConnectionsDisplay_Load(object sender, EventArgs e)
        {
            
            foreach(Connection conn in _path)
            {
                // Insert into flpConnections connection panel
                flpConnections.Controls.Add(new ConnectionPanel(conn, _cities, _transportTypes));
            }
        }
    }
}
