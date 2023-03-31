using VideoGameStore;

using System.IO;

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

        public VideoGame[] GetVideoGames(out int nrGames)
        {
            VideoGame[] games = new VideoGame[NR_MAX_GAMES];

            
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                nrGames = 0;

                
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    games[nrGames++] = new VideoGame(linieFisier);
                }
            }

            return games;
        }
    }
}