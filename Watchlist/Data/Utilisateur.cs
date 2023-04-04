namespace Watchlist.Data
{
    public class Utilisateur : Microsoft.AspNetCore.Identity.IdentityUser
    {
        // Elle doit disposer d'un constructeur qui appelle le constructeur de l'objet hérité
        public Utilisateur() : base()
        {
            this.ListeFilms = new HashSet<FilmUtilisateur>();
        }

        public string Prenom { get; set; }

        // propriété virtuelle pour représenter la liste des films de l'utilisateur
        // Il s'agit d'une collection ou d'une liste d'objets FilmUtilisateur
        // et plus précisément, de tous les objets FilmUtilisateur contenant l'identifiant de l'utilisateur
        public virtual ICollection<FilmUtilisateur> ListeFilms { get; set; }
    }
}

// nous n'avons pas ajouté d'objet DbSet pour la classe Utilisateur
// cela est dû au fait qu'il existe déjà une table AspNetUsers dans la base de données

// Puisque nous avons créé la classe Utilisateur qui hérite de la classe IdentityUser
// tout ce que vous ajoutez à Utilisateur sera automatiquement traduit dans la table AspNetUsers de la base de données
