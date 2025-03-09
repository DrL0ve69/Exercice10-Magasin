using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice10_Magasin.Model;

public class Section
{
    private int _numero;
    public int Numero
    {
        get => _numero;
        set
        {
            if (value < 0) throw new ArgumentException("Le numéro de la section doit être positif!");
            _numero = value;
        }
    }
    private string _nomSection;
    public string NomSection
    {
        get => _nomSection;
        set
        {
            if (value.Length > 25 || value.Length < 2) throw new ArgumentException("Le nom de la section doit contenir un minimum de 2 caractères et maximum de 25!");
            _nomSection = value;
        }
    }
    private List<Article> _liste_Articles_Section;
    public List<Article> Liste_Articles_Section
    {
        get => _liste_Articles_Section;
        set
        {
            _liste_Articles_Section = value;
        }
    }
    public Section()
    {
        Numero = 0;
        NomSection = "Non-disponible";
        Liste_Articles_Section = new List<Article>();
    }
    public Section(int numero, string nomSection)
    {
        Numero = numero;
        NomSection = nomSection;
        Liste_Articles_Section = new List<Article>();
    }
    public Section(int numero, string nomSection, List<Article> liste_Articles_Section)
    {
        Numero = numero;
        NomSection = nomSection;
        Liste_Articles_Section = liste_Articles_Section;
    }
    public void AjouterArticle(Article article)
    {
        Liste_Articles_Section.Add(article);
    }
    public void SupprimerArticle(Article article)
    {
        Liste_Articles_Section.Remove(article);
    }
    public void DeplacerArticle(Article article, Section section)
    {
        Liste_Articles_Section.Remove(article);
        section.AjouterArticle(article);
    }
}
