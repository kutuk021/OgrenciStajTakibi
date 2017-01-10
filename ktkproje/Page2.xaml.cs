using MySql.Data.MySqlClient;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ktkproje
{
    /// <summary>
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        MySqlConnection baglanti = new MySqlConnection("Server=localhost;Port=3306;Database=test;Uid=root;Pwd=;Convert Zero Datetime=True;Allow Zero Datetime=True;");
        public Page2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            baglanti.Open();
            MySqlCommand kitapekle = new MySqlCommand("INSERT INTO ogrenciler(ograd,ogrsoyad,ogrblm,ogrisyeri) values('" + txtad.Text + "','" + txtsoyad.Text + "','" + txtblm.Text + "','" + txtisyeri.Text + "')", baglanti);
            kitapekle.ExecuteNonQuery();
            kitapekle.Dispose();
            baglanti.Close();
            MessageBox.Show("Ögrenci Eklendi");
        }
    }
}
