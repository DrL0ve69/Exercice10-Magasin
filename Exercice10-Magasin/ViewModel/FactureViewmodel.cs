using Exercice10_Magasin.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice10_Magasin.ViewModel;

public class FactureViewModel : BaseViewModel
{
    public ObservableCollection<Article> ArticlesFacture => SectionViewModel.ArticlesPanier;
}
