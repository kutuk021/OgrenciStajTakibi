using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace ktkproje
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection("Server=localhost;Port=3306;Database=test;Uid=root;Pwd=;Convert Zero Datetime=True;Allow Zero Datetime=True;");
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationWindow win = new NavigationWindow();
            win.Content = new Page2();
            win.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MySqlCommand goster = new MySqlCommand("Select * from ogrenciler where ogrno='" + txtara.Text + "'", baglanti);
            MySqlDataAdapter ekle = new MySqlDataAdapter(goster);
            DataTable ta = new DataTable();
            ekle.Fill(ta);
            grid.ItemsSource = ta.AsDataView();
        }
    }
}
