using System.Configuration;
using System.Data;
using System.Windows;
using System.IO;

namespace contextapp_yash
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static string databasePath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments),
            "context.db3");
    }
}
