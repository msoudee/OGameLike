﻿using System;
using System.Collections.Generic;

namespace OGameLikeBO.Batiments.Generateur
{
    class GenerateurDUranium : GenerateurDeRessources
    {
        override public List<Ressource> coutTotal()
        {
            List<Ressource> res = new List<Ressource>();

            Ressource energie = new Ressource { Nom = TypeRessource.ENERGIE.ToString(), DerniereMAJ = DateTime.Now, DerniereQuantite = 0 };
            Ressource oxygene = new Ressource { Nom = TypeRessource.OXYGENE.ToString(), DerniereMAJ = DateTime.Now, DerniereQuantite = 0 };
            Ressource acier = new Ressource { Nom = TypeRessource.ACIER.ToString(), DerniereMAJ = DateTime.Now, DerniereQuantite = 0 };

            for(int nivTemp = 1; nivTemp <= Niveau; nivTemp++)
            {
                energie.DerniereQuantite += calculerCoutNiveauEnergie(nivTemp);
                oxygene.DerniereQuantite += calculerCoutNiveauOxygene(nivTemp);
                acier.DerniereQuantite += calculerCoutNiveauAcier(nivTemp);
            }

            res.Add(energie);
            res.Add(oxygene);
            res.Add(acier);

            return res;
        }

        override public List<Ressource> CoutSuivant()
        {

            List<Ressource> res = new List<Ressource>();

            res.Add(new Ressource { Nom = TypeRessource.ENERGIE.ToString(), DerniereMAJ = DateTime.Now, DerniereQuantite = calculerCoutNiveauEnergie(Niveau + 1) });
            res.Add(new Ressource { Nom = TypeRessource.OXYGENE.ToString(), DerniereMAJ = DateTime.Now, DerniereQuantite = calculerCoutNiveauOxygene(Niveau + 1) });
            res.Add(new Ressource { Nom = TypeRessource.ACIER.ToString(),   DerniereMAJ = DateTime.Now, DerniereQuantite = calculerCoutNiveauAcier(Niveau + 1) });

            return res;
        }
        override public List<Ressource> RessourcesParSecondes()
        {
            List<Ressource> res = new List<Ressource>();
            res.Add(new Ressource { Nom = TypeRessource.OXYGENE.ToString(), DerniereMAJ = DateTime.Now, DerniereQuantite = (int)((7 * Math.Pow((double)Niveau, 3)) + 2) });
            return res;
        }

        private int? calculerCoutNiveauEnergie(int? niv)
        {
            return niv;
        }

        private int? calculerCoutNiveauOxygene(int? niv)
        {
            return (200 * (niv / 2)) + 20;
        }

        private int? calculerCoutNiveauAcier(int? niv)
        {
            return (100 * (niv / 3)) + 20;
        }
    }
}
