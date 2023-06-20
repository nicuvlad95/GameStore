using VideoGameStore;

using System.IO;
using System.Configuration;
using System.Collections.Generic;

namespace NivelStocareDate
{
    public class AdministrareGames_FisierText
    {
        private const int NR_MAX_GAMES = 50;
        private string numeFisier;

        

        public AdministrareGames_FisierText(string numeFisier)
        {
            this.numeFisier = numeFisier;
            
            Stream streamFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }

        public void AddGame(VideoGame game)
        {
            game.IdGame = GetId();
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, true))
            {
                streamWriterFisierText.WriteLine(game.ConversieLaSir_PentruFisier());
            }
        }

        public List<VideoGame> GetVideoGames( int nrGames)
        {
            List<VideoGame> games = new List<VideoGame>();
       
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                nrGames = 10;

                
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    VideoGame game = new VideoGame(linieFisier);
                    games.Add(game);
                }
            }

            return games;
        }
        private int GetId()
        {
            int IdGame = 0;

            
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;

                
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    VideoGame game = new VideoGame(linieFisier);
                    IdGame = game.IdGame+1;
                }
            }

            return IdGame;
        }
    }
}