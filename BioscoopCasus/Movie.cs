using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BioscoopCasus
{
    internal class Movie
    {

        private string _title;
        private List<MovieScreening> _screenings;

        public Movie(string title)
        {
            this._title = title;

            _screenings = new List<MovieScreening>();
        }

        public void AddScreening(MovieScreening screening)
        {
            _screenings.Add(screening);
        }

        override public string ToString()
        {
            return _title;
        }

    }
}
