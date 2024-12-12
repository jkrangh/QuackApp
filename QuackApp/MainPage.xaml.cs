using QuackApp.ViewModels;

namespace QuackApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainViewModel mainViewModel)
        {

            BindingContext = mainViewModel;
            mainViewModel.Title = "Quack, quack!";
            InitializeComponent();
        }
    }

}
