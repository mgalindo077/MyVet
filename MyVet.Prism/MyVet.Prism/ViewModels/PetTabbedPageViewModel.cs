﻿using MyVet.Common.Helpers;
using MyVet.Common.Models;
using Newtonsoft.Json;
using Prism.Navigation;

namespace MyVet.Prism.ViewModels
{
    public class PetTabbedPageViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;

        public PetTabbedPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            var pet = JsonConvert.DeserializeObject<PetResponse>(Settings.Pet);
            Title = $"Pet: {pet.Name}";
            _navigationService = navigationService;
        }
    }
}
