using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfApp14
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;
        public MainWindow()
        {
            InitializeComponent();

            products = new ObservableCollection<Product>();

            products.Add(new Product()
            {
                Name = "Продукт1",
                Category = Categories.Food,
                Price = 400,
                Image = @"../Icons/food.png"
            });
            products.Add(new Product()
            {
                Name = "Продукт2",
                Category = Categories.Food,
                Price = 300,
                Image = @"../Icons/food.png"
            });
            products.Add(new Product()
            {
                Name = "Продукт3",
                Category = Categories.Appliances,
                Price = 600,
                Image = @"../Icons/home.png"
            });
            MyBox.ItemsSource = products;
        }
    }
}
