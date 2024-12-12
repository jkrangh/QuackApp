using CommunityToolkit.Mvvm.ComponentModel;
using System.ComponentModel;

namespace QuackApp.ViewModels
{
    public partial class BaseViewModel : ObservableObject
    {
        [ObservableProperty]
        private string? title;
    }
}
