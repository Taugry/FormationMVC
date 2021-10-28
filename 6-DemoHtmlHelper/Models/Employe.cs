using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _6_DemoHtmlHelper.Models
{
    public class Employe
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public double Salaire { get; set; }
        public bool IsActif { get; set; }
        public string Email { get; set; }
        public DateTime DateEntree { get; set; }
        public EmployeType Type { get; set; }
        //l'employe est lier a 1 departement
        public int DepartementId { get; set; }
    }

    public enum EmployeType
    {
        JUNIOR = 1,
        INTERMEDIAIRE = 2,
        SENIOR = 3,
    }
}