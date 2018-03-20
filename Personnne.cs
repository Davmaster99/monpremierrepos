using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicing
{
    class Personne
    {
        private string name;
        private string surname;
        private bool sexe;
        private DateTime date_de_naissance;
        private string statut_marital;

        public Personne(string name, string surname, bool sexe, DateTime time,  string statut)
        {
            this.name = name;
            this.surname = surname;
            this.sexe = sexe;
            date_de_naissance = time;
            statut_marital = statut;
        }
        //Exo_8
        public Personne(string name, string surname, bool sexe, DateTime time)
        {
            this.name = name;
            this.surname = surname;
            this.sexe = sexe;
            date_de_naissance = time;
            statut_marital = "unknowned";
        }
        //Fin Exo_8
        public String Name
        {
            set { name = value; }
            get { return name; }
        }

        public String Surname
        {
            set { surname = value; }
            get { return surname; }
        }

        public String Statut_marital
        {
            set { statut_marital = value; }
            get { return statut_marital; }
        }

        public DateTime Date_de_naissance
        {
            set { date_de_naissance = value; }
            get { return date_de_naissance; }
        }

        public int Age
        {
            get {
                DateTime now = DateTime.Now;
                int age = now.Year - date_de_naissance.Year;
                if (date_de_naissance > now.AddYears(-age))
                    age--;
                return age;
            }
        }

        public int RetournerAgeEn( int anneeRef)
        {
            int age = 0;
            if (date_de_naissance.Year > anneeRef)
                return age = -1;
            else
            {
                age = anneeRef - date_de_naissance.Year;
                return age;
            }
        }
        public int RetournerAgeEn( DateTime anneeRef)
        {
            int age = 0;
            if (date_de_naissance.Year > anneeRef.Year)
                return age = -1;
            else
            {
                age = anneeRef.Year - date_de_naissance.Year;
                if (date_de_naissance > anneeRef.AddYears(-age))
                    age--;
                return age;
            }
        }

        public Boolean PlusVieuxQue( int ageRef )
        { 
            if(date_de_naissance.Year < ageRef)
                return true;
            else
                return false;
        }

        public Boolean PlusVieuxQue(Personne pRef )
        {
            int tmp = DateTime.Compare(date_de_naissance, pRef.date_de_naissance);
            if (tmp >= 0)
                return false;
            else
                return true;
                
        }

        public string String_message()
        {  
            if(sexe == true)
                return surname + " " + name + " est née en " + date_de_naissance.Year + ", il est " + statut_marital;
            else
                return surname + " " + name + " est née en " + date_de_naissance.Year + ", elle est " + statut_marital;
        }

        public new string ToString()
        {
            return Surname + " S'en bat les couilles Du ToString xD ";
        }


    }
}
