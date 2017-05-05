using System.Windows;
using MVVMTest.View;
using MVVMTest.ViewModel;

namespace MVVMTest
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            var mw = new MainWindowView 
            {
                DataContext = new MainViewModel()
            };

            mw.Show();
        }
    }
}
