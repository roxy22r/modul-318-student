using SwissTransport.Core;
using SwissTransport.Models;



namespace ÖV4_U
{
    public partial class MainFrom : Form
    {
        ITransport transport = new Transport();

        public ITransport Transport { get => transport; set => transport = value; }

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
            string fromStation = tbxFromStation.Text;
            string toStation = tbxToStation.Text;
            if (fromStation != "" && toStation != "")
            {
                dgvRoot.Rows.Clear();
                trainInfoView.Rows.Clear();

                Connections connections = Transport.GetConnections(fromStation, toStation);
                connections.ConnectionList = filterConnectionByTime(connections);
                setConnection(fromStation, toStation, connections);
                setdepartureBoard(fromStation);
            }
            else {
                MessageBox.Show("Die Textfelder dürfen nicht leer sein!!!");
            }
        }
        private void setConnection(string fromStation, string toStation, Connections connections)
        {
            foreach (Connection connect in connections.ConnectionList)
            {
                fromStation = connect.From.Station.Name;
                toStation = connect.To.Station.Name;
                String plattform = connect.From.Platform;
                string arival = connect.To.Arrival.Value.ToString("dd/MM/yyyy HH:mm");
                string departs = connect.From.Departure.Value.ToString("dd/MM/yyyy HH:mm");
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
            return Transport.GetStationBoard(mainStation.Name, mainStation.Id);
        }

        private void setdepartureBoard(String input)
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
            foreach (Connection trainDeparturein  in connections.ConnectionList)
            {
                if (trainDeparturein.From.Departure.Value >=timepicker.Value)
                {
                    filtertConnection.Add(trainDeparturein);
                }
            }

            return filtertConnection;

        }

        private List<Station> stationbyInput(String input)
        {
            return Transport.GetStations(input).StationList;
        }
        private void SwitchFromToStation(object sender, EventArgs e)
        {
            String fromStaion=tbxFromStation.Text;
            tbxFromStation.Text = tbxToStation.Text;
            tbxToStation.Text = fromStaion;
        }

        private void autoCompleteTo(object sender, EventArgs e)
        {
            if (tbxToStation.Text!="") {
                List<Station> stations = new List<Station>();
                 stations = stationbyInput(tbxToStation.Text);
                foreach (Station station in stations)
                {
                    tbxToStation.Items.Add(station.Name);
                }
            }
        }
       
        private void departureBoard(object sender, EventArgs e)
        {
            if (tbxdepartureBoard.Text!="") {
                setdepartureBoard(tbxdepartureBoard.Text);
            }
            else
            {
                MessageBox.Show("Die Textfeld darf nicht leer sein!!!");
            }
        }

        private void autoCompleteFrom(object sender, EventArgs e)
        {
            if (tbxFromStation.Text != "")
            {
                List<Station> stations = new List<Station>();
                stations = stationbyInput(tbxFromStation.Text);
                foreach (Station station in stations)
                {
                    tbxFromStation.Items.Add(station.Name);
                }
            }
        }
    }


}
