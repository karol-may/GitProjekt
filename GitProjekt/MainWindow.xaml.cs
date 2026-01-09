using System.IO;
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

namespace GitProjekt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private void ReadDbIntoTestLabel() {

            using StreamReader reader = new("db.csv");

            string db = reader.ReadToEnd();

            Test.Content = db;

            reader.Close();

        }

        public MainWindow()
        {
            InitializeComponent();

            ReadDbIntoTestLabel();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var imie = Record_Imie.Text;
            var nazwisko = Record_Nazwisko.Text;
            var data_urodzenia = Record_DataUrodzenia.Text;

            using StreamWriter writer = new("db.csv",true);

            writer.WriteLine($"{imie},{nazwisko},{data_urodzenia}");

            writer.Close();

            ReadDbIntoTestLabel();

        }
    }
}