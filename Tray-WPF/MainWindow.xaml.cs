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
using System.Windows.Controls.Ribbon;

namespace Tray_WPF
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : RibbonWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            List<FileFolder> users = new List<FileFolder>();
            users.Add(new FileFolder() {Name = "aaa.docx", LastChange = new DateTime(2017, 7, 23, 12, 55, 59) });
            users.Add(new FileFolder() {Name = "bbb.xlsx", LastChange = new DateTime(2017, 1, 17, 6, 20, 11) });
            users.Add(new FileFolder() {Name = "ccc.pptx", LastChange = new DateTime(2017, 9, 2, 9, 44, 22) });
            filesAndFolders.ItemsSource = users;
            
        }
    }

    public class FileFolder
    {
        public string Name { get; set; }
        public DateTime LastChange { get; set; }
    }
}
