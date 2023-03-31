using System;
using System.Collections.Generic;


namespace VideoGameStore
{
    public class VideoGameStore
    {
        public List<VideoGame> Games { get; set; }

        public VideoGameStore()
        {
            Games = new List<VideoGame>();
        }

        public void AddGame(VideoGame game)
        {
            Games.Add(game);
        }

        public void RemoveGame(VideoGame game)
        {
            Games.Remove(game);
        }

        public List<VideoGame> SearchGamesByTitle(string keyword)
        {
            return Games;
        }

        public List<VideoGame> SearchGamesByGenre(string genre)
        {
            return Games;
        }

        public List<VideoGame> SearchGamesByPrice(double minPrice, double maxPrice)
        {
            return Games;
        }
    }
}
