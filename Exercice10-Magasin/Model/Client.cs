using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice10_Magasin.Model;

public class Client
{
    public string Nom { get; set; }
    public string Prenom { get; set; }
    public string NomComplet => $"{Nom}, {Prenom}";
    private int _pointFidelite;
    public int PointFidelite
    {
        get => _pointFidelite;
        set
        {
            if (value < 0) throw new ArgumentException("Les points de fidélité doivent être positifs!");
            _pointFidelite = value;
        }
    }
    public Client()
    {
        Nom = "Non-disponible";
        Prenom = "Non-disponible";
        PointFidelite = 0;
    }
    public Client(string nom, string prenom)
    {
        Nom = nom;
        Prenom = prenom;
        PointFidelite = 0;
    }
    // Constructeur avec paramètres pour initialiser, un client avec point d'achat
    public Client(string nom, string prenom, int pointFidelite)
    {
        Nom = nom;
        Prenom = prenom;
        PointFidelite = pointFidelite;
    }
}
