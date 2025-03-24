using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    ObservableCollection<Produkt> produktList = null;
    public MainWindow()
    {
        InitializeComponent();
        PrzygotujWiazanie();
    }

    private void PrzygotujWiazanie()
    {
        produktList = new ObservableCollection<Produkt>();
        produktList.Add(new Produkt("ołówek", "Ds-1091", 8, 12.42, "Katowice1"));
        produktList.Add(new Produkt("ołówek", "Ds-1092", 75, 4.20, "Katowice2"));
        produktList.Add(new Produkt("ołówek", "Ds-1093", 125, 4.20, "Katowice1"));
        produktList.Add(new Produkt("długopis żelkowy", "Ds-1090", 1238, 10.00, "Katowice1"));
        produktList.Add(new Produkt("długopis kulkowy", "Ds-1090", 8, 5.23, "Katowice2"));
        Produkty.ItemsSource = produktList;

        CollectionView widok = (CollectionView)CollectionViewSource.GetDefaultView(Produkty.ItemsSource);
        widok.SortDescriptions.Add(new SortDescription("Nazwa", ListSortDirection.Ascending));
        widok.Filter = FiltrUzytkownika;
    }

    private bool FiltrUzytkownika(object item)
    {
        if (String.IsNullOrEmpty(txtFilter.Text))
            return true;
        else
            return ((item as Produkt).Nazwa.IndexOf(txtFilter.Text, StringComparison.OrdinalIgnoreCase) >= 0);
    }

    private void txtFilter_TextChanged_1(object sender, TextChangedEventArgs e)
    {
        CollectionViewSource.GetDefaultView(Produkty.ItemsSource).Refresh();
    }

    private void Produkty_MouseDoubleClick(object sender, MouseButtonEventArgs e)
    {
        Window oknoFormularz = new ProduktFormularz(this);
        oknoFormularz.Show();
    }
}





















