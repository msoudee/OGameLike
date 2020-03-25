using System.Collections.Generic;

namespace OGameLikeBO
{
    public abstract class GenerateurDeRessources : Batiment
    {
        /**
         * Retourne la somme calculée en fonction du niveau du bâtiment de type "GenerateurDeRessource" 
         * pour un seul bâtiment donné pour plusieurs ressources de nom différent.
         */
        public virtual List<Ressource> RessourcesParSecondes()
        {
            return null;
        }
    }
}
