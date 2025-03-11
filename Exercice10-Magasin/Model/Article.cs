using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice10_Magasin.Model;

public class Article
{
    private string _code;
    public string Code 
    {
        get => _code;
        set 
        {
            if (value.Length > 12 || value.Length < 4) throw new ArgumentException("Le code doit contenir un minimum de 4 caractères et maximum de 12!");
            _code = value;
        }
    }
    private string _nomArticle;
    public string NomArticle
    {
        get => _nomArticle;
        set
        {
            if (value.Length > 50 || value.Length < 2) throw new ArgumentException("Le nom de l'article doit contenir un minimum de 2 caractères et maximum de 50!");
            _nomArticle = value;
        }
    }
    private double _prixAchat;
    private double _prixVente;
    private int _quantiteStock;
    public double PrixAchat 
    {
        get => _prixAchat;
        set
        {
            if (value < 0) throw new ArgumentException("Le prix d'achat doit être positif!");
            _prixAchat = value;
        }
    }
    public double PrixVente
    {
        get => _prixVente;
        set
        {
            if (value <= PrixAchat) throw new ArgumentException("Le prix de vente doit être plus grand que le prix d'achat");
            _prixVente = value;
        }
    }
    public int QuantiteStock
    {
        get => _quantiteStock;
        set
        {
            if (value < 0) throw new ArgumentException("La quantité en stock doit être positive!");
            _quantiteStock = value;
        }
    }
    public Article() 
    {
        Code = "Non-disponible";
        NomArticle = "Non-disponible";
        PrixAchat = 0;
        PrixVente = 0;
        QuantiteStock = 0;
    }
    public Article(string code, string nomArticle, double prixAchat, double prixVente, int quantiteStock)
    {
        Code = code;
        NomArticle = nomArticle;
        PrixAchat = prixAchat;
        PrixVente = prixVente;
        QuantiteStock = quantiteStock;
    }
    // Les méthodes
    public void Approvisionner(int quantite)
    {
        if (quantite < 1) throw new ArgumentException("La quantité ajoutée au stock doit être au moins 1.");
        QuantiteStock += quantite;
    }
    public void Vendre(int quantite)
    {
        if (quantite < 1) throw new ArgumentException("La quantité vendue doit être au moins 1.");
        if (quantite > QuantiteStock) throw new ArgumentException("La quantité vendue ne doit pas dépasser la quantité en stock.");
        QuantiteStock -= quantite;
    }
    public override string ToString()
    {
        return $"Code: {Code}, Nom: {NomArticle}\n" +
            $"PrixVente: {PrixVente:F2}$, Quantité en stock: {QuantiteStock}";
    }
    // La méthode <<Deplacer>> se retrouve présentement dans section
    /*
    public void Deplacer() 
    { }
    */
}
