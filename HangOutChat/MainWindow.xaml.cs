using HangOutChat.Core;
using HangOutChat.Word;
using System.Windows;

namespace HangOutChat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new WindowsViewModel(this);
        }
    }
}
