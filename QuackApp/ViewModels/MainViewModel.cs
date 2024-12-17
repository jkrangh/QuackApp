using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using QuackApp.Models;
using QuackApp.Services;

namespace QuackApp.ViewModels
{
    public partial class MainViewModel : BaseViewModel
    {
        private readonly DuckService duckService;

        [ObservableProperty] 
        private Duck vmDuck = new Duck();

        public MainViewModel(DuckService duckService)
        {
            Title = "Quack, quack!";
            this.duckService = duckService;
        }

        [RelayCommand]
        async Task GetDuckJpgAsync(object sender)
        {
            try
            {
                VmDuck = await duckService.GetDuckJpgAsync();
            }
            catch (Exception ex) 
            {
                await Shell.Current.DisplayAlert("Error", $"No ducks found: {ex.Message}", "OK");
            }
        }

        [RelayCommand]
        async Task GetDuckGifAsync()
        {
            try
            {
                VmDuck = await duckService.GetDuckGifAsync();
            }
            catch (Exception ex)
            {
                await Shell.Current.DisplayAlert("Error", $"No ducks found: {ex.Message}", "OK");
            }
        }
    }
}
