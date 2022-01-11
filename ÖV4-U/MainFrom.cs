

using SwissTransport.Core;
using SwissTransport.Models;



namespace ÖV4_U
{
    public partial class MainFrom : Form
    {
        ITransport transport = new Transport();
        AutoCompleteStringCollection autoCompleteSource = new AutoCompleteStringCollection();
        public MainFrom()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            tbxFromStation.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            tbxToStation.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
           

        }
        private void btnSubmit(object sender, EventArgs e)
        {
                dgvRoot.Rows.Clear();
                trainInfoView.Rows.Clear();
            string fromStation = tbxFromStation.Text;
            string toStation = tbxToStation.Text;
                Connections connections = transport.GetConnections(fromStation, toStation);

                departureSchedule(fromStation, toStation, connections);
            setStationBoard(fromStation);
        }
        private void departureSchedule(string fromStation, string toStation, Connections connections)
        {

            foreach (Connection connect in connections.ConnectionList)
            {
                fromStation = connect.From.Station.Name;
                toStation = connect.To.Station.Name;
                String plattform = connect.From.Platform;
                string arival = connect.To.Arrival.Value.ToShortTimeString();
                string departs = connect.From.Departure.Value.ToShortTimeString();
                string durration = connect.Duration;
                this.trainInfoView.Rows.Add(plattform, fromStation, toStation, departs, arival, durration);
            }


        }
        private StationBoardRoot getRootStopps(String input)
        {
            Station mainStation = new Station();
            List<Station> stations = stationbyInput(input);
            foreach (Station station in stations)
            {
                if (station.Name.Equals(input))
                {
                    mainStation = station;
                    break;
                }
            }
            return transport.GetStationBoard(mainStation.Name, mainStation.Id);




        }

        private void setStationBoard(String input)
        {
            StationBoardRoot root = getRootStopps(input);
            foreach (StationBoard board in root.Entries)

            {
                dgvRoot.Rows.Add(input, board.To, board.Stop.Departure);

            }
        }

        private List<Connection> filterConnectionByTime(Connections connections)
        {
            List<Connection> filtertConnection = new List<Connection>();
            foreach (Connection connection in connections.ConnectionList)
            {
                if (connection.From.Departure.Value > timepicker.Value)
                {
                    filtertConnection.Add(connection);
                }
            }

            return filtertConnection;

        }




        private List<Station> stationbyInput(String input)
        {
            Stations stations = transport.GetStations(input);

            return stations.StationList;

        }




        private void SwitchFromToStation(object sender, EventArgs e)
        {
            String fromStation = Convert.ToString(tbxFromStation.Text);
            String toStation = Convert.ToString(tbxToStation.Text);
            tbxFromStation.Text = toStation;
            tbxToStation.Text = fromStation;
        }

        private void autoCompleteTo(object sender, EventArgs e)
        {

            String input = Convert.ToString(tbxToStation.Text);
            List<Station> stations = new List<Station>();
            while (input != "")
            {
                stations = stationbyInput(input);


                break;
            }
            foreach (Station station in stations)
            {
                tbxToStation.Items.Add(station.Name);
            }
        }
        private void autoCompleteFrom(object sender, EventArgs e)
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

    }


}
