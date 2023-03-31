using System;


namespace VideoGameStore
{
    public class VideoGame
    {
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';

        public int IdGame = 0;
        public string Title { get; set; }
        public string Publisher { get; set; }
        public string Developer { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public double Price { get; set; }

        public VideoGame(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);

           
            IdGame = Convert.ToInt32(dateFisier[0]);
            Title = dateFisier[1];
        }

        public VideoGame( int idGame, string title, string publisher="", string developer="", string genre="", double price=0.00)
        {
            IdGame = idGame; 
            Title = title;
            Publisher = publisher;
            Developer = developer;
            Genre = genre;
            Price = price;
        }
        public void Info()
        {
            Console.WriteLine(IdGame + " " + Title);
        }

        public string ConversieLaSir_PentruFisier()
        {
            string obiectGamePentruFisier = string.Format("{1}{0}{2}{0}",
                SEPARATOR_PRINCIPAL_FISIER,
                IdGame.ToString(),
                Title ?? " NECUNOSCUT "
                );

            return obiectGamePentruFisier;
        }
    }
}
