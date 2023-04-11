// Tak, sam napisałem praktycznie cały kod
// Tak, potrafię go wyjaśnić
// Tak, wolę komentować po angielsku
// Tak, dijkstra boli
// Tak, pisałem to 2 dni
// Tak, stworzyłem ze 2 prototypy w pythonie
// Tak, przepisywałem ten kod z pythona kilka razy za każdym razem zaczynając od nowa
// Tak, nie wiem jak to napisać lepiej
// Tak, jest skalowalny więc można go użyć do większych grafów i w innych projektach

// Pozdrawiam Pana Dyrektora B)

// Usage notes:
// 1. To use this class, you need to create a new instance of it and pass it 3 dictionaries:
//      // Initialize PathFinder class
//      PathFinder pf = new PathFinder(connections, cities, transportTypes);
//
// 2. To find a path between two cities, use FindPath() method:
//      // Find path between two cities
//      try
//      {   
//          // Find path between two cities
//          List<Connection> path = pf.FindPath(0, 3, DateTime.Today.AddDays(2), 2);
//      
//          // Write path to console
//          pf.WritePath(path);
//      }
//      catch(Exception ex)
//      {
//          Console.WriteLine(ex.Message);
//      }
//
// 3. Dictionaries should be in format:
//      Dictionary<int, string> cities = new Dictionary<int, string>()
//      {
//          {0, "Warszawa"},
//          {1, "Kraków"},
//          {2, "Gdańsk"},
//          {3, "Poznań"}
//      };
//      
//      Dictionary<int, string> transportTypes = new Dictionary<int, string>()
//      {
//          {0, "Bus"},
//          {1, "Plane"},
//          {2, "Train"}
//      };
//
// 4. Connections should be in format:
//      List<Connection> connections = new List<Connection>();
//      // Connection parameters: id, source (city_id), destination (city_id), distance, price, departureTime, arrivalTime, transportType (transportType_id)
//
//      // Connections between Gdansk and other cities
//      connections.Add(new Connection(0,0, 3, 150, 80, DateTime.Now.Date.AddMinutes(120), DateTime.Now.Date.AddMinutes(120 + 90),  0)); // Gdansk - Bydgoszcz, bus
//      connections.Add(new Connection(1,0, 3, 150, 100, DateTime.Now.Date.AddMinutes(120), DateTime.Now.Date.AddMinutes(120 + 120),  1)); // Gdansk - Bydgoszcz, plane
//      connections.Add(new Connection(2,0, 3, 150, 120, DateTime.Now.Date.AddMinutes(120), DateTime.Now.Date.AddMinutes(120 + 150),  2)); // Gdansk - Bydgoszcz, train
//
//      // Connections between Warszawa and other cities
//      connections.Add(new Connection(3,1, 2, 300, 100, DateTime.Now.Date.AddMinutes(0), DateTime.Now.Date.AddMinutes(0 + 180),  0)); // Warszawa - Krakow, bus
//      connections.Add(new Connection(4,1, 2, 300, 200, DateTime.Now.Date.AddMinutes(0), DateTime.Now.Date.AddMinutes(0 + 240),  1)); // Warszawa - Krakow, plane
//      connections.Add(new Connection(5,1, 2, 300, 300, DateTime.Now.Date.AddMinutes(0), DateTime.Now.Date.AddMinutes(0 + 300),  2)); // Warszawa - Krakow, train
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GdzieDojade
{
    internal class PathFinder
    {
        private Dictionary<int, string> _cities;
        private List<Connection> _connections;
        private Dictionary<int, string> _transportTypes;

        // Constructor
        public PathFinder(List<Connection> connections, Dictionary<int, string> cities, Dictionary<int, string> transportTypes)
        {
            _cities = cities;
            _connections = connections;
            _transportTypes = transportTypes;
        }

        // Setters for variables
        public void SetCities(Dictionary<int, string> cities)
        {
            _cities = cities;
        }
        public void SetConnections(List<Connection> connections)
        {
            _connections = connections;
        }
        public void SetTransportTypes(Dictionary<int, string> transportTypes)
        {
            _transportTypes = transportTypes;
        }

        // Driver for path finding algorithm

        /// <summary>
        /// Finds shortest path between two cities   <paramref name="pathFindType"/> 0 - shortest, 1 - cheapest, 2 - fastest, other - shortest
        /// </summary>
        /// <param name="pathFindType"></param>
        /// <returns></returns>
        public List<Connection> FindPath(int source, int destination, DateTime startTime, int pathFindType = 0)
        {
            if (!_cities.ContainsKey(source))
                // if source is not in cities, throw exception
                throw new Exception("Invalid source");

            if (!_cities.ContainsKey(destination))
                // if destination is not in cities, throw exception
                throw new Exception("Invalid destination");

            if (source == destination)
                // if destination is the same as source
                throw new Exception("Departure can't be the same as destination");

            try
            {
                switch (pathFindType)
                {
                    case 0: // Shortest
                        return FindShortestConnectionsPath(source, destination, startTime);
                    case 1: // Cheapest
                        return FindCheapestConnectionsPath(source, destination, startTime);
                    case 2: // Fastest
                        return FindFastestConnectionsPath(source, destination, startTime);
                    default: // Shortest
                        return FindShortestConnectionsPath(source, destination, startTime);
                }
            }
            // If there is no path, throw exception
            catch (Exception ex) { throw new Exception(ex.Message); }
            
        }

        // Writes connectionsPath to the console
        public void WritePath(List<Connection> connectionsPath)
        {
            Console.WriteLine("Path:");
            Console.WriteLine("Id\tSource -> Destination\tDistance\tPrice\tDeparture Time\t\tArrival Time\t\tTransport Type");
            Console.WriteLine(PathToString(connectionsPath));
        }

        // Stringify connections Path
        public string PathToString(List<Connection> connectionsPath)
        {
            StringBuilder pathString = new StringBuilder();
            for (int i=0; i < connectionsPath.Count; i++)
            {
                pathString.Append(connectionsPath[i].ToString(_cities, _transportTypes));
                if(i < connectionsPath.Count - 1) pathString.Append("\n");
            }
            return pathString.ToString();
        }

        // Dijkstra algorithm
        private List<int> Dijkstra(int[,] adjacencyMatrix, int source, int destination)
        {
            // Initialize values for dijkstra
            int[] value = new int[_cities.Count];
            bool[] visited = new bool[_cities.Count];
            int[] previous = new int[_cities.Count];

            // Fill values above
            // values to inf
            // visited nodes to null
            // previous to none
            for (int i = 0; i < _cities.Count; i++)
            {
                value[i] = int.MaxValue;
                visited[i] = false;
                previous[i] = -1;
            }

            // Distance from source to source is set to zero
            value[source] = 0;

            // Magic that I'd like to not explain
            for (int i = 0; i < _cities.Count - 1; i++)
            {
                // Find closest node to current
                int min = int.MaxValue;
                int minIndex = -1;
                for (int j = 0; j < _cities.Count; j++)
                {
                    if (!visited[j] && value[j] <= min)
                    {
                        min = value[j];
                        minIndex = j;
                    }
                }

                // Mark closest node as visited
                visited[minIndex] = true;

                // Sus
                for (int j = 0; j < _cities.Count; j++)
                {
                    if (!visited[j] && adjacencyMatrix[minIndex, j] != 0 && value[minIndex] != int.MaxValue && value[minIndex] + adjacencyMatrix[minIndex, j] < value[j])
                    {
                        value[j] = value[minIndex] + adjacencyMatrix[minIndex, j];
                        previous[j] = minIndex;
                    }
                }
            }
            // Init list of cities id's
            List<int> path = new List<int>();
            // Set current location to destination
            int current = destination;

            // Iterate over previous nodes to get back from destination to source while adding nodes to path
            while (current != -1)
            {
                path.Add(current);
                current = previous[current];
            }

            // Reverse path to get from source to destination
            path.Reverse();
            return path;
        }

        // Create adjacency matrix for Dijkstra algorithm using Price 
        private int[,] CreateAdjacencyMatrixPrice()
        {
            int[,] adjacencyMatrix = new int[_cities.Count, _cities.Count];

            foreach (var connection in _connections)
            {
                // ensure that the Price is the lowest for the connection
                if (connection.Price < adjacencyMatrix[connection.Source, connection.Destination] || adjacencyMatrix[connection.Source, connection.Destination] == 0)
                    adjacencyMatrix[connection.Source, connection.Destination] = connection.Price;
            }
            return adjacencyMatrix;
        }

        // Create adjacency matrix for Dijkstra algorithm using distance
        private int[,] CreateAdjacencyMatrixDistance()
        {
            int[,] adjacencyMatrix = new int[_cities.Count, _cities.Count];
            foreach (var connection in _connections)
            {
                if (connection.Distance < adjacencyMatrix[connection.Source, connection.Destination] || adjacencyMatrix[connection.Source, connection.Destination] == 0)
                    adjacencyMatrix[connection.Source, connection.Destination] = connection.Distance;
            }
            return adjacencyMatrix;
        }

        // Create adjacency ,atrix for Dijkstra algorithm using time
        private int[,] CreateAdjacencyMatrixTime()
        {
            int[,] adjacencyMatrix = new int[_cities.Count, _cities.Count];
            foreach (var connection in _connections)
            {
                if (connection.ArrivalTime.Subtract(connection.DepartureTime).TotalMinutes < adjacencyMatrix[connection.Source, connection.Destination] || adjacencyMatrix[connection.Source, connection.Destination] == 0)
                    adjacencyMatrix[connection.Source, connection.Destination] = Int32.Parse(connection.ArrivalTime.Subtract(connection.DepartureTime).TotalMinutes.ToString());
            }
            return adjacencyMatrix;
        }

        // Write adjacency matrix to console
        private void WriteAdjacencyMatrix(int[,] adjacencyMatrix)
        {
            for (int i = 0; i < _cities.Count; i++)
            {
                for (int j = 0; j < _cities.Count; j++)
                {
                    Console.Write(adjacencyMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        // Find connections between two cities
        private List<Connection> FindConnections(int source, int destination, DateTime startTime)
        {
            // Find all connections between source and destination that depart after startTime
            var connections = _connections.Where(c => c.Source == source && c.Destination == destination && c.DepartureTime >= startTime).ToList();
            if (connections.Count == 0)
                throw new Exception("No connection found");

            return connections;
        }

        // Find fastest path between two cities, taking time into account, returns list of connections, takes path of city id's as input
        // NOTE: Does NOT take transfer time into account
        private List<Connection> FindFastestConnectionsPath(int source, int destination, DateTime startTime)
        {
            // Create adjacency matrix for lowest Time
            int[,] adjacencyMatrix = CreateAdjacencyMatrixTime();

            // Find path using Dijkstra's algorithm, returns list of city id's
            List<int> path = Dijkstra(adjacencyMatrix, source, destination);
            if (path.Count == 0)
                throw new Exception("No connection found");

            List<Connection> connectionsPath = new List<Connection>();
            DateTime currentTime = startTime;

            for (int i = 0; i < path.Count - 1; i++)
            {
                // find connections between two cities
                List<Connection> connections = new List<Connection>();
                try
                {
                    connections = FindConnections(path[i], path[i + 1], currentTime);
                }
                catch (Exception ex) { throw new Exception(ex.Message);}

                // set fastestConnection to first aveilable connection
                Connection fastestConneciton = connections[0];

                for (int j = 0; j < connections.Count; j++)
                {
                    // find the fastest connection in connections
                    if (fastestConneciton.DepartureTime > connections[j].DepartureTime)
                    {
                        fastestConneciton = connections[j];
                    }
                }

                connectionsPath.Add(fastestConneciton);
                currentTime = fastestConneciton.ArrivalTime;
            }
            return connectionsPath;
        }

        // Find cheapest path between two cities, returns list of connections, takes path of city id's as input
        private List<Connection> FindCheapestConnectionsPath(int source, int destination, DateTime startTime)
        {
            // Create adjacency matrix for lowest Price
            int[,] adjacencyMatrix = CreateAdjacencyMatrixPrice();

            // Find path using Dijkstra's algorithm, returns list of city id's
            List<int> path = Dijkstra(adjacencyMatrix, source, destination);
            if (path.Count == 0)
                throw new Exception("No connection found");

            List<Connection> connectionsPath = new List<Connection>();
            DateTime currentTime = startTime;

            for (int i = 0; i < path.Count - 1; i++)
            {
                // find connections between two cities
                List<Connection> connections = new List<Connection>();
                try
                {
                    connections = FindConnections(path[i], path[i + 1], currentTime);
                }
                catch(Exception ex) { throw new Exception(ex.Message); }

                // set cheapestConnection to first aveilable connection
                Connection cheapestConnection = connections[0];

                for (int j = 0; j < connections.Count; j++)
                {
                    // if the connection is cheaper than the previous one, set this as new connection
                    if (connections[j].Price < cheapestConnection.Price)
                    {
                        cheapestConnection = connections[j];
                    }
                }
                // Add cheapest connection to the path
                connectionsPath.Add(cheapestConnection);
                currentTime = cheapestConnection.ArrivalTime;
            }
            return connectionsPath;
        }

        // Find shortest path between two cities, return list of connections, takes path of city id's as input
        private List<Connection> FindShortestConnectionsPath(int source, int destination, DateTime startTime)
        {
            // Create adjacency matrix for lowest distance
            int[,] adjacencyMatrix = CreateAdjacencyMatrixDistance();


            // Find path using Dijkstra's algorithm, returns list of city id's
            List<int> path = Dijkstra(adjacencyMatrix, source, destination);
            if(path.Count == 1 )
                throw new Exception("No connection found");


            List<Connection> connectionsPath = new List<Connection>();
            DateTime currentTime = startTime;


            for (int i = 0; i < path.Count - 1; i++)
            {
                // find connections between two cities
                List<Connection> connections = new List<Connection>();
                try
                {
                    connections = FindConnections(path[i], path[i + 1], currentTime);
                }
                catch(Exception ex) { Console.WriteLine(ex.Message); throw new Exception(ex.Message); }

                // set shortestConnection to first aveilable connection
                Connection shortestConnection = connections[0];

                for (int j = 0; j < connections.Count; j++)
                {
                    // if the connection is earlier than the previous one, set this as new connection
                    if (connections[j].Distance < shortestConnection.Distance)
                    {
                        shortestConnection = connections[j];
                    }
                }
                // Add shortest connection to the path
                connectionsPath.Add(shortestConnection);
                currentTime = shortestConnection.ArrivalTime;
            }
            return connectionsPath;
        }
    }
}