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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Connection> connections = new List<Connection>
            {
                // Connection parameters: id, source (city_id), destination (city_id), distance, price, departureTime, arrivalTime, transportType (transportType_id)

                // Connections between Gdansk and other cities
                new Connection(0, 0, 3, 150, 80, DateTime.Now.Date.AddMinutes(120), DateTime.Now.Date.AddMinutes(120 + 90), 0), // Gdansk - Bydgoszcz, bus
                new Connection(1, 0, 3, 150, 100, DateTime.Now.Date.AddMinutes(120), DateTime.Now.Date.AddMinutes(120 + 120), 1), // Gdansk - Bydgoszcz, plane
                new Connection(2, 0, 3, 150, 120, DateTime.Now.Date.AddMinutes(120), DateTime.Now.Date.AddMinutes(120 + 150), 2), // Gdansk - Bydgoszcz, train

                // Connections between Warszawa and other cities
                new Connection(3, 1, 2, 300, 100, DateTime.Now.Date.AddMinutes(0), DateTime.Now.Date.AddMinutes(0 + 180), 0), // Warszawa - Krakow, bus
                new Connection(4, 1, 2, 300, 200, DateTime.Now.Date.AddMinutes(0), DateTime.Now.Date.AddMinutes(0 + 240), 1), // Warszawa - Krakow, plane
                new Connection(5, 1, 2, 300, 300, DateTime.Now.Date.AddMinutes(0), DateTime.Now.Date.AddMinutes(0 + 300), 2) // Warszawa - Krakow, train
            };


            Dictionary<int, string> cities = new Dictionary<int, string>()
            {
                {0, "Gdańsk"},
                {1, "Warszawa"},
                {2, "Kraków"},
                {3, "Bydgoszcz"}
            };


            Dictionary<int, string> transportTypes = new Dictionary<int, string>()
            {
                {0, "Bus"},
                {1, "Plane"},
                {2, "Train"}
            };

            PathFinder pf = new PathFinder(connections, cities, transportTypes);

            try
            {
                // Find path between two cities
                List<Connection> path = pf.FindPath(1, 2, DateTime.Today, 2);

                // Write path to console
                //pf.WritePath(path);
                lblReturn.Text = pf.PathToString(path);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                lblReturn.Text = ex.Message;
            }

            // Console test
            Console.WriteLine("Test");

        }
    }
}
