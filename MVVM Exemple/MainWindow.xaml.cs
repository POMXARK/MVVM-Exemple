using System.Windows;

namespace MVVM
{
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Логика mvvm.
        /// в главном методе формы.
        /// создать обьект DataContext = new ViewModel();
        /// Реализующий интерфейс INotifyPropertyChanged
        /// 
        /// Неважн где описанна логика , если класс реализует INotifyPropertyChanged, 
        /// то можно через свойства обновлять интерфейс через XAML Binding -> PropertyChanged // OnPropertyChanged("{Xaml Binding}")
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

            // привязаная левая часть к <StackPanel Grid.Column="1" DataContext="{Binding SelectedPhone}">
            // можно разграничивать блоки приложение, таким образом
            DataContext = new ApplicationViewModel();
        }
    }
}