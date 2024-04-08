using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class Song
    {
        private int minutes;//0-14
        private int seconds;//0-59
        private string name;//3-30 chars
        private string artist;//2-20 chars

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                if (value.Length >= 3 && value.Length <= 30)
                {
                    this.name = value;
                }
                else
                {
                    throw new InvalidSongNameException();
                }
            }
        }

        public string Artist
        {
            get
            {
                return artist;
            }

            set
            {
                if (value.Length >= 2 && value.Length <= 20)
                {
                    this.artist = value;
                }
                else
                {
                    throw new InvalidArtistNameException();
                }
            }
        }

        public int Minutes
        {
            get { return minutes; }
            set
            {
                if (value > 0 && value <= 14)
                {
                    this.minutes = value;
                }
                else
                {
                    throw new InvalidMinutesException();
                }

            }
        }


        public int Seconds
        {
            get { return seconds; }
            set
            {
                if (value > 0 && value < 59)
                {
                    this.seconds = value;
                }
                else
                {
                    throw new InvalidSecondsException();
                }
            }
        }
    }
}
