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
    public partial class Form1 : Form
    {
        private List<Connection> _connections = new List<Connection>();
        private Dictionary<int, string> _cities = new Dictionary<int, string>();
        private Dictionary<int, string> _transportTypes = new Dictionary<int, string>();
        private PathFinder _pathFinder;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Add connections to the array
            for (int day = 1; day <= 14; day++)
            {
                // Connections between Gdansk and other cities
                _connections.Add(new Connection(((31 * (day - 1)) + 0), 0, 2, 500, 150, DateTime.Now.Date.AddMinutes(60).AddDays(day - 1), DateTime.Now.Date.AddMinutes(60 + 240).AddDays(day - 1), 0)); // Gdansk - Wroclaw, bus
                _connections.Add(new Connection(((31 * (day - 1)) + 1), 0, 2, 500, 250, DateTime.Now.Date.AddMinutes(60).AddDays(day - 1), DateTime.Now.Date.AddMinutes(60 + 300).AddDays(day - 1), 1)); // Gdansk - Krakow, plane
                _connections.Add(new Connection(((31 * (day - 1)) + 2), 0, 2, 500, 350, DateTime.Now.Date.AddMinutes(60).AddDays(day - 1), DateTime.Now.Date.AddMinutes(60 + 360).AddDays(day - 1), 2)); // Gdansk - Krakow, train

                _connections.Add(new Connection(((31 * (day - 1)) + 3), 0, 3, 150, 80, DateTime.Now.Date.AddMinutes(120).AddDays(day - 1), DateTime.Now.Date.AddMinutes(120 + 90).AddDays(day - 1), 0)); // Gdansk - Bydgoszcz, bus
                _connections.Add(new Connection(((31 * (day - 1)) + 4), 0, 3, 150, 100, DateTime.Now.Date.AddMinutes(120).AddDays(day - 1), DateTime.Now.Date.AddMinutes(120 + 120).AddDays(day - 1), 1)); // Gdansk - Bydgoszcz, plane
                _connections.Add(new Connection(((31 * (day - 1)) + 5), 0, 3, 150, 120, DateTime.Now.Date.AddMinutes(120).AddDays(day - 1), DateTime.Now.Date.AddMinutes(120 + 150).AddDays(day - 1), 2)); // Gdansk - Bydgoszcz, train

                // Connections between Warszawa and other cities
                _connections.Add(new Connection(((31 * (day - 1)) + 6), 1, 2, 300, 100, DateTime.Now.Date.AddMinutes(0).AddDays(day - 1), DateTime.Now.Date.AddMinutes(0 + 180).AddDays(day - 1), 0)); // Warszawa - Krakow, bus
                _connections.Add(new Connection(((31 * (day - 1)) + 7), 1, 2, 300, 200, DateTime.Now.Date.AddMinutes(0).AddDays(day - 1), DateTime.Now.Date.AddMinutes(0 + 240).AddDays(day - 1), 1)); // Warszawa - Krakow, plane
                _connections.Add(new Connection(((31 * (day - 1)) + 8), 1, 2, 300, 300, DateTime.Now.Date.AddMinutes(0).AddDays(day - 1), DateTime.Now.Date.AddMinutes(0 + 300).AddDays(day - 1), 2)); // Warszawa - Krakow, train

                _connections.Add(new Connection(((31 * (day - 1)) + 9), 1, 3, 200, 80, DateTime.Now.Date.AddMinutes(60).AddDays(day - 1), DateTime.Now.Date.AddMinutes(60 + 90).AddDays(day - 1), 0)); // Warszawa - Bydgoszcz, bus
                _connections.Add(new Connection(((31 * (day - 1)) + 10), 1, 3, 200, 100, DateTime.Now.Date.AddMinutes(60).AddDays(day - 1), DateTime.Now.Date.AddMinutes(60 + 120).AddDays(day - 1), 1)); // Warszawa - Bydgoszcz, plane
                _connections.Add(new Connection(((31 * (day - 1)) + 11), 1, 3, 200, 120, DateTime.Now.Date.AddMinutes(60).AddDays(day - 1), DateTime.Now.Date.AddMinutes(60 + 150).AddDays(day - 1), 2)); // Warszawa - Bydgoszcz, train

                _connections.Add(new Connection(((31 * (day - 1)) + 12), 1, 4, 400, 150, DateTime.Now.Date.AddMinutes(120).AddDays(day - 1), DateTime.Now.Date.AddMinutes(120 + 240).AddDays(day - 1), 0)); // Warszawa - Slupsk, bus
                _connections.Add(new Connection(((31 * (day - 1)) + 13), 1, 4, 400, 250, DateTime.Now.Date.AddMinutes(120).AddDays(day - 1), DateTime.Now.Date.AddMinutes(120 + 300).AddDays(day - 1), 1)); // Warszawa - Slupsk, plane
                _connections.Add(new Connection(((31 * (day - 1)) + 14), 1, 4, 400, 350, DateTime.Now.Date.AddMinutes(120).AddDays(day - 1), DateTime.Now.Date.AddMinutes(120 + 360).AddDays(day - 1), 2)); // Warszawa - Slupsk, train

                // Connections between Krakow and other cities
                _connections.Add(new Connection(((31 * (day - 1)) + 15), 2, 3, 400, 100, DateTime.Now.Date.AddMinutes(0).AddDays(day - 1), DateTime.Now.Date.AddMinutes(0 + 180).AddDays(day - 1), 0)); // Krakow - Bydgoszcz, bus
                _connections.Add(new Connection(((31 * (day - 1)) + 16), 2, 3, 400, 200, DateTime.Now.Date.AddMinutes(0).AddDays(day - 1), DateTime.Now.Date.AddMinutes(0 + 240).AddDays(day - 1), 1)); // Krakow - Bydgoszcz, plane
                _connections.Add(new Connection(((31 * (day - 1)) + 17), 2, 3, 400, 300, DateTime.Now.Date.AddMinutes(0).AddDays(day - 1), DateTime.Now.Date.AddMinutes(0 + 300).AddDays(day - 1), 2)); // Krakow - Bydgoszcz, train

                _connections.Add(new Connection(((31 * (day - 1)) + 18), 2, 5, 150, 80, DateTime.Now.Date.AddMinutes(60).AddDays(day - 1), DateTime.Now.Date.AddMinutes(60 + 90).AddDays(day - 1), 0)); // Krakow - Wroclaw, bus
                _connections.Add(new Connection(((31 * (day - 1)) + 19), 2, 5, 150, 100, DateTime.Now.Date.AddMinutes(60).AddDays(day - 1), DateTime.Now.Date.AddMinutes(60 + 120).AddDays(day - 1), 1)); // Krakow - Wroclaw, plane
                _connections.Add(new Connection(((31 * (day - 1)) + 20), 2, 5, 150, 120, DateTime.Now.Date.AddMinutes(60).AddDays(day - 1), DateTime.Now.Date.AddMinutes(60 + 150).AddDays(day - 1), 2)); // Krakow - Wroclaw, train

                // Connections between Bydgoszcz and other cities
                _connections.Add(new Connection(((31 * (day - 1)) + 21), 3, 4, 250, 100, DateTime.Now.Date.AddMinutes(0).AddDays(day - 1), DateTime.Now.Date.AddMinutes(0 + 180).AddDays(day - 1), 0)); // Bydgoszcz - Slupsk, bus
                _connections.Add(new Connection(((31 * (day - 1)) + 22), 3, 4, 250, 200, DateTime.Now.Date.AddMinutes(0).AddDays(day - 1), DateTime.Now.Date.AddMinutes(0 + 240).AddDays(day - 1), 1)); // Bydgoszcz - Slupsk, plane
                _connections.Add(new Connection(((31 * (day - 1)) + 23), 3, 4, 250, 300, DateTime.Now.Date.AddMinutes(0).AddDays(day - 1), DateTime.Now.Date.AddMinutes(0 + 300).AddDays(day - 1), 2)); // Bydgoszcz - Slupsk, train

                _connections.Add(new Connection(((31 * (day - 1)) + 24), 3, 5, 300, 1000, DateTime.Now.Date.AddMinutes(60).AddDays(day - 1), DateTime.Now.Date.AddMinutes(60 + 90).AddDays(day - 1), 0)); // Bydgoszcz - Wroclaw, bus
                _connections.Add(new Connection(((31 * (day - 1)) + 25), 3, 5, 300, 100, DateTime.Now.Date.AddMinutes(60).AddDays(day - 1), DateTime.Now.Date.AddMinutes(60 + 120).AddDays(day - 1), 1)); // Bydgoszcz - Wroclaw, plane
                _connections.Add(new Connection(((31 * (day - 1)) + 26), 3, 5, 300, 120, DateTime.Now.Date.AddMinutes(60).AddDays(day - 1), DateTime.Now.Date.AddMinutes(60 + 150).AddDays(day - 1), 2)); // Bydgoszcz - Wroclaw, train

                // Connections between Slupsk and other cities
                _connections.Add(new Connection(((31 * (day - 1)) + 27), 4, 5, 350, 100, DateTime.Now.Date.AddMinutes(0).AddDays(day - 1), DateTime.Now.Date.AddMinutes(0 + 180).AddDays(day - 1), 0)); // Slupsk - Wroclaw, bus
                _connections.Add(new Connection(((31 * (day - 1)) + 28), 4, 5, 350, 200, DateTime.Now.Date.AddMinutes(0).AddDays(day - 1), DateTime.Now.Date.AddMinutes(0 + 240).AddDays(day - 1), 1)); // Slupsk - Wroclaw, plane
                _connections.Add(new Connection(((31 * (day - 1)) + 29), 4, 5, 350, 300, DateTime.Now.Date.AddMinutes(0).AddDays(day - 1), DateTime.Now.Date.AddMinutes(0 + 300).AddDays(day - 1), 2)); // Slupsk - Wroclaw, train

                // Connections between Wroclaw and other cities
                _connections.Add(new Connection(((31 * (day - 1)) + 30), 5, 1, 350, 100, DateTime.Now.Date.AddMinutes(0).AddDays(day - 1), DateTime.Now.Date.AddMinutes(0 + 180).AddDays(day - 1), 0)); // Wroclaw - Warszawa, bus
            }


            _cities = new Dictionary<int, string>()
            {
                {0, "Gdańsk"},
                {1, "Warszawa"},
                {2, "Kraków"},
                {3, "Bydgoszcz"},
                {4, "Słupsk"},
                {5, "Wrocław"}
            };


            _transportTypes = new Dictionary<int, string>()
            {
                {0, "Bus"},
                {1, "Plane"},
                {2, "Train"}
            };


            _pathFinder = new PathFinder(_connections, _cities, _transportTypes);
        }

        private void btnSearchConnection_Click(object sender, EventArgs e)
        {
            // Get cities id's
            int sourceId = (int) numSourceId.Value;
            int destinationId = (int) numDestinationId.Value;

            try
            {
                // Find path between two cities
                List<Connection> path = _pathFinder.FindPath(sourceId, destinationId, DateTime.Today);

                // Write path to console
                // _pathFinder.WritePath(path);
                lblReturn.Text = _pathFinder.PathToString(path);

            }
            catch (Exception ex)
            {
                // Console.WriteLine(ex.Message);
                lblReturn.Text = ex.Message;
            }
        }
    }
}
