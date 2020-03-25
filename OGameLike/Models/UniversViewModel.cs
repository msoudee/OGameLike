using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OGameLike.Models
{
    public class UniversViewModel
    {
        public int NombreSystemesSolaires { get; set; }

        public int NombrePlanetesParSystemes { get; set; }

        public List<SelectListItem> RessourcesDisponibles { get; set; }

        public List<string> RessourcesSelectionnees { get; set; }

        public List<SelectListItem> BatimentsDisponibles { get; set; }

        public List<string> BatimentsSelectionnes { get; set; }
    }
}