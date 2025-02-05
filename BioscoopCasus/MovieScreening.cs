using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioscoopCasus
{
    internal class MovieScreening
    {

        private DateTime _dateAndTime;
        private double _pricePerSeat;
        private Movie _movie;

        public MovieScreening(Movie movie, DateTime dateAndTime, double pricePerSeat)
        {
            this._movie = movie;
            this._dateAndTime = dateAndTime;
            this._pricePerSeat = pricePerSeat;
        }

        public double GetPricePerSeat()
        {
            return this._pricePerSeat;
        }

        public DateTime GetDateAndTime()
        {
            return _dateAndTime;
        }

        public override string ToString()
        {
            return $"Movie: {_movie} - Date and time: {_dateAndTime} - Price: {_pricePerSeat}";
        }

    }
}
