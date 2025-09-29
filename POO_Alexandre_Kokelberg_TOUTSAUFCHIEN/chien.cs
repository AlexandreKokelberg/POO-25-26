using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Alexandre_Kokelberg_TOUTSAUFCHIEN
{
    internal class chien
    {
        private string _race;
        private string _pelage;
        private double _taille;
        private double _poids;
        private bool _agressivite;
        private bool _sociabilite;
        private string _tag;
        private double _age;
        public chien(string race, string pelage, double taille, double poids, bool agressivite, bool sociabilite, string tag, double age)
        {
            _race = race;
            _pelage = pelage;
            _taille = taille;
            _poids = poids;
            _agressivite = agressivite;
            _sociabilite = sociabilite;
            _tag = tag;
            _age = age;
        }
        public string Manger(string nouriture)
        {
            return "Le chien a mangé " + nouriture;
        }
        public string Dormir(double secondes)
        {
            string[] mesure = ["secondes", "minutes", "heures", "jours", "semaines", "fortnights", "mois", "ans", "décennies", "siècles", "millénaires", "fois l'âge de l'univers"];
            double[] valeur = [secondes, secondes / 60, secondes / 60 / 60, secondes / 60 / 60 / 24, secondes / 60 / 60 / 24 / 7, secondes / 60 / 60 / 24 / 7 / 2, secondes / 60 / 60 / 24 / 30, secondes / 60 / 60 / 24 / 365, secondes / 60 / 60 / 24 / 365 / 10, secondes / 60 / 60 / 24 / 365 / 100, secondes / 60 / 60 / 24 / 365 / 1000, secondes / 60 / 60 / 24 / 365 / 13800000000];
            string message = "Le chien a dormi ";
            for (int iTemps = 0;  iTemps < mesure.Length; iTemps++)
            {
                message += valeur[iTemps] + " " + mesure[iTemps];
                if (iTemps != mesure.Length - 1)
                message += "\nou ";
            }
            return message;
        }
        public string AfficherCaracteristiques()
        {
            string message = $"Le chien est de race {_race}, son pelage est {_pelage}, il fait {_taille} cm de haut et pèse {_poids} kg, ce qui est moins que {_poids + 1} ";
            if (_agressivite && _sociabilite)
            {
                message += "Il est agressif mais social.";
            }
            if (_agressivite && !_sociabilite)
            {
                message += "Il est agressif et pas social :(.";
            }
            if (!_agressivite && _sociabilite)
            {
                message += "Il est non agressif et social :).";
            }
            if (!_agressivite && !_sociabilite)
            {
                message += "Il n'est rien.";
            }
            message += $" Son tag est {_tag} et il a {_age} an";
            if (_age > 1)
            {
                message += "s";
            }
            message += ".";
            return message;
        }
    }
}
