

using SwissTransport.Core;
using SwissTransport.Models;



namespace ÖV4_U
{
    public partial class MainFrom : Form
    {
            ITransport transport = new Transport();
        public MainFrom()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        { 

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {

                string fromStation = Convert.ToString(tbxFromStation.Text);
                string toStation = Convert.ToString(tbxToStation.Text);
                DateTime dateTime=Convert.ToDateTime(InputdateTime.Text);
                Connections connections = transport.GetConnections(fromStation, toStation);
                connections.ConnectionList =   filterConnectionByTimr(connections,dateTime);
              
                departureSchedule(fromStation, toStation, connections);
            }
            catch { 
            }
         }
        private void departureSchedule(string fromStation, string toStation, Connections connections) {
            
                foreach (Connection connect in connections.ConnectionList)
                {
                    fromStation = connect.From.Station.Name;
                    toStation = connect.To.Station.Name;
                    String plattform=connect.From.Platform;
                    string arival =  connect.To.Arrival.Value.ToShortTimeString();
                    string departs = connect.From.Departure.Value.ToShortTimeString();
              
                    string durration = connect.Duration;
                this.trainInfoView.Rows.Add(plattform,fromStation,toStation,departs,arival,durration);
            }
            
           
        }

        private List<Connection> filterConnectionByTimr(Connections connections,DateTime dateTime) {
            List<Connection> filtertConnection = new List<Connection>();
            foreach (Connection connection in connections.ConnectionList) {
                if (connection.From.Departure<dateTime) {
                    filtertConnection.Add(connection);
                }
            }
            return filtertConnection;
        
        }

    
      

        private List<Station> stationbyInput(String input) {
       Stations stations=     transport.GetStations(input);
            
            return stations.StationList;
       
        }

  
        private void to_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String input = Convert.ToString(tbxFromStation.Text);
                List<Station> stations = new List<Station>();
                while (input != "")
                {
                    stations = stationbyInput(input);


                    break;
                }
                foreach (Station station in stations)
                {
                    tbxFromStation.Items.Add(station.Name);
                }
            }
            catch { 
            }

        }

        
        private void from_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String input = Convert.ToString(tbxToStation.Text);
                List<Station> stations = new List<Station>();
                while (null != input && input != "")
                {
                    stations = stationbyInput(input);


                    break;
                }
                foreach (Station station in stations)
                {
                   
                    tbxToStation.Items.Add(station.Name);
                }
            }
            catch
            {


            }

        }

     
        }


        
    
}
