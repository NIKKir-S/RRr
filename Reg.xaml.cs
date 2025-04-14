using System;
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
using System.Windows.Shapes;
using nzikrov.dbContext;
using nzikrov.BdMod;
using System.Data.Entity;
using nzikrov.Logic;


namespace nzikrov
{
    /// <summary>
    /// Логика взаимодействия для Reg.xaml
    /// </summary>
    public partial class Reg : Window
    {
        private IauthService1 _authService;
        public Reg()
        {
            InitializeComponent();
            _authService = new AuthService();
            ShopDBEntities1 dbContext = new ShopDBEntities1();
        }

        private void btnOpen_Click(object sender, RoutedEventArgs e)
        {
            string login = tbxLogin.Text;
            string pass = tbxPass.Text;

            if (_authService.CheckData(login, pass))
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();

            }
            else
            {
                MessageBox.Show("Ошибка, проверьте правильность введённых данных в полях");
            }
        }
    }
}
