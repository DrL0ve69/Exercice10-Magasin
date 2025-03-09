using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice10_Magasin.Model;

public class Facture
{
    private string _numeroFacture;
    public string NumeroFacture
    {
        get => _numeroFacture;
        set
        {
            if (value.Length > 12 || value.Length < 4) throw new ArgumentException("Le numéro de la facture doit contenir un minimum de 4 caractères et maximum de 12!");
            _numeroFacture = value;
        }
    }
    private List<Article> _liste_Articles_Facture;
    public List<Article> Liste_Articles_Facture
    {
        get => _liste_Articles_Facture;
        set
        {
            if(value.Count == 0) throw new ArgumentException("Nous ne pouvons pas faire de facture sans achat?!?!!");
            _liste_Articles_Facture = value;
        }
    }
    public double PrixTotal // => Liste_Articles_Facture.Sum(p => p.PrixVente); ou :
    {
        get
        {
            double total = 0;
            foreach (var article in Liste_Articles_Facture)
            {
                total += article.PrixVente;
            }
            return total;
        }
    }
    private DateTime _dateFacture;
    public DateTime DateFacture
    {
        get => _dateFacture;
        set
        {
            if (value > DateTime.Now) throw new ArgumentException("La date de la facture ne peut pas être dans le futur!");
            _dateFacture = value;
        }
    }
    public Client Client { get; set; }
    public Facture()
    {
        NumeroFacture = "Non-disponible";
        Liste_Articles_Facture = new List<Article>();
        DateFacture = DateTime.Now;
        Client = new Client();
    }
    public Facture(string numeroFacture, List<Article> liste_Articles_Facture, DateTime dateFacture, Client client)
    {
        NumeroFacture = numeroFacture;
        Liste_Articles_Facture = liste_Articles_Facture;
        DateFacture = dateFacture;
        Client = client;
    }
    public double CalculerTaxes(double tauxTaxe)
    {
        return PrixTotal * tauxTaxe;
    }
    public double CalculerTotal(double tauxTaxe)
    {
        return PrixTotal + CalculerTaxes(tauxTaxe);
    }
}
