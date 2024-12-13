using QuackApp.ViewModels;

namespace QuackApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainViewModel mainViewModel)
        {
            InitializeComponent();

            BindingContext = mainViewModel;
            mainViewModel.Title = "Quack, quack!";
        }
    }

}
