using MyVet.Common.Models;
using Prism.Navigation;

namespace MyVet.Prism.ViewModels
{
    public class HistoryPageViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;
        private HistoryResponse _history;

        public HistoryPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "History";
            _navigationService = navigationService;
        }

        public HistoryResponse History
        {
            get => _history;
            set => SetProperty(ref _history, value);
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);

            if (parameters.ContainsKey("history"))
            {
                History = parameters.GetValue<HistoryResponse>("history");
            }
        }
    }
}
