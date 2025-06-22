using Big_Finish_Tracker.Core;
using Big_Finish_Tracker.Services;

namespace Big_Finish_Tracker.MVVM.ViewModel
{
    public class MainViewModel : Core.ViewModel
    {

        private INavigationService _navigationService;

        public INavigationService NavigationService
        {
            get => _navigationService;
            set
            {
                _navigationService = value;
                OnPropertyChanged(nameof(NavigationService));
            }
        }

        public RelayCommand NavigateHomeCommand { get; set; }

        public RelayCommand NavigateDiscoverCommand { get; set; }

        public MainViewModel(INavigationService navService)
        {
            NavigationService = navService;
            NavigationService.NavigateTo<HomeViewModel>();

            NavigateHomeCommand = new RelayCommand(o =>
            {
                NavigationService.NavigateTo<HomeViewModel>();
            }, o => true);

            NavigateDiscoverCommand = new RelayCommand(o =>
            {
                NavigationService.NavigateTo<DiscoveryViewModel>();
            }, o => true);
        }
    }
}
