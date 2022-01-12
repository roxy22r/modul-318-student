namespace SwissTransport.Core
{
    using System.Threading.Tasks;
    using System;
    using SwissTransport.Models;

    public interface ITransport
    {
        Task<Stations> GetStationsAsync(string query);

        Stations GetStations(string query);

        Task<StationBoardRoot> GetStationBoardAsync(string station, string id);

        StationBoardRoot GetStationBoard(string station, string id);

        Task<Connections> GetConnectionsAsync(string fromStation, string toStation, DateTime date, DateTime time);

        Connections GetConnections(string fromStation, string toStation,DateTime date , DateTime time );
    }
}