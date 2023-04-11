using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GdzieDojade
{
    internal partial class ConnectionPanel : UserControl
    {
        private Connection _connection;
        private Dictionary<int, string> _cities = new Dictionary<int, string>();
        private Dictionary<int, string> _transportTypes = new Dictionary<int, string>();

        internal ConnectionPanel(
            Connection connection, 
            Dictionary<int, string> cities, 
            Dictionary<int, string> transportTypes
        )
        {
            InitializeComponent();
            _connection = connection;
            _cities = cities;
            _transportTypes = transportTypes;
        }

        private void ConnectionPanel_Load(object sender, EventArgs e)
        {
            // Fill labels with data
            lblSource.Text = _cities[_connection.Source];
            lblDestination.Text = _cities[_connection.Destination];
            lblDistance.Text = _connection.Distance.ToString() + " Km";
            lblPrice.Text = _connection.Price.ToString() + " PLN";
            lblDepartureTime.Text = _connection.DepartureTime.ToString();
            lblArrivalTime.Text = _connection.ArrivalTime.ToString();
            lblTransportType.Text = _transportTypes[_connection.TransportType];
        }
    }
}
