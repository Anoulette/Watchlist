namespace Watchlist.Data
{
    public class FilmUtilisateur
    {
        // La propriété IdUtilisateur correspond à la propriété Id de la classe Utilisateur, qu'elle a héritée de IdentityUser
        // La propriété IdFilm correspond à la propriété Id de la classe Film
        public string IdUtilisateur { get; set; }
        public int IdFilm { get; set; }
        public bool Vu { get; set; }
        public int Note { get; set; }

        // ces 2 autres propriétés utilisent le mot clé virtual
        // elles représentent la relation entre l'objet FilmUtilisateur et les objets Utilisateur et Film
        public virtual Utilisateur User { get; set; }
        public virtual Film Film { get; set; }
    }
}
