using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceWeb2
{
    public class Mapping
    {
        private Personne personnage;
        Personne personne = new Personne();
        PersonneDto personne2 = new PersonneDto();

            
        private Partie partiee;
        Partie partie = new Partie();
        PartieDto partie2 = new PartieDto();

        private Monstre monstree;
        Monstre monstre = new Monstre();
        MonstreDto monstre2 = new MonstreDto();

        private Salle sallee;
        Salle salle = new Salle();
        SalleDto salle2 = new SalleDto();

        private Texte textee;
        Texte texte = new Texte();
        TexteDto texte2 = new TexteDto();

        private Objet objett;
        Objet objet = new Objet();
        ObjetDto objet2 = new ObjetDto();



        public Personne ToEntity(PersonneDto p)
        {
            personne.Id = p.Id;
            personne.Nom = p.Nom;
            personne.Pv = p.Pv;
            personne.Force = p.Force;
            personne.Dexterite = p.Dexterite;
            personne.Fuite = p.Fuite;
            personne.xp = p.Xp;
            personne.po = p.Po;
            return personne;
        }

        public PersonneDto toDto(Personne p)
        {
            personne2.Id = p.Id;
            personne2.Nom = p.Nom;
            return personne2;
        }

        public Partie ToEntity(PartieDto p)
        {
            partie.Id = p.Id;
            partie.id_personnage = p.Id_personnage;
            partie.salle_actuelle = p.Salle_actuelle;
            partie.difficulte = p.Difficulte;

            return partie;
        }

        public PartieDto toDto(Partie p)
        {
            partie2.Id = p.Id;
            partie2.Id_personnage = (int)p.id_personnage;
            partie2.Salle_actuelle = (int)p.salle_actuelle;
            partie2.Difficulte = (int)p.difficulte;
            return partie2;
        }

        public Monstre ToEntity(MonstreDto p)
        {
            monstre.Id = p.Id;
            monstre.nom = p.Nom;
            monstre.pv = p.Pv;
            monstre.force = (int)p.Force;
            monstre.dexterite =(int) p.Dexterite;
            monstre.drop_xp = p.Drop_xp;
            monstre.drop_argent = p.Drop_argent;
            monstre.proba_drop_argent = p.Proba_drop_argent;
            return monstre;
        }

        public MonstreDto toDto(Monstre p)
        {
            monstre2.Id = p.Id;
            monstre2.Nom = p.nom;
            monstre2.Pv = (int)p.pv;
            monstre2.Force = (int)p.force;
            monstre2.Dexterite = (int)p.dexterite;
            monstre2.Drop_xp =(int) p.drop_xp;
            monstre2.Drop_argent = (int)p.drop_argent;
            monstre2.Proba_drop_argent = (int) p.proba_drop_argent;
            return monstre2;
        }

        public Salle ToEntity(SalleDto p)
        {
            salle.Id = p.Id;
            salle.coordonneeX = p.coordonneeX;
            salle.coordonneeY = p.coordonneeY;
            salle.id_contenu = p.id_contenu;
            salle.type_contenu = p.type_contenu;
            salle.portes = p.portes;
            salle.etat = p.etat;
            salle.id_partie = p.id_partie;

            return salle;
        }


        public SalleDto toDto(Salle p)
        {
            salle2.Id = p.Id;
            salle2.coordonneeX = p.coordonneeX;
            salle2.coordonneeY = p.coordonneeY;
            salle2.id_contenu = p.id_contenu;
            salle2.type_contenu = p.type_contenu;
            salle2.portes = p.portes;
            salle2.etat = p.etat;
            salle2.id_partie = p.id_partie;
            return salle2;
        }

        public Texte ToEntity(TexteDto p)
        {
            texte.Id = p.Id;
            texte.type = p.type;
            texte.contenu = p.contenu;
           
            return texte;
        }


        public TexteDto toDto(Texte p)
        {
            texte2.Id = p.Id;
            texte2.type = p.type;
            texte2.contenu = p.contenu;
            return texte2;
        }

        public Objet ToEntity(ObjetDto p)
        {
            objet.Id = p.Id;
            objet.nom = p.nom;
            objet.description = p.description;
            objet.propriete_cible = p.propriete_cible;
            objet.montant = objet.montant;

            return objet;
        }


        public ObjetDto toDto(Objet p)
        {
            objet2.Id = p.Id;
            objet2.nom = p.nom;
            objet2.description = p.description;
            objet2.propriete_cible = p.propriete_cible;
            objet2.montant = objet.montant;

            return objet2;
        }
    }
}

