using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPIU
{
    public class VideoGame
    {
        public string Title { get; set; }
        public string Publisher { get; set; }
        public string Developer { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public double Price { get; set; }

        public VideoGame(string title, string publisher, string developer, DateTime releaseDate, string genre, double price)
        {
            Title = title;
            Publisher = publisher;
            Developer = developer;
            ReleaseDate = releaseDate;
            Genre = genre;
            Price = price;
        }
    }
}
