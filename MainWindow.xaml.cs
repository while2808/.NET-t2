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
using contextapp_yash.Classes;
using SQLite;

namespace contextapp_yash
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Contact> contacts = new List<Contact>();
        private Contact? selectedContact = null;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void LoadContacts()
        {
            using (var conn = new SQLiteConnection(App.databasePath))
            {
                conn.CreateTable<Contact>();
                contacts = conn.Table<Contact>().OrderBy(c=>c.Name).ToList();
            };
            contactListView.ItemsSource = contacts;
        }
        private void searchbox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void contactListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}