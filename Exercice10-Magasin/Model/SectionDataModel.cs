using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice10_Magasin.Model;

class SectionDataModel
{
    public static ObservableCollection<Section> DB_Sections = new ObservableCollection<Section>() 
    {

        new Section(1, "Section 1"),            
        new Section(2, "Section 2"),           
        new Section(3, "Section 3"),           
        new Section(4, "Section 4"),           
        new Section(5, "Section 5"),
        new Section(6, "Section 6"),
        new Section(7, "Section 7"),
        new Section(8, "Section 8"),
        new Section(9, "Section 9"),
        new Section(10, "Tous les articles", ArticleDataModel.GetAll_Articles()),
    };
    public static ObservableCollection<Section> GetAll_Sections() 
    {
        return DB_Sections;
    }
    public static Section GetSection(int numero)
    {
        return DB_Sections.FirstOrDefault(s => s.Numero == numero);
    }
    public static void AddSection(Section section)
    {
        DB_Sections.Add(section);
    }
    public static void RemoveSection(Section section)
    {
        DB_Sections.Remove(section);
    }
}
