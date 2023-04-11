using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GdzieDojade
{
    public partial class SearchConnectionControl : UserControl
    {
        private List<Connection> _connections = new List<Connection>();
        private Dictionary<int, string> _cities = new Dictionary<int, string>();
        private Dictionary<string, int> _citiesInverted = new Dictionary<string, int>();
        private Dictionary<int, string> _transportTypes = new Dictionary<int, string>();
        private PathFinder _pathFinder;
        private string _sqlConnectionString;

        public SearchConnectionControl(string sqlConnectionString)
        {
            InitializeComponent();
            _sqlConnectionString = sqlConnectionString;
        }

        private void SearchConnectionControl_Load(object sender, EventArgs e)
        {
            // Connect to database and fill connections list
            using (SqlConnection connection = new SqlConnection(_sqlConnectionString))
            {
                try
                {
                    // Open the connection
                    connection.Open();

                    // Create command to get all connections
                    SqlCommand command = new SqlCommand("SELECT * FROM Connections", connection);
                    // Execute command
                    SqlDataReader reader = command.ExecuteReader();
                    // Read data
                    while (reader.Read())
                    {
                        // Get data
                        int id = (int)reader["Id"];
                        int source = (int)reader["Source"];
                        int destination = (int)reader["Destination"];
                        int distance = (int)reader["Distance"];
                        int price = (int)reader["Price"];
                        DateTime departure = (DateTime)reader["DepartureTime"];
                        DateTime arrival = (DateTime)reader["ArrivalTime"];
                        int transportType = (int)reader["TransportType"];
                        // Add connection to list
                        _connections.Add(new Connection(id, source, destination, distance, price, departure, arrival, transportType));
                    }
                    // Close reader
                    reader.Close();



                    // Create command to get all cities
                    command = new SqlCommand("SELECT * FROM Cities", connection);
                    // Execute command
                    reader = command.ExecuteReader();
                    // Read data
                    while (reader.Read())
                    {
                        // Get data
                        int id = (int)reader["Id"];
                        string name = (string)reader["Name"];
                        // Add city to dictionary
                        _cities.Add(id, name);
                    }
                    // Close reader
                    reader.Close();



                    // Create command to get all transport types
                    command = new SqlCommand("SELECT * FROM TransportTypes", connection);
                    // Execute command
                    reader = command.ExecuteReader();
                    // Read data
                    while (reader.Read())
                    {
                        // Get data
                        int id = (int)reader["Id"];
                        string name = (string)reader["Name"];
                        // Add transport type to dictionary
                        _transportTypes.Add(id, name);
                    }
                    // Close reader
                    reader.Close();



                    // Close the connection
                    connection.Close(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error connecting to the database", ex.Message);
                }
            }

            // Fill citiesInverted dictionary
            foreach (KeyValuePair<int, string> city in _cities)
            {
                _citiesInverted.Add(city.Value, city.Key);
            }

            // Fill cbxSource and cbxDestination comboboxes with cities
            foreach (KeyValuePair<int, string> city in _cities)
            {
                cbxSource.Items.Add(city.Value);
                cbxDestination.Items.Add(city.Value);
            }

            // Create path finder
            _pathFinder = new PathFinder(_connections, _cities, _transportTypes);

        }

        private void btnSearchConnection_Click(object sender, EventArgs e)
        {
            // Get cities id's
            int sourceId = (int)_citiesInverted[cbxSource.SelectedItem.ToString()];
            int destinationId = (int)_citiesInverted[cbxDestination.SelectedItem.ToString()];

            // Connect to database
            //using (SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=TravelAgency;Integrated Security=True"))
            //{
            //    connection.Open();
            //    // Create command
            //    SqlCommand command = new SqlCommand("SELECT * FROM Connections", connection);
            //    // Execute command
            //    SqlDataReader reader = command.ExecuteReader();
            //    // Read data
            //    while (reader.Read())
            //    {
            //        // Get data
            //        int id = (int)reader["Id"];
            //        int source = (int)reader["Source"];
            //        int destination = (int)reader["Destination"];
            //        int distance = (int)reader["Distance"];
            //        int price = (int)reader["Price"];
            //        DateTime departure = (DateTime)reader["Departure"];
            //        DateTime arrival = (DateTime)reader["Arrival"];
            //        int transportType = (int)reader["TransportType"];
            //        // Add connection to list
            //        _connections.Add(new Connection(id, source, destination, distance, price, departure, arrival, transportType));
            //    }
            //    // Close reader
            //    reader.Close();
            //    // Create command
            //    command = new SqlCommand("SELECT * FROM Cities", connection);
            //    // Execute command
            //    reader = command.ExecuteReader();
            //    // Read data
            //    while (reader.Read())
            //    {
            //        // Get data
            //        int id = (int)reader["Id"];
            //        string name = (string)reader["Name"];
            //        // Add city to dictionary
            //        _cities.Add(id, name);
            //    }
            //    // Close reader
            //    reader.Close();
            //    // Create command
            //    command = new SqlCommand("SELECT * FROM TransportTypes", connection);
            //    // Execute command
            //    reader = command.ExecuteReader();
            //    // Read data
            //    while (reader.Read())
            //    {
            //        // Get data
            //        int id = (int)reader["Id"];
            //        string name = (string)reader["Name"];
            //        // Add transport type to dictionary
            //        _transportTypes.Add(id, name);
            //    }
            //    // Close reader
            //    reader.Close();
            //}

            try
            {
                // Find path between two cities
                List<Connection> path = _pathFinder.FindPath(sourceId, destinationId, DateTime.Today);

                // Write path to console
                // _pathFinder.WritePath(path);
                //lblReturn.Text = _pathFinder.PathToString(path);

            }
            catch (Exception ex)
            {
                // Console.WriteLine(ex.Message);
                //lblReturn.Text = ex.Message;
            }
        }
    }
}
