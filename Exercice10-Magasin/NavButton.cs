﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Exercice10_Magasin;

/// <summary>
/// Suivez les étapes 1a ou 1b puis 2 pour utiliser ce contrôle personnalisé dans un fichier XAML.
///
/// Étape 1a) Utilisation de ce contrôle personnalisé dans un fichier XAML qui existe dans le projet actif.
/// Ajoutez cet attribut XmlNamespace à l'élément racine du fichier de balisage où il doit 
/// être utilisé :
///
///     xmlns:MyNamespace="clr-namespace:Exercice10_Magasin"
///
///
/// Étape 1b) Utilisation de ce contrôle personnalisé dans un fichier XAML qui existe dans un autre projet.
/// Ajoutez cet attribut XmlNamespace à l'élément racine du fichier de balisage où il doit 
/// être utilisé :
///
///     xmlns:MyNamespace="clr-namespace:Exercice10_Magasin;assembly=Exercice10_Magasin"
///
/// Vous devrez également ajouter une référence du projet contenant le fichier XAML
/// à ce projet et regénérer pour éviter des erreurs de compilation :
///
///     Cliquez avec le bouton droit sur le projet cible dans l'Explorateur de solutions, puis sur
///     "Ajouter une référence"->"Projets"->[Recherchez et sélectionnez ce projet]
///
///
/// Étape 2)
/// Utilisez à présent votre contrôle dans le fichier XAML.
///
///     <MyNamespace:NavButton/>
///
/// </summary>
public class NavButton : ListBoxItem
{
    static NavButton()
    {
        DefaultStyleKeyProperty.OverrideMetadata(typeof(NavButton), new FrameworkPropertyMetadata(typeof(NavButton)));
    }
    public Uri NavLink
    {
        get { return (Uri)GetValue(NavLinkProperty); }
        set { SetValue(NavLinkProperty, value); }
    }
    public static readonly DependencyProperty NavLinkProperty =
        DependencyProperty.Register("NavLink", typeof(Uri), typeof(NavButton), new PropertyMetadata(null));

    public Geometry Icon
    {
        get { return (Geometry)GetValue(IconProperty); }
        set { SetValue(IconProperty, value); }
    }
    public static readonly DependencyProperty IconProperty =
        DependencyProperty.Register("Icon", typeof(Geometry), typeof(NavButton), new PropertyMetadata(null));

}
