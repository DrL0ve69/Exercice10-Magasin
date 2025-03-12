using Exercice10_Magasin.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice10_Magasin.ViewModel;

public class ArticleViewModel : BaseViewModel
{
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
    public ArticleViewModel()
    {
        Articles = ArticleDataModel.GetAll_Articles();
    }
}
