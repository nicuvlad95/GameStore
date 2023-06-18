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
                nrGames = 0;

                
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    games.Add(new VideoGame(linieFisier));
                }
            }

            return games;
        }
    }
}