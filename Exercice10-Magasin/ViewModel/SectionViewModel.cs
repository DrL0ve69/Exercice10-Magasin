using Exercice10_Magasin.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice10_Magasin.ViewModel;

public class SectionViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;
    private void OnPropertyChanged(string propertyName)
    {
        if (PropertyChanged != null)
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
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
    public SectionViewModel()
    {
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
        Sections[0].Liste_Articles_Section = Articles.ToList();
        SelectedSection = Sections[0];

    }
}
