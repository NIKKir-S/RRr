using System;
using System.Collections.Generic;
using System.Data.Entity;
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
using System.Windows.Shapes;
using nzikrov.dbContext;
using nzikrov.Logic;
using nzikrov.BdMod;
using nzikrov.ModelUs;

namespace nzikrov
{
    /// <summary>
    /// Логика взаимодействия для Okno.xaml
    /// </summary>
    public partial class Okno : Window
    {
        ShopDBEntities1 dbContext = new ShopDBEntities1();
        private Products _product;
        public Okno((Products product, ShopDBEntities1 DbContext)
        {
            InitializeComponent();

            dbContext = DbContext;
            _product = products;
            if (_product != null)
            {
                nameTextBox.Text = _product.ProductName;
                priceTextBox.Text = _product.Price.ToString();
                descriptionTextBox.Text = _product.Description;
            }
        }


        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(nameTextBox.Text))
                {
                    MessageBox.Show("Введите название товара.");
                    return;
                }

                if (!decimal.TryParse(priceTextBox.Text, out decimal price))
                {
                    MessageBox.Show("Введите коннкретную цену товара.");
                    return;
                }

                if (_product == null)
                {
                    _product = new Products
                    {
                        ProductName = nameTextBox.Text,
                        Price = price,
                        Description = descriptionTextBox.Text
                    };

                }
                else
                {
                    _product.ProductName = nameTextBox.Text;
                    _product.Price = price;
                    _product.Description = descriptionTextBox.Text;
                }
            }
            catch { }
        }
    } 
}
