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
        Duck duck = new Duck();

        public MainViewModel(DuckService duckService)
        {
            this.duckService = duckService;
        }

        [RelayCommand]
        async Task<Duck> GetDuckAsync()
        {
            return await duckService.GetDuckAsync();
        }
    }
}
