﻿using CommunityToolkit.Mvvm.ComponentModel;
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
        async Task GetDuckJpgAsync()
        {
            VmDuck = await duckService.GetDuckJpgAsync();
        }

        [RelayCommand]
        async Task GetDuckGifAsync()
        {
            VmDuck = await duckService.GetDuckGifAsync();
        }
    }
}