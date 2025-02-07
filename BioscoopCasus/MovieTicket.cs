using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BioscoopCasus
{
    public class MovieTicket
    {
        [JsonInclude]
        [JsonPropertyName("rowNr")]
        private int _rowNr;

        [JsonInclude]
        [JsonPropertyName("seatNr")]
        private int _seatNr;
        
        [JsonInclude]
        [JsonPropertyName("isPremium")]
        private bool _isPremium;
        
        [JsonInclude]
        [JsonPropertyName("movieScreening")]
        private MovieScreening _movieScreening;

        public MovieTicket(MovieScreening movieScreening, bool isPremiumReservation, int seatRow, int seatNr)
        {
            this._movieScreening = movieScreening;
            this._isPremium = isPremiumReservation;
            this._rowNr = seatRow;
            this._seatNr = seatNr;
        }

        public bool IsPremiumTicket()
        {
            return this._isPremium;
        }

        public double GetPrice()
        {
            return _movieScreening.GetPricePerSeat();
        }

        public DateTime GetDateAndTime()
        {
            return _movieScreening.GetDateAndTime();
        }

        public override string ToString()
        {
            return $"Screening: {_movieScreening} - Row number: {_rowNr} - Seat number: {_seatNr}";
        }

    }
}
