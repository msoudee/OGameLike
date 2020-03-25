using System;
using System.Collections.Generic;

namespace OGameLikeBO.Batiments.Generateur
{
    class GenerateurDOxygene : GenerateurDeRessources
    {
        override public List<Ressource> coutTotal()
        {
            List<Ressource> res = new List<Ressource>();

            Ressource energie = new Ressource { Nom = TypeRessource.ENERGIE.ToString(), DerniereMAJ = DateTime.Now, DerniereQuantite = 0 };
            Ressource oxygene = new Ressource { Nom = TypeRessource.OXYGENE.ToString(), DerniereMAJ = DateTime.Now, DerniereQuantite = 0 };
            Ressource acier = new Ressource { Nom = TypeRessource.ACIER.ToString(), DerniereMAJ = DateTime.Now, DerniereQuantite = 0 };
            Ressource uranium = new Ressource { Nom = TypeRessource.URANIUM.ToString(), DerniereMAJ = DateTime.Now, DerniereQuantite = 0 };

            for(int nivTemp = 1; nivTemp <= Niveau; nivTemp++)
            {
                energie.DerniereQuantite += calculerCoutNiveauEnergie(nivTemp);
                oxygene.DerniereQuantite += calculerCoutNiveauOxygene(nivTemp);
                acier.DerniereQuantite += calculerCoutNiveauAcier(nivTemp);
                uranium.DerniereQuantite += calculerCoutNiveauUranium(nivTemp);
            }

            res.Add(energie);
            res.Add(oxygene);
            res.Add(acier);
            res.Add(uranium);

            return res;
        }

        override public List<Ressource> CoutSuivant()
        {

            List<Ressource> res = new List<Ressource>();

            res.Add(new Ressource { Nom = TypeRessource.ENERGIE.ToString(), DerniereMAJ = DateTime.Now, DerniereQuantite = calculerCoutNiveauEnergie(Niveau + 1) });
            res.Add(new Ressource { Nom = TypeRessource.OXYGENE.ToString(), DerniereMAJ = DateTime.Now, DerniereQuantite = calculerCoutNiveauOxygene(Niveau + 1) });
            res.Add(new Ressource { Nom = TypeRessource.ACIER.ToString(),   DerniereMAJ = DateTime.Now, DerniereQuantite = calculerCoutNiveauAcier(Niveau + 1) });
            res.Add(new Ressource { Nom = TypeRessource.URANIUM.ToString(), DerniereMAJ = DateTime.Now, DerniereQuantite = calculerCoutNiveauUranium(Niveau + 1) });

            return res;
        }
        override public List<Ressource> RessourcesParSecondes()
        {
            List<Ressource> res = new List<Ressource>();
            res.Add(new Ressource { Nom = TypeRessource.OXYGENE.ToString(), DerniereMAJ = DateTime.Now, DerniereQuantite = ((20 * (Niveau / 2)) + 5) });
            return res;
        }

        private int? calculerCoutNiveauEnergie(int? niv)
        {
            return niv;
        }

        private int? calculerCoutNiveauOxygene(int? niv)
        {
            return ((200 * (niv / 12)) + 20);
        }

        private int? calculerCoutNiveauAcier(int? niv)
        {
            return ((1000 * (niv / 8)) + 20);
        }

        private int? calculerCoutNiveauUranium(int? niv)
        {
            return ((1500 * (niv / 20)) + 20);
        }
    }
}
