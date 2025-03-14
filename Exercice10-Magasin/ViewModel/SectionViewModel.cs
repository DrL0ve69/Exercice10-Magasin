﻿using Exercice10_Magasin.Command;
using Exercice10_Magasin.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Exercice10_Magasin.ViewModel;

public class SectionViewModel : BaseViewModel
{

    private ObservableCollection<Section> _sections;
    public ObservableCollection<Section> Sections
    {
        get => _sections;
        set
        {
            _sections = value;
            OnPropertyChanged(nameof(Sections));
        }
    }
    private Section _selectedSection;
    public Section SelectedSection
    {
        get => _selectedSection;
        set
        {
            _selectedSection = value;
            OnPropertyChanged(nameof(SelectedSection));
        }
    }
    private Article _selectedArticle;
    public Article SelectedArticle
    {
        get => _selectedArticle;
        set
        {
            _selectedArticle = value;
            OnPropertyChanged(nameof(SelectedArticle));
            OnPropertyChanged(nameof(SelectedSection.Liste_Articles_Section));
        }
    }
    private ObservableCollection<Article> _articles = new();
    public ObservableCollection<Article> Articles
    {
        get => _articles;
        set
        {
            _articles = value;
            OnPropertyChanged(nameof(Articles));
        }
    }
    private int _indexSection;
    public int IndexSection
    {
        get => _indexSection;
        set
        {
            _indexSection = value;
            OnPropertyChanged(nameof(IndexSection));
        }
    }
    private int _indexArticle;
    public int IndexArticle
    {
        get => _indexArticle;
        set
        {
            _indexArticle = value;
            OnPropertyChanged(nameof(IndexArticle));
        }
    }
    private static ObservableCollection<Article> _articlesPanier = new();
    public static ObservableCollection<Article> ArticlesPanier 
    {
        get => _articlesPanier;
        set 
        {
            _articlesPanier = value;
        }
    }
    // Les commandes de la page section
    public ICommand PreviousSectionCommand { get; }
    public ICommand NextSectionCommand { get; }
    public ICommand AjoutPanierCommand { get; }

    // Initialisation des commandes&propriétés
    public SectionViewModel()
    {
        AjoutPanierCommand = new RelayCommand(AjoutPanier, CanAjouterPanier);
        // Section suivante&précédente
        NextSectionCommand = new RelayCommand(NextSection, CanNextSection);
        PreviousSectionCommand = new RelayCommand(PreviousSection, CanPreviousSection);

        Sections = SectionDataModel.GetAll_Sections();
        Articles = ArticleDataModel.GetAll_Articles();
        /*
        Sections = new ObservableCollection<Section>
        {
            new Section(1, "Section 1"),
            new Section(2, "Section 2"),
            new Section(3, "Section 3"),
            new Section(4, "Section 4"),
            new Section(5, "Section 5"),
            new Section(6, "Section 6"),
        };

        Articles = new ObservableCollection<Article>
        {
            new Article("1001", "Article 1", 1.1, 11.1, 101),
            new Article("1002", "Article 2", 22, 22.22, 20),
            new Article("1003", "Article 3", 333, 333.03, 33),
            new Article("1004", "Article 4", 1.1, 4, 4),
            new Article("1005", "Article 5", 25, 55, 50),
            new Article("1006", "Article 6", 6, 666, 66),
        };

        Sections[0].Liste_Articles_Section = new ObservableCollection<Article>
        {
            Articles[0],
            Articles[1],
            Articles[2],
            Articles[3],
            Articles[4],
            Articles[5],
        };
        */

        IndexSection = 3;

        SelectedSection = Sections[IndexSection];

        Sections[0].NomSection = "Section 1 - Updated";

    }
    // On peut ajouter l'article au panier si un article est sélectionné et qu'il y a une quantité en stock, donc !=0
    private bool CanAjouterPanier() => SelectedArticle != null && SelectedArticle.QuantiteStock != 0;
    private void AjoutPanier()
    {
        // L'achat fonctionne mais l'interface ne fonctionne pas...
        // HOOOOLD ON SON !!! Si on change de page et qu'on revient, ça fonctionne...

        SelectedArticle.Vendre(1);
        if(!ArticlesPanier.Contains(SelectedArticle)) ArticlesPanier.Add(SelectedArticle);
    }
    private bool CanPreviousSection() => IndexSection > 0;
    private void PreviousSection()
    {
        IndexSection--;
        SelectedSection = Sections[IndexSection];
    }
    private bool CanNextSection() => IndexSection < Sections.Count - 1;
    private void NextSection()
    {
        IndexSection++;
        SelectedSection = Sections[IndexSection];
    }
}
