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

namespace WpfItemsControlsTwoApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Product> products;
        public MainWindow()
        {
            InitializeComponent();

            ListBox list = new();
            list.Items.Add("Manager");
            list.Items.Add("Developer");
            list.Items.Add("Saler");

            TabItem tab = new();
            tab.Header = "Employees";
            tab.Content = list;

            tabsInfo.Items.Add(tab);

            products = new List<Product>()
            {
                new(){ Name = "Notebook", Brand = "Asus", Price = 50000, IsActive = true },
                new(){ Name = "Phone", Brand = "Apple", Price = 90000, IsActive = false  },
                new(){ Name = "Watch", Brand = "Samsung", Price = 45000, IsActive = true  },
            };

            ResourceDictionary resources = new ResourceDictionary();
            resources.Add("products", products);
            this.Resources = resources;
        }
    }
}