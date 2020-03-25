﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGameLikeBO
{
    public abstract class Batiment : IDbEntity
    {
        [StringLength(20, MinimumLength = 5)]
        public string Nom { get; set; }

        [Range(0, Int32.MaxValue)]
        public int? niveau { get; set; }

        /**
         * Représente le nombre de case nécessaire au bâtiment pour exister. Chaque niveau du bâtiment demande +1 case pour pouvoir être construit.
         */
        public int? NombreCasesNecessaires()
        {
            return 0;
        }

        /**
         * Retourne la liste des ressources totale ayant permit la construction du bâtiment. 
         * Attention, un bâtiment peut ne pas avoir coûter d'énergie et/ou d'oxygène et/ou d'acier et/ou d'uranium.
         */
        public List<Ressource> coutTotal()
        {
            return null;
        }

        /**
         * Retourne la liste des ressources permettant la construction du niveau suivant. 
         * Attention, un bâtiment peut ne pas avoir coûter d'énergie et/ou d'oxygène et/ou d'acier et/ou d'uranium.
         */
        public List<Ressource> CoutSuivant()
        {
            return null;
        }
    }
}
