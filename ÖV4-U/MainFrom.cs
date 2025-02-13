using SwissTransport.Core;
using SwissTransport.Models;
using Microsoft.Web.WebView2.Core;



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
            map("Schweiz");
        }
        private void btnSubmit(object sender, EventArgs e)
        {
            string fromStation = tbxFromStation.Text;
            string toStation = tbxToStation.Text;
            if (fromStation != "" && toStation != "")
            {
                dgvRoot.Rows.Clear();
                trainInfoView.Rows.Clear();

                Connections connections = Transport.GetConnections(fromStation, toStation,datepicker.Value.Date,timepicker.Value);
             
                setConnection(fromStation, toStation, connections);
                setdepartureBoard(fromStation);
                map(fromStation);
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
                
                string durration = connect.Duration;
                this.trainInfoView.Rows.Add(plattform, fromStation, toStation, connect.From.Departure.Value, connect.To.Arrival.Value.Date, durration);
            }
        }
     
        private void setdepartureBoard(String input)
        {
            StationBoardRoot root = Transport.GetStationBoard(input,"id");
            foreach (StationBoard board in root.Entries)
            {
                dgvRoot.Rows.Add(input, board.To, board.Stop.Departure);

            }
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

        private void autoCompleteDepartureBoard(object sender, EventArgs e)
        {
            if (tbxFromStation.Text != "")
            {
                List<Station> stations = new List<Station>();
                stations = stationbyInput(tbxdepartureBoard.Text);
                foreach (Station station in stations)
                {
                    tbxdepartureBoard.Items.Add(station.Name);
                }
            }
        }

        private void map(String fromStation) {
           List<Station>station =stationbyInput(fromStation);
            webView.Source =new Uri("https://www.openstreetmap.org/search?query="+fromStation);
        }

    }


}
