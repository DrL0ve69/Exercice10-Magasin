using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice10_Magasin.Model;

public class ArticleDataModel
{
    public static ObservableCollection<Article> DB_Articles = new ObservableCollection<Article>()
    {
        new Article("1001", "Article 1", 1.1, 11.1, 101),
        new Article("1002", "Article 2", 22, 22.22, 20),
        new Article("1003", "Article 3", 333, 333.03, 33),
        new Article("1004", "Article 4", 1.1, 4, 4),
        new Article("1005", "Article 5", 25, 55, 50),
        new Article("1006", "Article 6", 6, 666, 66),
        new Article("1007", "Article 7", 7, 77, 77),
        new Article("1008", "Article 8", 8, 88, 88),
        new Article("1009", "Article 9", 9, 99, 99),
        new Article("1010", "Article 10", 10, 100, 10),
    };
    public static ObservableCollection<Article> GetAll_Articles()
    {
        return DB_Articles;
    }
    public static void AddArticle(Article article)
    {
        DB_Articles.Add(article);
    }
    public static void DeleteArticle(Article article)
    {
        DB_Articles.Remove(article);
    }
    public static Article GetArticle(string code)
    {
        return DB_Articles.FirstOrDefault(a => a.Code == code);
    }
    public static void VendreArticle(Article article)
    {
        article.Vendre(1);
    }
}
